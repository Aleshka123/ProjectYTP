using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScript
{
    public class PlayerHP
    {
        static void Main()
        {
        }

        public int TestPlayerHp(string gameObject, int HP)
        {
            if (gameObject == "AmmoEnemy")
            {
                if (HP == 0)
                    return HP;
                else 
                    return HP -= 1;
            }

            if (gameObject == "Wall")
            {
                if (HP == 0)
                    return HP;
                else
                    return HP -= 1;
            }

            if (gameObject == "Enemy")
            {
                return HP = 0;
            }

            return HP;
        }
    }
}
