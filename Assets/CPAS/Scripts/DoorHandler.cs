using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorHandler : MonoBehaviour
{
    public ITweenMagic tween;

    public float timeToAutoClose = 14;

    void Start()
    {
        tween = GetComponent<ITweenMagic>();
    }

    public void OpenDoor()
    {
        tween.PlayForwardRotation();
        StartCoroutine(CloseDoor());
    }

    IEnumerator CloseDoor()
    {
        yield return new WaitForSecondsRealtime(timeToAutoClose);
        tween.PlayReverseRotation();
    }
}