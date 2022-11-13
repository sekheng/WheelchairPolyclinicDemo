using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLevelHandler : MonoBehaviour, ILevelHandler
{
    public GameObject Task1;
    public GameObject Task2;
    public GameObject Task3;
    public GameObject Task4;
    public GameObject Task5;
    public GameObject Task6;
    public GameObject Task7;
    public GameObject Task8;
    public GameObject Task9;
    public GameObject Task10;
    public GameObject Task11;
    public GameObject Task12;
    public GameObject Task13;
    public GameObject Task14;
    public GameObject Task15;
    public GameObject Task16;


    public void DisableAllTasks()
    {
        Task1.SetActive(false);
        Task2.SetActive(false);
        Task3.SetActive(false);
        Task4.SetActive(false);
        Task5.SetActive(false);
        Task6.SetActive(false);
        Task7.SetActive(false);
        Task8.SetActive(false);
        Task9.SetActive(false);
        Task10.SetActive(false);
        Task11.SetActive(false);
        Task12.SetActive(false);
        Task13.SetActive(false);
        Task14.SetActive(false);
        Task15.SetActive(false);
        Task16.SetActive(false);


    }

    public void Checkpoint(int CurrentTaskNo)
    {
        DisableAllTasks();
        switch (CurrentTaskNo)
        {

            case 0:
                // DirectionalArrow.instance.target = Task1.transform;
                Task1.SetActive(true);
                Debug.Log("Enabled Task 1");
                break;
            case 1:
                AudioManager.instance.Play("Achievement Sound");
                // DirectionalArrow.instance.target = Task2.transform;
                Task2.SetActive(true);
                Debug.Log("Enabled Task 2");
                break;
            case 2:
                AudioManager.instance.Play("Achievement Sound");
                Task3.SetActive(true);
                //DirectionalArrow.instance.target = Task3.transform;
                Debug.Log("Enabled Task 3");
                break;
            case 3:
                AudioManager.instance.Play("Achievement Sound");
                Task4.SetActive(true);

                // DirectionalArrow.instance.target = Task4.transform;
                Debug.Log("Enabled Task 4");
                break;
            case 4:
                AudioManager.instance.Play("Achievement Sound");
                // DirectionalArrow.instance.target = Task5.transform;
                Task5.SetActive(true);
                Debug.Log("Enabled Task 5");
                break;
            case 5:
                AudioManager.instance.Play("Achievement Sound");
                // DirectionalArrow.instance.target = Task5.transform;
                Task6.SetActive(true);
                Debug.Log("Enabled Task 5");
                break;
            case 6:
                AudioManager.instance.Play("Achievement Sound");
                // DirectionalArrow.instance.target = Task5.transform;
                Task7.SetActive(true);
                Debug.Log("Enabled Task 5");
                break;
            case 7:
                AudioManager.instance.Play("Achievement Sound");
                // DirectionalArrow.instance.target = Task5.transform;
                Task8.SetActive(true);
                Debug.Log("Enabled Task 5");
                break;
            case 8:
                AudioManager.instance.Play("Achievement Sound");
                // DirectionalArrow.instance.target = Task5.transform;
                Task9.SetActive(true);
                Debug.Log("Enabled Task 5");
                break;
            case 9:
                AudioManager.instance.Play("Achievement Sound");
                // DirectionalArrow.instance.target = Task5.transform;
                Task10.SetActive(true);
                Debug.Log("Enabled Task 5");
                break;
            case 10:
                AudioManager.instance.Play("Achievement Sound");
                // DirectionalArrow.instance.target = Task5.transform;
                Task11.SetActive(true);
                Debug.Log("Enabled Task 5");
                break;
            case 11:
                AudioManager.instance.Play("Achievement Sound");
                // DirectionalArrow.instance.target = Task5.transform;
                Task12.SetActive(true);
                Debug.Log("Enabled Task 5");
                break;
            case 12:
                AudioManager.instance.Play("Achievement Sound");
                // DirectionalArrow.instance.target = Task5.transform;
                Task13.SetActive(true);
                Debug.Log("Enabled Task 5");
                break;
            case 13:
                AudioManager.instance.Play("Achievement Sound");
                // DirectionalArrow.instance.target = Task5.transform;
                Task14.SetActive(true);
                Debug.Log("Enabled Task 5");
                break;
            case 14:
                AudioManager.instance.Play("Achievement Sound");
                // DirectionalArrow.instance.target = Task5.transform;
                Task15.SetActive(true);
                Debug.Log("Enabled Task 5");
                break;
            case 15:
                AudioManager.instance.Play("Achievement Sound");
                // DirectionalArrow.instance.target = Task5.transform;
                Task16.SetActive(true);
                Debug.Log("Enabled Task 5");
                break;

            default:
                break;
        }
    }

}
