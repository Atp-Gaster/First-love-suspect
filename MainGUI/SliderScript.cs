using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class SliderScript : MonoBehaviour
{
    public Flowchart flowchart;

    public Slider INT_Slider;
    public Slider CON_Slider;
    public Slider CHA_Slider;
    public Slider FUN_Slider;
    public Slider CRE_Slider;

//    int intINT = flowchart.GetIntegerVariable("INT");
//    int intCHA = flowchart.GetIntegerVariable("CHA");
//    int intCON = flowchart.GetIntegerVariable("CON");
//    int intFUN = flowchart.GetIntegerVariable("FUN");
//    int intCRE = flowchart.GetIntegerVariable("CRE");

    void updateAttribute()
    {
        float INT = (float)(flowchart.GetIntegerVariable("INT"));
        float CHA = (float)(flowchart.GetIntegerVariable("CHA"));
        float CON = (float)(flowchart.GetIntegerVariable("CON"));
        float FUN = (float)(flowchart.GetIntegerVariable("FUN"));
        float CRE = (float)(flowchart.GetIntegerVariable("CRE"));

        INT_Slider.value = INT;
        CHA_Slider.value = CHA;
        CON_Slider.value = CON;
        FUN_Slider.value = FUN;
        CRE_Slider.value = CRE;
    }
}
