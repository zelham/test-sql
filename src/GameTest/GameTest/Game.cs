using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest
{
    class Game
    {
        public void PlayGame(Player player)
        {
            float health = player.GetHealth();
            Console.WriteLine("The player has " + health + " health.");
        }
    }
}
