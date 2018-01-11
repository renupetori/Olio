using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoituspeli.Battle
{
    public class BattleGoblin
    {


        public int testi = 2;

        public BattleGoblin()
        {
            Console.WriteLine($"\n{Enemy.Level1EnemyList._goblin} attacks!");

            while (Character.Character._stats["HP"] >= 0 || Enemy.Level1EnemyList._goblinstats["HP"] >= 0)
            {
                new BattleHeroTurn();
                if (Enemy.Level1EnemyList._goblinstats["HP"] >= 0)
                {
                    new BattleEnemyTurn();
                }
            }
        }
        
    }
}
