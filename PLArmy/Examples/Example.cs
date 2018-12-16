using PLArmy.Classes.Proxy;
using PLArmy.Enums;
using PLArmy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLArmy.Examples
{
    class Example
    {
        public static void GoStock()
        {
            IMilitaryStock militaryStock = new ProxyStock(ERank.Captain, 100, 20, 15);
            militaryStock.TakeArmor(80);
            militaryStock.TakeArmor(10);
            militaryStock.TakeArmor(20);
            militaryStock.TakeFood(30);
            militaryStock.TakeFood(10);
            militaryStock.TakeWeapon(5);
            militaryStock.TakeWeapon(20);
            Console.ReadKey();
        }
    }
}
