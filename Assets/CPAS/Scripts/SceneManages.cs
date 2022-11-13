using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SceneManages : MonoBehaviour
{
    public GameObject WheelChair;

    private bool isWheelchairOn = false;

    public Text wheelchairBtnTxt;
    public Image wheelchairBtnImage;
    public Color onColor, offColor;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F11))
        {
            //WheelChair.SetActive(!WheelChair.activeSelf);
            ToggleChairPressed();
        }
    }

    public void ToggleChairPressed()
    {
        isWheelchairOn = !isWheelchairOn;
        WheelChair.SetActive(isWheelchairOn);
        if (isWheelchairOn)
        {
            wheelchairBtnTxt.text = "TURN OFF";
            wheelchairBtnImage.color = onColor;
        }
        else
        {
            wheelchairBtnTxt.text = "TURN ON";
            wheelchairBtnImage.color = offColor;
        }
    }
}
