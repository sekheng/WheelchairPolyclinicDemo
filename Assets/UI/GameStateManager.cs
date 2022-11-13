using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameStateManager : MonoBehaviour
{
    public static GameStateManager Instance { get; private set; }
    public GameObject blueBtn;
    public GameObject redBtn;
    bool expectInput = false;
    public GameObject avatar;
    public GameObject outsideLift;
    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.

        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    private GameStateTrigger _gameState;

    public GameStateTrigger GameState
    {
        get => _gameState;
        set
        {
            _gameState = value;
        }
    }


    public GameStateTrigger IntialGameState;

    public TextMeshProUGUI taskText;
    
    // Start is called before the first frame update
    void Start()
    {
        SetGameState(IntialGameState);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (expectInput) {
            if (Input.GetKey(KeyCode.Alpha1) || Input.GetKey(KeyCode.Keypad1)|| Input.GetKey(KeyCode.Alpha3) || Input.GetKey(KeyCode.Keypad3)){
                SetGameState(TriggerManager.Instance.IncrementGameState());
                blueBtn.SetActive(false);
                redBtn.SetActive(false);

                if (GameState.gameState == 4) { //lift handler
                    print("moving up");
                    //SetGameState(TriggerManager.Instance.ForceGameState(4),true);
                    avatar.transform.position = outsideLift.transform.position;
                }
                expectInput = false;
            }
        }
    }

    public void SetGameState(GameStateTrigger gst, bool force = false) {
      
        if (gst.gameState == 0 || (gst.gameState - GameState.gameState) == 1 || force) //failsafe to prevent sequence breaking
        {
            print("set to:" + gst.gameState);
            GameState = gst;
            taskText.text = GameState.gameTask;
            //print("text set");
            if (GameState.numButtons >= 1) {
                expectInput = true;
                blueBtn.SetActive(true);
                blueBtn.GetComponent<OptionButton>().SetOptionText(GameState.option1);
            }

            if (GameState.numButtons == 2)
            {
                expectInput = true;
                redBtn.SetActive(true);
                redBtn.GetComponent<OptionButton>().SetOptionText(GameState.option2);
            }
        }
    }
}
