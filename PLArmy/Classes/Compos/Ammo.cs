using PLArmy.Enums;
using PLArmy.Interfaces.Compos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLArmy.Classes.Compos
{
    /// <summary>
    /// Боезапас
    /// </summary>
    class Ammo : IItem
    {
        public List<string> Take(ESubdivision subdivision)
        {
            List<string> vs = new List<string>();
            vs.Add(String.Format("Вы взяли боезапас"));
            return vs;
        }
    }
}
