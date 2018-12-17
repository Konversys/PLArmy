﻿using PLArmy.Classes.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLArmy.Classes.Flyweight
{
    /// <summary>
    /// Мед. взвод
    /// </summary>
    class MedicalPlatoon : Platoon
    {
        public MedicalPlatoon()
        {
        }

        public override void SetTitleAndConnect(string title)
        {
            Console.WriteLine(" Мед. взвод {0} присоединился к батальону", title);
        }
    }
}