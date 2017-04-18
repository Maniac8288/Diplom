using Diplom.Models;
using System;
using System.Windows.Forms;

namespace Diplom.View.Docs
{
    public partial class CreateDocs : Form
    {
        public CreateDocs()
        {
            InitializeComponent();
        }

        private void Create_Click(object sender, EventArgs e)
        {
          var  path = "";
            if (comboBox1.Text == "Полная информация")
            {
                 path = System.IO.Path.GetFullPath(@"Shablon.docx");
            }
            if (comboBox1.Text == "Список группы")
            {
                 path = System.IO.Path.GetFullPath(@"SpisokGroups.docx");
            }
            string group = ChouseGroup.Text.ToString();
                saveFileDialog1.Filter = "Word | *.docx";
                saveFileDialog1.DefaultExt = "docx";

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
                    string result = CreateDocx.Instance.CreateSpisok(group, path, filenameSave);
                    MessageBox.Show(result);
                }
           
            }
    }
}
