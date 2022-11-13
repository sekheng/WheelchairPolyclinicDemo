using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botanic_GameLevelHandler : MonoBehaviour, ILevelHandler
{
    public GameObject Task1;
    public GameObject Task2;
    public GameObject Task3;
    public GameObject Task4;

    public void Checkpoint(int CurrentTaskNo)
    {
        switch (CurrentTaskNo)
        {

            case 0:
                DirectionalArrow.instance.target = Task1.transform;
                Debug.Log("Enabled Task 1");
                break;
            case 1:
                AudioManager.instance.Play("Achievement Sound");
                DirectionalArrow.instance.target = Task2.transform;
                Debug.Log("Enabled Task 2");
                break;
            case 2:
                AudioManager.instance.Play("Achievement Sound");

                DirectionalArrow.instance.target = Task3.transform;
                Debug.Log("Enabled Task 3");
                break;
            case 3:
                AudioManager.instance.Play("Achievement Sound");

                DirectionalArrow.instance.target = Task4.transform;
                Debug.Log("Enabled Task 4");
                break;

            default:
                break;
        }
    }

}
