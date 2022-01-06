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

namespace WPFCRUD
{
    /// <summary>
    /// Interaction logic for Form.xaml
    /// </summary>
    public partial class Form : Window
    {

        private int _id;
        public Form(int id = 0)
        {
            InitializeComponent();

            this._id = id;

            if (id != 0)
            {
                using (WPFEntities db = new WPFEntities())
                {
                    Student retrievedStudent = db.Students.Find(id);

                    FirstNameTxt.Text = retrievedStudent.FirstName;
                    LastNameTxt.Text = retrievedStudent.LastName;
                    AgeTxt.Text = retrievedStudent.Age.ToString();
                    HeightTxt.Text = retrievedStudent.Height.ToString();
                    FailedTxt.IsChecked = retrievedStudent.Failed;
                }
            }


        }

        private void CloseForm(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddNewStudent(object sender, RoutedEventArgs e)
        {
            if (this._id == 0)
            {
                Student newStudent = new Student();
                newStudent.FirstName = FirstNameTxt.Text;
                newStudent.LastName = LastNameTxt.Text;
                newStudent.Age = int.Parse(AgeTxt.Text);
                newStudent.Height = decimal.Parse(HeightTxt.Text);
                newStudent.Failed = FailedTxt.IsChecked.Value;

                using (WPFEntities db = new WPFEntities()) // Opening connection to the database.
                {
                    db.Students.Add(newStudent);
                    db.SaveChanges();                    
                } //Closes connection to the database
                this.Close();                
            }
            else
            {
                using (WPFEntities db = new WPFEntities()) //opening connection to DB
                {
                    Student oStudent = db.Students.Find(this._id);

                    oStudent.FirstName = FirstNameTxt.Text;
                    oStudent.LastName = LastNameTxt.Text;
                    oStudent.Age = int.Parse(AgeTxt.Text);
                    oStudent.Height = decimal.Parse(HeightTxt.Text);

                    if (FailedTxt.IsChecked == true) { oStudent.Failed = true; }
                    else { oStudent.Failed = false; }

                    db.Entry(oStudent).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                ListOfStudents studentsList = new ListOfStudents();
                this.Close();
                studentsList.ShowDialog();
            }

        }
    }
}
