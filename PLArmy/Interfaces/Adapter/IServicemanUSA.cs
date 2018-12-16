namespace PLArmy.Interfaces.Adapter
{
    /// <summary>
    /// Интерфейс возможностей солдата США
    /// </summary>
    interface IServicemanUSA
    { 
        void Attack();
        void Retreat();
        void SetOrder();
        void GetOrder();
        void Repair();
        void Break();
    }
}
