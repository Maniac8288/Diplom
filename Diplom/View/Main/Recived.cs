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
    public partial class Recived : Form
    {
        public Recived()
        {
            InitializeComponent();
        }

        private void Recived_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Students_mdfDataSet1.StudentReceiveds". При необходимости она может быть перемещена или удалена.
            this.studentReceivedsTableAdapter.Fill(this._Students_mdfDataSet1.StudentReceiveds);

        }

        private void Update_Table_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите обновить таблицу. Все старые данные будут удалены!",
                       "Обновление",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Warning,
                       MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                Computing.Instance.DeleteExcess();
            }
        }
        /// <summary>
        /// Удаление студента
        /// </summary>
        private void DeleteStudent_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                try
                {
                    DialogResult result = MessageBox.Show(
                        "Вы действительно хотите удалить выбранного абитуриента",
                        "Удаление",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1);
                    if (result == DialogResult.Yes)
                    {
                        int student = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
                        Computing.Instance.DeleteStudent(student,true);
                        dataGridView2.Rows.Remove(dataGridView2.CurrentRow);

                    }

                }
                catch
                {
                    MessageBox.Show("Не удалось удалить данного абитуриента");
                }
            }
        }
    }
}
