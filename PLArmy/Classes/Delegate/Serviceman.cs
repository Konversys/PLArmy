using PLArmy.Enums;
using PLArmy.Interfaces.Adapter;
using PLArmy.Interfaces.Delegate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLArmy.Classes.Delegate
{
    /// <summary>
    /// Военнослужащий
    /// </summary>
    abstract class Serviceman : IServiceMan
    {
        public ERank rank { get; protected set; }
        protected ICommand command { get; set; }
        protected IEquipment equipment { get; set; }
        public void CanICommand()
        {
            command.ExecuteOrder();
            command.GiveOrder();
        }

        public void CanIEquipment()
        {
            equipment.Repair();
            equipment.Break();
        }
    }
}
