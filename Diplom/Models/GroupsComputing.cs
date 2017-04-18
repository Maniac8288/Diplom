using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Models
{
   public class GroupsComputing
    {
        public static GroupsComputing Instance = new GroupsComputing();
        /// <summary>
        /// По выбранной группе находит количетсво мест
        /// </summary>
        /// <param name="key">Код группы</param>
        /// <returns></returns>
        public List<string> ChouseGroups(string key)
        {
            using (DataContext db = new DataContext())
            {
                var group = db.Groups.FirstOrDefault(x => x.key == key);
                List<string> Seats = new List<string>();
                Seats.Add(group.CountSeats.ToString());
                Seats.Add(group.CountBudget.ToString());
                Seats.Add(group.Quota.ToString());
                Seats.Add(group.Teacher);

                return Seats;
            }
        }
        /// <summary>
        /// Изменяет количетсво мест
        /// </summary>
        /// <param name="key">Код группы</param>
        /// <param name="count">Новое количество</param>
        public void EditSeats (string key,int count)
        {
            using (DataContext db = new DataContext())
            {
                var group = db.Groups.FirstOrDefault(x => x.key == key);
                group.CountSeats = count;
                db.SaveChanges();
            }
        }
        /// <summary>
        /// Изменяет бюджетных мест
        /// </summary>
        /// <param name="key">Код группы</param>
        /// <param name="count">Новое количество</param>
        public string EditBudgetSeats(string key, int count)
        {
            using (DataContext db = new DataContext())
            {
                var group = db.Groups.FirstOrDefault(x => x.key == key);
                group.CountBudget = count;
                if (group.CountSeats < group.CountBudget)
                {
                    return "";
                }
                else {
                    db.SaveChanges();
                    return "Успешно обновлено";
                }
            }
        }
        /// <summary>
        /// Изменяет квотные места
        /// </summary>
        /// <param name="key">Код группы</param>
        /// <param name="count">Новое количество</param>
        public string EditQuotaSeats(string key, int count)
        {
            using (DataContext db = new DataContext())
            {
                var group = db.Groups.FirstOrDefault(x => x.key == key);
                group.Quota = count;
                if (group.CountBudget < group.Quota)
                {
                    return "";
                }
                else
                {
                    db.SaveChanges();
                    return "Успешно обновлено";
                }
            }
        }
        /// <summary>
        /// Изменяет класного руководителя
        /// </summary>
        /// <param name="key">Код группы</param>
        /// <param name="Name">Новый учитель</param>
        public void EditTeacher(string key, string Name)
        {
            using (DataContext db = new DataContext())
            {
                    var group = db.Groups.FirstOrDefault(x => x.key == key);
                    group.Teacher = Name;
                    db.SaveChanges();
            }
        }
        #region Статистика        
        /// <summary>
        /// Подсчитывает количество мест в учебном заведение
        /// </summary>
        /// <returns></returns>
        public int CountSeatAll()
        {
            int Count = 0;
            using (DataContext db = new DataContext())
            {
                foreach(var group in db.Groups)
                {
                    Count += group.CountSeats;
                }
            }
            return Count;
        }
        /// <summary>
        /// Подсчитывает количество бюджетных мест
        /// </summary>
        /// <returns></returns>
        public int CountBudgetAll()
        {
            int Count = 0;
            using (DataContext db = new DataContext())
            {
                foreach (var group in db.Groups)
                {
                    Count += group.CountBudget;
                }
            }
            return Count;
        }
        /// <summary>
        /// Подсчитывает количество оставшихся мест
        /// </summary>
        /// <returns></returns>
        public int CountSeat()
        {
            int Count = 0;
            using (DataContext db = new DataContext())
            {
                var Groups = db.Groups.ToList();
                foreach (var group in Groups)
                {
                    var NumberGroup = group.Id;
                    var Group = db.SdudentsRecevieds.Where(x => x.NumberGroup == NumberGroup.ToString()).ToList();
                
                   
                    Count +=group.CountSeats-Group.Count() ;
                }
            }
            return Count;
        }
        /// <summary>
        /// Подсчитывает количество оставшихся бюджетных мест
        /// </summary>
        /// <returns></returns>
        public int CountBudget()
        {
            int Count = 0;
            using (DataContext db = new DataContext())
            {
                var Groups = db.Groups.ToList();
                foreach (var group in Groups)
                {
                    var NumberGroup = group.Id;
                    var Group = db.SdudentsRecevieds.Where(x => x.NumberGroup == NumberGroup.ToString()).ToList();
                    var GroupBudget = Group.Where(x => x.Contract == "Бюджет").ToList();
                    Count +=  group.CountBudget- GroupBudget.Count();
                }
            }
            return Count;
        }
        #endregion Статистика


    }
}
