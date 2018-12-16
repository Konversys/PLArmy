using PLArmy.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLArmy.Interfaces.Composite
{
    /// <summary>
    /// Предмет
    /// </summary>
    interface IItem
    {
        /// <summary>
        /// Взять предмет для...
        /// </summary>
        /// <param name="subdivision">Подразделение для предмета</param>
        void Take(ESubdivision subdivision);
    }
}
