using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class StatCollector {

    //Date-Time
    public float Time;
    public string Date;
    public int Week;

    //LifeStyle-Stat
    public int Money;
    public int R_Rider;
    public int R_Reika;
    public int R_Yuki;
    public int R_Norden;
    public int R_Pleun;

    #region Stat System   
    
    public void CheckStat()
    {
        Debug.Log("Time: " + Time);
        Debug.Log("Date: " + Date);
        Debug.Log("Week: " + Week);

        Debug.Log("Money: " + Money);

        Debug.Log("Rider: " + R_Reika);
        Debug.Log("Reika: " + R_Rider);
        Debug.Log("Yuki: " + R_Yuki);
        Debug.Log("Norden: " + R_Norden);
        Debug.Log("Pleun: " + R_Pleun);
    }

    #endregion

    #region Save&Load

    

    #endregion


}
