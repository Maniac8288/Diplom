using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.DataModel
{
    /// <summary>
    /// Группы
    /// </summary>
    public class Group
    {
        /// <summary>
        /// Индификация через Енум.
        /// </summary>
        /// <value>
        /// Индифкационый номер.
        /// </value>
       
        public int Id { get; set; }
        /// <summary>
        /// Код специальности
        /// </summary>
        /// <value>
        /// Код
        /// </value>
        public string key { get; set; }
        /// <summary>
        /// Название групы
        /// </summary>
        /// <value>
        /// Название
        /// </value>
        public string Name { get; set; }
        /// <summary>
        /// Количество бюджетных мест
        /// </summary>
        /// <value>
        ///  Количество бюджетных мест
        /// </value>
        public int CountBudget { get; set; }
        /// <summary>
        /// Количество мест в группе
        /// </summary>
        /// <value>
        /// Количество мест в группе
        /// </value>
        public int CountSeats { get; set; }
        /// <summary>
        /// Квота для иностранцев
        /// </summary>
        /// <value>
        /// Квота
        /// </value>
        public int Quota { get; set; }
    }
 
}
