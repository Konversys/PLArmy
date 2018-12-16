using PLArmy.Interfaces.Iterator;
using System.Collections.Generic;

namespace PLArmy.Classes.Iterator
{
    /// <summary>
    /// Взвод
    /// </summary>
    class Platoon : ISolderNumerable
    {
        /// <summary>
        /// Название взвода
        /// </summary>
        public string title { get; private set; }
        /// <summary>
        /// Список взвода
        /// </summary>
        List<Solder> solders;
        public Platoon(string title)
        {
            this.solders = new List<Solder>();
            this.title = title;
        }
        /// <summary>
        /// Количество бойцов
        /// </summary>
        int ISolderNumerable.Count
        {
            get { return solders.Count; }
        }
        /// <summary>
        /// Текущий солдат
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Solder this[int index]
        {
            get { return solders[index]; }
        }
        /// <summary>
        /// Создать итератор
        /// </summary>
        /// <returns></returns>
        public ISolderIterator CreateNumerator()
        {
            return new SolderNumerator(this);
        }
        /// <summary>
        /// Добавить солдата
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="post">Должность</param>
        public void AddSolder(string name, string post)
        {
            this.solders.Add(new Solder(name, post));
        }
        /// <summary>
        /// Удалить солдата
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="post">Должность</param>
        public void RemoveSolder(string name)
        {
            solders.RemoveAll(x => x.name == name);
        }

    }
}
