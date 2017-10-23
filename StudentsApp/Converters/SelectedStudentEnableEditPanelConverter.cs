using System;
using System.Globalization;
using System.Windows.Data;

namespace StudentsApp.Converters
{
    public class SelectedStudentEnableEditPanelConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value != null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
