using System;
using System.Collections.Generic;
using System.Diagnostics;
//using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives; //Needed for Toggle Button
using System.ComponentModel; // Needed to raise event for bindings to update GUI
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
        //Profile and Binding Objects instantiated:
        #region Profile and Binding Objects
        public Profile userProfile1 = new Profile();
        public Profile userProfile2 = new Profile();
        public Profile userProfile3 = new Profile();
        public Profile userProfile4 = new Profile();

        //Create Binding Objects no longer used.
        //public Binding brightnessBinding = new Binding("Brightness");
        //public Binding easyBinding = new Binding("Difficulty[0]");
        //public Binding normBinding = new Binding("Difficulty[1]");
        //public Binding hardBinding = new Binding("Difficulty[2]");
        //public Binding resolutionBinding = new Binding("Resolution");
        //public Binding permadeathBinding = new Binding("IsPermadeath");
        //public Binding hintsBinding = new Binding("AreHintsEnabled");
        #endregion
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = userProfile1;
            //BindingInitializer(userProfile1);
        }
        public void onUserButtonClick(object sender, RoutedEventArgs e)
        {
            RadioButton UserProfileBtn = sender as RadioButton;
            DataContextChanger(UserProfileBtn);
        }
        //None of this is used. Once a source is set, the source cannot be changed. Must use datacontext to change what the bindings are linked to.
        /// <summary>
        /// Takes a Profile class object (userProfile) as input. Sets all of the initial settings of the binding and then sets it to the userProfile argument.
        /// </summary>
        //public void BindingInitializer(Profile userProfile)
        //{
        //    //Configures the Brightness Slider binding object
        //    brightnessBinding.Mode = BindingMode.TwoWay;
        //    brightnessBinding.Source = userProfile;
        //    BindingOperations.SetBinding(BrightSlider, Slider.ValueProperty, brightnessBinding);
        //    //Configures the Difficulty Radio Buttons binding object
        //    easyBinding.Mode = BindingMode.TwoWay;
        //    easyBinding.Source = userProfile;
        //    BindingOperations.SetBinding(EasyRadio, RadioButton.IsCheckedProperty, easyBinding);
        //    normBinding.Mode = BindingMode.TwoWay;
        //    normBinding.Source = userProfile;
        //    BindingOperations.SetBinding(NormalRadio, RadioButton.IsCheckedProperty, normBinding);
        //    hardBinding.Mode = BindingMode.TwoWay;
        //    hardBinding.Source = userProfile;
        //    BindingOperations.SetBinding(HardRadio, RadioButton.IsCheckedProperty, hardBinding);
        //    //Configures the Resolution ComboBox binding object.
        //    resolutionBinding.Mode = BindingMode.TwoWay;
        //    resolutionBinding.Source = userProfile;
        //    BindingOperations.SetBinding(ResCombo, ComboBox.SelectedIndexProperty, resolutionBinding);
        //    //Configures the Permadeath binding object.
        //    permadeathBinding.Mode = BindingMode.TwoWay;
        //    permadeathBinding.Source = userProfile;
        //    BindingOperations.SetBinding(PermadeathCheck, CheckBox.IsCheckedProperty, permadeathBinding);
        //    //Configures the Hints Enabled binding object.
        //    hintsBinding.Mode = BindingMode.TwoWay;
        //    hintsBinding.Source = userProfile;
        //    BindingOperations.SetBinding(HintCheck, CheckBox.IsCheckedProperty, hintsBinding);
        //}
        
        /// <summary>
        /// Takes a Profile class object (userProfile) as input and changes the target of the binding to that profile.
        /// </summary>
        //public void BindingSetter(Profile userProfile)
        //{
            //Sets Brightness Slider to new user profile.
            //brightnessBinding.Source = userProfile;
            //BindingOperations.SetBinding(BrightSlider, Slider.ValueProperty, brightnessBinding);
            //Sets Difficulty radios to new user profile.
            //easyBinding.Source = userProfile;
            //BindingOperations.SetBinding(EasyRadio, RadioButton.IsCheckedProperty, easyBinding);
            //normBinding.Source = userProfile;
            //BindingOperations.SetBinding(NormalRadio, RadioButton.IsCheckedProperty, normBinding);
            //hardBinding.Source = userProfile;
            //BindingOperations.SetBinding(HardRadio, RadioButton.IsCheckedProperty, hardBinding);
            //Sets Resolution combos to new user profile.
            //resolutionBinding.Source = userProfile;
            //BindingOperations.SetBinding(ResCombo, ComboBox.SelectedIndexProperty, resolutionBinding);
            //Sets Permadeath checkbox to new user profile.
            //permadeathBinding.Source = userProfile;
            //BindingOperations.SetBinding(PermadeathCheck, CheckBox.IsCheckedProperty, permadeathBinding);
            //Sets Hints Enabled checkbox to new user profile.
            //hintsBinding.Source = userProfile;
            //BindingOperations.SetBinding(HintCheck, CheckBox.IsCheckedProperty, hintsBinding);
        //}

        /// <summary>
        /// Clears all bindings from each setting (Brightness, Difficulty, Resolution, and Extras)
        /// </summary>
        //public void BindingClear()
        //{
        //    BindingOperations.ClearBinding(BrightSlider, Slider.ValueProperty);
        //    brightnessBinding.Source = DependencyProperty.UnsetValue;
        //    BindingOperations.ClearBinding(EasyRadio, RadioButton.IsCheckedProperty);
        //    easyBinding.Source = DependencyProperty.UnsetValue;
        //    BindingOperations.ClearBinding(NormalRadio, RadioButton.IsCheckedProperty);
        //    normBinding.Source = DependencyProperty.UnsetValue;
        //    BindingOperations.ClearBinding(HardRadio, RadioButton.IsCheckedProperty);
        //    hardBinding.Source = DependencyProperty.UnsetValue;
        //    BindingOperations.ClearBinding(ResCombo, ComboBox.SelectedIndexProperty);
        //    resolutionBinding.Source = DependencyProperty.UnsetValue;
        //    BindingOperations.ClearBinding(PermadeathCheck, CheckBox.IsCheckedProperty);
        //    permadeathBinding.Source = DependencyProperty.UnsetValue;
        //    BindingOperations.ClearBinding(HintCheck, CheckBox.IsCheckedProperty);
        //    hintsBinding.Source = DependencyProperty.UnsetValue;
        //}
        
        /// <summary>
        /// Used in the onUserButtonClick method to change the bindings to the selected userprofile. The argument UserButton is sent by the Click event as the object sender.
        /// </summary>
        public void DataContextChanger(RadioButton UserButton)
        {
            //BindingClear();
            switch (UserButton.Content)
            {
                case "User 1":
                    this.DataContext = userProfile1;
                    break;
                case "User 2":
                    this.DataContext = userProfile2;
                    break;
                case "User 3":
                    this.DataContext = userProfile3;
                    break;
                case "User 4":
                    this.DataContext = userProfile4;
                    break;
                default:
                    break;
            }
        }
        public void onHardClick(object sender, RoutedEventArgs e)
        {
            Praise.Visibility = Visibility.Visible;
        }
        public void DebugWriter(object sender, RoutedEventArgs e)
        {
            Debug.WriteLine($"----------------Profile 1-----------------------------");
            Debug.WriteLine($"{userProfile1.Brightness}");
            //Debug.Write($"{userProfile1.SelectedDiff} ");
            Debug.Write($"[{userProfile1.Easy} ");
            Debug.Write($"{userProfile1.Normal} ");
            Debug.Write($"{userProfile1.Hard}] \n");
            Debug.WriteLine($"{userProfile1.Resolution}");
            Debug.WriteLine($"{userProfile1.IsPermadeath}");
            Debug.WriteLine($"{userProfile1.AreHintsEnabled}");
            Debug.WriteLine($"----------------Profile 2-----------------------------");
            Debug.WriteLine($"{userProfile2.Brightness}");
            //Debug.Write($"{userProfile2.SelectedDiff} ");
            Debug.Write($"[{userProfile2.Easy} ");
            Debug.Write($"{userProfile2.Normal} ");
            Debug.Write($"{userProfile2.Hard}] \n");
            Debug.WriteLine($"{userProfile2.Resolution}");
            Debug.WriteLine($"{userProfile2.IsPermadeath}");
            Debug.WriteLine($"{userProfile2.AreHintsEnabled}");
            Debug.WriteLine($"----------------Profile 3-----------------------------");
            Debug.WriteLine($"{userProfile3.Brightness}");
            //Debug.Write($"{userProfile3.SelectedDiff} ");
            Debug.Write($"[{userProfile3.Easy} ");
            Debug.Write($"{userProfile3.Normal} ");
            Debug.Write($"{userProfile3.Hard}] \n");
            Debug.WriteLine($"{userProfile3.Resolution}");
            Debug.WriteLine($"{userProfile3.IsPermadeath}");
            Debug.WriteLine($"{userProfile3.AreHintsEnabled}");
            Debug.WriteLine($"----------------Profile 4-----------------------------");
            Debug.WriteLine($"{userProfile4.Brightness}");
            //Debug.Write($"{userProfile4.SelectedDiff} ");
            Debug.Write($"[{userProfile4.Easy} ");
            Debug.Write($"{userProfile4.Normal} ");
            Debug.Write($"{userProfile4.Hard}] \n");
            Debug.WriteLine($"{userProfile4.Resolution}");
            Debug.WriteLine($"{userProfile4.IsPermadeath}");
            Debug.WriteLine($"{userProfile4.AreHintsEnabled}");
        }
    }
    //Class for Profile. Must implement the INotifyPropertyChanged Interface. This enforces the use of the PropertyChanged Event.
    public class Profile : INotifyPropertyChanged
    {
        //Fields and Properties
        // Must use the onPropertyChanged method in the setter to raise the PropertyChanged event whenever a property is changed.
        #region Fields and Properties
        public event PropertyChangedEventHandler PropertyChanged;
        private int brightness;
        public int Brightness {
            get { return brightness; }
            set {this.brightness = value; onPropertyChanged("Brightness");} 
        }

        public bool easy;
        public bool normal;
        public bool hard;
        public bool Easy
        {
            get { return easy; }
            set { this.easy = value; onPropertyChanged("Easy"); }
        }
        public bool Normal
        {
            get { return normal; }
            set { this.normal = value; onPropertyChanged("Normal"); }
        }
        public bool Hard
        {
            get { return hard; }
            set { this.hard = value; onPropertyChanged("Hard"); }
        }









        public bool[] difficulty;
        public bool[] Difficulty
        {
            get { return difficulty; }
            set { this.difficulty = value; onPropertyChanged("Difficulty"); }
        }
        public int SelectedDiff {
            get { return Array.IndexOf(difficulty, true); }
        }
        private int resolution;
        public int Resolution {
            get { return resolution; }
            set { this.resolution = value; onPropertyChanged("Resolution"); }
        }
        private bool isPermadeath;
        public bool IsPermadeath {
            get { return isPermadeath; }
            set { this.isPermadeath = value; onPropertyChanged("IsPermadeath"); }
        }
        public bool areHintsEnabled;
        public bool AreHintsEnabled {
            get { return areHintsEnabled; }
            set { this.areHintsEnabled = value; onPropertyChanged("AreHintsEnabled"); }
        }
        #endregion
        
        //Constructor
        public Profile()
        {
            this.brightness = 0;
            this.normal = true;
            this.difficulty = new bool[3] {false, true, false };
            this.resolution = 2;
            this.isPermadeath = false;
            this.areHintsEnabled = false;
        }

        //The property argument can actually be blank. It is informational for the EventArgs. However, you do need an argument to confrom to the PropertyChanged event dele
        public void onPropertyChanged(string property)
        {
            if (PropertyChanged!=null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
