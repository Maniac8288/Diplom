using Diplom.Models;
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
    public partial class ChouseGroupAndSeats : Form
    {
        public ChouseGroupAndSeats()
        {
            InitializeComponent();
        }

        private void AcceptChouse_Click(object sender, EventArgs e)
        {
            if (ListGroups.Text.ToString() == "")
            {
                MessageBox.Show("Выбирете группу");
            }
            else {
                var key = ListGroups.Text.ToString();
                try
                {
                    List<int> Seats = GroupsComputing.Instance.ChouseGroups(key);


                    CountSeatsLabel.Text = "Количество мест: " + Seats[0].ToString();
                    EditSeats.Size = new Size(90, 23);
                    CountBudgetLabel.Text = "Бюджетные места: " + Seats[1].ToString();
                    EditBudget.Size = new Size(90, 23);
                    CountQuata.Text = "Квота: " + Seats[2].ToString();
                    EditQuota.Size = new Size(90, 23);
                    EditBudgetLabel.Text = "";
                    EditBudgetAction.Size = new Size(0, 23);
                    AcceptEditBudget.Size = new Size(0, 23);
                    EditBudgetAction.Text = "";
                    EditSeatsLabel.Text = "";
                    EditSeatAction.Size = new Size(0, 23);
                    AcceptEditSeat.Size = new Size(0, 23);
                    EditSeatAction.Text = "";
                    EditQuotaLabel.Text = "";
                    EditQuotaAction.Size = new Size(0, 23);
                    AcceptEditQuota.Size = new Size(0, 23);
                    EditSeatAction.Text = "";
                }
                catch
                {
                    MessageBox.Show("Вашей группы не существует");
                }
            }
        }

        private void EditSeats_Click(object sender, EventArgs e)
        {
            var key = ListGroups.Text.ToString();
            List<int> Seats = GroupsComputing.Instance.ChouseGroups(key);
            EditSeatsLabel.Text = "Введите кол-во";
            EditSeatAction.Size= new Size(90, 23);
            AcceptEditSeat.Size = new Size(90, 23);
            EditSeatAction.Text = Seats[0].ToString();
        }
        private void EditBudget_Click(object sender, EventArgs e)
        {
            var key = ListGroups.Text.ToString();
            List<int> Seats = GroupsComputing.Instance.ChouseGroups(key);
            EditBudgetLabel.Text = "Введите кол-во";
            EditBudgetAction.Size = new Size(90, 23);
            AcceptEditBudget.Size = new Size(90, 23);
            EditBudgetAction.Text = Seats[1].ToString();
        }
        private void EditQuota_Click(object sender, EventArgs e)
        {
            var key = ListGroups.Text.ToString();
            List<int> Seats = GroupsComputing.Instance.ChouseGroups(key);
            EditQuotaLabel.Text = "Введите кол-во";
            EditQuotaAction.Size = new Size(90, 23);
            AcceptEditQuota.Size = new Size(90, 23);
            EditQuotaAction.Text = Seats[2].ToString();
        }
        private void AcceptEditBudget_Click(object sender, EventArgs e)
        {
            
            var key = ListGroups.Text.ToString();
            try
            {
                int count = Convert.ToInt32(EditBudgetAction.Text.ToString());
                GroupsComputing.Instance.EditBudgetSeats(key, count);
                CountBudgetLabel.Text = "Бюджетные места: " + EditBudgetAction.Text.ToString();
                EditBudgetLabel.Text = "";
                EditBudgetAction.Size = new Size(0, 23);
                AcceptEditBudget.Size = new Size(0, 23);
            }
            catch
            {
                MessageBox.Show("Введите корректное количество");
            }
           
          
        
        }

        private void AcceptEditSeat_Click(object sender, EventArgs e)
        {
         
            var key = ListGroups.Text.ToString();
            try
            {
                int count = Convert.ToInt32(EditSeatAction.Text.ToString());
                GroupsComputing.Instance.EditSeats(key, count);
                CountSeatsLabel.Text = "Количество мест: " + EditSeatAction.Text.ToString();
                EditSeatsLabel.Text = "";
                EditSeatAction.Size = new Size(0, 23);
                AcceptEditSeat.Size = new Size(0, 23);
            }
            catch
            {
                MessageBox.Show("Введите корректное количество");
            }
        }

        private void AcceptEditQuota_Click(object sender, EventArgs e)
        {
            var key = ListGroups.Text.ToString();
            try
            {
                int count = Convert.ToInt32(EditQuotaAction.Text.ToString());
                GroupsComputing.Instance.EditQuotaSeats(key, count);
                CountQuata.Text = "Количество мест: " + EditQuotaAction.Text.ToString();
                EditQuotaLabel.Text = "";
                EditQuotaAction.Size = new Size(0, 23);
                AcceptEditQuota.Size = new Size(0, 23);
            }
            catch
            {
                MessageBox.Show("Введите корректное количество");
            }
        }
    }
}
