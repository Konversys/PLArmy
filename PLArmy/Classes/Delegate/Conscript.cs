using PLArmy.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLArmy.Classes.Delegate
{
    class Conscript : Serviceman
    {
        /// <summary>
        /// Срочник новобранец
        /// Мало знает
        /// Выполняет команды
        /// </summary>
        public Conscript()
        {
            Console.WriteLine("Я срочник-новобранец:");
            equipment = new LowLevelKnowledge();
            command = new LowRank();
            rank = ERank.Soldier;
        }
    }
}
