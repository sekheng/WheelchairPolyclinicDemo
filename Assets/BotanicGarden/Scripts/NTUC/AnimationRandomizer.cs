using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationRandomizer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float timeRange = Random.Range(0f, 1f);
        GetComponent<Animator>().Play(0, -1, timeRange);
    }
}
