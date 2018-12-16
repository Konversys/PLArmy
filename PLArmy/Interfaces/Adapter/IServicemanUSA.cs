using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLArmy.Interfaces.Adapter
{
    /// <summary>
    /// Интерфейс возможностей солдата США
    /// </summary>
    interface IServicemanUSA
    { 
        void Attack();
        void Retreat();
        void SetOrder();
        void GetOrder();
        void Repair();
        void Break();
    }
}
