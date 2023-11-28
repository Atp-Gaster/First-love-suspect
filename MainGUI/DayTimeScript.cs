using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class DayTimeScript : MonoBehaviour
{
    public Flowchart flowchart;
    public GameObject objtxt;
    public Text txt;

    void setDayTime()
    {
        int Time = flowchart.GetIntegerVariable("Time");
        int Day = flowchart.GetIntegerVariable("Day");
        string TimeTxt;
        string DayTxt;

        if (Time == 0)
        {
            TimeTxt = "เช้า";
        }
        else if (Time == 1)
        {
            TimeTxt = "กลางวัน";
        }
        else if (Time == 2)
        {
            TimeTxt = "เลิกเรียน";
        }
        else if (Time == 3)
        {
            TimeTxt = "เย็น";
        }
        else
        {
            TimeTxt = "ไม่มีข้อมูล";
        }

        switch (Day % 7)
        {
            case 1:
                DayTxt = "จันทร์";
                break;
            case 2:
                DayTxt = "อังคาร";
                break;
            case 3:
                DayTxt = "พุธ";
                break;
            case 4:
                DayTxt = "พฤหัส";
                break;
            case 5:
                DayTxt = "ศุกร์";
                break;
            case 6:
                DayTxt = "เสาร์";
                break;
            case 0:
                DayTxt = "อาทิตย์";
                break;
            default:
                DayTxt = "(?)";
                break;
        }

        txt.text = "วัน" + DayTxt + "ที่ " + Day.ToString() + " | ช่วง" + TimeTxt;
    }
}
