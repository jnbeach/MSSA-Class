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

namespace ProfileLoadouts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Profile1 userProfile1 = new Profile1();
            Profile2 userProfile2 = new Profile2();
            Profile3 userProfile3 = new Profile3();
            Profile4 userProfile4 = new Profile4();
        }
    }
    class Profile1
    {
        
    }
    class Profile2
    {

    }
    class Profile3
    {

    }
    class Profile4
    {

    }
}
