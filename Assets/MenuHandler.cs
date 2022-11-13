using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
    public GameObject MainMenuPanel;
    public GameObject SettingsPanel;


    public void On_Menu_Click()
    {
        SettingsPanel.SetActive(false);
    }

    public void On_Quit_Click()
    {
        Application.Quit();
        // SettingsPanel.SetActive(false);
    }


    public void On_Settings_Click()
    {
        // MainMenuPanel.SetActive(false);
        SettingsPanel.SetActive(true);
    }

    //On_1
    public void On_Button_1()
    {
        SceneManager.LoadScene("CPAS");
    }

    //On_6
    public void On_Button_6()
    {
        SceneManager.LoadScene("HDB");
    }

    //On_8
    public void On_Button_8()
    {
        SceneManager.LoadScene("BotanicGarden");
    }




}
