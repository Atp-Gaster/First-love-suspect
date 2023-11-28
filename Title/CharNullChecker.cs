using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class CharNullChecker : MonoBehaviour
{
    public Flowchart flowchart;
    private string PlayerName;
    private int counter = 0;

    void isNotEntered()
    {
        Debug.Log("Method Pass: isNotEntered");
        PlayerName = flowchart.GetStringVariable("PlayerName");

        foreach (char c in PlayerName)
        {
            counter++;
        }

        Debug.Log("counter: " + counter);

        if (counter == 0)
        {
            flowchart.SetBooleanVariable("NotEntered", true);
        }
        else
        {
            flowchart.SetBooleanVariable("NotEntered", false);
        }
    }
}
