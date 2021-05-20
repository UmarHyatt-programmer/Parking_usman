using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class MainMenu1 : MonoBehaviour
{
    void Start()
    {
        Debug.Log(PlayerPrefs.GetInt("openedlevel"));
    }
    public void StartGame()
    {
        SoundManager.instance.Click();
        SceneManager.LoadScene("Garage");
    }
    public void ExitGame()
    {
        SoundManager.instance.Click();
        Debug.Log("Quit");
        Application.Quit();
    }
    public void bgsound()
    {
        SoundManager.instance.Bg();
    }
    public void Privacypolicy()
    {
        SoundManager.instance.Click();
    }
    public void Share()
    {
        SoundManager.instance.Click();
    }
    public void Moregames()
    {
        SoundManager.instance.Click();
    }
    public void Addbutton()
    {
        SoundManager.instance.Click();
    }
    public void Removeads()
    {
        SoundManager.instance.Click();
    }
}
