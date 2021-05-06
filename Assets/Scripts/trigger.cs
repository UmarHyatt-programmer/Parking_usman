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
            LevelComplete.SetActive(true);
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "obsticles")
        {
            LevelFailed.SetActive(true);
        }
    }
}
