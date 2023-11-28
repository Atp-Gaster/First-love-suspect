using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;   

public class MainmenuController : MonoBehaviour
{
    public AudioClip[] SFXList;
    public AudioMixer audioMixer;

    public float SFXVolume_ = 0;
    public float BGMVolume_ = 0;

    //SFXList
    public void PlayClickBotton()
    {
        this.GetComponent<AudioSource>().PlayOneShot(SFXList[0]);        
    }

    public void PlayBGMSFX()
    {
        this.GetComponent<AudioSource>().PlayOneShot(SFXList[1]);
    }


    //SFXController
    public void SetMasterVolume(float MasterVolume)
    {
        Debug.Log(MasterVolume);
        audioMixer.SetFloat("MasterVolume", MasterVolume);
    }

    public void SetSFXVolume(float SFXVolume)
    {
        Debug.Log(SFXVolume);
        audioMixer.SetFloat("SFXVolume", SFXVolume);
    }

    public void SetBGVolume(float BGMVolume)
    {
        this.BGMVolume_ = BGMVolume;
        Debug.Log(BGMVolume);
        audioMixer.SetFloat("BGMVolume", BGMVolume);
        Debug.LogWarning("Send Value: " + BGMVolume_);
    }      

}
