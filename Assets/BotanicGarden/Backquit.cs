using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Backquit : MonoBehaviour
{
    public GameObject SettingPage;

    public Slider MoveSpeed, RotSpeed;

    public bool isMainMenu;
    public void OnValueChangeMoveSpeed()
    {
        PlayerPrefs.SetFloat("MoveSpeed", MoveSpeed.value);   
    }
    public void OnValueChangeRotSpeed()
    {
        PlayerPrefs.SetFloat("RotSpeed", RotSpeed.value);
    }

    public void SettingsStatus(bool status)
    {
        SettingPage.SetActive(status);
    }

    private void Awake()
    {
        if (isMainMenu)
        {
            if (PlayerPrefs.HasKey("MoveSpeed"))
            {
                MoveSpeed.value = PlayerPrefs.GetFloat("MoveSpeed");
            }
            else
            {
                MoveSpeed.value = 0;
            }
            if (PlayerPrefs.HasKey("RotSpeed"))
            {
                RotSpeed.value = PlayerPrefs.GetFloat("RotSpeed");
            }
            else
            {
                RotSpeed.value = 0;
            }
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void GoToMenu()
    {
        Application.LoadLevel("MainMenu");
    }
    public void GoToScene(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
}
