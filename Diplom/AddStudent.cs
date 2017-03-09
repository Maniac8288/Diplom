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
        private readonly string templateFileName = @"c:\test.docx";
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
                GPA = Computing.Instance.GetGPA(listGPA)
        };
            Computing.Instance.AddStudent(NewStudent);
            var wordApp = new word.Application();
            wordApp.Visible = false;
            var wordDocument = wordApp.Documents.Open(templateFileName);
            word.Table _table = wordDocument.Tables[1];
            _table.Rows.Add(1);
        }
            
        

        private void AddStudent_Load(object sender, EventArgs e)
        {
           
        }
    }
}
