using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayGame("poison.");
        }

        static void PlayGame(string damageType)
        {   
            //player
            float health = 10.0f;

            //inform player how much health they have
            DisplayMessage("the player currently has " + health + " health.");

            //attack player
            const float damage = 1.0f;
            health = health - damage;
            DisplayMessage("the player has been taken " + damage + " damage from " + damageType);

            //display player has been attacked
            DisplayMessage("the player now has " + health + " health.");

            //resolve player

        }

        static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
