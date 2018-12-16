using PLArmy.Interfaces.Decorator;

namespace PLArmy.Classes.Decorator
{
    /// <summary>
    /// Декоратор
    /// Класс декоратора также хранит ссылку на декорируемый объект в виде объекта базового класса Component
    /// И реализует связь с базовым классом.
    /// </summary>
    class ServicemanDecorator : IEmergency
    {
        IEmergency serviceman;

        public ServicemanDecorator(IEmergency serviceman)
        {
            this.serviceman = serviceman;
        }

        public virtual void FollowInstructionInCaseOfFire()
        {
            serviceman.FollowInstructionInCaseOfFire();
        }
    }
}
