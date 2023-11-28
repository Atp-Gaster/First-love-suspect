using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class MoneyScript : MonoBehaviour
{
    public Flowchart flowchart;
    public GameObject objtxt;
    public Text txt;

    void setMoney()
    {
        int Money = flowchart.GetIntegerVariable("Money");

        txt.text = "เงิน: " + Money + " zotein";
    }
}
