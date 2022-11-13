using UnityEngine;
using UnityEngine.UI;


public class GameplayHandler : MonoBehaviour
{
    public Levels[] levels;
    public GameObject Player;
    public Canvas PlayerCanvas;

    public int TaskNo;



    /// ui manager things 
    public Text TaskDescriptionText;

    public static GameplayHandler instance;



    private void Awake()
    {
        // DontDestroyOnLoad(gameObject);
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    void Start()
    {

        // StartCoroutine(StartTimeline());
        // TaskDescriptionText.text = levels[GameManager.instance.LevelSelected].TaskDescription[TaskNo];
        // OnNextTask();

        OnLevelStart();

        ActivePlayer();



    }

    public void OnLevelStart()
    {
        ActiveLevel();
        NextTask(0f);
        // ActiveEmenies();


    }

    void ActiveLevel()
    {
        levels[GameManager.instance.LevelSelected].LevelHandler.SetActive(true);
    }

    void ActivePlayer()
    {


        Player.transform.position = levels[GameManager.instance.LevelSelected].PlayerPos.position;
        Player.transform.rotation = levels[GameManager.instance.LevelSelected].PlayerPos.rotation;

        Player.SetActive(true);
        Debug.Log(levels[GameManager.instance.LevelSelected].PlayerPos.position);

        PlayerCanvas.enabled = true;


        // levels[GameManager.instance.LevelSelected].spawnEnemies.enabled = true;

    }

    public void NextTask(float delay)
    {
        if (levels[GameManager.instance.LevelSelected].TaskDescription.Length > TaskNo)
        {

            TaskDescriptionText.text = levels[GameManager.instance.LevelSelected].TaskDescription[TaskNo];
            if (levels[GameManager.instance.LevelSelected].LevelHandler.GetComponent<ILevelHandler>() != null)
            {
                // Debug.Log("1");
                levels[GameManager.instance.LevelSelected].LevelHandler.GetComponent<ILevelHandler>().Checkpoint(TaskNo);
            }
            TaskNo++;
        }
        else
        {
            Debug.Log("LevelComplete");
            // UIHandler.instance.LevelCompleted(delay);
            TaskNo = 0;
        }
    }
}

[System.Serializable]
public class Levels
{
    public string levelName;
    // public float levelTime;
    // public GameObject equippedWeapon;
    public Transform PlayerPos;
    public GameObject LevelHandler;
    public string[] TaskDescription;

}