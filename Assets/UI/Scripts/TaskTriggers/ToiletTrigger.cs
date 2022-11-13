using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class ToiletTrigger : MonoBehaviour
{

    public GameObject BlueButton;
    public PlayableDirector timeline;
    // public GameObject RedButton;

    bool isOpened;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !isOpened)
        {
            BlueButton.SetActive(true);
            // RedButton.SetActive(true);
        }
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
                timeline.gameObject.SetActive(true);
                StartCoroutine(StartTimeline((float)timeline.duration));
                // RedButton.SetActive(false);
                // GameplayHandler.instance.NextTask(0);

                // GameplayHandler.instance.NextTask(0);

            }

        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            BlueButton.SetActive(false);
            // RedButton.SetActive(false);
        }


    }


    IEnumerator StartTimeline(float seconds)
    {

        yield return new WaitForSeconds(seconds);
        GameplayHandler.instance.NextTask(0);
        timeline.gameObject.SetActive(false);


    }
}
