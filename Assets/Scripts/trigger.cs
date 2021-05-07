using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public GameObject LevelComplete, LevelFailed;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ParkingPoint")
        {
            SoundManager.instance.Reward();
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
