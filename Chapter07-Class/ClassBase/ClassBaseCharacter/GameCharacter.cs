using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBaseCharacter
{
    class GameCharacter
    {
        public string Name;
        public int Health;
        public int Money;
        public int Level;


        public void TakeDamage(int damage)
        {
            Health -= damage;
        }

        public void TakeCash(int cash)
        {
            Money += cash;
        }

        public void GiveCash(int cash)
        {
            Money -= cash;
        }

        public void LevelUp(int point)
        {
            Level += point;
        }
    }
}
