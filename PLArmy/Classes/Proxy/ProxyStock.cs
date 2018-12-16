using PLArmy.Classes.Delegate;
using PLArmy.Enums;
using PLArmy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLArmy.Classes.Proxy
{
    class ProxyStock : IMilitaryStock
    {
        ERank rank { get; set; }
        Stock stock { get; set; }

        /// <summary>
        /// Прийти на склад
        /// </summary>
        /// <param name="rank">Ваш ранг</param>
        /// <param name="countArmor">Кол-во брони на складе</param>
        /// <param name="countFood">Кол-во еды на складе</param>
        /// <param name="countWeapon">Кол-во оружия на складе</param>
        public ProxyStock(ERank rank, int countArmor, int countFood, int countWeapon)
        {
            this.stock = new Stock(countArmor, countFood, countWeapon);
            this.rank = rank;
        }
        /// <summary>
        /// Прийти на склад
        /// </summary>
        /// <param name="serviceman">Военнослужащий</param>
        /// <param name="countArmor">Кол-во брони на складе</param>
        /// <param name="countFood">Кол-во еды на складе</param>
        /// <param name="countWeapon">Кол-во оружия на складе</param>
        public ProxyStock(Serviceman serviceman, int countArmor, int countFood, int countWeapon)
        {
            this.stock = new Stock(countArmor, countFood, countWeapon);
            this.rank = serviceman.rank;
        }
        /// <summary>
        /// Взять броню
        /// </summary>
        /// <param name="count">Кол-во</param>
        public void TakeArmor(int count)
        {
            ERank allowRank = ERank.Lieutenant;
            Console.Write("Вы {0} ~ {1}: Броня - ", rank, allowRank);
            if (rank >= allowRank)
            {
                stock.TakeArmor(count);
            }
            else
            {
                RefuseLowRank();
            }
        }
        /// <summary>
        /// Взять еду
        /// </summary>
        /// <param name="count">Кол-во</param>
        public void TakeFood(int count)
        {
            ERank allowRank = ERank.Sergeant;
            Console.Write("Вы {0} ~ {1}: Еда - ", rank, allowRank);
            if (rank >= allowRank)
            {
                stock.TakeFood(count);
            }
            else
            {
                RefuseLowRank();
            }
        }
        /// <summary>
        /// Взять оружие
        /// </summary>
        /// <param name="count">Кол-во</param>
        public void TakeWeapon(int count)
        {
            ERank allowRank = ERank.Major;
            Console.Write("Вы {0} ~ {1}: Оружие - ", rank, allowRank);
            if (rank >= allowRank)
            {
                stock.TakeWeapon(count);
            }
            else
            {
                RefuseLowRank();
            }
        }

        void RefuseLowRank()
        {
            Console.WriteLine("Ваш ранг слишком низкий для получения этого предмета");
        }
    }
}
