using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PLArmy.Classes.Delegate;
using PLArmy.Interfaces.Decorator;

namespace PLArmy.Classes.Decorator
{
    class ServiceManDuty : ServicemanDecorator
    {
        public ServiceManDuty(IEmergency serviceman) : base(serviceman)
        {
            
        }

        public void SaveItems()
        {
            Console.Write(" Я буду спасать вещи.");
        }

        public override void FollowInstructionInCaseOfFire()
        {
            SaveItems();
            base.FollowInstructionInCaseOfFire();
        }
    }
}
