using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Diplom
{
    public class Computing
    {
        public static Computing Instance = new Computing();
        /// <summary>
        /// Добавления студента в базу данных.
        /// </summary>
        /// <param name="student">Модель студента.</param>
        public void AddStudent(Student student)
        {
            using (DataContext db = new DataContext())
            {
                db.Students.Add(student);
                db.SaveChanges();
            }
        }
        /// <summary>
        /// Вычисления среднего балла.
        /// </summary>
        /// <param name="listGPA">Коллекция оценок.</param>
        /// <returns></returns>
        public double GetGPA(List<int> listGPA)
        {
            double Count = listGPA.Count;
            double Sum = 0;
            for (int i = 0; i < listGPA.Count; i++)
            {
                Sum = listGPA[i] + Sum;
            }

            double gpa = Sum / Count;
            return Math.Round(gpa, 2);
        }

        /// <summary>
        /// Создает новый вордовский документ и заполняет его данными
        /// </summary>
        /// <param name="filename">Шаблон на основе, которого создается новый документ.</param>
        /// <param name="filenameSave">Путь сохранения нового документа.</param>
        /// <returns>Сообщение о результате.</returns>
        public string CreateDocx(string filename, string filenameSave)
        {
            using (var db = new DataContext())
            {
                var wordapp = new Word.Application();
                wordapp.Visible = false;
                var worddocument = wordapp.Documents.Open(filename);
                Word.Table table = worddocument.Tables[1];
                int i = 1;
                try
                { 
                  foreach(var student in db.Students)
                    {
                        i++;
                       //Добавление строки с закладками для данных
                        table.Rows.Add();
                        table.Cell(i, 1).Range.Text = "{id}";
                        table.Cell(i, 2).Range.Text = "{name}";
                        table.Cell(i, 3).Range.Text = "{DateDocument}";
                        table.Cell(i, 4).Range.Text = "{DateBirth}";
                        table.Cell(i, 5).Range.Text = "{Language}";
                        table.Cell(i, 6).Range.Text = "{ForeignLanguage}";
                        table.Cell(i, 7).Range.Text = "{School} {EndSchool}";
                        table.Cell(i, 8).Range.Text = "{GPA}";
                        table.Cell(i, 9).Range.Text = "{House}";
                        table.Cell(i, 10).Range.Text = "{MilitaryID}";
                        table.Cell(i, 11).Range.Text = "{Documents}";
                        table.Cell(i, 12).Range.Text = "{Sex}";
                        table.Cell(i, 13).Range.Text = "{Dormitories}";
                        table.Cell(i, 14).Range.Text = "{Phone}";
                        table.Cell(i, 15).Range.Text = "{Citizenship}";
                        table.Cell(i, 16).Range.Text = "{Social}";
                        table.Cell(i, 17).Range.Text = "{Nationality}";
                        // Замена закладок на данные из БД
                        ReplaceWordSub("{id}", student.ID.ToString(), worddocument);
                        ReplaceWordSub("{name}", student.SurName + " "+student.NameStudent+" "+student.SecondName, worddocument);
                        ReplaceWordSub("{DateDocument}", student.DateDocument.ToLongDateString().ToString(), worddocument);
                        ReplaceWordSub("{DateBirth}", student.DateBirth.ToLongDateString().ToString(), worddocument);
                        ReplaceWordSub("{Language}", student.Language, worddocument);
                        ReplaceWordSub("{ForeignLanguage}", student.ForeignLanguage, worddocument);
                        ReplaceWordSub("{School}", student.School+" ", worddocument);
                        ReplaceWordSub("{EndSchool}", student.EndSchool.ToLongDateString().ToString(), worddocument);
                        ReplaceWordSub("{GPA}", student.GPA.ToString(), worddocument);
                        ReplaceWordSub("{House}", student.House, worddocument);
                        ReplaceWordSub("{MilitaryID}", student.MilitaryID, worddocument);
                        ReplaceWordSub("{Documents}", student.Documents, worddocument);
                        ReplaceWordSub("{Sex}", student.Sex, worddocument);
                        ReplaceWordSub("{Dormitories}", student.Dormitories, worddocument);
                        ReplaceWordSub("{Phone}", student.Phone, worddocument);
                        ReplaceWordSub("{Citizenship}", student.Citizenship , worddocument);
                        ReplaceWordSub("{Social}", student.Social, worddocument);
                        ReplaceWordSub("{Nationality}", student.Nationality, worddocument);
                    }
                    worddocument.SaveAs(filenameSave);
                    worddocument.Close();
                    return "Файл успешно сохранен ";
                }
                catch (Exception ex)
                {
                    return ex.ToString();
                }
            }
        }
        private void ReplaceWordSub(string stubToReplace, string text, Word.Document WordDocument)
        {
            var range = WordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
        }
    }
}



