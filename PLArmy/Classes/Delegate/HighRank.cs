using PLArmy.Interfaces.Delegate;
using System;

namespace PLArmy.Classes.Delegate
{
    /// <summary>
    /// Отдает приказы
    /// </summary>
    class HighRank : ICommand
    {
        public string ExecuteOrder()
        {
            return String.Format("     Мое звание позволяет мне отдавать приказы"); 
        }

        public string GiveOrder()
        {
            return String.Format("     Мало кто может отдать мне приказ");
        }
    }
}
