using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLArmy.Interfaces.Delegate
{
    /// <summary>
    /// Командирские возможности
    /// </summary>
    interface ICommand
    {
        void GiveOrder();
        void ExecuteOrder();
    }
}
