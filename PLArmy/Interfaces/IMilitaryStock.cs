using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLArmy.Interfaces
{
    interface IMilitaryStock
    {
        /// <summary>
        /// Взять еду
        /// </summary>
        /// <param name="count">Кол-во</param>
        void TakeFood(int count);
        /// <summary>
        /// Взять броню
        /// </summary>
        /// <param name="count">Кол-во</param>
        void TakeArmor(int count);
        /// <summary>
        /// Взять оружие
        /// </summary>
        /// <param name="count">Кол-во</param>
        void TakeWeapon(int count);
    }
}
