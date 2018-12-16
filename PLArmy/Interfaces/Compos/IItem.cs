using PLArmy.Enums;

namespace PLArmy.Interfaces.Compos
{
    /// <summary>
    /// Предмет
    /// </summary>
    interface IItem
    {
        /// <summary>
        /// Взять предмет для...
        /// </summary>
        /// <param name="subdivision">Подразделение для предмета</param>
        void Take(ESubdivision subdivision);
    }
}
