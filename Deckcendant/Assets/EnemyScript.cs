using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public int yeet;
    public EnemyMoves YeetLol;


    string name;
    int type;
    int health;
    int block;
    int cooldown;
    private static System.Random rand = new System.Random();


    //public void TakeDamage(Card c) { health -= c.efPower; }

    public void ChooseAttack()
    {
        int i = rand.Next(/* NUMBER OF ATTACKS*/);
    }
    /*
    public void TakeDamage(Card c)
    {
        if (block - c.efPower <= 0) health -= block + c.efPower;
        else block -= c.efPower;
    }
    */



    public void ChooseMove()
    {
        int i = rand.Next(/* NUMBER OF MOVES*/);
        /* moves should have:
            -a string for the name
            -an integer to identify what it is
            -effect magnitude (how much damage, 
        */
    }



    // Start is called before the first frame update
    void Start()
    {
        YeetLol.YEET();
        Debug.Log(YeetLol.heal.name);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
