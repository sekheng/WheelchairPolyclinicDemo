using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botanic_TaskTrigger : MonoBehaviour
{
    bool isTriggered;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !isTriggered)
        {
            GameplayHandler.instance.NextTask(0);
            isTriggered = true;
        }
    }
}
