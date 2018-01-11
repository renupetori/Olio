using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoituspeli.Battle
{
    public class BattleHeroTurn
    {
        
        public BattleHeroTurn()
        {
            Console.WriteLine("");
            Console.WriteLine("\nYour turn. Choose a command by typing a number:\n1: Attack\n2: Defend\n3:Item");
            Console.ReadKey();
        }
    }
}
