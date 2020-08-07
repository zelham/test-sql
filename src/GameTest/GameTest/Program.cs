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
            float[] enemies = { 1.0f, 3.0f, 5.0f, 8.0f, 13.0f };
            bool isPlayerDead = false;
            bool isEnemyDead = false;
            bool isGameOver = false;

            Console.WriteLine(enemies.Length + " enemies have approached.");
            for (int i = 0; i < enemies.Length; i++)
            {
                Console.WriteLine("Enemy " + (i + 1) + " has " + enemies[i] + " health.");
            }

            while (isGameOver == false)
            {
                for (int i = 0; i < enemies.Length; i++)
                {
                    enemies[i] -= PlayCombat(playerHealth, damageType, enemies[i]);

                    isEnemyDead = enemies[0] < 1;
                    isPlayerDead = ResolvePlayer(playerHealth);
                    if (isPlayerDead || isEnemyDead)
                    {
                        isGameOver = true;
                    }

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

        static float PlayCombat(float playerHealth, string damageType, float enemyHealth)
        {
            bool didBlock = false;
            bool didAttack = false;
            ConsoleKeyInfo playerAction;

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
                playerHealth -= damage;
                DisplayMessage("the player has been taken " + damage + " damage from " + damageType);
                //display player has been attacked
                DisplayMessage("the player now has " + playerHealth + " health.");
            }

            if (didAttack == true)
            {
                //attack enemy
                const float damage = 1.0f;
                enemyHealth -= damage;
                DisplayMessage("the enemy has been taken " + damage + " damage from " + damageType);
                //display player has been attacked
                DisplayMessage("the enemy now has " + enemyHealth + " health.");
            }
            return enemyHealth;
        }
    }
}
