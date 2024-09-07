using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Класс для генерации уникальных идентификаторов.
    /// </summary>
    internal static class IdGenerator
    {
        /// <summary>
        /// Поле, содержащее текущее значение идентификатора.
        /// </summary>
        static int _id;

        /// <summary>
        /// Свойство для получения и установки текущего значения идентификатора.
        /// </summary>
        static int Id
        {
            get
            { 
                return _id; 
            }
            set { 
                _id = value; 
            }
        }

        /// <summary>
        /// Возвращает следующий уникальный идентификатор.
        /// Увеличивает значение текущего идентификатора на 1.
        /// </summary>
        /// <returns>Следующий идентификатор.</returns>
        public static int GetNextId()
        {
            return Id++;
        }
    }
}
