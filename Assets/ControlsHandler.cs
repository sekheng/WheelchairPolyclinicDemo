using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlsHandler : MonoBehaviour
{

    public Slider MoveSlider;
    public Slider RotateSlider;

    private void Start()
    {
        MoveSlider.value = Controls.MoveSpeed;
        RotateSlider.value = Controls.RotateSpeed;
    }

    public void ChangeMoveValue()
    {
        Controls.MoveSpeed = (int)MoveSlider.value;
        Debug.Log(Controls.MoveSpeed);

    }

    public void ChangeRotateValue()
    {
        Controls.RotateSpeed = (int)RotateSlider.value;
        Debug.Log(Controls.RotateSpeed);
    }
}
