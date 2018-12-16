using PLArmy.Classes.Delegate;
using PLArmy.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLArmy.Interfaces.Iterator
{
    /// <summary>
    /// Солдат
    /// </summary>
    class Solder : Serviceman
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string name { get; private set; }
        /// <summary>
        /// Должность
        /// </summary>
        public string post { get; private set; }
        /// <summary>
        /// Создать солдата
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="post">Должность</param>
        public Solder(string name, string post)
        {
            equipment = new HighLevelKnowledge();
            command = new LowRank();
            rank = ERank.Soldier;
            this.post = post;
            this.name = name;
        }
    }
}
