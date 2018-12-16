using PLArmy.Classes.Adapter;
using PLArmy.Classes.Compos;
using PLArmy.Classes.Decorator;
using PLArmy.Classes.Delegate;
using PLArmy.Classes.Iterator;
using PLArmy.Classes.Proxy;
using PLArmy.Enums;
using PLArmy.Interfaces;
using PLArmy.Interfaces.Compos;
using PLArmy.Interfaces.Decorator;
using System;

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
        /// <summary>
        /// Адаптер
        /// </summary>
        public static void GoAdapterRusConscriptUSA()
        {
            Serviceman serviceman = new Conscript();
            serviceman.CanICommand();
            Console.WriteLine();
            serviceman.CanIEquipment();
            Console.WriteLine();
            RusificatedConscriptUSA rusificated = new RusificatedConscriptUSA();
            rusificated.CanICommand();
            Console.WriteLine();
            rusificated.CanIEquipment();
            Console.ReadKey();
        }
        /// <summary>
        /// Декоратор
        /// </summary>
        public static void GoDecoratorFire()
        {
            IEmergency serviceman = new ServicemanResponsible(new ServiceManDuty(new ExperiencedOfficer()));
            serviceman.FollowInstructionInCaseOfFire();
            Console.WriteLine();

            serviceman = new ServiceManDuty(new ContractTechnician());
            serviceman.FollowInstructionInCaseOfFire();
            Console.WriteLine();

            serviceman = new Conscript();
            serviceman.FollowInstructionInCaseOfFire();
            Console.WriteLine();

            serviceman = new ServiceManDuty(new ExperiencedOfficer());
            serviceman.FollowInstructionInCaseOfFire();

            Console.ReadKey();
        }
        /// <summary>
        /// Компоновщик
        /// </summary>
        public static void GoCompositeItem()
        {
            IItem ammo = new Ammo();
            IItem fuel = new Fuel();
            IItem zip = new ZIP();

            Composite tank = new Composite();
            tank.AddItem(ammo);
            tank.AddItem(ammo);
            tank.AddItem(fuel);
            tank.AddItem(zip);

            Composite platoon = new Composite();
            platoon.AddItem(tank);
            platoon.AddItem(tank);
            platoon.AddItem(tank);

            Composite sq = new Composite();
            sq.AddItem(platoon);
            sq.AddItem(platoon);
            sq.AddItem(platoon);
            sq.AddItem(platoon);

            sq.Take(ESubdivision.Рота);

            Console.ReadKey();
        }
        /// <summary>
        /// Итератор
        /// </summary>
        public static void GoIteratorPlatoonRollCall()
        {
            Platoon platoon = new Platoon("2СИ-15");
            platoon.AddSolder("Халилов ", "Старший стрелок");
            platoon.AddSolder("Одилов  ", "Гранатометчик");
            platoon.AddSolder("Шарков  ", "Помощник гранатометчика");
            platoon.AddSolder("Лепезин ", "Стрелок");
            platoon.AddSolder("Дадашев ", "Стрелок");
            platoon.AddSolder("Нагель  ", "Пулеметчик");
            platoon.AddSolder("Андрюков", "Снайпер");

            RollCall rollCall = new RollCall();
            rollCall.Begin(platoon);

            Console.ReadKey();
        }
    }
}
