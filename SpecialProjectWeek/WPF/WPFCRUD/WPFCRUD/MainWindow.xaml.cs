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

namespace WPFCRUD
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
        private void OpenListOfStudents(object sender, RoutedEventArgs e)
        {
            ListOfStudents studentsListWindow = new ListOfStudents();
            studentsListWindow.ShowDialog(); //Show lets you open as many windows as you want, whereas ShowDialog will only focus on one.
        }
    }
}
