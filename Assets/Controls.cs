using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    static Controls instance;
    public static Controls Instance
    {
        get { return instance; }
    }
    public float MoveSpeed = 2;
    public float RotateSpeed = 0.5f;
    // Start is called before the first frame update
    void Awake()
    {
        if (instance != null)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        //MoveSpeed = 2;
        //RotateSpeed = 1;
        //PlayerPrefs.SetInt("MoveSpeed", MoveSpeed);
        //PlayerPrefs.SetInt("RotateSpeed", RotateSpeed);
    }
}
