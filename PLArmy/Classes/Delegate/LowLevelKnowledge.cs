using PLArmy.Interfaces.Delegate;
using System;

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
