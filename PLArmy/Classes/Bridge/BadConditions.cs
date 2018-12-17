using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PLArmy.Interfaces.Bridge;

namespace PLArmy.Classes.Bridge
{
    /// <summary>
    /// Плохой исход войны
    /// Уточненная абстракция
    /// </summary>
    class BadConditions : War
    {
        public BadConditions(IPlan plan) : base(plan)
        {
        }

        public override void Report()
        {
            Console.WriteLine("Война закончилась поражением");
        }
    }
}
