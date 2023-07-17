using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnCollide : MonoBehaviour
{
    [SerializeField, Tooltip("To play this audio source on collide")]
    AudioSource SFX;

    [SerializeField, Tooltip("The gameobject tags to play the sound on collide")]
    string[] tags;

    [SerializeField, Tooltip("False means if the collider's tag doesnt belong in the list, play sound effect. Vice versa")]
    bool isIncludeFlag = true;


    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other);
        foreach (var tag in tags)
        {
            int isSame = tag.CompareTo(other.gameObject.tag);
            if (isSame == 0)
            {
                    if (isIncludeFlag)
                    {
                        if (!SFX.isPlaying)
                        {
                            SFX.Play();
                        Debug.Log("play at: " + other.name);
                        }
                    }
                    // this means the it is colliding with a gameobject that has this tag, just jump out of it
                    return;
            }
        }
        if (!SFX.isPlaying && !isIncludeFlag)
        {
            SFX.Play();
            Debug.Log("play at: " + other.name);
        }
    }
}
