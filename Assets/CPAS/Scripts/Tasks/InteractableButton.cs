using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractableButton : MonoBehaviour
{
    public TasksManager manager;
    public int taskNo;
    public bool shouldCompleteTask = true;

    public UnityEvent actionOnButtonTap;

    public KeyCode key = KeyCode.Keypad1;
    public KeyCode altKey = KeyCode.Alpha1;

    private void Update()
    {
        if (Input.GetKeyUp(key) || Input.GetKeyUp(altKey))
        {
            actionOnButtonTap.Invoke();
            if (shouldCompleteTask)
            {
                manager.UpdateTask(taskNo);
            }
        }
    }
}