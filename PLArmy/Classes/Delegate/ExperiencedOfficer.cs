using PLArmy.Enums;
using System;

namespace PLArmy.Classes.Delegate
{
    class ExperiencedOfficer : Serviceman
    {
        /// <summary>
        /// Офицер
        /// Много знает
        /// Отдает команды
        /// </summary>
        public ExperiencedOfficer()
        {
            Console.WriteLine("Я опытный офицер:");
            command = new HighRank();
            equipment = new HighLevelKnowledge();
            rank = ERank.Major;
        }
    }
}
