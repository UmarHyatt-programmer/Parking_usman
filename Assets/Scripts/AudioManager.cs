using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public AudioSource myFx;

    public AudioClip clickFx;
   
    public void ClickSound()
    {
        myFx.PlayOneShot(clickFx);
    }

}
