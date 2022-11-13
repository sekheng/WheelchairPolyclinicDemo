using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftTrigger : MonoBehaviour
{
    public Animator liftAnimator;
    public Animator doorAnimator;

    public GameObject BlueButton;


    bool isOpened;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !isOpened)
            BlueButton.SetActive(true);
        // if (other.gameObject.tag == "Player" && !isOpened)
        // {
        //     liftAnimator.SetTrigger("Open");
        //     isOpened = true;
        // }
    }


    private void OnTriggerStay(Collider other)
    {
        if (BlueButton.activeSelf && !isOpened)
        {
            if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1))
            {
                // ChairMovement.instance.gameObject.GetComponent<Rigidbody>().isKinematic = true;
                liftAnimator.SetTrigger("Up");
                // liftAnimator.enabled = true;
                isOpened = true;
                BlueButton.SetActive(false);
                Invoke("OpenDoor", 1.5f);

                GameplayHandler.instance.NextTask(0);

            }

        }
    }

    public void OpenDoor()
    {
        doorAnimator.SetTrigger("Open");
        // ChairMovement.instance.gameObject.GetComponent<Rigidbody>().isKinematic = false;

    }


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
            BlueButton.SetActive(false);

    }
}
