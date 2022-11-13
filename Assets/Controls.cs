using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    public static int MoveSpeed;
    public static int RotateSpeed;
    // Start is called before the first frame update
    void Awake()
    {
        MoveSpeed = 4;
        RotateSpeed = 1;
    }
}
