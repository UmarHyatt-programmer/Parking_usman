using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GAMECONTROLLER : MonoBehaviour
{
    public GameObject truck1, trcuk2, trcukHolder;
    public GameObject level1, level2, level3, level4, level5, level6, level7, level8, level9, level10;
    public GameObject level1Pos, level2Pos, level3Pos, level4Pos, level5Pos, level6Pos, level7Pos, level8Pos, level9Pos, level10Pos;
    Carselection carselection;
    public void Awake()
    {
        SoundManager.instance.bgsource.mute=true;
    }
    public void Start()
    {
        Debug.Log(PlayerPrefs.GetInt("openedlevel"));
        if (Carselection.selectedLevel == 1)
        {
            level1.SetActive(true);
            trcukHolder.transform.position = level1Pos.transform.position;
            trcukHolder.transform.rotation = level1Pos.transform.rotation; 
        }
        if (Carselection.selectedLevel == 2)
        {
            level2.SetActive(true);
            trcukHolder.transform.position = level2Pos.transform.position;
            trcukHolder.transform.rotation = level2Pos.transform.rotation; 

        }
        if (Carselection.selectedLevel == 3)
        {
            level3.SetActive(true);
            trcukHolder.transform.position = level3Pos.transform.position;
            trcukHolder.transform.rotation = level3Pos.transform.rotation; 
        }
        if (Carselection.selectedLevel == 4)
        {
            level4.SetActive(true);
            trcukHolder.transform.position = level4Pos.transform.position;
            trcukHolder.transform.rotation = level4Pos.transform.rotation; 
        }
        if (Carselection.selectedLevel == 5)
        {
            level5.SetActive(true);
            trcukHolder.transform.position = level5Pos.transform.position;
            trcukHolder.transform.rotation = level5Pos.transform.rotation; 
        }
        if (Carselection.selectedLevel == 6)
        {
            level6.SetActive(true);
            trcukHolder.transform.position = level6Pos.transform.position;
            trcukHolder.transform.rotation = level6Pos.transform.rotation; 

        }
        if (Carselection.selectedLevel == 7)
        {
            level7.SetActive(true);
            trcukHolder.transform.position = level7Pos.transform.position;
            trcukHolder.transform.rotation = level7Pos.transform.rotation; 
        }
        if (Carselection.selectedLevel == 8)
        {
            level8.SetActive(true);
            trcukHolder.transform.position = level8Pos.transform.position;
            trcukHolder.transform.rotation = level8Pos.transform.rotation; 
        }
        if (Carselection.selectedLevel == 9)
        {
            level9.SetActive(true);
            trcukHolder.transform.position = level9Pos.transform.position;
            trcukHolder.transform.rotation = level9Pos.transform.rotation; 
        }
        if (Carselection.selectedLevel == 10)
        {
            level10.SetActive(true);
            trcukHolder.transform.position = level10Pos.transform.position;
            trcukHolder.transform.rotation = level10Pos.transform.rotation; 
        }
        if (Carselection.selectcarname == "truck1")
        {
            truck1.SetActive(true);
        }
        if (Carselection.selectcarname == "truck2")
        {
            trcuk2.SetActive(true);
        }
    }
}
