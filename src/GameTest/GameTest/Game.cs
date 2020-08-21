using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest
{
    class Game
    {
        public void PlayGame(Entity player, Entity enemy1, Entity enemy2)
        {
            float health = player.GetHealth();
            Console.WriteLine("The player has " + health + " health.");

            // Combat

            if (!(player is Enemy))
            {
                Console.WriteLine("Player is not an ememy");
            }

            // Display what everyone is weilding
            if (player is Player)
            {
                Player p1 = (Player)player;
                p1.PrintHoldable();

                Holdable holdable = p1.GetHoldable();
                if (holdable.IsEpicWeapon)
                {
                    EpicWeapon e1 = (EpicWeapon)holdable;
                    string specialAttack = "Player is attacking with special: " + e1.GetEpicMove();
                    Console.WriteLine(specialAttack);
                }
            }

        }
    }
}
