﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoituspeli.Enemy
{
    public class Level1EnemyList
    {
        public static Dictionary<string, int> _goblinstats { get; set; }
        public static string _goblin = "Goblin";
        public static string _orc = "Orc";

        public Level1EnemyList()
        {
            
            _goblinstats = new Dictionary<string, int>()
            {
                    {"LVL", 1 },
                    {"HP", 10 },
                    {"STR", 2 },
                    {"DEX", 3 },
                    {"VIT", 2 },
                    {"INT", 1 },
                    {"MND", 1 },
                    {"LCK", 1 },
                    {"EXP", 80}
            };
        }
}
}
