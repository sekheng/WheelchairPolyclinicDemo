using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToiletDoorTrigger : MonoBehaviour
{
    bool isTriggered;

    public Animator ToiletDoor;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !isTriggered)
        {
            ToiletDoor.SetTrigger("Open");
            // GameplayHandler.instance.NextTask(0);
            isTriggered = true;
        }
    }
}
