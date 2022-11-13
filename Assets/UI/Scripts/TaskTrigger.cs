using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskTrigger : MonoBehaviour
{
    bool isTriggered;

    public Animator Task1_Door_Close_Anim;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !isTriggered)
        {
            if (Task1_Door_Close_Anim != null)
            {

                Task1_Door_Close_Anim.SetTrigger("Close");
            }
            GameplayHandler.instance.NextTask(0);
            isTriggered = true;
        }
    }
}
