using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorToggle : MonoBehaviour
{
    [SerializeField, Tooltip("the toggled image")]
    Image image;
    [SerializeField, Tooltip("Color for is on")]
    Color onColor;
    [SerializeField, Tooltip("Color for is off")]
    Color offColor;
    [SerializeField, Tooltip("Toggle UI")]
    Toggle toggle;

    public void ToggleColor(bool isOn)
    {
        image.color = isOn ? onColor : offColor;
    }

    private void Start()
    {
        ToggleColor(toggle.isOn);
    }
}
