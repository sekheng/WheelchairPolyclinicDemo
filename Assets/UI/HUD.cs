using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUD : MonoBehaviour
{
    public GameObject taskObject;

    public TasksManager tasks;

    private bool isArrowOn = true;

    public void ToggleTaskObject()
    {
        taskObject.SetActive(!taskObject.activeSelf);
    }

    public void ToggleArrows()
    {
        isArrowOn = !isArrowOn;
        foreach (var arrow in tasks.arrows)
        {
            arrow.SetActive(isArrowOn);
        }
    }
}