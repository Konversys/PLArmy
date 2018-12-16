using PLArmy.Interfaces.Composite;
using PLArmy.Interfaces.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLArmy.Classes.Iterator
{
    class ItemNumerator : IItemIterator
    {
        IItemNumerable aggregate;
        int index = 0;

        public ItemNumerator(IItemNumerable aggregate)
        {
            this.aggregate = aggregate;
        }

        public bool hasNext()
        {
            return index < aggregate.Count;
        }

        public IItem next()
        {
            return aggregate[index++];
        }
    }
}
