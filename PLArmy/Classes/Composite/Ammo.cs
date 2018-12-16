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
    /// Боезапас
    /// </summary>
    class Ammo : IItem
    {
        public void Take(ESubdivision subdivision)
        {
            Console.WriteLine("             Вы взяли боезапас");
        }
    }
}
