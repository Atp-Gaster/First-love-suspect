using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Weekender : MonoBehaviour
{
    public Flowchart flowchart;

    public int Day;
    public bool isWeekend;

    void WeekendCal()
    {
        Day = flowchart.GetIntegerVariable("Day");

        if (((Day + 1) % 7) == 0 || (Day % 7 == 0))
        {
            isWeekend = true;
        }
        else
        {
            isWeekend = false;
        }

        flowchart.SetBooleanVariable("isWeekend", isWeekend);
    }
}
