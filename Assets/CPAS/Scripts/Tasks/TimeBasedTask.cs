using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeBasedTask : MonoBehaviour
{
    public Text timerText;
    [Tooltip("In seconds")]
    public float time;
    public int taskNo;
    public TasksManager manager;

    void Start()
    {
        StartCoroutine(timer());
    }

    IEnumerator timer()
    {
        timerText.gameObject.SetActive(true);
        while (time > 0)
        {
            yield return new WaitForSeconds(1);
            time--;
            timerText.text = time + "secs";
        }
        timerText.gameObject.SetActive(false);
        manager.UpdateTask(taskNo);
    }
}