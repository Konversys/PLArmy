using PLArmy.Interfaces.Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLArmy.Classes.Bridge
{
    /// <summary>
    /// Развитие войны
    /// Abstraction: определяет базовый интерфейс и хранит ссылку на объект Implementor.
    /// Выполнение операций в Abstraction делегируется методам объекта Implementor
    /// </summary>
    abstract class War
    {
        public IPlan plan { get; set; }
        public War(IPlan plan)
        {
            Console.WriteLine("Начинаем войну");
            this.plan = plan;
        }
        /// <summary>
        /// Атаковать
        /// </summary>
        public void Attack()
        {
            plan.Attack();
        }
        /// <summary>
        /// Передышка/Занять позицию
        /// </summary>
        public void Respite()
        {
            plan.TakePosition();
        }
        /// <summary>
        /// Нести потери
        /// </summary>
        public void BearALoss()
        {
            plan.Retreat();
        }
        /// <summary>
        /// Отчет о статусе войны
        /// </summary>
        public abstract void Report();
    }
}
