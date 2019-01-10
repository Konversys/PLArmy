﻿using PLArmy.Classes.Delegate;
using PLArmy.Enums;
using PLArmy.Classes.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLArmy.Classes.Facade
{
    /// <summary>
    /// Полковник строит и снаряжает роту
    /// Клиент
    /// </summary>
    class Colonel : Solder
    {
        public Colonel(string name, string post) : base(name, post)
        {
            command = new HighRank();
            equipment = new HighLevelKnowledge();
            rank = ERank.Colonel;
        }
        public List<string> ToManage(Sq sq)
        {
            List<string> vs = new List<string>();
            vs.AddRange(sq.Equip());
            vs.AddRange(sq.AddSubPlatoon());
            return vs;
        }
        /// <summary>
        /// Узнать кол-во бойцов в роте
        /// </summary>
        /// <param name="sq"></param>
        public string GetSqSolderCount(Sq sq)
        {
            return String.Format(" В роте {0} бойцов", sq.GetSolderCount());
        }
    }
}
