using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    public AudioSource audioSource, bgsource;
    public AudioClip click, bg, reward, fail;


    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            DestroyImmediate(gameObject);
        }
        //audioSource=GetComponent<AudioSource>();
    }
    public void Click()
    {
        audioSource.clip = click;
        audioSource.Play();
    }
    public void Bg()
    {
        DontDestroyOnLoad(gameObject);
        bgsource.Play();
    }
    public void Reward()
    {
        audioSource.clip = reward;
        audioSource.Play();
    }
    public void Fail()
    {
        audioSource.clip = fail;
        audioSource.Play();
    }

}

