using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class EditStudent : Form
    {
        public EditStudent(Student student)
        {

            InitializeComponent();
            AddSurName.Text = student.SurName;
            AddName.Text = student.NameStudent;
            AddSecondName.Text = student.SecondName;
            AddNationality.Text = student.Nationality;
            AddDateBirth.Value = student.DateBirth;
            AddDateDocument.Value = student.DateDocument;
            AddSocial.Text = student.Social;
            ComboLanguage.Text = student.Language;
            AddCitizenship.Text = student.Citizenship;
            AddForeignLanguage.Text = student.ForeignLanguage;
            AddPhone.Text = student.Phone;
            AddTicket.Text = student.MilitaryID;
            AddHouse.Text = student.House;
            AddSex.Text = student.Sex;
            AddDormitories.Text = student.Dormitories;
            AddDocuments.Text = student.Documents;
            AddSchool.Text = student.School;
            AddEndSchool.Value = student.EndSchool;
            AddGPA.Text = student.GPA.ToString();
            NubmerGroupChouse.Text = student.NumberGroup;
            ID.Tag = student.ID;
        }

        private void EditStudent_Load(object sender, EventArgs e)
        {

        }

        private void SaveChange_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AddSurName.Text) || string.IsNullOrWhiteSpace(AddName.Text) || string.IsNullOrWhiteSpace(AddSecondName.Text) || string.IsNullOrWhiteSpace(AddNationality.Text) || string.IsNullOrWhiteSpace(AddDateBirth.Text) || string.IsNullOrWhiteSpace(ComboLanguage.Text) || string.IsNullOrWhiteSpace(AddCitizenship.Text) || string.IsNullOrWhiteSpace(AddForeignLanguage.Text) || string.IsNullOrWhiteSpace(AddHouse.Text) || string.IsNullOrWhiteSpace(AddSex.Text) || string.IsNullOrWhiteSpace(AddDormitories.Text) || string.IsNullOrWhiteSpace(AddDocuments.Text) || string.IsNullOrWhiteSpace(AddSchool.Text) || string.IsNullOrWhiteSpace(AddEndSchool.Value.ToString()) || string.IsNullOrWhiteSpace(AddGPA.Text))
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
                        NumberGroup = NubmerGroupChouse.Text.ToString(),
                        ID = Convert.ToInt32(ID.Tag)
                        
                    };
                    Computing.Instance.EditStudent(NewStudent);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
