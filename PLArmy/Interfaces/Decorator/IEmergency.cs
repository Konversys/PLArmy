namespace PLArmy.Interfaces.Decorator
{
    /// <summary>
    /// Случаи ЧП
    /// Component - абстрактный класс, который определяет интерфейс для наследуемых объектов
    /// </summary>
    interface IEmergency
    {
        /// <summary>
        /// Инструкции на случай пожара
        /// </summary>
        void FollowInstructionInCaseOfFire();
    }
}
