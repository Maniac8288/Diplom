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
        public List<int> ChouseGroups(string key)
        {
            using (DataContext db = new DataContext())
            {
                var group = db.Groups.FirstOrDefault(x => x.key == key);
                List<int> Seats = new List<int>();
                Seats.Add(group.CountSeats);
                Seats.Add(group.CountBudget);
                Seats.Add(group.Quota);

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
        public void EditBudgetSeats(string key, int count)
        {
            using (DataContext db = new DataContext())
            {
                var group = db.Groups.FirstOrDefault(x => x.key == key);
                group.CountBudget = count;
                db.SaveChanges();
            }
        }
        /// <summary>
        /// Изменяет квотные места
        /// </summary>
        /// <param name="key">Код группы</param>
        /// <param name="count">Новое количество</param>
        public void EditQuotaSeats(string key, int count)
        {
            using (DataContext db = new DataContext())
            {
                var group = db.Groups.FirstOrDefault(x => x.key == key);
                group.Quota = count;
                db.SaveChanges();
            }
        }
    }
}
