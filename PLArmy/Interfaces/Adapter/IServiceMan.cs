using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLArmy.Interfaces.Adapter
{
    /// <summary>
    /// Интерфейс возможностей солдата
    /// </summary>
    interface IServiceMan
    {
        void CanICommand();

        void CanIEquipment();
    }
}
