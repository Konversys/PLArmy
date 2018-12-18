using PLArmy.Interfaces;
using PLArmy.Interfaces.Adapter;
using PLArmy.Interfaces.Delegate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLArmy.Classes.Adapter
{
    /// <summary>
    /// Срочник из США приведенный к интерфейсу РФ
    /// Класс-адаптер
    /// </summary>
    class RusificatedConscriptUSA : IServiceMan
    {
        ConscriptUSA conscript { get; set; }
        public string Greeting { get; private set; }
        public RusificatedConscriptUSA()
        {
            this.Greeting = "Hello! I'm Rusificated Conscript from USA: ";
            this.conscript = new ConscriptUSA();
        }       

        public string[] CanICommand()
        {
            return new string[] { this.conscript.SetOrder(), this.conscript.GetOrder() };
        }

        public string[] CanIEquipment()
        {
            return new string[] { this.conscript.Break(), this.conscript.Repair() };
        }
    }
}
