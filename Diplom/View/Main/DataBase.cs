using Diplom.View.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom.View.Main
{
    public partial class DataBase : Form
    {
        EditStudent EditStudent;
        Recived Recivied;

        public DataBase()
        {
            InitializeComponent();
         
        }

        private void DataBase_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Students_mdfDataSet.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this._Students_mdfDataSet.Students);

        }

        private void DeleteStudent_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                try
                {
                   DialogResult result = MessageBox.Show(
                       "Вы действительно хотите удалить выбранного абитуриента",
                       "Удаление",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Warning,
                       MessageBoxDefaultButton.Button1 );
                    if (result == DialogResult.Yes)
                    {
                        int student = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                        Computing.Instance.DeleteStudent(student,false);
                        dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

                    }
                    
                   
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
                Student student = Computing.Instance.ChouseStudent(id);
                EditStudent = new EditStudent(student);
                EditStudent.Show();
             
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Recivied = new Recived();
            Recivied.Show();
            this.Close();

        }
    }
}
