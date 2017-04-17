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
    public partial class Groups : Form
    {
        ChouseGroupAndSeats chouseGroupAndSeats;
        public Groups()
        {
            InitializeComponent();
        }

    

        private void Groups_Load(object sender, EventArgs e)
        {
            SeatAll.Text= GroupsComputing.Instance.CountSeatAll().ToString();
            BudgetAll.Text = GroupsComputing.Instance.CountBudgetAll().ToString();
            Seat.Text = GroupsComputing.Instance.CountSeat().ToString();
            Budget.Text = GroupsComputing.Instance.CountBudget().ToString();            
        }

        private void Update_Click(object sender, EventArgs e)
        {
            SeatAll.Text = GroupsComputing.Instance.CountSeatAll().ToString();
            BudgetAll.Text = GroupsComputing.Instance.CountBudgetAll().ToString();
            Seat.Text = GroupsComputing.Instance.CountSeat().ToString();
            Budget.Text = GroupsComputing.Instance.CountBudget().ToString();
        }
     
        private void AcceptChouse_Click_1(object sender, EventArgs e)
        {
            if (ListGroups.Text.ToString() == "")
            {
                MessageBox.Show("Выбирете группу");
            }
            else
            {
                var key = ListGroups.Text.ToString();
                try
                {
                    List<int> Seats = GroupsComputing.Instance.ChouseGroups(key);


                    CountSeatsLabel.Text = "Количество мест: " + Seats[0].ToString();
                    EditSeats.Visible = true;
                    CountBudgetLabel.Text = "Бюджетные места: " + Seats[1].ToString();
                    EditBudget.Visible = true;
                    CountQuata.Text = "Квота: " + Seats[2].ToString();
                    EditQuota.Visible = true;
                    EditBudgetLabel.Text = "";
                    EditBudgetAction.Visible = false;
                    AcceptEditBudget.Visible = false;
                    EditBudgetAction.Text = "";
                    EditSeatsLabel.Text = "";
                    EditSeatAction.Visible = false;
                    AcceptEditSeat.Visible = false;
                    EditSeatAction.Text = "";
                    EditQuotaLabel.Text = "";
                    EditQuotaAction.Visible = false;
                    AcceptEditQuota.Visible = false;
                    EditSeatAction.Text = "";
                }
                catch
                {
                    MessageBox.Show("Вашей группы не существует");
                }
            }
        }

        private void EditSeats_Click_1(object sender, EventArgs e)
        {
            var key = ListGroups.Text.ToString();
            List<int> Seats = GroupsComputing.Instance.ChouseGroups(key);
            EditSeatsLabel.Text = "Введите кол-во";
            EditSeatAction.Visible = true;
            AcceptEditSeat.Visible = true;
            EditSeatAction.Text = Seats[0].ToString();
        }

        private void EditBudget_Click_1(object sender, EventArgs e)
        {
            var key = ListGroups.Text.ToString();
            List<int> Seats = GroupsComputing.Instance.ChouseGroups(key);
            EditBudgetLabel.Text = "Введите кол-во";
            EditBudgetAction.Visible = true;
            AcceptEditBudget.Visible = true;
            EditBudgetAction.Text = Seats[1].ToString();
        }

        private void EditQuota_Click_1(object sender, EventArgs e)
        {
            var key = ListGroups.Text.ToString();
            List<int> Seats = GroupsComputing.Instance.ChouseGroups(key);
            EditQuotaLabel.Text = "Введите кол-во";
            EditQuotaAction.Visible = true;
            AcceptEditQuota.Visible = true;
            EditQuotaAction.Text = Seats[2].ToString();
        }

        private void AcceptEditSeat_Click_1(object sender, EventArgs e)
        {
            var key = ListGroups.Text.ToString();
            try
            {
                int count = Convert.ToInt32(EditSeatAction.Text.ToString());
                GroupsComputing.Instance.EditSeats(key, count);
                CountSeatsLabel.Text = "Количество мест: " + EditSeatAction.Text.ToString();
                EditSeatsLabel.Text = "";
                EditSeatAction.Visible = false;
                AcceptEditSeat.Visible = false;
            }
            catch
            {
                MessageBox.Show("Введите корректное количество");
            }
        }

        private void AcceptEditBudget_Click_1(object sender, EventArgs e)
        {
            var key = ListGroups.Text.ToString();
            try
            {
                int count = Convert.ToInt32(EditBudgetAction.Text.ToString());
                if (GroupsComputing.Instance.EditBudgetSeats(key, count) == "") {
                    MessageBox.Show("Количество бюджетных мест слишком вилеко");
                }
                else{
                    CountBudgetLabel.Text = "Бюджетные места: " + EditBudgetAction.Text.ToString();
                    EditBudgetLabel.Text = "";
                    EditBudgetAction.Visible = false;
                    AcceptEditBudget.Visible = false;
                  
                }
            }
            catch
            {
                MessageBox.Show("Введите корректное количество");
            }
        }

        private void AcceptEditQuota_Click_1(object sender, EventArgs e)
        {
            var key = ListGroups.Text.ToString();
            try
            {
                int count = Convert.ToInt32(EditQuotaAction.Text.ToString());
                if (GroupsComputing.Instance.EditQuotaSeats(key, count) == "")
                {
                    MessageBox.Show("Количество бюджетных мест слишком вилеко");
                }
                else
                {
                    CountQuata.Text = "Квота: " + EditQuotaAction.Text.ToString();
                    EditQuotaLabel.Text = "";
                    EditQuotaAction.Visible = false;
                    AcceptEditQuota.Visible = false;
                }
            }
            catch
            {
                MessageBox.Show("Введите корректное количество");
            }
        }
    }
}
