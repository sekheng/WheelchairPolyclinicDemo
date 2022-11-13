using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HDB_DoorTrigger : MonoBehaviour
{
    public Animator doorAnimator;

    public GameObject BlueButton;


    bool isOpened;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !isOpened)
            BlueButton.SetActive(true);
        // if (other.gameObject.tag == "Player" && !isOpened)
        // {
        //     doorAnimator.SetTrigger("Open");
        //     isOpened = true;
        // }
    }


    private void OnTriggerStay(Collider other)
    {
        if (BlueButton.activeSelf && !isOpened)
        {
            if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1))
            {
                doorAnimator.SetTrigger("Open");
                AudioManager.instance.Play("Door Open");
                // doorAnimator.enabled = true;
                isOpened = true;
                BlueButton.SetActive(false);

                // GameplayHandler.instance.NextTask(0);

            }

        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
            BlueButton.SetActive(false);

    }
}
