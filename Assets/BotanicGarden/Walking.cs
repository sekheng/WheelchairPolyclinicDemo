using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour
{
    public float TimeToChangeDirection = 3;
    public float Speed;
    private bool changeDir;
    private void Awake()
    {
        StartCoroutine(WalkingDelay());
    }

    private void Update()
    {
        if (!changeDir)
        {
            Speed = 1;
            transform.Translate(transform.forward * Speed * Time.deltaTime, Space.World);
        }
        else
        {
            Speed = -1;
            transform.Translate(transform.forward * -Speed * Time.deltaTime, Space.World);
        }
    }

    IEnumerator WalkingDelay()
    {
        while (true)
        {
            yield return new WaitForSeconds(TimeToChangeDirection);
            changeDir = !changeDir;
            transform.localEulerAngles =
                new Vector3(0, transform.localEulerAngles.y + 180, 0);
        }
    }
}
