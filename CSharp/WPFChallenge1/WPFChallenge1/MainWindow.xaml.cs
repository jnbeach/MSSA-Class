using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFChallenge1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string coffeeType;
        string size;
        string extras;
        string summary;



        Coffee coffee1 { get; set; } = new Coffee();

        public MainWindow()
        {
            InitializeComponent();

            summaryText.DataContext = coffee1;
            //summaryText.Text = "Place order here.";
            //Need data context here?
        }
        
        private void sizeClick(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(smallSize))
            {
                this.size = "Small";
            }
            if (sender.Equals(medSize))
            {
                this.size = "Medium";
            }            
            if (sender.Equals(largeSize))
            {
                this.size = "Large";
            }
            summaryUpdater();
        }
        private void typeClick(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(Coffee))
            {
                this.coffeeType = "Coffee";
            }
            if (sender.Equals(Latte))
            {
                this.coffeeType = "Latte";
            }
            if (sender.Equals(Cappucino))
            {
                this.coffeeType = "Cappucino";
            }
            if (sender.Equals(Americano))
            {
                this.coffeeType = "Americano";
            }
            if (sender.Equals(Espresso))
            {
                this.coffeeType = "Espresso";
            }
            if (sender.Equals(Macchiato))
            {
                this.coffeeType = "Macchiato";
            }
            summaryUpdater();
        }
        private void extrasCheckedOrUnchecked(object sender, RoutedEventArgs e)
        {
            if (sugar.IsChecked == true && cream.IsChecked == true)
            {
                this.extras = "with Sugar and Cream";
            }
            else if (sugar.IsChecked == true && cream.IsChecked == false)
            {
                this.extras = "with Sugar";
            }
            else if (sugar.IsChecked == false && cream.IsChecked == true)
            {
                this.extras = "with Cream";
            }
            else
            {
                this.extras = "";
            }
            summaryUpdater();
        }
        private void summaryUpdater()
        {
            
            this.summary = $"{this.size} {this.coffeeType} {this.extras}";
            //summaryText.DataContext = coffee1;
            //summaryText.Text = this.summary;
            coffee1.Description = this.summary;
            Debug.WriteLine(coffee1.Description);
        }
        private void submitOrder(object sender, RoutedEventArgs e)
        {
            this.size="";
            this.coffeeType="";
            this.extras="";
            smallSize.IsChecked = false;
            medSize.IsChecked = false;
            largeSize.IsChecked = false;
            CoffeeSelector.SelectedItem = null;
            sugar.IsChecked = false;
            cream.IsChecked = false;
            summaryUpdater();
            MessageBox.Show("Your order has been submitted");
        }
    }
    public class Coffee
    {
        public string Description { get; set; }
        public Coffee()
        {
            //this.Description;
        }
    }
}
