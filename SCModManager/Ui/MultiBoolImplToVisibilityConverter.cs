﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace SCModManager.Ui
{
    class MultiBoolImplToVisibilityConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            bool retVal = false;

            if (values.Length == 2)
            {
                bool v1 = values[0] is bool ? (bool)values[0] : false;
                bool v2 = values[1] is bool ? (bool)values[1] : false;

                if (v1)
                    retVal = v2;
                else
                    retVal = true;
            }


            return retVal ? Visibility.Visible : Visibility.Collapsed;
        }


        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
