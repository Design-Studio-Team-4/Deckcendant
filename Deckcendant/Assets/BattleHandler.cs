using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleHandler : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform enemy;

    // Start is called before the first frame update
    void Start()
    {
        SpawnCombatant(true, player);
        SpawnCombatant(false, enemy);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void SpawnCombatant(bool isFriendly, Transform combatant)
    {
        Vector3 pos;
       
        if (isFriendly)
        {
            pos = new Vector3(-5.0f, 0.0f, 0.0f);

        } else
        {
            pos = new Vector3(+5.0f, 0.0f, 0.0f);
        }
        Instantiate(combatant, pos, combatant.transform.rotation);
    }
}
