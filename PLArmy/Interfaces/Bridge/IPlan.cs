using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLArmy.Interfaces.Bridge
{
    /// <summary>
    /// План атаки при войне
    /// Implementor: определяет базовый интерфейс для конкретных реализаций.
    /// </summary>
    interface IPlan
    {
        /// <summary>
        /// Атаковать
        /// </summary>
        void Attack();
        /// <summary>
        /// Отступать
        /// </summary>
        void Retreat();
        /// <summary>
        /// Занять позицию
        /// </summary>
        void TakePosition();
    }
}
