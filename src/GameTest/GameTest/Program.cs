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
            Game game = new Game();
            Player player = new Player(100);
            Player player2 = new Player(50);

            game.PlayGame(player);

            Console.ReadKey();
        }

        static void PlayGame2(string damageType)
        {
            // Create enemies
            float[] enemies = { 1.0f, 3.0f, 5.0f, 8.0f, 13.0f };

            // Create player
            float playerHealth = 10.0f;

            // Start combat!
            Console.WriteLine(enemies.Length + " enemies have approached.");

            // Loop over enemies
            for (int i = 0; i < enemies.Length; i++)
            {
                bool isEnemyDead = false;
                while (!isEnemyDead)
                {
                    // Resolve combat
                    bool didPlayerWin = BattleEnemy(i, playerHealth, enemies[i], damageType);
                    if (!didPlayerWin)
                    {
                        DisplayMessage("The player has been defeated");
                        return;
                    }
                }
            }

            DisplayMessage("The player has defeated all remaining enemies");
        }

        // Returns true if player won
        // Returns false if player died
        static bool BattleEnemy(int enemyId, float playerHealth, float enemyHealth, string damageType)
        {
            bool isEnemyDead = false;
            bool isPlayerDead = false;
            while (!isEnemyDead && !isPlayerDead)
            {
                DisplayMessage("The player currently has " + playerHealth + " health.");
                Console.WriteLine("Enemy " + (enemyId + 1) + " has " + enemyHealth + " health.");

                // Get input
                //attack or defend ('a' == 'a')
                DisplayMessage("choose an action: attack(a) or block(b)");
                ConsoleKeyInfo playerAction = Console.ReadKey();

                if (playerAction.KeyChar == 'a')
                {
                    enemyHealth = AttackEnemy(damageType, enemyHealth);
                    playerHealth = AttackPlayer(damageType, playerHealth);
                }
                else if (playerAction.KeyChar == 'b')
                {
                    DisplayMessage("The player blocked all incoming damage.");
                }

                // Is enemy dead?
                if (enemyHealth < 1)
                {
                    isEnemyDead = true;
                    DisplayMessage("The enemy has " + enemyHealth + " health and has been defeated.");
                }
                else if (playerHealth < 1)
                {
                    isPlayerDead = true;
                }
            }

            return !isPlayerDead;
        }

        static float AttackPlayer(string damageType, float playerHealth)
        {
            const float damage = 1.0f;
            playerHealth -= damage;
            DisplayMessage("the player has been taken " + damage + " damage from " + damageType);
            //display player has been attacked
            DisplayMessage("the player now has " + playerHealth + " health.");

            return playerHealth;
        }

        static float AttackEnemy(string damageType, float enemyHealth)
        {
            const float damage = 1.0f;
            enemyHealth -= damage;
            DisplayMessage("the enemy has been taken " + damage + " damage from " + damageType);
            //display player has been attacked
            DisplayMessage("the enemy now has " + enemyHealth + " health.");

            return enemyHealth;
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
                DisplayMessage("The player currently has " + playerHealth + " health.");
                DisplayMessage("Enemy " + (i + 1) + " has " + enemies[i] + " health.");
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
