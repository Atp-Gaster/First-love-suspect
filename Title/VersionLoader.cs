using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class VersionLoader : MonoBehaviour
{
    public Flowchart flowchart;
    public GameObject objtxt;
    public Text txt;
    string versionText;

    // Start is called before the first frame update
    void getVersion()
    {
        versionText = "Game Version: " + Application.version;
        Debug.Log(versionText);

        txt.text = versionText;
    }
}
