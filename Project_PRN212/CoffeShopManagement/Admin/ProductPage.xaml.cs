using CafeManager.BLL.Services;
using CafeManager.DAL.Models;
using CafeManager.DAL.Repositories;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CoffeShopManagement.Admin
{
    /// <summary>
    /// Interaction logic for ProductPage.xaml
    /// </summary>
    public partial class ProductPage : Page
    {
        private ProductService _productService;

        public ProductPage(ProductService productService)
        {
            InitializeComponent();
            _productService = productService;
            LoadProducts();
        }

        private void LoadProducts()
        {
            var products = _productService.GetAllProducts();
            FoodDataGrid.ItemsSource = products;
        }

        private void ClearInputs()
        {
            ProductIDTextBox.Text = string.Empty;
            ProductNameTextBox.Text = string.Empty;
            PriceTextBox.Text = string.Empty;
            CategoryComboBox.SelectedIndex = -1;
            FoodImage.Source = null;
        }

        private Food CreateProductFromInputs()
        {
            return new Food
            {
                Id = string.IsNullOrEmpty(ProductIDTextBox.Text) ? 0 : int.Parse(ProductIDTextBox.Text),
                Name = ProductNameTextBox.Text,
                Price = double.TryParse(PriceTextBox.Text, out var price) ? price : 0,
                IdCategory = CategoryComboBox.SelectedIndex + 1, // Assuming categories start at index 0
                ImageLink = FoodImage.Source?.ToString() ?? string.Empty // Example: Update this logic to handle actual file paths
            };
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var product = CreateProductFromInputs();
            if (_productService.AddProduct(product))
            {
                MessageBox.Show("Product added successfully!");
                LoadProducts();
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Failed to add product. Check your inputs.");
            }
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            var product = CreateProductFromInputs();
            if (_productService.UpdateProduct(product))
            {
                MessageBox.Show("Product updated successfully!");
                LoadProducts();
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Failed to update product. Check your inputs.");
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(ProductIDTextBox.Text, out var productId))
            {
                if (_productService.DeleteProduct(productId))
                {
                    MessageBox.Show("Product deleted successfully!");
                    LoadProducts();
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show("Failed to delete product. Product not found.");
                }
            }
            else
            {
                MessageBox.Show("Invalid Product ID.");
            }
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            var keyword = SearchTextBox.Text.ToLower();
            var products = _productService.GetAllProducts();
            var filteredProducts = new List<Food>();

            foreach (var product in products)
            {
                if (product.Name.ToLower().Contains(keyword))
                {
                    filteredProducts.Add(product);
                }
            }

            FoodDataGrid.ItemsSource = filteredProducts;
        }

        private void FoodDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FoodDataGrid.SelectedItem is Food selectedProduct)
            {
                ProductIDTextBox.Text = selectedProduct.Id.ToString();
                ProductNameTextBox.Text = selectedProduct.Name;
                PriceTextBox.Text = selectedProduct.Price.ToString();
                CategoryComboBox.SelectedIndex = selectedProduct.IdCategory - 1; // Assuming categories are sequential
                FoodImage.Source = string.IsNullOrEmpty(selectedProduct.ImageLink)
                    ? null
                    : new System.Windows.Media.Imaging.BitmapImage(new System.Uri(selectedProduct.ImageLink));
            }
        }

        private void ChooseImageButton_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new Microsoft.Win32.OpenFileDialog
            {
                Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                FoodImage.Source = new System.Windows.Media.Imaging.BitmapImage(new System.Uri(openFileDialog.FileName));
            }
        }

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            LoadProducts();
        }
    }
}
