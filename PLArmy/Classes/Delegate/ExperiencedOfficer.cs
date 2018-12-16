using PLArmy.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
