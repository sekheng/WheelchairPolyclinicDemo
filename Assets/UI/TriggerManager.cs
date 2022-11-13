using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerManager : MonoBehaviour
{
    public static TriggerManager Instance { get; private set; }
    public List<GameStateTrigger> GameStateTriggers;

    public GameStateTrigger finishedTrigger;
    // Start is called before the first frame update

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
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public GameStateTrigger IncrementGameState()
    {
        print(GameStateManager.Instance.GameState.gameState);
        if (GameStateManager.Instance.GameState.gameState + 1 <= GameStateTriggers.Count)
        {
            return (GameStateTriggers[GameStateManager.Instance.GameState.gameState + 1]);
        }
        else return finishedTrigger;
    }

    public GameStateTrigger ForceGameState(int gs)
    {
        return (GameStateTriggers[gs]);
    }
}
