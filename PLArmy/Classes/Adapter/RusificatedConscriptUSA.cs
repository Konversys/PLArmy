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

        public RusificatedConscriptUSA()
        {
            Console.WriteLine("Hello! I'm Rusificated Conscript from USA: ");
            this.conscript = new ConscriptUSA();
        }       

        public void CanICommand()
        {
            this.conscript.SetOrder();
            this.conscript.GetOrder();
        }

        public void CanIEquipment()
        {
            this.conscript.Repair();
            this.conscript.Break();
        }
    }
}
