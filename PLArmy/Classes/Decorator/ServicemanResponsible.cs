using System;
using PLArmy.Interfaces.Decorator;

namespace PLArmy.Classes.Decorator
{
    /// <summary>
    /// Дежурный по части - ответственный за ситуацию
    /// ConcreteComponent - Конкретная реализация с новой функциональностью
    /// </summary>
    class ServicemanResponsible : ServicemanDecorator
    {
        public ServicemanResponsible(IEmergency serviceman) : base(serviceman)
        {

        }

        public void MakeReport()
        {
            Console.Write(" Я несу ответственность за проишествие.");
        }
        /// <summary>
        /// Несет ответственность + доп. функции
        /// </summary>
        public override void FollowInstructionInCaseOfFire()
        {
            MakeReport();
            base.FollowInstructionInCaseOfFire();
        }
    }
}
