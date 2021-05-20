using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public GameObject LevelComplete, LevelFailed;
    bool isComplete = false;
    void Start()
    {
        // Debug.Log("selected level"+ Carselection.selectedLevel);
        // Debug.Log("Opened level"+PlayerPrefs.GetInt("openedlevel"));

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ParkingPoint")
        {
            SoundManager.instance.Reward();
            Carselection.totalUnlock++;


            if (Carselection.selectedLevel >= PlayerPrefs.GetInt("openedlevel") - 1)
            {
                // Debug.Log("increment working");
                PlayerPrefs.SetInt("openedlevel", PlayerPrefs.GetInt("openedlevel") + 1);
                //isComplete = true;
            }

            // Debug.Log(PlayerPrefs.GetInt("openedlevel"));
            LevelComplete.SetActive(true);
            Time.timeScale = 0;
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "obsticles")
        {
            SoundManager.instance.Fail();
            LevelFailed.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
