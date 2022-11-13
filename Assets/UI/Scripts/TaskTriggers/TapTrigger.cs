using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapTrigger : MonoBehaviour
{
    bool isTriggered;

    public GameObject TapWater;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !isTriggered)
        {
            TapWater.SetActive(true);
            GameplayHandler.instance.NextTask(0);
            isTriggered = true;
        }
    }
}
