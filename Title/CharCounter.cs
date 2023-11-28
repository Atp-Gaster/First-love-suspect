using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class CharCounter : MonoBehaviour
{
    public Flowchart flowchart;
    public int charLimit = 20;
    private string PlayerName;
    private int counter = 0;

    // Start is called before the first frame update
    void isExceedCharLimit()
    {
        PlayerName = flowchart.GetStringVariable("PlayerName");

        foreach (char c in PlayerName)
        {
            counter++;
        }

        if (counter > charLimit)
        {
            flowchart.SetBooleanVariable("limitExceed", true);
        }
        else
        {
            flowchart.SetBooleanVariable("limitExceed", false);
        }

        counter = 0;

    }
}
