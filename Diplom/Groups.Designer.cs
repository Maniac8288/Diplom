namespace Diplom
{
    partial class Groups
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
            this.EditBudget = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EditBudget
            // 
            this.EditBudget.BackColor = System.Drawing.Color.Transparent;
            this.EditBudget.BackgroundImage = global::Diplom.Properties.Resources.depositphotos_33130249_stock_illustration_white_texture_seamless_background_vector;
            this.EditBudget.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditBudget.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBudget.Location = new System.Drawing.Point(507, 553);
            this.EditBudget.Name = "EditBudget";
            this.EditBudget.Size = new System.Drawing.Size(293, 32);
            this.EditBudget.TabIndex = 63;
            this.EditBudget.Text = "Изменить бюджетные места";
            this.EditBudget.UseVisualStyleBackColor = false;
            this.EditBudget.Click += new System.EventHandler(this.EditBudget_Click);
            // 
            // Groups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 597);
            this.Controls.Add(this.EditBudget);
            this.Name = "Groups";
            this.Text = "Groups";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EditBudget;
    }
}