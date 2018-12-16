using PLArmy.Enums;
using PLArmy.Interfaces.Compos;
using System;

namespace PLArmy.Classes.Compos
{
    /// <summary>
    /// Комплект ЗИП
    /// </summary>
    class ZIP : IItem
    {
        public void Take(ESubdivision subdivision)
        {
            Console.WriteLine("             Вы взяли комплект ЗИП");
        }
    }
}
