using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextToggle : MonoBehaviour
{
    [SerializeField, Tooltip("The Toggle UI")]
    Toggle toggle;
    [SerializeField, Tooltip("On Text")]
    string onText;
    [SerializeField, Tooltip("Off Text")]
    string offText;
    [SerializeField, Tooltip("The Text UI")]
    TextMeshProUGUI textMeshPro;

    // Start is called before the first frame update
    void Start()
    {
        ToggleText(toggle.isOn);
    }

    public void ToggleText(bool isOn)
    {
        textMeshPro.text = isOn? onText : offText;
    }
}
