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
            Console.ReadKey();
        }

        static void PlayGame(string damageType)
        {   
            //player
            float playerHealth = 10.0f;
            float enemyHealth = 5.0f;
            bool didBlock = false;
            bool didAttack = false;
            bool isPlayerDead = false;
            bool isEnemyDead = false;
            bool isGameOver = false;
            ConsoleKeyInfo playerAction;

            while (isGameOver == false)
            {
                //inform player how much health they have
                DisplayMessage("the player currently has " + playerHealth + " health.");

                DisplayMessage("choose an action: attack(a) or block(b)");
                playerAction = Console.ReadKey();
                //attack or defend ('a' == 'a')
                if (playerAction.KeyChar == 'a')
                {
                    didAttack = true;
                }
                else if (playerAction.KeyChar == 'b')
                {
                    didBlock = true;
                    DisplayMessage("the player blocked the damage.");
                }

                if (didBlock == false)
                {
                    //attack player
                    const float damage = 1.0f;
                    playerHealth = playerHealth - damage;
                    DisplayMessage("the player has been taken " + damage + " damage from " + damageType);
                    //display player has been attacked
                    DisplayMessage("the player now has " + playerHealth + " health.");
                }

                if (didAttack == true)
                {
                    //attack enemy
                    const float damage = 1.0f;
                    enemyHealth = enemyHealth - damage;
                    DisplayMessage("the enemy has been taken " + damage + " damage from " + damageType);
                    //display player has been attacked
                    DisplayMessage("the enemy now has " + enemyHealth + " health.");
                }

                isEnemyDead = enemyHealth < 1;
                isPlayerDead = ResolvePlayer(playerHealth);
                if (isPlayerDead || isEnemyDead)
                {
                    isGameOver = true;
                }
                else
                {
                    didBlock = false;
                    didAttack = false;
                }
            }

            
        }

        static bool ResolvePlayer(float health)
        {
            bool isDead = false;

            //resolve player
            if (health < 1)
            {
                isDead = true;
                DisplayMessage("the player is now dead.");
            }
            else
            {
                DisplayMessage("the player lives to fight another day.");
            }

            return isDead;
        }

        static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
