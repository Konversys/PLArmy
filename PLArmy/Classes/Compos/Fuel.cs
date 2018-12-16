using PLArmy.Enums;
using PLArmy.Interfaces.Compos;
using System;

namespace PLArmy.Classes.Compos
{
    /// <summary>
    /// Топливо
    /// </summary>
    class Fuel : IItem
    {
        public void Take(ESubdivision subdivision)
        {
            Console.WriteLine("             Вы взяли топливо");
        }
    }
}
