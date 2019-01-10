using PLArmy.Enums;
using System;
using PLArmy.Classes.Iterator;

namespace PLArmy.Classes.Delegate
{
    class ContractTechnician : Solder
    {
        /// <summary>
        /// Технарь
        /// Много знает
        /// Выполняет команды
        /// </summary>
        public ContractTechnician()
        {
            this.Greeting = String.Format("Я контрактник - выпускник технического училища:");
            command = new LowRank();
            equipment = new HighLevelKnowledge();
            rank = ERank.Sergeant;
        }
    }
}
