using PLArmy.Interfaces.Delegate;
using System;

namespace PLArmy.Classes.Delegate
{
    /// <summary>
    /// Выполняет приказы
    /// </summary>
    class LowRank : ICommand
    {
        public void ExecuteOrder()
        {
            Console.WriteLine("     Мое звание слишком маленькое чтобы отдавать приказы");
        }

        public void GiveOrder()
        {
            Console.WriteLine("     Я всегда готов выполнить приказ");
        }
    }
}
