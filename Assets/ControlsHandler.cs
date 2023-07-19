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
        MoveSlider.value = Controls.Instance.MoveSpeed;
        RotateSlider.value = Controls.Instance.RotateSpeed;
    }

    public void ChangeMoveValue()
    {
        Controls.Instance.MoveSpeed = MoveSlider.value;
        //Debug.Log(Controls.MoveSpeed);
        //PlayerPrefs.SetInt("MoveSpeed", Controls.MoveSpeed);
    }

    public void ChangeRotateValue()
    {
        Controls.Instance.RotateSpeed = RotateSlider.value;
        //Debug.Log(Controls.RotateSpeed);
        //PlayerPrefs.SetInt("RotateSpeed", Controls.RotateSpeed);

    }
}
