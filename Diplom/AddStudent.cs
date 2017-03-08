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

namespace Diplom
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }
        SqlConnection SqlConnection;
        private void InfoSchool_Enter(object sender, EventArgs e)
        {

        }

        private void AddStudentBD_Click(object sender, EventArgs e)
        {
            using (DataContext db = new DataContext()) {
                Student Student1 = new Student { SurName = "123", NameStudent = "345", SecondName = "567" };
                db.Students.Add(Student1);
                db.SaveChanges();
            }
            
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
           
        }
    }
}
