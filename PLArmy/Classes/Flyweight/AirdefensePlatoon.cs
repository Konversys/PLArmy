using PLArmy.Classes.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLArmy.Classes.Flyweight
{
    /// <summary>
    /// Арта
    /// </summary>
    class AirdefensePlatoon : Platoon
    {
        public AirdefensePlatoon()
        {
        }

        public override void SetTitleAndConnect(string title)
        {
            Console.WriteLine(" Арт. взвод {0} присоединился к батальону", title);
        }
    }
}