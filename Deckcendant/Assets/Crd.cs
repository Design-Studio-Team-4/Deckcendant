using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crd : MonoBehaviour
{
    public string cardName = "A Card";
    // * variable for the art here *
    public int efType = 0;
    public int efPower = 5;
    public int cost = 1;
    public GameObject CrdText;
    bool isFocus;
    public GameObject hand;


    void Start()
    {
        isFocus = false;
        CrdText.GetComponent<TextMesh>().text = cardName;

    }

    void Update()
    {

    }

    public string description()
    {
        switch (efType)
        {
            case 0:
                return "Deal " + efPower + " Damage";
            case 1:
                return "Gain " + efPower + " Block";
            case 2:
                return "Restore " + efPower + " HP";

        }
        return "Deal " + efPower + " Damage";

    }
    public void checkFocus()
    {
        int handfocus = hand.GetComponent<getFocus>();  
    }
}
