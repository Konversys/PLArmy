using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PLArmy.Classes.Delegate;
using PLArmy.Interfaces.Decorator;

namespace PLArmy.Classes.Decorator
{
    class ServicemanResponsible : ServicemanDecorator
    {
        public ServicemanResponsible(IEmergency serviceman) : base(serviceman)
        {

        }

        public void MakeReport()
        {
            Console.Write(" Я несу ответственность за проишествие.");
        }

        public override void FollowInstructionInCaseOfFire()
        {
            MakeReport();
            base.FollowInstructionInCaseOfFire();
        }
    }
}
