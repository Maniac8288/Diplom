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
    public partial class Groups : Form
    {
        ChouseGroupAndSeats chouseGroupAndSeats;
        public Groups()
        {
            InitializeComponent();
        }

        private void EditBudget_Click(object sender, EventArgs e)
        {
            chouseGroupAndSeats = new ChouseGroupAndSeats();
            chouseGroupAndSeats.Show();
        }
    }
}
