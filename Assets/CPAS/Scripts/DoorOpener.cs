using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    public Animator doorAnimator;
    bool isOpened;
    private void Start()
    {
        doorAnimator = transform.parent.gameObject.GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !isOpened)
        {
            doorAnimator.enabled = true;
            isOpened = true;
        }
    }
}
