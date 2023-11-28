using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class EndOfTrialVarLoad : MonoBehaviour
{
    public Flowchart flowchart;
    public GameObject objtxt;
    public Text txt;

    void setEndStat()
    {
        int RELA_Rider = flowchart.GetIntegerVariable("RELA_Rider");
        int RELA_Reika = flowchart.GetIntegerVariable("RELA_Reika");
        int RELA_Yuuki = flowchart.GetIntegerVariable("RELA_Yuuki");
        int RELA_Noirden = flowchart.GetIntegerVariable("RELA_Noirden");
        int RELA_Plen = flowchart.GetIntegerVariable("RELA_Plen");
        int Day = flowchart.GetIntegerVariable("Day");
        int Time = flowchart.GetIntegerVariable("Time");

        txt.text = "Day = " + Day + "\t\t\tTime = " + Time +  "\nRider = " + RELA_Rider + "\t\tReika = " + RELA_Reika + "\nYuuki = " + RELA_Yuuki + "\t\tNoirden = " + RELA_Noirden + "\nPhloen = " + RELA_Plen;
    }
}
