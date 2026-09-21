using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassBaseFighter
{
    class Fighter
    {
        public string Name;
        public int Health;
        public int Damage;


        public void Attack(Fighter enemy)
        {
            enemy.TakeDamage(Damage);
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
        }

        public bool IsAlive()
        {
            return Health > 0;
        }

    }
}
