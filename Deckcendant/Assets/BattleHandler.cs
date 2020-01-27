using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleHandler : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform enemy;

    
    private static BattleHandler instance;
    private State state;

    public static BattleHandler GetInstance()
    {
        return instance;
    }

    private enum State
    {
       WaitingForPlayer,
       Busy,
    }

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        SpawnCombatant(true, player);
        SpawnCombatant(false, enemy);

        state = State.WaitingForPlayer;
    }

    // Update is called once per frame
    void Update()
    {
        if (state == State.WaitingForPlayer)
        {
            if (Input.GetKeyDown(KeyCode.Space))
                 {
                    state = State.Busy;
                    
                 }
        }
     
    }
    private void SpawnCombatant(bool isFriendly, Transform combatant)
    {
        Vector3 pos;
       
      /*  if (isFriendly)
        {
            pos = new Vector3(-5.0f, 0.0f, 0.0f);

        } else
        {
            pos = new Vector3(+5.0f, 0.0f, 0.0f);
        }*/
        Instantiate(combatant, combatant.position, combatant.transform.rotation);
    }
}
