using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level10Handler : MonoBehaviour, ILevelHandler
{
    // public bool hasRope;
    public GameObject windowTrigger;
    public Transform windowOutsidePosition;

    public Transform playerTransform;
    // Start is called before the first frame update

    private void Update()
    {
        // if (hasRope)
        // {
        //     this.WindowTrigger.SetActive(true);
        // }
    }
    void ILevelHandler.Checkpoint(int CurrentTaskNo)
    {
        switch (CurrentTaskNo)
        {
            case 2:
                Debug.Log("2");
                windowTrigger.SetActive(true);
                break;
            case 3:
                Debug.Log("3");
                // GameManager.instance.isGamePaused(true);
                playerTransform.position = windowOutsidePosition.position;
                // GameManager.instance.isGamePaused(false);
                playerTransform.gameObject.SetActive(true);
                break;

            default:
                break;
        }
    }
}
