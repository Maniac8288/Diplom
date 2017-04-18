namespace Diplom.View.Main
{
    partial class Recived
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recived));
            this._Students_mdfDataSet1 = new Diplom._Students_mdfDataSet1();
            this.studentReceivedsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentReceivedsTableAdapter = new Diplom._Students_mdfDataSet1TableAdapters.StudentReceivedsTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameStudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationalityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDocumentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.languageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citizenshipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foreignLanguageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.militaryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dormitoriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endSchoolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estimatesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonePareantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update_Table = new System.Windows.Forms.Button();
            this.DeleteStudent = new System.Windows.Forms.Button();
            this.Edit_Student = new System.Windows.Forms.Button();
            this.AddStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._Students_mdfDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentReceivedsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // _Students_mdfDataSet1
            // 
            this._Students_mdfDataSet1.DataSetName = "_Students_mdfDataSet1";
            this._Students_mdfDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentReceivedsBindingSource
            // 
            this.studentReceivedsBindingSource.DataMember = "StudentReceiveds";
            this.studentReceivedsBindingSource.DataSource = this._Students_mdfDataSet1;
            // 
            // studentReceivedsTableAdapter
            // 
            this.studentReceivedsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.contractDataGridViewTextBoxColumn,
            this.surNameDataGridViewTextBoxColumn,
            this.nameStudentDataGridViewTextBoxColumn,
            this.secondNameDataGridViewTextBoxColumn,
            this.nationalityDataGridViewTextBoxColumn,
            this.dateBirthDataGridViewTextBoxColumn,
            this.dateDocumentDataGridViewTextBoxColumn,
            this.socialDataGridViewTextBoxColumn,
            this.languageDataGridViewTextBoxColumn,
            this.citizenshipDataGridViewTextBoxColumn,
            this.foreignLanguageDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.militaryIDDataGridViewTextBoxColumn,
            this.houseDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.dormitoriesDataGridViewTextBoxColumn,
            this.documentsDataGridViewTextBoxColumn,
            this.schoolDataGridViewTextBoxColumn,
            this.endSchoolDataGridViewTextBoxColumn,
            this.gPADataGridViewTextBoxColumn,
            this.numberGroupDataGridViewTextBoxColumn,
            this.estimatesDataGridViewTextBoxColumn,
            this.phonePareantDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.studentReceivedsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.GridColor = System.Drawing.Color.DarkOrange;
            this.dataGridView2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dataGridView2.Location = new System.Drawing.Point(12, 12);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1156, 337);
            this.dataGridView2.TabIndex = 1;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contractDataGridViewTextBoxColumn
            // 
            this.contractDataGridViewTextBoxColumn.DataPropertyName = "Contract";
            this.contractDataGridViewTextBoxColumn.HeaderText = "Contract";
            this.contractDataGridViewTextBoxColumn.Name = "contractDataGridViewTextBoxColumn";
            this.contractDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surNameDataGridViewTextBoxColumn
            // 
            this.surNameDataGridViewTextBoxColumn.DataPropertyName = "SurName";
            this.surNameDataGridViewTextBoxColumn.HeaderText = "SurName";
            this.surNameDataGridViewTextBoxColumn.Name = "surNameDataGridViewTextBoxColumn";
            this.surNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameStudentDataGridViewTextBoxColumn
            // 
            this.nameStudentDataGridViewTextBoxColumn.DataPropertyName = "NameStudent";
            this.nameStudentDataGridViewTextBoxColumn.HeaderText = "NameStudent";
            this.nameStudentDataGridViewTextBoxColumn.Name = "nameStudentDataGridViewTextBoxColumn";
            this.nameStudentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // secondNameDataGridViewTextBoxColumn
            // 
            this.secondNameDataGridViewTextBoxColumn.DataPropertyName = "SecondName";
            this.secondNameDataGridViewTextBoxColumn.HeaderText = "SecondName";
            this.secondNameDataGridViewTextBoxColumn.Name = "secondNameDataGridViewTextBoxColumn";
            this.secondNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nationalityDataGridViewTextBoxColumn
            // 
            this.nationalityDataGridViewTextBoxColumn.DataPropertyName = "Nationality";
            this.nationalityDataGridViewTextBoxColumn.HeaderText = "Nationality";
            this.nationalityDataGridViewTextBoxColumn.Name = "nationalityDataGridViewTextBoxColumn";
            this.nationalityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateBirthDataGridViewTextBoxColumn
            // 
            this.dateBirthDataGridViewTextBoxColumn.DataPropertyName = "DateBirth";
            this.dateBirthDataGridViewTextBoxColumn.HeaderText = "DateBirth";
            this.dateBirthDataGridViewTextBoxColumn.Name = "dateBirthDataGridViewTextBoxColumn";
            this.dateBirthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDocumentDataGridViewTextBoxColumn
            // 
            this.dateDocumentDataGridViewTextBoxColumn.DataPropertyName = "DateDocument";
            this.dateDocumentDataGridViewTextBoxColumn.HeaderText = "DateDocument";
            this.dateDocumentDataGridViewTextBoxColumn.Name = "dateDocumentDataGridViewTextBoxColumn";
            this.dateDocumentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // socialDataGridViewTextBoxColumn
            // 
            this.socialDataGridViewTextBoxColumn.DataPropertyName = "Social";
            this.socialDataGridViewTextBoxColumn.HeaderText = "Social";
            this.socialDataGridViewTextBoxColumn.Name = "socialDataGridViewTextBoxColumn";
            this.socialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // languageDataGridViewTextBoxColumn
            // 
            this.languageDataGridViewTextBoxColumn.DataPropertyName = "Language";
            this.languageDataGridViewTextBoxColumn.HeaderText = "Language";
            this.languageDataGridViewTextBoxColumn.Name = "languageDataGridViewTextBoxColumn";
            this.languageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // citizenshipDataGridViewTextBoxColumn
            // 
            this.citizenshipDataGridViewTextBoxColumn.DataPropertyName = "Citizenship";
            this.citizenshipDataGridViewTextBoxColumn.HeaderText = "Citizenship";
            this.citizenshipDataGridViewTextBoxColumn.Name = "citizenshipDataGridViewTextBoxColumn";
            this.citizenshipDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // foreignLanguageDataGridViewTextBoxColumn
            // 
            this.foreignLanguageDataGridViewTextBoxColumn.DataPropertyName = "ForeignLanguage";
            this.foreignLanguageDataGridViewTextBoxColumn.HeaderText = "ForeignLanguage";
            this.foreignLanguageDataGridViewTextBoxColumn.Name = "foreignLanguageDataGridViewTextBoxColumn";
            this.foreignLanguageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // militaryIDDataGridViewTextBoxColumn
            // 
            this.militaryIDDataGridViewTextBoxColumn.DataPropertyName = "MilitaryID";
            this.militaryIDDataGridViewTextBoxColumn.HeaderText = "MilitaryID";
            this.militaryIDDataGridViewTextBoxColumn.Name = "militaryIDDataGridViewTextBoxColumn";
            this.militaryIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // houseDataGridViewTextBoxColumn
            // 
            this.houseDataGridViewTextBoxColumn.DataPropertyName = "House";
            this.houseDataGridViewTextBoxColumn.HeaderText = "House";
            this.houseDataGridViewTextBoxColumn.Name = "houseDataGridViewTextBoxColumn";
            this.houseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dormitoriesDataGridViewTextBoxColumn
            // 
            this.dormitoriesDataGridViewTextBoxColumn.DataPropertyName = "Dormitories";
            this.dormitoriesDataGridViewTextBoxColumn.HeaderText = "Dormitories";
            this.dormitoriesDataGridViewTextBoxColumn.Name = "dormitoriesDataGridViewTextBoxColumn";
            this.dormitoriesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // documentsDataGridViewTextBoxColumn
            // 
            this.documentsDataGridViewTextBoxColumn.DataPropertyName = "Documents";
            this.documentsDataGridViewTextBoxColumn.HeaderText = "Documents";
            this.documentsDataGridViewTextBoxColumn.Name = "documentsDataGridViewTextBoxColumn";
            this.documentsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // schoolDataGridViewTextBoxColumn
            // 
            this.schoolDataGridViewTextBoxColumn.DataPropertyName = "School";
            this.schoolDataGridViewTextBoxColumn.HeaderText = "School";
            this.schoolDataGridViewTextBoxColumn.Name = "schoolDataGridViewTextBoxColumn";
            this.schoolDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endSchoolDataGridViewTextBoxColumn
            // 
            this.endSchoolDataGridViewTextBoxColumn.DataPropertyName = "EndSchool";
            this.endSchoolDataGridViewTextBoxColumn.HeaderText = "EndSchool";
            this.endSchoolDataGridViewTextBoxColumn.Name = "endSchoolDataGridViewTextBoxColumn";
            this.endSchoolDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gPADataGridViewTextBoxColumn
            // 
            this.gPADataGridViewTextBoxColumn.DataPropertyName = "GPA";
            this.gPADataGridViewTextBoxColumn.HeaderText = "GPA";
            this.gPADataGridViewTextBoxColumn.Name = "gPADataGridViewTextBoxColumn";
            this.gPADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberGroupDataGridViewTextBoxColumn
            // 
            this.numberGroupDataGridViewTextBoxColumn.DataPropertyName = "NumberGroup";
            this.numberGroupDataGridViewTextBoxColumn.HeaderText = "NumberGroup";
            this.numberGroupDataGridViewTextBoxColumn.Name = "numberGroupDataGridViewTextBoxColumn";
            this.numberGroupDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estimatesDataGridViewTextBoxColumn
            // 
            this.estimatesDataGridViewTextBoxColumn.DataPropertyName = "Estimates";
            this.estimatesDataGridViewTextBoxColumn.HeaderText = "Estimates";
            this.estimatesDataGridViewTextBoxColumn.Name = "estimatesDataGridViewTextBoxColumn";
            this.estimatesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phonePareantDataGridViewTextBoxColumn
            // 
            this.phonePareantDataGridViewTextBoxColumn.DataPropertyName = "PhonePareant";
            this.phonePareantDataGridViewTextBoxColumn.HeaderText = "PhonePareant";
            this.phonePareantDataGridViewTextBoxColumn.Name = "phonePareantDataGridViewTextBoxColumn";
            this.phonePareantDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Update_Table
            // 
            this.Update_Table.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Update_Table.BackColor = System.Drawing.Color.White;
            this.Update_Table.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Update_Table.FlatAppearance.BorderSize = 0;
            this.Update_Table.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.Update_Table.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.Update_Table.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update_Table.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Update_Table.Image = global::Diplom.Properties.Resources.Books;
            this.Update_Table.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Update_Table.Location = new System.Drawing.Point(895, 456);
            this.Update_Table.Name = "Update_Table";
            this.Update_Table.Size = new System.Drawing.Size(290, 32);
            this.Update_Table.TabIndex = 8;
            this.Update_Table.Text = "Автоматическое заполнение";
            this.Update_Table.UseVisualStyleBackColor = false;
            this.Update_Table.Click += new System.EventHandler(this.Update_Table_Click);
            // 
            // DeleteStudent
            // 
            this.DeleteStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteStudent.BackColor = System.Drawing.Color.White;
            this.DeleteStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteStudent.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.DeleteStudent.FlatAppearance.BorderSize = 0;
            this.DeleteStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.DeleteStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.DeleteStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteStudent.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteStudent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DeleteStudent.Image = global::Diplom.Properties.Resources.Delete;
            this.DeleteStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteStudent.Location = new System.Drawing.Point(12, 456);
            this.DeleteStudent.Name = "DeleteStudent";
            this.DeleteStudent.Size = new System.Drawing.Size(241, 32);
            this.DeleteStudent.TabIndex = 9;
            this.DeleteStudent.Text = "Удалить студента";
            this.DeleteStudent.UseVisualStyleBackColor = false;
            this.DeleteStudent.Click += new System.EventHandler(this.DeleteStudent_Click);
            // 
            // Edit_Student
            // 
            this.Edit_Student.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Edit_Student.BackColor = System.Drawing.Color.White;
            this.Edit_Student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Edit_Student.FlatAppearance.BorderSize = 0;
            this.Edit_Student.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.Edit_Student.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.Edit_Student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_Student.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Edit_Student.Image = global::Diplom.Properties.Resources.cog;
            this.Edit_Student.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Edit_Student.Location = new System.Drawing.Point(298, 456);
            this.Edit_Student.Name = "Edit_Student";
            this.Edit_Student.Size = new System.Drawing.Size(262, 32);
            this.Edit_Student.TabIndex = 10;
            this.Edit_Student.Text = "Редактировать студента";
            this.Edit_Student.UseVisualStyleBackColor = false;
            // 
            // AddStudent
            // 
            this.AddStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddStudent.BackColor = System.Drawing.Color.White;
            this.AddStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddStudent.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddStudent.FlatAppearance.BorderSize = 0;
            this.AddStudent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.AddStudent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange;
            this.AddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddStudent.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddStudent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddStudent.Image = global::Diplom.Properties.Resources.Add;
            this.AddStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddStudent.Location = new System.Drawing.Point(618, 456);
            this.AddStudent.Name = "AddStudent";
            this.AddStudent.Size = new System.Drawing.Size(241, 32);
            this.AddStudent.TabIndex = 11;
            this.AddStudent.Text = "Добавить студента";
            this.AddStudent.UseVisualStyleBackColor = false;
            // 
            // Recived
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Diplom.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1197, 528);
            this.Controls.Add(this.AddStudent);
            this.Controls.Add(this.Edit_Student);
            this.Controls.Add(this.DeleteStudent);
            this.Controls.Add(this.Update_Table);
            this.Controls.Add(this.dataGridView2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Recived";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поступившие студенты";
            this.Load += new System.EventHandler(this.Recived_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Students_mdfDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentReceivedsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private _Students_mdfDataSet1 _Students_mdfDataSet1;
        private System.Windows.Forms.BindingSource studentReceivedsBindingSource;
        private _Students_mdfDataSet1TableAdapters.StudentReceivedsTableAdapter studentReceivedsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameStudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationalityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDocumentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn socialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn languageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn citizenshipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foreignLanguageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn militaryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dormitoriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endSchoolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gPADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estimatesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonePareantDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Update_Table;
        private System.Windows.Forms.Button DeleteStudent;
        private System.Windows.Forms.Button Edit_Student;
        private System.Windows.Forms.Button AddStudent;
    }
}