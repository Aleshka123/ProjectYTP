using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScript
{
    public class EnemyHP
    {

        public int TestEnemyHp(string gameObject, int HP)
        {
            if (gameObject == "Ammo" || gameObject == "Player")
            {
                if (HP == 0)
                    return HP;
                else
                    return HP -= 1;
            }
            return HP;
        }
    }
}
