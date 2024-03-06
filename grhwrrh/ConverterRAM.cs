﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace grhwrrh
{
    public class ConverterRAM : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            byte[] image = null;
            int val = int.Parse(value.ToString());
            if (val > 10000)
            {
                image = File.ReadAllBytes("8.jpg");
            }
            if (val < 10000)
            {
                image = File.ReadAllBytes("9.jpg");
            }
            return image;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
