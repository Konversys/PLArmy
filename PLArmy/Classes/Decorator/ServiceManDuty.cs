using System;
using PLArmy.Interfaces.Decorator;

namespace PLArmy.Classes.Decorator
{
    /// <summary>
    /// Дежурный - Отвечает за вещи в части
    /// ConcreteComponent - Конкретная реализация с новой функциональностью
    /// </summary>
    class ServiceManDuty : ServicemanDecorator
    {
        public ServiceManDuty(IEmergency serviceman) : base(serviceman)
        {
            
        }

        public void SaveItems()
        {
            Console.Write(" Я буду спасать вещи.");
        }
        /// <summary>
        /// Выносит вещи + доп. функции
        /// </summary>
        public override void FollowInstructionInCaseOfFire()
        {
            SaveItems();
            base.FollowInstructionInCaseOfFire();
        }
    }
}
