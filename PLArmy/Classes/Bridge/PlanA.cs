using PLArmy.Interfaces.Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLArmy.Classes.Bridge
{
    /// <summary>
    /// План действий на случай войны
    /// Конкретная реализация, которая унаследована от Implementor
    /// </summary>
    class PlanA : IPlan
    {
        public PlanA()
        {
            Console.WriteLine(" Используем план А");
        }

        public void Attack()
        {
            Console.WriteLine("     Атакуем с левого фланга");
        }

        public void Retreat()
        {
            Console.WriteLine("     Отступаем через деревню. Подрываем мост после себя");
        }

        public void TakePosition()
        {
            Console.WriteLine("     Занять позицию у подножья горы");
        }
    }
}
