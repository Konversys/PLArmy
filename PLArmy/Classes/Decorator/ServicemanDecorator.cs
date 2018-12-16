using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PLArmy.Classes.Delegate;
using PLArmy.Interfaces.Decorator;

namespace PLArmy.Classes.Decorator
{
    class ServicemanDecorator : IEmergency
    {
        IEmergency serviceman;

        public ServicemanDecorator(IEmergency serviceman)
        {
            this.serviceman = serviceman;
        }

        public virtual void FollowInstructionInCaseOfFire()
        {
            serviceman.FollowInstructionInCaseOfFire();
        }
    }
}
