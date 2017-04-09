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
    public partial class DataBase : Form
    {
        EditStudent EditStudent;
     
        public DataBase()
        {
            InitializeComponent();
        }
        Recevied Recivied;

        private void DataBase_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Students_mdfDataSet1.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this._Students_mdfDataSet1.Students);
         
            


        }

        private void studentsBindingSource2_CurrentChanged(object sender, EventArgs e)
        {

        }

    

        private void button1_Click_1(object sender, EventArgs e)
        {
            Computing.Instance.DeleteExcess();
            Recivied = new Recevied();
            Recivied.Show();
           
        }

        private void Delete_Student_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                try
                {
                    int student = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    Computing.Instance.DeleteStudent(student);
                    dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                }
                catch 
                {
                    MessageBox.Show("Не удалось удалить данного абитуриента");
                }
            }
            else
            {
                MessageBox.Show("Выбирете абитуриента");
            }
        }

        private void Edit_Student_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
               
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    Student student= Computing.Instance.ChouseStudent(id);
                EditStudent = new EditStudent(student);
                EditStudent.Show();
                this.Close();
            }
        }
    }
}
