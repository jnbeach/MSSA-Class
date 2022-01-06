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
using System.Windows.Shapes;
using WPFCRUD.Model;
using WPFCRUD.ViewModels;

namespace WPFCRUD
{
    /// <summary>
    /// Interaction logic for ListOfStudents.xaml
    /// </summary>
    public partial class ListOfStudents : Window
    {
        public ListOfStudents()
        {
            InitializeComponent();

            //This will retrieve the contents of the database when the window is initialized.
            Refresh();
        }
        //Retrieves contents from the database.
        public void Refresh()
        {
            List<StudentViewModel> myListOfStudents = new List<StudentViewModel>();

            using(WPFEntities db = new WPFEntities()) // Opening connection to the database.
            {
               var query = (from obj in db.Students select new StudentViewModel {
                    Id = obj.Id,
                    FirstName = obj.FirstName,
                    LastName = obj.LastName,
                    Age = obj.Age,
                    Height = obj.Height,
                    Failed = obj.Failed
                });

                myListOfStudents = query.ToList();

            } //Closes connection to the database

            

            //Made another student class to make this work, but I'm sure there is a way to avoid this.

            DataGrid.ItemsSource = myListOfStudents;
        }
        private void CloseListOfStudents(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OpenForm(object sender, RoutedEventArgs e)
        {
            Form AddNewStudentForm = new Form();
            AddNewStudentForm.ShowDialog();
            Refresh();
        }

        private void EditStudent(object sender, RoutedEventArgs e)
        {
            Button editStudentButton = (Button)sender;
            int ButtonId = (int) editStudentButton.CommandParameter;
        }

        private void DeleteStudent(object sender, RoutedEventArgs e)
        {
            Button editStudentButton = (Button)sender;
            int ButtonId = (int)editStudentButton.CommandParameter;

            using (WPFEntities db = new WPFEntities())
            {
                Student StudentToRemove = db.Students.Find(ButtonId);
                db.Students.Remove(StudentToRemove);

                db.SaveChanges();
            }
            Refresh();
        }
    }
}
