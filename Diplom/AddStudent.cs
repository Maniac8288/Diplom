using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Diplom;
using word = Microsoft.Office.Interop.Word;

namespace Diplom
{
    public partial class AddStudent : Form
    {
    
        public AddStudent()
        {
            InitializeComponent();
        
             
    }
       
        private void InfoSchool_Enter(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Handles the Click event of the AddStudentBD control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void AddStudentBD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AddSurName.Text)||string.IsNullOrWhiteSpace(AddName.Text) || string.IsNullOrWhiteSpace(AddSecondName.Text) || string.IsNullOrWhiteSpace(AddNationality.Text) || string.IsNullOrWhiteSpace(AddDateBirth.Text) || string.IsNullOrWhiteSpace(ComboLanguage.Text) || string.IsNullOrWhiteSpace(AddCitizenship.Text) || string.IsNullOrWhiteSpace(AddForeignLanguage.Text) || string.IsNullOrWhiteSpace(AddHouse.Text)|| string.IsNullOrWhiteSpace(AddSex.Text) || string.IsNullOrWhiteSpace(AddDormitories.Text) || string.IsNullOrWhiteSpace(AddDocuments.Text) || string.IsNullOrWhiteSpace(AddSchool.Text) || string.IsNullOrWhiteSpace(AddEndSchool.Value.ToString()) || string.IsNullOrWhiteSpace(AddGPA.Text))
            {
                Error.Text = "Введите все обязательные поля";
            }
            else
            {
                try
                {
                    var listGPA = AddGPA.Text.ToString().Split(',').Select(int.Parse).ToList();
                    Student NewStudent = new Student()
                    {
                        SurName = AddSurName.Text.ToString(),
                        NameStudent = AddName.Text.ToString(),
                        SecondName = AddSecondName.Text.ToString(),
                        Nationality = AddNationality.Text.ToString(),
                        DateBirth = AddDateBirth.Value,
                        DateDocument = AddDateDocument.Value,
                        Social = AddSocial.Text.ToString(),
                        Language = ComboLanguage.Text.ToString(),
                        Citizenship = AddCitizenship.Text.ToString(),
                        ForeignLanguage = AddForeignLanguage.Text.ToString(),
                        Phone = AddPhone.Text.ToString(),
                        MilitaryID = AddTicket.Text.ToString(),
                        House = AddHouse.Text.ToString(),
                        Sex = AddSex.Text.ToString(),
                        Dormitories = AddDormitories.Text.ToString(),
                        Documents = AddDocuments.Text.ToString(),
                        School = AddSchool.Text.ToString(),
                        EndSchool = AddEndSchool.Value,
                        GPA = Computing.Instance.GetGPA(listGPA),
                        NumberGroup = NubmerGroupChouse.Text.ToString()
                        
                    };
                    Computing.Instance.AddStudent(NewStudent);
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    
                }
               
            }
        }
        private void AddStudent_Load(object sender, EventArgs e)
        {
           
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
