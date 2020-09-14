using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Player
    {
        private int _health;
        private int _damage;
        private bool isAlive;
        private string _name;
        public Player()
        {
            _health = 100;
            _damage = 10;

        }
        public Player( string nameVal, int healthVal, int damageVal)
        {
            _health = healthVal;
            _damage = damageVal;
            _name = nameVal;
        }
        public bool GetIsAlive()
        {
            return _health > 0;
        }

        public void PrintStats()
        {
            Console.WriteLine("Name:" + _name);
            Console.WriteLine("Health:" + _health);
            Console.WriteLine("Damage:" + _damage);

        }
        public void Attack(Player enemy)
        {
            enemy.TakeDamage(_damage);
        }



        private void TakeDamage(int damageVal)
        {
            if (GetIsAlive())
            {
                _health -= damageVal;
            }
            Console.WriteLine(_name = " Did" + damageVal + "damage!!!!!!!");
        }

    }
}