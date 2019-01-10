using PLArmy.Enums;
using System;
using PLArmy.Classes.Iterator;

namespace PLArmy.Classes.Delegate
{
    class Conscript : Solder
    {
        /// <summary>
        /// Срочник новобранец
        /// Мало знает
        /// Выполняет команды
        /// </summary>
        public Conscript()
        {
            this.Greeting = String.Format("Я срочник-новобранец:");
            equipment = new LowLevelKnowledge();
            command = new LowRank();
            rank = ERank.Soldier;
        }
    }
}
