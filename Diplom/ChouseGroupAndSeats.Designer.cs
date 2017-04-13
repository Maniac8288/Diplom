namespace Diplom
{
    partial class ChouseGroupAndSeats
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Surname = new System.Windows.Forms.Label();
            this.ListGroups = new System.Windows.Forms.ComboBox();
            this.AcceptChouse = new System.Windows.Forms.Button();
            this.CountSeatsLabel = new System.Windows.Forms.Label();
            this.EditSeats = new System.Windows.Forms.Button();
            this.EditBudget = new System.Windows.Forms.Button();
            this.CountBudgetLabel = new System.Windows.Forms.Label();
            this.EditSeatsLabel = new System.Windows.Forms.Label();
            this.EditSeatAction = new System.Windows.Forms.TextBox();
            this.AcceptEditSeat = new System.Windows.Forms.Button();
            this.AcceptEditBudget = new System.Windows.Forms.Button();
            this.EditBudgetAction = new System.Windows.Forms.TextBox();
            this.EditBudgetLabel = new System.Windows.Forms.Label();
            this.EditQuota = new System.Windows.Forms.Button();
            this.CountQuata = new System.Windows.Forms.Label();
            this.AcceptEditQuota = new System.Windows.Forms.Button();
            this.EditQuotaAction = new System.Windows.Forms.TextBox();
            this.EditQuotaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Surname.Location = new System.Drawing.Point(12, 29);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(119, 18);
            this.Surname.TabIndex = 1;
            this.Surname.Text = "Выбор группы";
            // 
            // ListGroups
            // 
            this.ListGroups.FormattingEnabled = true;
            this.ListGroups.Items.AddRange(new object[] {
            "09.02.01",
            "09.02.03",
            "09.02.05",
            "40.02.01"});
            this.ListGroups.Location = new System.Drawing.Point(137, 30);
            this.ListGroups.Name = "ListGroups";
            this.ListGroups.Size = new System.Drawing.Size(121, 21);
            this.ListGroups.TabIndex = 2;
            // 
            // AcceptChouse
            // 
            this.AcceptChouse.Location = new System.Drawing.Point(264, 28);
            this.AcceptChouse.Name = "AcceptChouse";
            this.AcceptChouse.Size = new System.Drawing.Size(90, 23);
            this.AcceptChouse.TabIndex = 3;
            this.AcceptChouse.Text = "Подвердить";
            this.AcceptChouse.UseVisualStyleBackColor = true;
            this.AcceptChouse.Click += new System.EventHandler(this.AcceptChouse_Click);
            // 
            // CountSeatsLabel
            // 
            this.CountSeatsLabel.AutoSize = true;
            this.CountSeatsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountSeatsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CountSeatsLabel.Location = new System.Drawing.Point(12, 120);
            this.CountSeatsLabel.Name = "CountSeatsLabel";
            this.CountSeatsLabel.Size = new System.Drawing.Size(0, 18);
            this.CountSeatsLabel.TabIndex = 4;
            // 
            // EditSeats
            // 
            this.EditSeats.Location = new System.Drawing.Point(264, 120);
            this.EditSeats.Name = "EditSeats";
            this.EditSeats.Size = new System.Drawing.Size(0, 23);
            this.EditSeats.TabIndex = 5;
            this.EditSeats.Text = "Изменить";
            this.EditSeats.UseVisualStyleBackColor = true;
            this.EditSeats.Click += new System.EventHandler(this.EditSeats_Click);
            // 
            // EditBudget
            // 
            this.EditBudget.Location = new System.Drawing.Point(264, 172);
            this.EditBudget.Name = "EditBudget";
            this.EditBudget.Size = new System.Drawing.Size(0, 23);
            this.EditBudget.TabIndex = 7;
            this.EditBudget.Text = "Изменить";
            this.EditBudget.UseVisualStyleBackColor = true;
            this.EditBudget.Click += new System.EventHandler(this.EditBudget_Click);
            // 
            // CountBudgetLabel
            // 
            this.CountBudgetLabel.AutoSize = true;
            this.CountBudgetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountBudgetLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CountBudgetLabel.Location = new System.Drawing.Point(12, 172);
            this.CountBudgetLabel.Name = "CountBudgetLabel";
            this.CountBudgetLabel.Size = new System.Drawing.Size(0, 18);
            this.CountBudgetLabel.TabIndex = 6;
            // 
            // EditSeatsLabel
            // 
            this.EditSeatsLabel.AutoSize = true;
            this.EditSeatsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditSeatsLabel.Location = new System.Drawing.Point(10, 309);
            this.EditSeatsLabel.Name = "EditSeatsLabel";
            this.EditSeatsLabel.Size = new System.Drawing.Size(0, 18);
            this.EditSeatsLabel.TabIndex = 8;
            // 
            // EditSeatAction
            // 
            this.EditSeatAction.Location = new System.Drawing.Point(141, 308);
            this.EditSeatAction.Name = "EditSeatAction";
            this.EditSeatAction.Size = new System.Drawing.Size(0, 20);
            this.EditSeatAction.TabIndex = 9;
            // 
            // AcceptEditSeat
            // 
            this.AcceptEditSeat.Location = new System.Drawing.Point(262, 306);
            this.AcceptEditSeat.Name = "AcceptEditSeat";
            this.AcceptEditSeat.Size = new System.Drawing.Size(0, 23);
            this.AcceptEditSeat.TabIndex = 10;
            this.AcceptEditSeat.Text = "Потвердить";
            this.AcceptEditSeat.UseVisualStyleBackColor = true;
            this.AcceptEditSeat.Click += new System.EventHandler(this.AcceptEditSeat_Click);
            // 
            // AcceptEditBudget
            // 
            this.AcceptEditBudget.Location = new System.Drawing.Point(262, 377);
            this.AcceptEditBudget.Name = "AcceptEditBudget";
            this.AcceptEditBudget.Size = new System.Drawing.Size(0, 23);
            this.AcceptEditBudget.TabIndex = 13;
            this.AcceptEditBudget.Text = "Потвердить";
            this.AcceptEditBudget.UseVisualStyleBackColor = true;
            this.AcceptEditBudget.Click += new System.EventHandler(this.AcceptEditBudget_Click);
            // 
            // EditBudgetAction
            // 
            this.EditBudgetAction.Location = new System.Drawing.Point(143, 378);
            this.EditBudgetAction.Name = "EditBudgetAction";
            this.EditBudgetAction.Size = new System.Drawing.Size(0, 20);
            this.EditBudgetAction.TabIndex = 12;
            // 
            // EditBudgetLabel
            // 
            this.EditBudgetLabel.AutoSize = true;
            this.EditBudgetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditBudgetLabel.Location = new System.Drawing.Point(12, 377);
            this.EditBudgetLabel.Name = "EditBudgetLabel";
            this.EditBudgetLabel.Size = new System.Drawing.Size(0, 18);
            this.EditBudgetLabel.TabIndex = 11;
            // 
            // EditQuota
            // 
            this.EditQuota.Location = new System.Drawing.Point(262, 221);
            this.EditQuota.Name = "EditQuota";
            this.EditQuota.Size = new System.Drawing.Size(0, 23);
            this.EditQuota.TabIndex = 15;
            this.EditQuota.Text = "Изменить";
            this.EditQuota.UseVisualStyleBackColor = true;
            this.EditQuota.Click += new System.EventHandler(this.EditQuota_Click);
            // 
            // CountQuata
            // 
            this.CountQuata.AutoSize = true;
            this.CountQuata.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountQuata.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CountQuata.Location = new System.Drawing.Point(12, 221);
            this.CountQuata.Name = "CountQuata";
            this.CountQuata.Size = new System.Drawing.Size(0, 18);
            this.CountQuata.TabIndex = 14;
            // 
            // AcceptEditQuota
            // 
            this.AcceptEditQuota.Location = new System.Drawing.Point(265, 450);
            this.AcceptEditQuota.Name = "AcceptEditQuota";
            this.AcceptEditQuota.Size = new System.Drawing.Size(0, 23);
            this.AcceptEditQuota.TabIndex = 18;
            this.AcceptEditQuota.Text = "Потвердить";
            this.AcceptEditQuota.UseVisualStyleBackColor = true;
            this.AcceptEditQuota.Click += new System.EventHandler(this.AcceptEditQuota_Click);
            // 
            // EditQuotaAction
            // 
            this.EditQuotaAction.Location = new System.Drawing.Point(143, 451);
            this.EditQuotaAction.Name = "EditQuotaAction";
            this.EditQuotaAction.Size = new System.Drawing.Size(0, 20);
            this.EditQuotaAction.TabIndex = 17;
            // 
            // EditQuotaLabel
            // 
            this.EditQuotaLabel.AutoSize = true;
            this.EditQuotaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditQuotaLabel.Location = new System.Drawing.Point(12, 450);
            this.EditQuotaLabel.Name = "EditQuotaLabel";
            this.EditQuotaLabel.Size = new System.Drawing.Size(0, 18);
            this.EditQuotaLabel.TabIndex = 16;
            // 
            // ChouseGroupAndSeats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 517);
            this.Controls.Add(this.AcceptEditQuota);
            this.Controls.Add(this.EditQuotaAction);
            this.Controls.Add(this.EditQuotaLabel);
            this.Controls.Add(this.EditQuota);
            this.Controls.Add(this.CountQuata);
            this.Controls.Add(this.AcceptEditBudget);
            this.Controls.Add(this.EditBudgetAction);
            this.Controls.Add(this.EditBudgetLabel);
            this.Controls.Add(this.AcceptEditSeat);
            this.Controls.Add(this.EditSeatAction);
            this.Controls.Add(this.EditSeatsLabel);
            this.Controls.Add(this.EditBudget);
            this.Controls.Add(this.CountBudgetLabel);
            this.Controls.Add(this.EditSeats);
            this.Controls.Add(this.CountSeatsLabel);
            this.Controls.Add(this.AcceptChouse);
            this.Controls.Add(this.ListGroups);
            this.Controls.Add(this.Surname);
            this.Name = "ChouseGroupAndSeats";
            this.Text = "ChouseGroupAndSeats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.ComboBox ListGroups;
        private System.Windows.Forms.Button AcceptChouse;
        private System.Windows.Forms.Label CountSeatsLabel;
        private System.Windows.Forms.Button EditSeats;
        private System.Windows.Forms.Button EditBudget;
        private System.Windows.Forms.Label CountBudgetLabel;
        private System.Windows.Forms.Label EditSeatsLabel;
        private System.Windows.Forms.TextBox EditSeatAction;
        private System.Windows.Forms.Button AcceptEditSeat;
        private System.Windows.Forms.Button AcceptEditBudget;
        private System.Windows.Forms.TextBox EditBudgetAction;
        private System.Windows.Forms.Label EditBudgetLabel;
        private System.Windows.Forms.Button EditQuota;
        private System.Windows.Forms.Label CountQuata;
        private System.Windows.Forms.Button AcceptEditQuota;
        private System.Windows.Forms.TextBox EditQuotaAction;
        private System.Windows.Forms.Label EditQuotaLabel;
    }
}