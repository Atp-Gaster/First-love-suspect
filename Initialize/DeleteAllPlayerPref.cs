using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteAllPlayerPref : MonoBehaviour
{
    // Start is called before the first frame update
    void clearPlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
    }
}
