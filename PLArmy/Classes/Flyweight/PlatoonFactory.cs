using PLArmy.Classes.Iterator;
using PLArmy.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLArmy.Classes.Flyweight
{
    /// <summary>
    /// Фабрика приспособленцев - создает объекты разделяемых приспособленцев
    /// </summary>
    class PlatoonFactory
    {
        Dictionary<string, Platoon> batalion;

        public PlatoonFactory()
        {
            this.batalion = new Dictionary<string, Platoon>();
            batalion.Add("Медицинский", new MedicalPlatoon());
            batalion.Add("Связисты", new ConnectionPlatoon());
            batalion.Add("Артиллеристы", new AirdefensePlatoon());
            batalion.Add("Танкисты", new TankPlatoon());
        }

        public Platoon GetPlatoon(string specialty)
        {
            if (batalion.ContainsKey(specialty))
                return batalion[specialty];
            else
                return null;
        }
    }
}
