using System.Collections.Generic;

namespace PLArmy.Interfaces.Adapter
{
    /// <summary>
    /// Интерфейс возможностей солдата
    /// </summary>
    interface IServiceMan
    {
        string[] CanICommand();

        string[] CanIEquipment();
    }
}
