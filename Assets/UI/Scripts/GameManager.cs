using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    // public bool isMainMenu;
    // public bool isLevelSelection;
    // public bool isGameplay;
    // public bool isGamePaused;

    // public GameData GData;
    public int LevelSelected;

    public static GameManager instance;
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }
    }




    // public void UpdateCoins(Text[] coins)
    // {
    //     for (int i = 0; i < coins.Length; i++)
    //     {
    //         coins[i].text = GData.TotalCoins.ToString();
    //     }
    // }


    // public void ChangeScene(string sceneName)
    // {
    //     SceneManager.LoadScene(sceneName);
    // }
    // public void isGamePaused(bool status)
    // {
    //     if (status)
    //     {
    //         Time.timeScale = 0.0001f;
    //     }
    //     else
    //     {
    //         Time.timeScale = 1f;

    //     }
    // }
}