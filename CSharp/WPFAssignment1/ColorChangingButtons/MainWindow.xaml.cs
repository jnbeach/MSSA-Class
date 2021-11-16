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

namespace ColorChangingButtons
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            
        }
        void ChangeColorTo(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(RedButton))
            {
                mainRect.Fill = new SolidColorBrush(Color.FromArgb(0xFF,0x8B,0,0));//#FF8B0000
            }
            if (sender.Equals(BlueButton))
            {
                mainRect.Fill = new SolidColorBrush(Color.FromArgb(0xFF,0x14,0x21,0xA4));//#FF1421A4
            }
            if (sender.Equals(GreenButton))
            {
                mainRect.Fill = new SolidColorBrush(Color.FromArgb(0xFF, 0x22, 0x6C, 0x33));//#FF226C33
            }
            if (sender.Equals(YellowButton))
            {
                mainRect.Fill = new SolidColorBrush(Color.FromArgb(0xFF, 0xD9, 0xEC, 0x1B));//#FFD9EC1B
            }
            
        }

    }
}
