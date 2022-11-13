using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botanic_DoorTrigger : MonoBehaviour
{
    public Animator doorAnimator;


    bool isOpened;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !isOpened)
        {
            doorAnimator.SetTrigger("Open");
            isOpened = true;
        }
    }
}
