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

        public override void SetTitleAndConnect(string title)
        {
            Console.WriteLine(" Взвод связи {0} присоединился к батальону", title);
        }
    }
}
