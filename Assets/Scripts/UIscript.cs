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
            Time.timeScale = 1;
        }
        else
        {
            Time.timeScale = 2;
        }
    }
    public void PauseGame()
    {
        GamePaused = true;
        PausePanal.SetActive(true);
        PauseButton.SetActive(false);
    }

    public void ResumeGame()
    {
        GamePaused = false;
        PausePanal.SetActive(false);
        PauseButton.SetActive(true);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene("GamePlay");
    }
    public void Home()
    {
        SceneManager.LoadScene("Main Menu");
    }
    public void Next()
    {
        if (Carselection.selectedLevel == 10)
        {
            SceneManager.LoadScene("Main Menu");
        }
        else
        {
            Carselection.selectedLevel++;
            SceneManager.LoadScene("GamePlay");
            Carselection.totalUnlock++;
            PlayerPrefs.SetInt("openedlevel",Carselection.totalUnlock);

        }
    }
}