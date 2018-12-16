using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLArmy.Interfaces.Iterator
{
    /// <summary>
    /// Определяет интерфейс для обхода составных объектов
    /// </summary>
    interface ISolderIterator
    {
        bool HasNext();
        Solder Next();
    }
}
