using PLArmy.Classes.Delegate;
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
        /// <summary>
        /// Прокси
        /// </summary>
        public static void GoProxyStock()
        {
            Serviceman serviceman = new ExperiencedOfficer();
            IMilitaryStock militaryStock = new ProxyStock(serviceman, 100, 20, 15);
            militaryStock.TakeArmor(80);
            militaryStock.TakeArmor(10);
            militaryStock.TakeArmor(20);
            militaryStock.TakeFood(30);
            militaryStock.TakeFood(10);
            militaryStock.TakeWeapon(5);
            militaryStock.TakeWeapon(20);
            Console.ReadKey();
        }
        /// <summary>
        /// Делегирование
        /// </summary>
        public static void GoDelegateServiceman()
        {
            Serviceman serviceman;

            serviceman = new Conscript();
            serviceman.CanICommand();
            Console.WriteLine();
            serviceman.CanIEquipment();
            Console.WriteLine();
            serviceman = new ExperiencedOfficer();
            serviceman.CanICommand();
            Console.WriteLine();
            serviceman.CanIEquipment();
            Console.WriteLine();
            serviceman = new ContractTechnician();
            serviceman.CanICommand();
            Console.WriteLine();
            serviceman.CanIEquipment();
            Console.ReadKey();
        }
    }
}
