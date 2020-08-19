using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest
{
    class Player
    {
        public Player(float startingHealth)
        {
            _health = startingHealth;
        }
        private float _health;
        public bool IsDead()
        {
            return _health < 1;
        }
        public float GetHealth()
        {
            return _health;
        }
    }
}
