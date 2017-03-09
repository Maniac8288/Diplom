using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom
{
  public  class Computing
    {
        public static Computing Instance = new Computing();
        /// <summary>
        /// Добавления студента в базу данных.
        /// </summary>
        /// <param name="student">Модель студента.</param>
        public  void AddStudent(Student student)
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
            for(int i = 0; i < listGPA.Count; i++)
            {
                Sum = listGPA[i] + Sum;
            }

         double gpa = Sum / Count;
            return Math.Round(gpa, 2);
        }
    }
    }

