using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom
{
    public class Student
    {
        /// <summary>
        /// Индификатор абитуриента
        /// </summary>
        /// <value>
        /// ID
        /// </value>
        public int ID { get; set; }
        /// <summary>
        /// Фамилия абитуриента.
        /// </summary>
        /// <value>
        /// Фамилия.
        /// </value>
        public string SurName { get; set; }
        /// <summary>
        /// Имя абитуриента.
        /// </summary>
        /// <value>
        /// Имя.
        /// </value>
        public string NameStudent { get; set;}
        /// <summary>
        /// Отчество абитуриента.
        /// </summary>
        /// <value>
        /// Отчество .
        /// </value>
        public string SecondName { get; set; }
        /// <summary>
        /// Нациаональность абитуриента.
        /// </summary>
        /// <value>
        /// Национальность.
        /// </value>
        public string Nationality { get; set; }
        /// <summary>
        /// Дата рождения абитуриента.
        /// </summary>
        /// <value>
        /// Дата рождения.
        /// </value>
        public DateTime DateBirth { get; set; }
        /// <summary>
        /// Дата приема документов абитуриента.
        /// </summary>
        /// <value>
        /// Дата приема документов.
        /// </value>
        public DateTime DateDocument { get; set; }
        /// <summary>
        /// Социальное положение абитуриента.
        /// </summary>
        /// <value>
        /// Социальное положение.
        /// </value>
        public string Social { get; set; }
        /// <summary>
        /// Язык обучения абитуриента.
        /// </summary>
        /// <value>
        /// Язык обучения.
        /// </value>
        public string Language { get; set; }
        /// <summary>
        /// Гражданство абитуриента.
        /// </summary>
        /// <value>
        /// Гражданство.
        /// </value>
        public string Citizenship { get; set; }
        /// <summary>
        /// Иностранный язык абитуриента.
        /// </summary>
        /// <value>
        /// Иностранный язык.
        /// </value>
        public string ForeignLanguage { get; set; }
        /// <summary>
        /// Телефон для связи с абитуриентом.
        /// </summary>
        /// <value>
        /// Телефон.
        /// </value>
        public string Phone { get; set; }
        /// <summary>
        /// Номер военого билета абитуриента.
        /// </summary>
        /// <value>
        /// Номер военого билета.
        /// </value>
        public string MilitaryID { get; set; }
        /// <summary>
        /// Место жительство абитуриента.
        /// </summary>
        /// <value>
        /// Место жительство.
        /// </value>
        public string House { get; set; }
        /// <summary>
        /// Пол абитуриента.
        /// </summary>
        /// <value>
        /// Пол.
        /// </value>
        public string Sex { get; set; }
        /// <summary>
        /// Хочет ли абитуриент проживать в общежития .
        /// </summary>
        /// <value>
        /// Общежития.
        /// </value>
        public string Dormitories { get; set; }
        /// <summary>
        /// Перечень документов абитуриента.
        /// </summary>
        /// <value>
        /// Перечень документов.
        /// </value>
        public string Documents { get; set; }
        /// <summary>
        /// Ниминование школы и её место нахождения абитуриента.
        /// </summary>
        /// <value>
        /// Ниминование школы и её место нахождения
        /// </value>
        public string School { get; set; }
        /// <summary>
        /// Дата окончание школы абитуриента.
        /// </summary>
        /// <value>
        ///  Дата окончание школы.
        /// </value>
        public DateTime EndSchool { get; set; }
        /// <summary>
        /// Средний балл абитуриента.
        /// </summary>
        /// <value>
        /// Средний балл.
        /// </value>
        public double GPA { get; set; }
        /// <summary>
        /// Номер группы
        /// </summary>
        public string NumberGroup { get; set; }
        /// <summary>
        /// Оценки абитуриента
        /// </summary>
        /// <value>
        /// Оценки
        /// </value>
        public string Estimates { get; set; }
        /// <summary>
        ///Телефон родителей
        /// </summary>
        /// <value>
        /// Родительский телефон
        /// </value>
        public string PhonePareant { get; set; }
      
    }
}
