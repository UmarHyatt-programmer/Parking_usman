using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UIscript : MonoBehaviour
{

    public GameObject PausePanal;
    public GameObject PauseButton, Restart, HomeButton, NextButton;

    public GameObject[] Nextlevel;
    bool GamePaused;
    // Start is called before the first frame update
    void Start()
    {
        GamePaused = false;
        Nextlevel[Carselection.selectedLevel - 1].SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        if (GamePaused)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
    public void PauseGame()
    {
        SoundManager.instance.Click();
        GamePaused = true;
        PausePanal.SetActive(true);
        PauseButton.SetActive(false);
    }

    public void ResumeGame()
    {
        SoundManager.instance.Click();
        GamePaused = false;
        PausePanal.SetActive(false);
        PauseButton.SetActive(true);
    }
    public void RestartGame()
    {
        SoundManager.instance.Click();
        SceneManager.LoadScene("GamePlay");
    }
    public void Home()
    {
        SoundManager.instance.Click();
        SoundManager.instance.bgsource.mute=false;
        SceneManager.LoadScene("Main Menu");
    }
    public void Next()
    {
        SoundManager.instance.Click();
        if (Carselection.selectedLevel == 10)
        {
            SceneManager.LoadScene("Main Menu");
        }
        else
        {
            Carselection.selectedLevel++;
            SceneManager.LoadScene("GamePlay");
        }
    }
    public void Gearhandle()
    {
        SoundManager.instance.Click();
    }
}