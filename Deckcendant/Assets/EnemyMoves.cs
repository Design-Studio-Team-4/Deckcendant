using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoves : MonoBehaviour
{
    public class Move
    {
        public string name;
        int type;
        int power;
        int cost;

        Move(string n, int t, int p, int c)
        {
            name = n;
            type = t;
            power = p;
            cost = c;
        }

    }

   // Move punch = new Move("Punch", 0, 3, 3);
    ///Move defend = new Move("Block", 1, 1, 1);
   /// Move heal = new Move("Heal", 2, 2, 2);

    public void YEET()
    {
   //     Debug.log("YEET");
    }

}
