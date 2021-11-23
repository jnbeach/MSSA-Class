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

namespace EmployeeInfo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// </summary>
    public partial class MainWindow : Window
    {
        public Patient p1;
        public Patient p2;
        public Patient p3;
        public Patient p4;
        public Patient p5;
        public object tempDataContext;
        public List<Patient> PatientList { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            p1 = new Patient("Bob", "Smith", 72);
            p2 = new Patient("Rob", "Brown", 42);
            p3 = new Patient("Adam", "West", 38);
            p4 = new Patient("Jack", "Black", 45);
            p5 = new Patient("John", "Doe", 80);
            PatientList = new List<Patient>();
            PatientList.Add(p1);
            PatientList.Add(p2);
            PatientList.Add(p3);
            PatientList.Add(p4);
            PatientList.Add(p5);
            DataContext = this;
        }
    }
    public class Patient
    {
        //Fields and properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string BloodType { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public string Insurance { get; set; }
        public string Allergies { get; set; }
        public string Medications { get; set; }

        //Constructor for Patient
        public Patient(string first, string last, int a)
        {
            this.FirstName = first;
            this.LastName = last;
            this.Age = a;
            this.DateOfBirth = new DateTime(1946, 1, 12);
            this.BloodType = "O-";
            this.Weight = 150;
            this.Height = 70;
            this.Insurance= "Tricare";
            this.Allergies= "Bureaucracy";
            this.Medications= "Ibuprofen";
        }
    }
}
