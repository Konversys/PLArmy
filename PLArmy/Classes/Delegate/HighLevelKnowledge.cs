using PLArmy.Interfaces.Delegate;
using System;

namespace PLArmy.Classes.Delegate
{
    /// <summary>
    /// Много знает
    /// </summary>
    class HighLevelKnowledge : IEquipment
    {
        public void Break()
        {
            Console.WriteLine("     Я слишком опытен чтобы ломать технику");
        }

        public void Repair()
        {
            Console.WriteLine("     Я могу легко починить технику");
        }
    }
}
