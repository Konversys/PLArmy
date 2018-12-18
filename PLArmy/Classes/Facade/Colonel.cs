using PLArmy.Classes.Delegate;
using PLArmy.Enums;
using PLArmy.Interfaces.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLArmy.Classes.Facade
{
    /// <summary>
    /// Полковник строит и снаряжает роту
    /// Клиент
    /// </summary>
    class Colonel : Solder
    {
        public Colonel(string name, string post) : base(name, post)
        {
            command = new HighRank();
            equipment = new HighLevelKnowledge();
            rank = ERank.Colonel;
        }
        public void ToManage(Sq sq)
        {
            sq.Equip();
            sq.AddSubPlatoon();
        }
    }
}
