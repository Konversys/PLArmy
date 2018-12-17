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
    class PlanB : IPlan
    {
        public PlanB()
        {
            Console.WriteLine(" Используем план Б");
        }

        public void Attack()
        {
            Console.WriteLine("     Атакуем, обойдя с тыла");
        }

        public void Retreat()
        {
            Console.WriteLine("     Отступаем через лесополосу");
        }

        public void TakePosition()
        {
            Console.WriteLine("     Занимаем позицию за городским элеватором");
        }
    }
}
