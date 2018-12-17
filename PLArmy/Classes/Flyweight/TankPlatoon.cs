using PLArmy.Classes.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLArmy.Classes.Flyweight
{
    /// <summary>
    /// Танковый взвод
    /// </summary>
    class TankPlatoon : Platoon
    {
        public TankPlatoon()
        {
        }

        public override void SetTitleAndConnect(string title)
        {
            Console.WriteLine(" Танковый взвод {0} присоединился к батальону", title);
        }
    }
}
