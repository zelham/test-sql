using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest
{
    class Holdable
    {
        private string _name;
        public bool IsEpicWeapon;

        public Holdable(string name)
        {
            _name = name;
        }

        public void PrintName()
        {
            Console.WriteLine("Holdable name: " + _name);
        }

        public string GetName()
        {
            return _name;
        }
    }

    class Weapon : Holdable
    {
        public Weapon(string name) : base(name) { }
    }

    class EpicWeapon : Holdable
    {
        public EpicWeapon(string name) : base(name)
        {
            IsEpicWeapon = true;
        }

        public string GetEpicMove()
        {
            return "Super Special move invoked.  lots of sounds and graphics";
        }
    }

    class Spell : Holdable
    {
        public Spell(string name) : base(name) { }
    }

    class Player : Entity
    {
        private Holdable _holdable;

        public Player(float startingHealth, Holdable weapon) : base(startingHealth)
        {
            _holdable = weapon;
        }

        public void PrintHoldable()
        {
            Console.WriteLine("Currently weilding a " + _holdable.GetName());
        }

        public Holdable GetHoldable()
        {
            return _holdable;
        }
    }

    class Enemy : Entity
    {
        private Holdable _spell;

        public Enemy(float startingHealth, Holdable spell) : base(startingHealth)
        {
            _spell = spell;
        }

        public void PrintHoldable()
        {
            Console.WriteLine("Currently casing " + _spell);
        }
    }

    class Entity
    {
        protected float _health;

        public Entity(float startingHealth)
        {
            _health = startingHealth;
        }

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
