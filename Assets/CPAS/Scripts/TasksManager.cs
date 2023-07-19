using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TasksManager : MonoBehaviour
{
    public Task[] tasks;
    public Text tasksHints;
    public Transform Player;
    public GameObject[] arrows;
    private int currentTask=0;

    private void Start()
    {
        tasksHints.text = tasks[currentTask].taskString;
    }

    public void UpdateTask(int taskNo)
    {
        if (currentTask == taskNo)
        {
            currentTask++;
            if (currentTask < tasks.Length)
            {
                tasksHints.text = tasks[currentTask].taskString;

                for (int i = 0; i < tasks.Length; i++)
                {
                    if (i == currentTask)
                    {
                        tasks[i].taskObject.SetActive(true);
                    }
                    else
                    {
                        tasks[i].taskObject.SetActive(false);
                    }
                }
            }
            else
            {
                for (int i = 0; i < tasks.Length; i++)
                {
                    tasks[i].taskObject.SetActive(false);
                }
                // change the text to be Completed
                tasksHints.text = "Completed";
            }
        }
    }

    public void ResetPlayerPos(Transform pos)
    {
        Player.GetComponent<CharacterController>().enabled = false;
        Player.position = pos.position;
        Player.rotation = pos.rotation;
        Player.GetComponent<CharacterController>().enabled = true;
    }
}

[System.Serializable]
public class Task
{
    public GameObject taskObject;
    public string taskString;
}