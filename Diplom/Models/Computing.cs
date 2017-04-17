using Diplom.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
        public void EditStudent(Student student)
        {
            using (DataContext db= new DataContext())
            {
                Student OldStudent = db.Students.FirstOrDefault(x => x.ID == student.ID);
                OldStudent.ID = student.ID;
                OldStudent.MilitaryID = student.MilitaryID;
                OldStudent.Citizenship = student.Citizenship;
                OldStudent.School = student.School;
                OldStudent.SecondName = student.SecondName;
                OldStudent.Sex = student.Sex;
                OldStudent.Social = student.Social;
                OldStudent.SurName = student.SurName;
                OldStudent.EndSchool = student.EndSchool;
                OldStudent.NameStudent = student.NameStudent;
                OldStudent.DateBirth = student.DateBirth;
                OldStudent.DateDocument = student.DateDocument;
                OldStudent.Documents = student.Documents;
                OldStudent.Dormitories = student.Dormitories;
                OldStudent.ForeignLanguage = student.ForeignLanguage;
                OldStudent.GPA = student.GPA;
                OldStudent.House = student.House;
                OldStudent.Language = student.Language;
                OldStudent.Nationality = student.Nationality;
                OldStudent.NumberGroup = student.NumberGroup;
                OldStudent.Phone = student.Phone;
                OldStudent.PhonePareant = student.PhonePareant;
                db.SaveChanges();
            }
        }
        /// <summary>
        /// Удаление студента из базы данных
        /// </summary>
        /// <param name="Id">Ид студента.</param>
        public void DeleteStudent(int Id)
        {
            using (DataContext db= new DataContext())
            {
                var student = db.Students.FirstOrDefault(x => x.ID == Id);
                db.Students.Remove(student);
                db.SaveChanges();
            }
        }
        /// <summary>
        /// Выбрать студента из БД по ID
        /// </summary>
        /// <param name="Id">Id</param>
        /// <returns></returns>
        public Student ChouseStudent(int Id)
        {
            using (DataContext db = new DataContext())
            {
                var student = db.Students.FirstOrDefault(x => x.ID == Id);
                return student;
            }
        }
        /// <summary>
        /// Заполняет группы абитуриаентами
        /// </summary>
        public void DeleteExcess()
        {
            //Подключение к базе данных
            using (DataContext db = new DataContext())
            {   
               // Удаление всех студентов (если они есть) из поступивших
                db.SdudentsRecevieds.RemoveRange(db.SdudentsRecevieds);
                db.SaveChanges();
                for (int i = 111; i <= 114; i++)
                {
                    //Группа в которую поступает абитуриент
                    var Group = db.Groups.FirstOrDefault(x => x.Id == i);

                    // Конверт модели из базы данных в модель с поступившими студентами
                    var ModelStudentReceived = db.Students.Select(ConvertStudent());

                    // Создание массива заполнеными студентами - контрактниками 
                    var Contract = ModelStudentReceived.Where(x => x.NumberGroup == i.ToString()).ToList();

                    // Создание массива заполнеными студентами отсортироваными по Среднему балу  - Имеющие социальное положение 
                    //(Массив имеет ограничение в размере равному количеству бюджетных мест в группе)
                    var social = Contract.Where(x => x.Social != "").OrderByDescending(x => x.GPA).Take(Group.CountBudget).ToList();

                    // Удаление из массива контракников всех студентов имеющих социальное положение 
                    foreach (var sociealItem in social)
                    {
                        Contract.Remove(sociealItem);
                    }
                    // Создание массива иностранцев отсортированных по среднему балу
                    var Foreign = Contract.OrderByDescending(x => x.GPA).Where(x => x.Citizenship != "ПМР").ToList();

                    // Удаление иностранцев с массива контракников 
                    foreach (var ForeginItem in Foreign)
                    {
                        Contract.Remove(ForeginItem);
                    }
                    // Создание масива студентов из ПМР
                    var PMR = Contract.Where(x => x.Citizenship == "ПМР").ToList();

                    // Добавление в массив "ПМР" студентов иностранцев с ограничением в квотные места
                    PMR.AddRange(Foreign.Take(Group.Quota));

                    // Добавление в массив контрактников пропустив квотные места
                    Contract.AddRange(Foreign.Skip(Group.Quota));

                    // Создание массива бюджетников на основе массива ПМР отсортированых по среднему балу и имеет ограничение в Бюджетные места - Массив с социальными положениями
                    var Budget = PMR.OrderByDescending(x => x.GPA).Take(Group.CountBudget - social.Count()).ToList();

                    // Удаление из массива контракников всех бюджетников         
                    foreach(var BudgetItem in Budget)
                    {
                        Contract.Remove(BudgetItem);
                    }
                    // Создание массива контракников отсортированных по среднему баллу с ограничеем "Всего мест-Бюджетные места"
                    var newGroupContract = Contract.OrderByDescending(x => x.GPA).Take(Group.CountSeats - Group.CountBudget).ToList();

                    // Добавление студентов в базу данных имеющие социальное положение 
                    foreach (var student in social)
                    {
                        var studentReceived = new StudentReceived()
                        {
                            ID = student.ID,
                            MilitaryID = student.MilitaryID,
                            Citizenship = student.Citizenship,
                            School = student.School,
                            SecondName = student.SecondName,
                            Sex = student.Sex,
                            Social = student.Social,
                            SurName = student.SurName,
                            EndSchool = student.EndSchool,
                            NameStudent = student.NameStudent,
                            DateBirth = student.DateBirth,
                            DateDocument = student.DateDocument,
                            Documents = student.Documents,
                            Dormitories = student.Dormitories,
                            ForeignLanguage = student.ForeignLanguage,
                            GPA = student.GPA,
                            House = student.House,
                            Language = student.Language,
                            Nationality = student.Nationality,
                            NumberGroup = student.NumberGroup,
                            Phone = student.Phone,
                            Contract = "Бюджет",
                            PhonePareant = student.PhonePareant,
                            Estimates = student.Estimates

                        };
                        db.SdudentsRecevieds.Add(studentReceived);
                        db.SaveChanges();
                    }
                    // Добавление студентов в базу даных бюджетников 
                    foreach (var student in Budget)
                    {
                        var studentReceived = new StudentReceived()
                        {
                            ID = student.ID,
                            MilitaryID = student.MilitaryID,
                            Citizenship = student.Citizenship,
                            School = student.School,
                            SecondName = student.SecondName,
                            Sex = student.Sex,
                            Social = student.Social,
                            SurName = student.SurName,
                            EndSchool = student.EndSchool,
                            NameStudent = student.NameStudent,
                            DateBirth = student.DateBirth,
                            DateDocument = student.DateDocument,
                            Documents = student.Documents,
                            Dormitories = student.Dormitories,
                            ForeignLanguage = student.ForeignLanguage,
                            GPA = student.GPA,
                            House = student.House,
                            Language = student.Language,
                            Nationality = student.Nationality,
                            NumberGroup = student.NumberGroup,
                            Phone = student.Phone,
                            Contract = "Бюджет",
                            PhonePareant = student.PhonePareant,
                            Estimates = student.Estimates

                        };
                        db.SdudentsRecevieds.Add(studentReceived);
                        db.SaveChanges();

                    }
                    // Добавление в базу даных контракников
                    foreach (var student in newGroupContract)
                    {
                        var studentReceived = new StudentReceived()
                        {
                            ID = student.ID,
                            MilitaryID = student.MilitaryID,
                            Citizenship = student.Citizenship,
                            School = student.School,
                            SecondName = student.SecondName,
                            Sex = student.Sex,
                            Social = student.Social,
                            SurName = student.SurName,
                            EndSchool = student.EndSchool,
                            NameStudent = student.NameStudent,
                            DateBirth = student.DateBirth,
                            DateDocument = student.DateDocument,
                            Documents = student.Documents,
                            Dormitories = student.Dormitories,
                            ForeignLanguage = student.ForeignLanguage,
                            GPA = student.GPA,
                            House = student.House,
                            Language = student.Language,
                            Nationality = student.Nationality,
                            NumberGroup = student.NumberGroup,
                            Phone = student.Phone,
                            Contract = "Контракт",
                            PhonePareant = student.PhonePareant,
                            Estimates = student.Estimates
                        };
                        db.SdudentsRecevieds.Add(studentReceived);
                        db.SaveChanges();
                    }

                }
            }
        }
            
        public static Expression<Func<Student, ModelStudentReceived>> ConvertStudent()
        {
            return student => new ModelStudentReceived()
            {
                ID =student.ID,
                MilitaryID=student.MilitaryID,
                Citizenship=student.Citizenship,
                School=student.School,
                SecondName=student.SecondName,
                Sex=student.Sex,
                Social=student.Social,
                SurName=student.SurName,
                EndSchool=student.EndSchool,
                NameStudent=student.NameStudent,
                DateBirth=student.DateBirth,
                DateDocument=student.DateDocument,
                Documents=student.Documents,
                Dormitories=student.Dormitories,
                ForeignLanguage=student.ForeignLanguage,
                GPA=student.GPA,
                House=student.House,
                Language=student.Language,
                Nationality=student.Nationality,
                NumberGroup=student.NumberGroup,
                Phone=student.Phone,
                PhonePareant =student.PhonePareant,
                Estimates =student.Estimates
            };
        }
        public static Expression<Func<ModelStudentReceived, StudentReceived>> ConvertStudentReviced()
        {
            return student => new StudentReceived()
            {
                ID = student.ID,
                MilitaryID = student.MilitaryID,
                Citizenship = student.Citizenship,
                School = student.School,
                SecondName = student.SecondName,
                Sex = student.Sex,
                Social = student.Social,
                SurName = student.SurName,
                EndSchool = student.EndSchool,
                NameStudent = student.NameStudent,
                DateBirth = student.DateBirth,
                DateDocument = student.DateDocument,
                Documents = student.Documents,
                Dormitories = student.Dormitories,
                ForeignLanguage = student.ForeignLanguage,
                GPA = student.GPA,
                House = student.House,
                Language = student.Language,
                Nationality = student.Nationality,
                NumberGroup = student.NumberGroup,
                Phone = student.Phone,
                PhonePareant=student.PhonePareant,
                Estimates = student.Estimates
            };
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
                        table.Cell(i, 9).Range.Text = "{House} {PhonePareant}";
                        table.Cell(i, 10).Range.Text = "{MilitaryID}";
                        table.Cell(i, 11).Range.Text = "{Documents}";
                        table.Cell(i, 12).Range.Text = "{Sex}";
                        table.Cell(i, 13).Range.Text = "{Dormitories}";
                        table.Cell(i, 14).Range.Text = "{Phone}";
                        table.Cell(i, 15).Range.Text = "{Citizenship}";
                        table.Cell(i, 16).Range.Text = "{Social}";
                        table.Cell(i, 17).Range.Text = "{Nationality}";
                        table.Cell(i, 18).Range.Text = "{NumberGroup}";
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
                        ReplaceWordSub("{PhonePareant}", student.PhonePareant, worddocument);
                        ReplaceWordSub("{MilitaryID}", student.MilitaryID, worddocument);
                        ReplaceWordSub("{Documents}", student.Documents, worddocument);
                        ReplaceWordSub("{Sex}", student.Sex, worddocument);
                        ReplaceWordSub("{Dormitories}", student.Dormitories, worddocument);
                        ReplaceWordSub("{Phone}", student.Phone, worddocument);
                        ReplaceWordSub("{Citizenship}", student.Citizenship , worddocument);
                        ReplaceWordSub("{Social}", student.Social, worddocument);
                        ReplaceWordSub("{Nationality}", student.Nationality, worddocument);
                        ReplaceWordSub("{NumberGroup}", student.NumberGroup, worddocument);
                    }
                    worddocument.SaveAs(filenameSave);
                    worddocument.Close();
                    return "Файл успешно сохранен ";
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
        }
        private void ReplaceWordSub(string stubToReplace, string text, Word.Document WordDocument)
        {
            var range = WordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
        }
       
    }
}



