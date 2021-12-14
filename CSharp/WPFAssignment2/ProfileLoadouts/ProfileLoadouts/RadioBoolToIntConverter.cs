using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ProfileLoadouts
{
    //For more info about this solution for radio buttons:
    //https://stackoverflow.com/questions/1317891/simple-wpf-radiobutton-binding/24166629
    //Basically:
    //1. Define the RadioBoolToIntConverter Class and implement IValueConverter
    //2.In the XAML Markup, include RadioBoolToIntConverter as a resource in Window.Resources.
    //3. Bind the value of each radio button to a single property holding an integer, but add an attribute that defines the Converter and Converter Parameter. In a two-way binding, the Converter ConvertBack() Method will convert the IsChecked boolean value (true) to the given integer for the radio button (Converter Parameter). The Convert() Method will look at the stored integer. If it is the same as the parameter of the Radio button, it will make IsChecked = true.
    public class RadioBoolToIntConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int integer = (int)value;
            if (integer == int.Parse(parameter.ToString()))
                return true;
            else
                return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return parameter;
        }
    }
}
