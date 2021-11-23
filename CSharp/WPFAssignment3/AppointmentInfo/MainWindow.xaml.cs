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

namespace AppointmentInfo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Patient p1;
        public Patient p2;
        public Patient p3;
        private List<Patient> patientList;
        public List<Patient> PatientList {get; set ;}
        public MainWindow()
        {
            InitializeComponent();
            p1 = new Patient("Bob", "Smith", 72);
            p2 = new Patient("Rob", "Brown", 42);
            p3 = new Patient("Adam", "West", 38);
            PatientList = new List<Patient>();
            PatientList.Add(p1);
            PatientList.Add(p2);
            PatientList.Add(p3);
            this.DataContext = PatientList;            
        }
    }
    public class Patient
    {
        private string firstName;
        public string FirstName { get; set; }

        private string lastName;
        public string LastName { get; set; }
        private int age;
        public int Age { get; set; }

        public Patient(string first, string last, int a)
        {
            this.firstName = first;
            this.lastName = last;
            this.age = a;
        }

    }
}
