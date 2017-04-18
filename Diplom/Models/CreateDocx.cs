using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;

namespace Diplom.Models
{
   public class CreateDocx
    {
        public static CreateDocx Instance = new CreateDocx();
        /// <summary>
        /// Создает новый вордовский документ с полной информацей о абитуриенте и заполняет его данными
        /// </summary>
        /// <param name="filename">Шаблон на основе, которого создается новый документ.</param>
        /// <param name="filenameSave">Путь сохранения нового документа.</param>
        /// <returns>Сообщение о результате.</returns>
        public string CreateDox(string group, string filename, string filenameSave)
        {

            var wordapp = new Word.Application();
            wordapp.Visible = false;
            var worddocument = wordapp.Documents.Open(filename);
            Word.Table table = worddocument.Tables[1];
            int i = 1;
            try
            {

                using (var db = new DataContext())
                {
                    if (group != "Все")
                    {
                        var Students = db.Students.Where(x => x.NumberGroup == group);

                        foreach (var student in Students)
                        {
                            i++;
                            //Добавление данных
                            table.Rows.Add();
                            table.Cell(i, 1).Range.Text = student.ID.ToString();
                            table.Cell(i, 2).Range.Text = student.SurName + " " + student.NameStudent + " " + student.SecondName;
                            table.Cell(i, 3).Range.Text = student.DateDocument.ToLongDateString().ToString();
                            table.Cell(i, 4).Range.Text = student.DateBirth.ToLongDateString().ToString();
                            table.Cell(i, 5).Range.Text = student.Language;
                            table.Cell(i, 6).Range.Text = student.ForeignLanguage;
                            table.Cell(i, 7).Range.Text = student.School + " " + student.EndSchool.ToLongDateString().ToString();
                            table.Cell(i, 8).Range.Text = student.GPA.ToString();
                            table.Cell(i, 9).Range.Text = student.House + " " + student.PhonePareant;
                            table.Cell(i, 10).Range.Text = student.MilitaryID;
                            table.Cell(i, 11).Range.Text = student.Documents;
                            table.Cell(i, 12).Range.Text = student.Sex;
                            table.Cell(i, 13).Range.Text = student.Dormitories;
                            table.Cell(i, 14).Range.Text = student.Phone;
                            table.Cell(i, 15).Range.Text = student.Citizenship;
                            table.Cell(i, 16).Range.Text = student.Social;
                            table.Cell(i, 17).Range.Text = student.Nationality;
                            table.Cell(i, 18).Range.Text = student.NumberGroup;
                        }
                        ReplaceWordSub("{Nubmer}", "Группа №" + group, worddocument);
                        worddocument.SaveAs(filenameSave);
                        worddocument.Close();
                        return "Файл успешно сохранен ";
                    }

                    else
                    {
                        var Students = db.Students;

                        foreach (var student in Students)
                        {
                            i++;
                            //Добавление данных
                            table.Rows.Add();
                            table.Cell(i, 1).Range.Text = student.ID.ToString();
                            table.Cell(i, 2).Range.Text = student.SurName + " " + student.NameStudent + " " + student.SecondName;
                            table.Cell(i, 3).Range.Text = student.DateDocument.ToLongDateString().ToString();
                            table.Cell(i, 4).Range.Text = student.DateBirth.ToLongDateString().ToString();
                            table.Cell(i, 5).Range.Text = student.Language;
                            table.Cell(i, 6).Range.Text = student.ForeignLanguage;
                            table.Cell(i, 7).Range.Text = student.School + " " + student.EndSchool.ToLongDateString().ToString();
                            table.Cell(i, 8).Range.Text = student.GPA.ToString();
                            table.Cell(i, 9).Range.Text = student.House + " " + student.PhonePareant;
                            table.Cell(i, 10).Range.Text = student.MilitaryID;
                            table.Cell(i, 11).Range.Text = student.Documents;
                            table.Cell(i, 12).Range.Text = student.Sex;
                            table.Cell(i, 13).Range.Text = student.Dormitories;
                            table.Cell(i, 14).Range.Text = student.Phone;
                            table.Cell(i, 15).Range.Text = student.Citizenship;
                            table.Cell(i, 16).Range.Text = student.Social;
                            table.Cell(i, 17).Range.Text = student.Nationality;
                            table.Cell(i, 18).Range.Text = student.NumberGroup;
                        }
                        ReplaceWordSub("{Nubmer}", "Все абитуриенты", worddocument);
                        worddocument.SaveAs(filenameSave);
                        worddocument.Close();
                        return "Файл успешно сохранен ";
                    }
                }
            }
            catch (Exception ex)
            {
                try
                {
                    worddocument.Close();
                }
                catch
                {

                }
                return ex.ToString();
            }

        }
        /// <summary>
        /// Создает новый вордовский документ с  информацей о группе и заполняет его данными
        /// </summary>
        /// <param name="filename">Шаблон на основе, которого создается новый документ.</param>
        /// <param name="filenameSave">Путь сохранения нового документа.</param>
        /// <returns>Сообщение о результате.</returns>
        public string CreateSpisok(string group, string filename, string filenameSave)
        {

            var wordapp = new Word.Application();
            wordapp.Visible = false;
            var worddocument = wordapp.Documents.Open(filename);
            Word.Table table = worddocument.Tables[1];
            int i = 1;
            try
            {

                using (var db = new DataContext())
                {
                    //if (group != "Все")
                    //{
                        var Students = db.SdudentsRecevieds.Where(x => x.NumberGroup == group);

                        foreach (var student in Students)
                        {
                            i++;
                            //Добавление данных
                            table.Rows.Add();
                            table.Cell(i, 1).Range.Text = i.ToString();
                            table.Cell(i, 2).Range.Text = student.SurName + " " + student.NameStudent + " " + student.SecondName;
                            table.Cell(i, 3).Range.Text = student.Contract;
                            table.Cell(i, 4).Range.Text = student.ID.ToString();
                            table.Cell(i, 5).Range.Text = student.DateBirth.ToLongDateString().ToString();
                            table.Cell(i, 6).Range.Text = student.Social;
                        }
                    var Id = Convert.ToInt32(group);
                        var Groups = db.Groups.FirstOrDefault(x => x.Id == Id);
                        if (Groups.Teacher == null) { Groups.Teacher = ""; }
                        int CountBudget = Students.Where(x => x.Contract == "Бюджет").ToList().Count();
                        int CountContract = Students.Where(x => x.Contract == "Контракт").ToList().Count();
                        int CountWoman = Students.Where(x => x.Sex == "Женский").ToList().Count();
                        int CountMan = Students.Where(x => x.Contract == "Мужской").ToList().Count();
                        ReplaceWordSub("{NumberGroup}", "Группа " + group, worddocument);
                        ReplaceWordSub("{NameGroup}", "Группа " + Groups.Name, worddocument);
                        ReplaceWordSub("{Budget}", CountBudget.ToString(), worddocument);
                        ReplaceWordSub("{Contract}", CountContract.ToString(), worddocument);
                        ReplaceWordSub("{W}", CountWoman.ToString(), worddocument);
                        ReplaceWordSub("{M}", CountMan.ToString(), worddocument);
                        ReplaceWordSub("{NameTeacher}", Groups.Teacher, worddocument);
                        worddocument.SaveAs(filenameSave);
                        worddocument.Close();
                        return "Файл успешно сохранен ";
                  

                    //else
                    //{
                    //    var Students = db.Students;

                    //    foreach (var student in Students)
                    //    {
                    //        i++;
                    //        //Добавление данных
                    //        table.Rows.Add();
                    //        table.Cell(i, 1).Range.Text = student.ID.ToString();
                    //        table.Cell(i, 2).Range.Text = student.SurName + " " + student.NameStudent + " " + student.SecondName;
                    //        table.Cell(i, 3).Range.Text = student.DateDocument.ToLongDateString().ToString();
                    //        table.Cell(i, 4).Range.Text = student.DateBirth.ToLongDateString().ToString();
                    //        table.Cell(i, 5).Range.Text = student.Language;
                    //        table.Cell(i, 6).Range.Text = student.ForeignLanguage;
                    //        table.Cell(i, 7).Range.Text = student.School + " " + student.EndSchool.ToLongDateString().ToString();
                    //        table.Cell(i, 8).Range.Text = student.GPA.ToString();
                    //        table.Cell(i, 9).Range.Text = student.House + " " + student.PhonePareant;
                    //        table.Cell(i, 10).Range.Text = student.MilitaryID;
                    //        table.Cell(i, 11).Range.Text = student.Documents;
                    //        table.Cell(i, 12).Range.Text = student.Sex;
                    //        table.Cell(i, 13).Range.Text = student.Dormitories;
                    //        table.Cell(i, 14).Range.Text = student.Phone;
                    //        table.Cell(i, 15).Range.Text = student.Citizenship;
                    //        table.Cell(i, 16).Range.Text = student.Social;
                    //        table.Cell(i, 17).Range.Text = student.Nationality;
                    //        table.Cell(i, 18).Range.Text = student.NumberGroup;
                    //    }
                    //    ReplaceWordSub("{Nubmer}", "Все абитуриенты", worddocument);
                    //    worddocument.SaveAs(filenameSave);
                    //    worddocument.Close();
                    //    return "Файл успешно сохранен ";
                    //}
                }
            }
            catch (Exception ex)
            {
                try
                {
                    worddocument.Close();
                }
                catch
                {

                }
                return ex.ToString();
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
