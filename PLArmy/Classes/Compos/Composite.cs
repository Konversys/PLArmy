using PLArmy.Enums;
using PLArmy.Interfaces.Compos;
using System;
using System.Collections.Generic;

namespace PLArmy.Classes.Compos
{
    /// <summary>
    /// Список подразделений и выданных им предметов
    /// Представляет компонент, который может содержать другие компоненты и реализует механизм для их добавления и удаления
    /// </summary>
    class Composite : IItem
    { 
        /// <summary>
        /// Хранит компоненты
        /// </summary>
        List<IItem> components = new List<IItem>();
        /// <summary>
        /// Добавить элемент
        /// </summary>
        /// <param name="item"></param>
        public void AddItem(IItem item)
        {
            components.Add(item);
        }

        /// <summary>
        /// Удалить элемент
        /// </summary>
        /// <param name="item"></param>
        public void RemoveItem(IItem item)
        {
            components.Remove(item);
        }
        /// <summary>
        /// Взять выданные подразделению предметы
        /// </summary>
        /// <param name="subdivision">Подразделение</param>
        public void Take(ESubdivision subdivision)
        {
            switch (subdivision)
            {
                case ESubdivision.Военнослущащий:
                    Console.WriteLine("             Выдать предметы: {0}", subdivision);
                    break;
                case ESubdivision.Танк:
                    Console.WriteLine("         Выдать предметы: {0}", subdivision);
                    break;
                case ESubdivision.Взвод:
                    Console.WriteLine("     Выдать предметы: {0}", subdivision);
                    break;
                case ESubdivision.Рота:
                    Console.WriteLine(" Выдать предметы: {0}", subdivision);
                    break;
                case ESubdivision.Батальен:
                    Console.WriteLine("Выдать предметы: {0}", subdivision);
                    break;
                case ESubdivision.Полк:
                    Console.WriteLine("Выдать предметы: {0}", subdivision);
                    break;
                default:
                    Console.WriteLine("Выдать предметы: {0}", subdivision);
                    break;
            }
            foreach (var item in components)
            {
                if (subdivision - 1 > 0)
                {
                    item.Take(subdivision - 1);
                }
            }
            Console.WriteLine();
        }
    }
}
