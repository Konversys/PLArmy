using PLArmy.Interfaces.Delegate;
using System;

namespace PLArmy.Classes.Delegate
{
    /// <summary>
    /// Отдает приказы
    /// </summary>
    class HighRank : ICommand
    {
        public void ExecuteOrder()
        {
            Console.WriteLine("     Мое звание позволяет мне отдавать приказы"); 
        }

        public void GiveOrder()
        {
            Console.WriteLine("     Мало кто может отдать мне приказ");
        }
    }
}
