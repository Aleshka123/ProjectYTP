using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTest
{
    public class Class1
    {
        public int TestHp(string gameObject, int HP, int Count)
        {
            if (gameObject == "AmmoEnemy")
            {
                HP -= 1;
                if (HP <= 0)
                {
                    Count++;
                }
            }

            if (gameObject == "Wall")
            {
                HP -= 1;
                if (HP <= 0)
                {
                    Count++;
                }
            }

            if (gameObject == "Enemy")
            {
                HP = 0;
                Count++;

            }

            return HP;
        }
    }
}
