namespace Diplom.View.Docs
{
    partial class CreateDocs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateDocs));
            this.panel1 = new System.Windows.Forms.Panel();
            this.NameGroup = new System.Windows.Forms.Label();
            this.Statistic = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ChouseGroup = new System.Windows.Forms.ComboBox();
            this.Create = new System.Windows.Forms.Button();
            this.LabelChouseDocs = new System.Windows.Forms.Label();
            this.LabelChouseGroup = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.Statistic.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.NameGroup);
            this.panel1.Location = new System.Drawing.Point(31, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 36);
            this.panel1.TabIndex = 65;
            // 
            // NameGroup
            // 
            this.NameGroup.AutoSize = true;
            this.NameGroup.BackColor = System.Drawing.SystemColors.Desktop;
            this.NameGroup.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameGroup.ForeColor = System.Drawing.Color.Orange;
            this.NameGroup.Location = new System.Drawing.Point(86, 5);
            this.NameGroup.Name = "NameGroup";
            this.NameGroup.Size = new System.Drawing.Size(200, 21);
            this.NameGroup.TabIndex = 0;
            this.NameGroup.Text = "Создание документов";
            // 
            // Statistic
            // 
            this.Statistic.AccessibleDescription = "";
            this.Statistic.AutoSize = true;
            this.Statistic.BackColor = System.Drawing.Color.White;
            this.Statistic.Controls.Add(this.comboBox1);
            this.Statistic.Controls.Add(this.ChouseGroup);
            this.Statistic.Controls.Add(this.Create);
            this.Statistic.Controls.Add(this.LabelChouseDocs);
            this.Statistic.Controls.Add(this.LabelChouseGroup);
            this.Statistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Statistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Statistic.Location = new System.Drawing.Point(31, 32);
            this.Statistic.Name = "Statistic";
            this.Statistic.Size = new System.Drawing.Size(434, 321);
            this.Statistic.TabIndex = 66;
            this.Statistic.TabStop = false;
            this.Statistic.Text = "Статистика";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Полная информация",
            "Список группы"});
            this.comboBox1.Location = new System.Drawing.Point(224, 173);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(192, 24);
            this.comboBox1.TabIndex = 72;
            this.comboBox1.Text = "Полная информация";
            // 
            // ChouseGroup
            // 
            this.ChouseGroup.FormattingEnabled = true;
            this.ChouseGroup.Items.AddRange(new object[] {
            "Все",
            "111",
            "112",
            "113",
            "114"});
            this.ChouseGroup.Location = new System.Drawing.Point(295, 68);
            this.ChouseGroup.Name = "ChouseGroup";
            this.ChouseGroup.Size = new System.Drawing.Size(121, 24);
            this.ChouseGroup.TabIndex = 71;
            this.ChouseGroup.Text = "Все";
            // 
            // Create
            // 
            this.Create.BackColor = System.Drawing.Color.White;
            this.Create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Create.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.Create.FlatAppearance.BorderSize = 5;
            this.Create.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.Create.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.Create.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create.Location = new System.Drawing.Point(285, 254);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(143, 32);
            this.Create.TabIndex = 65;
            this.Create.Text = "Создать";
            this.Create.UseVisualStyleBackColor = false;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // LabelChouseDocs
            // 
            this.LabelChouseDocs.AutoSize = true;
            this.LabelChouseDocs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelChouseDocs.Font = new System.Drawing.Font("Microsoft NeoGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelChouseDocs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelChouseDocs.Location = new System.Drawing.Point(6, 172);
            this.LabelChouseDocs.Name = "LabelChouseDocs";
            this.LabelChouseDocs.Size = new System.Drawing.Size(145, 21);
            this.LabelChouseDocs.TabIndex = 1;
            this.LabelChouseDocs.Text = "Выбор документа:";
            // 
            // LabelChouseGroup
            // 
            this.LabelChouseGroup.AutoSize = true;
            this.LabelChouseGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelChouseGroup.Font = new System.Drawing.Font("Microsoft NeoGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelChouseGroup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelChouseGroup.Location = new System.Drawing.Point(6, 67);
            this.LabelChouseGroup.Name = "LabelChouseGroup";
            this.LabelChouseGroup.Size = new System.Drawing.Size(121, 21);
            this.LabelChouseGroup.TabIndex = 0;
            this.LabelChouseGroup.Text = "Выбор группы:";
            // 
            // CreateDocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Diplom.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(934, 546);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Statistic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateDocs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание документов";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Statistic.ResumeLayout(false);
            this.Statistic.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label NameGroup;
        private System.Windows.Forms.GroupBox Statistic;
        private System.Windows.Forms.Label LabelChouseDocs;
        private System.Windows.Forms.Label LabelChouseGroup;
        private System.Windows.Forms.ComboBox ChouseGroup;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}