using UnityEngine;
using UnityEngine.SceneManagement;

public class UIHandler : MonoBehaviour
{
    public GameObject TaskPanel;
    public GameObject[] Arrows;

    public static UIHandler instance;
    private void Awake()
    {
        //DontDestroyOnLoad(gameObject);
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    public void OnTaskButton_Click()
    {
        TaskPanel.SetActive(!TaskPanel.activeSelf);
    }

    public void OnArrowButton_Click()
    {
        foreach (var arrow in Arrows)
        {
            arrow.SetActive(!arrow.activeSelf);
        }
    }


    public void OnMenuButton_Click()
    {
        SceneManager.LoadScene("Menu");
        //Menu
    }

    public void OnQuitButton_Click()
    {
        Application.Quit();
    }

    public void OnResetButton_Click()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        // SceneManager.LoadScene(SceneManager.ActiveScene);
    }



    public void LevelFailed()
    {
        // GameManager.instance.isGamePaused(false);
        // FailedPanel.SetActive(true);
    }

    public void LevelCompleted()
    {
        // GameManager.instance.isGamePaused(true);
        // CompletedPanel.SetActive(true);
    }
    public void LevelCompleted(float delay)
    {
        Invoke("LevelCompleted", delay);
    }

    public void NextLevel()
    {
        // GameManager.instance.LevelSelected++;
        // GameManager.instance.isGameplay = true;
        // SceneManager.LoadScene("LoadingScreen");

        // GameManager.instance.isGamePaused(false);
        GameManager.instance.LevelSelected++;
        // GameManager.instance.isGameplay = true;
        // GameManager.instance.isGameplay = true;
        // SceneManager.LoadScene("LoadingScreen");
    }

    public void ReplayLevel()
    {
        // GameManager.instance.isGamePaused(false);
        // SceneManager.LoadScene("NewGameplay");
    }

    public void HomeMenu()
    {
        // GameManager.instance.isGamePaused(false);
        // GameManager.instance.isGameplay = false;
        // GameManager.instance.ChangeScene("MainMenu");
    }


    public void OpenPausePanel()
    {
        // PausePanel.SetActive(true);
        // GameManager.instance.isGamePaused(true);
    }

    public void ClosePausePanel()
    {
        // PausePanel.SetActive(false);
        // GameManager.instance.isGamePaused(false);
    }

    public void OpenWatchVideoPanel()
    {
        // WatchVideoPanel.SetActive(true);
        // GameManager.instance.isGamePaused(true);
    }
    public void CloseWatchVideoPanel()
    {
        // GameManager.instance.isGamePaused(false);
        // WatchVideoPanel.SetActive(false);
    }

    public void OnWatchVideoSuccessful()
    {

        // GameManager.instance.isGamePaused(false);
        // TimeHandler.instance.check = true;'
        // TimeHandler.instance.timeLeft = 40f;'
        CloseWatchVideoPanel();
    }
    public void WatchVideo()
    {
        //GameManager.instance.RewardedAd();
    }
    public void NoThanks()
    {
        CloseWatchVideoPanel();
        LevelFailed();
    }

}
