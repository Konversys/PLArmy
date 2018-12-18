using PLArmy.Enums;
using PLArmy.Interfaces;
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

        public string Greeting { get; protected set; } 

        protected ICommand command { get; set; }
        protected IEquipment equipment { get; set; }
        public string[] CanICommand()
        {
            return new string[] { command.ExecuteOrder(), command.GiveOrder() };
        }
        
        public string[] CanIEquipment()
        {
            return new string[] { equipment.Repair(), equipment.Break() };
        }

        public string FollowInstructionInCaseOfFire()
        {
            return String.Format(" Я покину помещение.");
        }
    }
}
