using PLArmy.Interfaces.Delegate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLArmy.Classes.Delegate
{
    /// <summary>
    /// Мало знает
    /// </summary>
    class LowLevelKnowledge : IEquipment
    {
        public void Break()
        {
            Console.WriteLine("     Я могу легко сломать технику");
        }

        public void Repair()
        {
            Console.WriteLine("     Я не знаю как чинить технику");
        }
    }
}
