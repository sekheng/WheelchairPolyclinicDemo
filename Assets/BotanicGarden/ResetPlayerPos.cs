using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlayerPos : MonoBehaviour
{
public Transform Player;
private Vector3 pos;
void Awake()
{
    pos = Player.position;
}

public void ResetPos()
{
    Player.position = pos;
    Application.LoadLevel(Application.loadedLevel);
}
}
