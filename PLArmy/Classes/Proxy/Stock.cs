using PLArmy.Interfaces;
using System;

namespace PLArmy.Classes.Proxy
{
    class Stock : IMilitaryStock
    {
        int countArmor;
        int countFood;
        int countWeapon;

        public Stock(int countArmor, int countFood, int countWeapon)
        {
            this.countArmor = countArmor;
            this.countFood = countFood;
            this.countWeapon = countWeapon;
        }

        public void TakeArmor(int count)
        {
            if (this.countArmor - count >= 0)
            {
                this.countArmor -= count;
                Console.WriteLine("Вы взяли {0} брони. Осталось на складе - {1}", count, this.countArmor);
            }
            else
            {
                RefuseNoCount();
            }
        }

        public void TakeFood(int count)
        {
            if (this.countFood - count >= 0)
            {
                this.countFood -= count;
                Console.WriteLine("Вы взяли {0} еды. Осталось на складе - {1}", count, this.countFood);
            }
            else
            {
                RefuseNoCount();
            }
        }

        public void TakeWeapon(int count)
        {
            if (this.countWeapon - count >= 0)
            {
                this.countWeapon -= count;
                Console.WriteLine("Вы взяли {0} оружия. Осталось на складе - {1}", count, this.countWeapon);
            }
            else
            {
                RefuseNoCount();
            }
        }

        void RefuseNoCount()
        {
            Console.WriteLine("Заданного кол-ва предметов нет на складе");
        }
    }
}
