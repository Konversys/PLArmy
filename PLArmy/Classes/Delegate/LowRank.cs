using PLArmy.Interfaces.Delegate;
using System;

namespace PLArmy.Classes.Delegate
{
    /// <summary>
    /// Выполняет приказы
    /// </summary>
    class LowRank : ICommand
    {
        public string ExecuteOrder()
        {
            return String.Format("     Мое звание слишком маленькое чтобы отдавать приказы");
        }

        public string GiveOrder()
        {
            return String.Format("     Я всегда готов выполнить приказ");
        }
    }
}
