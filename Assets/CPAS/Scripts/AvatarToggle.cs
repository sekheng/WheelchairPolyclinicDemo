using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarToggle : MonoBehaviour
{
    [SerializeField, Tooltip("List of all the avatars in the scene")]
    private GameObject[] avatars;

    // Start is called before the first frame update
    void Start()
    {
        avatars = GameObject.FindGameObjectsWithTag("People");
    }

    public void Toggle(bool _on)
    {
        foreach (var avatar in avatars)
        {
            avatar.SetActive(_on);
        }
    }
}
