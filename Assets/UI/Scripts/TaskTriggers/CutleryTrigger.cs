using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutleryTrigger : MonoBehaviour
{
    // public Animator fridgeAnimator;

    public GameObject BlueButton;
    public GameObject RedButton;

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
            if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3))
            {
                // fridgeAnimator.SetTrigger("Open");
                // fridgeAnimator.enabled = true;
                isOpened = true;
                BlueButton.SetActive(false);
                RedButton.SetActive(false);
                GameplayHandler.instance.NextTask(0);

                // GameplayHandler.instance.NextTask(0);

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
