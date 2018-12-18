using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PLArmy.Interfaces.Bridge;

namespace PLArmy.Classes.Bridge
{
    /// <summary>
    /// Хороший исход войны
    /// Уточненная абстракция
    /// </summary>
    class GoodConditions : War
    {
        public GoodConditions(IPlan plan) : base(plan)
        {
        }

        public override string Report()
        {
            return String.Format("Война закончилась победой");
        }
    }
}
