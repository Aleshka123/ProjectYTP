using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GameScript
{
    public class PlayerController
    {

        public float MoveSpeed = 10f;
        public float Movement = 0f;

        public float TestPlayerController(int X, int Y)
        { 
            if (X == 1 && Y == 1)
               Movement = Move(X * Y, 1.5f);
            if (X == -1 && Y == 1)
                Movement = Move(X * Y, 1.5f);
            if (X == 1 && Y == -1)
                Movement = Move(X * Y, 1.5f);
            if (X == -1 && Y == -1)
                Movement = Move(X * Y, 1.5f);
            if (X == 1 && Y == 0)
                Movement = Move(X, 1f);
            if (X == -1 && Y == 0)
                Movement = Move(X, 1f);
            if (X == 0 && Y == 1)
                Movement = Move(Y, 1f);
            if (X == 0 && Y == -1)
                Movement = Move(Y, 1f);
            if (X == 0 && Y == 0)
                Movement = 0;
            return Movement;
        }

        float Move(float move, float delSpeed)
        {
            return (move / delSpeed * MoveSpeed);
        }
    }
}
