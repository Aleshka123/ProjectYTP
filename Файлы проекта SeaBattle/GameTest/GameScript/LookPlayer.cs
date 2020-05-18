using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScript
{
    public class LookPlayer
    {
        public double TestPlayerLook(double XPlayer, double YPlayer, double XEnemy, double YEnemy)
        {
            if (XPlayer == 0 && YPlayer == 0 && XEnemy == 0 && YEnemy == 0)
                return 0;
            else
                return Math.Atan((YPlayer - YEnemy) / (XPlayer - XEnemy)) * (Math.PI * 2 / 360);
        }
    }
}
