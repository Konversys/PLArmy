using PLArmy.Enums;
using System;

namespace PLArmy.Classes.Delegate
{
    class ContractTechnician : Serviceman
    {
        /// <summary>
        /// Технарь
        /// Много знает
        /// Выполняет команды
        /// </summary>
        public ContractTechnician()
        {
            Console.WriteLine("Я контрактник - выпускник технического училища:");
            command = new LowRank();
            equipment = new HighLevelKnowledge();
            rank = ERank.Sergeant;
        }
    }
}
