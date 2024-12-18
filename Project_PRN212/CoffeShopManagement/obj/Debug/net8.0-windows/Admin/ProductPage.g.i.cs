﻿#pragma checksum "..\..\..\..\Admin\ProductPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87FCBC64E18D8EE57843D8189D3B6432431B4932"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CoffeShopManagement.Admin;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace CoffeShopManagement.Admin {
    
    
    /// <summary>
    /// ProductPage
    /// </summary>
    public partial class ProductPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 52 "..\..\..\..\Admin\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ProductIDTextBox;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\Admin\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ProductNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\Admin\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image FoodImage;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\Admin\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CategoryComboBox;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\..\Admin\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PriceTextBox;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\..\Admin\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchTextBox;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\..\Admin\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid FoodDataGrid;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.11.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CoffeShopManagement;component/admin/productpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Admin\ProductPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ProductIDTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.ProductNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            
            #line 63 "..\..\..\..\Admin\ProductPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ChooseImageButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.FoodImage = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.CategoryComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 70 "..\..\..\..\Admin\ProductPage.xaml"
            this.CategoryComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CategoryComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.PriceTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            
            #line 84 "..\..\..\..\Admin\ProductPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 85 "..\..\..\..\Admin\ProductPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UpdateButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 86 "..\..\..\..\Admin\ProductPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteButton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.SearchTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            
            #line 93 "..\..\..\..\Admin\ProductPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SearchButton_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.FoodDataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 97 "..\..\..\..\Admin\ProductPage.xaml"
            this.FoodDataGrid.Loaded += new System.Windows.RoutedEventHandler(this.DataGrid_Loaded);
            
            #line default
            #line hidden
            
            #line 97 "..\..\..\..\Admin\ProductPage.xaml"
            this.FoodDataGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FoodDataGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

