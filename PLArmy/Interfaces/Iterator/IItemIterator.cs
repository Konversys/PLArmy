using PLArmy.Interfaces.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLArmy.Interfaces.Iterator
{
    interface IItemIterator
    {
        bool hasNext();
        IItem next();
    }
}
