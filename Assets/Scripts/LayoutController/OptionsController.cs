using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class OptionsController : MonoBehaviour
{
    public Button btnOn;
    public Button btnOff;
    public void soundSettingON(){
        AudioSource[] audios = FindObjectsOfType<AudioSource>();
        foreach (AudioSource a in audios)
        {
            a.Play();
        }
    }
    public void soundSettingOFF(){
        AudioSource[] audios = FindObjectsOfType<AudioSource>();
        foreach (AudioSource a in audios)
        {
            a.Pause();
        }
    }
    public void ReturnMenu(){
        SceneManager.LoadScene("Menu");
    }
}
