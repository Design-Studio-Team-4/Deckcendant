using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleHandler : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform enemy;

    // Start is called before the first frame update
    private static BattleHandler instance;
    public static BattleHandler GetInstance()
    {
        return instance;
    }
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        SpawnCombatant(true, player);
        SpawnCombatant(false, enemy);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

        }
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
