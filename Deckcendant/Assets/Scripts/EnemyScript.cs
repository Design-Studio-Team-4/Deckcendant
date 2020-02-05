﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public int yeet;
    public EnemyMoves YeetLol;

    string name;
    int type;
    int maxHealth;
    int currentHealth;
    int block;
    int cooldown;

    EnemyMoves.Move currentMove = new EnemyMoves.Move();

    private static System.Random rand = new System.Random();

    public void TakeDamage(Crd c)
    {
        if (block - c.efPower <= 0) currentHealth -= block + c.efPower;
        else block -= c.efPower;
    }

    public void ChooseMove()
    {
        int i = rand.Next(/* NUMBER OF MOVES*/ 3);
        currentMove = EnemyMoves.instance.moveList[i];
        cooldown += currentMove.cost;
    }

    public void TakeAction()
    {
        //execute move
        switch (currentMove.type)
        {
            case 0: // if attack
                Player.instance.TakeDamage(currentMove.power); // *** change instance to the actual player 
                break;
            case 1: // if block
                block += currentMove.power;
                break;
            case 2: // if heal
                if (currentHealth + currentMove.power > maxHealth) currentHealth = maxHealth;
                else currentHealth += currentMove.power;
                break;
        }

        //choose move
        ChooseMove();

    }
    
    public void die()
    {
        Destroy(this);
    }

    // Start is called before the first frame update
    void Start()
    {
        //YeetLol.YEET();
        //Debug.Log(YeetLol.heal.name);
    }

    // Update is called once per frame
    void Update()
    {
        if (cooldown == 0)
        {
            TakeAction();
        }

        if (currentHealth >= 0) die();

    }
}
