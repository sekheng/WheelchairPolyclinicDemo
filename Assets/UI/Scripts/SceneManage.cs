using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManage : MonoBehaviour
{
    public GameObject WheelChair;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F11))
        {
            WheelChair.SetActive(!WheelChair.activeSelf);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            Application.Quit();
        }
    }
}
