using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiningTrigger : MonoBehaviour
{
    public GameObject SnackPlate;
    public GameObject BlueButton;

    bool isOpened;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !isOpened)
        {
            BlueButton.SetActive(true);
        }
    }


    private void OnTriggerStay(Collider other)
    {
        if (BlueButton.activeSelf && !isOpened)
        {
            if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1))
            {
                isOpened = true;
                SnackPlate.SetActive(true);
                BlueButton.SetActive(false);

                GameplayHandler.instance.NextTask(0);
            }

        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            BlueButton.SetActive(false);
        }


    }
}
