using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class AllowanceScript : MonoBehaviour
{
    public Flowchart flowchart;

    private int Day;
    private int Money;
    private int Time;

    public int ALLOWANCEPERWEEK; 

    void allowanceAdd()
    {
        Day = flowchart.GetIntegerVariable("Day");
        Money = flowchart.GetIntegerVariable("Money");
        Time = flowchart.GetIntegerVariable("Time");

        if ((Day - 1) % 7 == 0 && Time == 0)
        {
            Money += ALLOWANCEPERWEEK;
        }

        flowchart.SetIntegerVariable("Money", Money);
    }
}
