using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
                instance = new GameObject("GameManager").AddComponent<GameManager>(); //create game manager object if required
            return instance;
        }
    }

    private static GameManager instance = null;

    private void Awake()
    {
        if (instance)
        {
            DestroyImmediate(gameObject); //Delete duplicate
        }
        else
        {
            instance = this; //Make this object the only instance
            DontDestroyOnLoad(gameObject); //Set as do not destroy

            if (!PlayerPrefs.HasKey("openedlevel"))
            {
                PlayerPrefs.SetInt("score", 0);
            }
        }
    }
}
