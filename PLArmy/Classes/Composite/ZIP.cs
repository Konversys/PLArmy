using PLArmy.Enums;
using PLArmy.Interfaces.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLArmy.Classes.Composite
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
