using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVTrigger : MonoBehaviour
{

    // public Animator fridgeAnimator;

    public GameObject BlueButton;
    public GameObject RedButton;

    public GameObject Video1;
    public GameObject Video2;

    bool isOpened;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !isOpened)
        {
            BlueButton.SetActive(true);
            RedButton.SetActive(true);
        }
        // BlueButton.SetActive(true);
        // if (other.gameObject.tag == "Player" && !isOpened)
        // {
        //     fridgeAnimator.SetTrigger("Open");
        //     isOpened = true;
        // }
    }


    private void OnTriggerStay(Collider other)
    {
        if (BlueButton.activeSelf && !isOpened)
        {
            if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1))
            {
                // fridgeAnimator.SetTrigger("Open");
                // fridgeAnimator.enabled = true;
                isOpened = true;
                BlueButton.SetActive(false);
                RedButton.SetActive(false);
                Video1.SetActive(true);
                GameplayHandler.instance.NextTask(0);

                // GameplayHandler.instance.NextTask(0);

            }
            else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3))
            {
                isOpened = true;
                BlueButton.SetActive(false);
                RedButton.SetActive(false);
                Video2.SetActive(true);
                GameplayHandler.instance.NextTask(0);
            }

        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            BlueButton.SetActive(false);
            RedButton.SetActive(false);
        }


    }
}
