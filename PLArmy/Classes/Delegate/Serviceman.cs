using PLArmy.Enums;
using PLArmy.Interfaces.Adapter;
using PLArmy.Interfaces.Decorator;
using PLArmy.Interfaces.Delegate;
using System;

namespace PLArmy.Classes.Delegate
{
    /// <summary>
    /// Военнослужащий
    /// </summary>
    abstract class Serviceman : IServiceMan, IEmergency
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

        public void FollowInstructionInCaseOfFire()
        {
            Console.Write(" Я покину помещение.");
        }
    }
}
