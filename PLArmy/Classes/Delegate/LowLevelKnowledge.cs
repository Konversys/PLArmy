using PLArmy.Interfaces.Delegate;
using System;

namespace PLArmy.Classes.Delegate
{
    /// <summary>
    /// Мало знает
    /// </summary>
    class LowLevelKnowledge : IEquipment
    {
        public string Break()
        {
            return String.Format("     Я могу легко сломать технику");
        }

        public string Repair()
        {
            return String.Format("     Я не знаю как чинить технику");
        }
    }
}
