using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class MainMenu1 : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("worked");

        SceneManager.LoadScene("Garage");
    }
    public void ExitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
