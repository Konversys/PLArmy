using PLArmy.Classes.Delegate;
using PLArmy.Interfaces.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLArmy.Classes.Adapter
{
    /// <summary>
    /// Рядовой срочник из США.
    /// Адаптируемый класс
    /// </summary>
    class ConscriptUSA : IServicemanUSA
    {
        public void Attack()
        {
            Console.WriteLine("     I'm Attack");
        }

        public void Retreat()
        {
            Console.WriteLine("     I'm Retreat");
        }

        public void SetOrder()
        {
            Console.WriteLine("     I'm can't Set Order");
        }

        public void GetOrder()
        {
            Console.WriteLine("     I'm Get Order");
        }

        public void Repair()
        {
            Console.WriteLine("     I'm don't know how to Repair");
        }

        public void Break()
        {
            Console.WriteLine("     I'll will crash everything around me");
        }
    }
}
