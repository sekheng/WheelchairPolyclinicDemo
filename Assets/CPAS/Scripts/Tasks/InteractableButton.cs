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

    public ButtonType buttonType = ButtonType.BLUE;

    private void Update()
    {
        if (buttonType == ButtonType.BLUE)
        {
            if (Input.GetKeyUp(KeyCode.Alpha1) || Input.GetKeyUp(KeyCode.Alpha3) ||
            Input.GetKeyUp(KeyCode.Keypad1) || Input.GetKeyUp(KeyCode.Keypad3))
            {
                actionOnButtonTap.Invoke();
                if (shouldCompleteTask)
                {
                    manager.UpdateTask(taskNo);
                }
            }
        }
        else if (buttonType == ButtonType.RED)
        {
            if (Input.GetKeyUp(KeyCode.Keypad2) || Input.GetKeyUp(KeyCode.Alpha2))
            {
                actionOnButtonTap.Invoke();
                if (shouldCompleteTask)
                {
                    manager.UpdateTask(taskNo);
                }
            }
        }
    }
}

public enum ButtonType
{
    BLUE,
    RED
}