using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLArmy.Enums
{
    /// <summary>
    /// Звание
    /// </summary>
    enum ERank : uint
    {
        /// <summary>
        /// Солдат
        /// </summary>
        Soldier = 1,
        /// <summary>
        /// Сержант
        /// </summary>
        Sergeant,
        /// <summary>
        /// Летенант
        /// </summary>
        Lieutenant,
        /// <summary>
        /// Капитан
        /// </summary>
        Captain,
        /// <summary>
        /// Майор
        /// </summary>
        Major,
        /// <summary>
        /// Полковник
        /// </summary>
        Colonel,
        /// <summary>
        /// Генерал
        /// </summary>
        General
    }
}
