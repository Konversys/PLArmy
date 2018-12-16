using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PLArmy.Classes.Composite;
using PLArmy.Enums;
using PLArmy.Interfaces.Composite;
using PLArmy.Interfaces.Iterator;

namespace PLArmy.Classes.Iterator
{
    class ItemChecker
    {
        public void TraversalData(Composite.Composite composite, ESubdivision subdivision)
        {
            IItemIterator iterator = composite.CreateNumerator();
            while (iterator.hasNext())
            {
                IItem item = iterator.next();
                item.Take(subdivision);
            }
        }
    }
}
