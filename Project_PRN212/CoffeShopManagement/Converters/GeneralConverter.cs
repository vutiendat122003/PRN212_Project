using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace CoffeShopManagement.Converters
{
    public class GeneralConverter : IValueConverter
    {
        public string ConverterType { get; set; } = string.Empty; // "Gender" hoặc "Role"

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (ConverterType)
            {
                case "Gender":
                    if (value is bool gender)
                    {
                        return gender ? "Male" : "Female";
                    }
                    break;

                case "Role":
                    if (value is int role)
                    {
                        return role == 1 ? "Admin" : "Staff";
                    }
                    break;

                default:
                    return "Unknown";
            }

            return "Unknown";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (ConverterType)
            {
                case "Gender":
                    return value?.ToString() == "Male";

                case "Role":
                    return value?.ToString() == "Admin" ? 1 : 0;

                default:
                    throw new NotImplementedException();
            }
        }
    }
}
