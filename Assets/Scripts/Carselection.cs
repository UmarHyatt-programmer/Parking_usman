using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Carselection : MonoBehaviour
{
    public GameObject truck1, truck2, panal;
    public GameObject[] UnlockLevel;
    public static int totalUnlock = 1;
    public static int selectedLevel;

    public Button nextb, previousb;
    public static string selectcarname;
    void Start()
    {
        //  PlayerPrefs.SetInt("openedlevel",totalUnlock);
        Debug.Log(PlayerPrefs.GetInt("openedlevel"));
        for (int i = 0; i < PlayerPrefs.GetInt("openedlevel"); i++)
        {
            UnlockLevel[i].SetActive(false);
        }
    }
    public void Nextbutton()
    {
        nextb.interactable = false;
        previousb.interactable = true;

        truck1.SetActive(false);
        truck2.SetActive(true);

    }
    public void previousbutton()
    {
        nextb.interactable = true;
        previousb.interactable = false;

        truck1.SetActive(true);
        truck2.SetActive(false);
    }
    public void Selecrcar()
    {
        if (truck1.activeInHierarchy)
        {
            selectcarname = "truck1";
            Debug.Log("Truck 1 Selected");
            panal.SetActive(true);
        }
        if (truck2.activeInHierarchy)
        {
            selectcarname = "truck2";
            Debug.Log("Truck 2 Selected");
            panal.SetActive(true);
        }
    }
    public void LevelSelection(int x)
    {
        selectedLevel = x;
        SceneManager.LoadScene("GamePlay");
    }
    public void Home()
    {
        SceneManager.LoadScene("Main Menu");
    }
    public void BackGame()
    {
        SceneManager.LoadScene("Garage");
    }
}
