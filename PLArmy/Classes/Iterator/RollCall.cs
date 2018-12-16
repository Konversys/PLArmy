using PLArmy.Interfaces.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLArmy.Classes.Iterator
{
    class RollCall
    {
        /// <summary>
        /// Произвести перекличку взвода
        /// </summary>
        /// <param name="platoon">Взвод</param>
        public void Begin(Platoon platoon)
        {
            Console.WriteLine("Перекличка взвода: {0}", platoon.title);
            ISolderIterator iterator = platoon.CreateNumerator();
            while (iterator.HasNext())
            {
                Solder solder = iterator.Next();
                Console.WriteLine(" Я: {0}. Должность: {1}", solder.name, solder.post);
            }
        }
    }
}
