using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class InputTestTk : MonoBehaviour
{
    public GameObject One,Three;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.Alpha1))
        {
            One.SetActive(true);
            Three.SetActive(false);
        }
        if (Input.GetButtonDown("Fire3")|| Input.GetKeyDown(KeyCode.Alpha3))
        {
            Three.SetActive(true);
            One.SetActive(false);
        }
    }
}
