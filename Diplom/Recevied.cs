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
    public partial class Recevied : Form
    {
        public Recevied()
        {
            InitializeComponent();
        }

        private void Recevied_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Students_mdfDataSet3.StudentReceiveds". При необходимости она может быть перемещена или удалена.
            this.studentReceivedsTableAdapter1.Fill(this._Students_mdfDataSet3.StudentReceiveds);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "_Students_mdfDataSet1.StudentReceiveds". При необходимости она может быть перемещена или удалена.
            this.studentReceivedsTableAdapter.Fill(this._Students_mdfDataSet1.StudentReceiveds);

        }
    }
}
