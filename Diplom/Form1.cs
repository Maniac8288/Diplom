using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.IO;

namespace Diplom
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        AddStudent addStudent;
        DataBase dataBase;
        Main main;
        Groups groups;

        private void button1_Click(object sender, EventArgs e)
        {
            addStudent = new AddStudent();
            addStudent.Show();

        }

     

        private void button2_Click(object sender, EventArgs e)
        {
            dataBase = new DataBase();
            dataBase.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter="Word | *.docx";
            saveFileDialog1.DefaultExt = "docx";
            openFileDialog1.Filter = "Word | *.docx";
            DialogResult Open = MessageBox.Show("Выбрать вордовский шаблон", "Открытие шаблона", 
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Asterisk,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            if (Open == DialogResult.OK)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                // получаем выбранный файл
                string filename = openFileDialog1.FileName;

                DialogResult Save = MessageBox.Show("Выбрать путь сохранения файла", "Сохранение",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Asterisk,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
                if (Save == DialogResult.OK)
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                        return;
                    // получаем выбранный файл
                    string filenameSave = saveFileDialog1.FileName;
                    string result = Computing.Instance.CreateDocx(filename, filenameSave);
                    MessageBox.Show(result);
                }
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Groups_Click(object sender, EventArgs e)
        {
            groups = new Groups();
            groups.Show();
        }
    }
   }

