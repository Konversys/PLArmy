using PLArmy.Classes.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLArmy.Classes.Flyweight
{
    /// <summary>
    /// Взвод связи
    /// </summary>
    class ConnectionPlatoon : Platoon
    {
        public ConnectionPlatoon()
        { 
        }

        public override string SetTitleAndConnect(string title)
        {
            return String.Format(" Взвод связи {0} присоединился к батальону", title);
        }
    }
}
