using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharControllerSchool : MonoBehaviour
{
    public List<AudioClip> Clips = new List<AudioClip>();
    public float Rot, Mov;

    private AudioSource _audio;

    private void Awake()
    {
        _audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        // Vector3 stickInput = new Vector3(0, 0f, 
        //     Input.GetAxisRaw("Vertical")* PlayerPrefs.GetFloat("MoveSpeed"));
        GetComponent<Rigidbody>().velocity = transform.forward * Input.GetAxisRaw("Vertical") * PlayerPrefs.GetFloat("MoveSpeed");
        transform.Rotate(0, Input.GetAxisRaw("Horizontal") * PlayerPrefs.GetFloat("RotSpeed"), 0);
        
        // if (Input.GetKey(KeyCode.KeypadDivide) || Input.GetKey(KeyCode.UpArrow))
        // {
        //     GetComponent<Rigidbody>().velocity = transform.forward * Mov;
        //     Debug.Log("forward");
        // }
        // if (Input.GetKey(KeyCode.DownArrow))
        // {
        //     GetComponent<Rigidbody>().velocity = transform.forward * -Mov;
        //     Debug.Log("backward");
        // }
        // if (Input.GetKey(KeyCode.KeypadMultiply) || Input.GetKey(KeyCode.LeftArrow))
        // {
        //     Debug.Log("left");
        //     transform.Rotate(0, -Rot, 0);
        // }
        // if (Input.GetKey(KeyCode.KeypadPlus) || Input.GetKey(KeyCode.RightArrow))
        // {
        //     transform.Rotate(0, Rot, 0);
        //     Debug.Log("right");
        // }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Wall"))
        {
            
            _audio.PlayOneShot(Clips[0]);
        }
        if (collision.gameObject.tag.Equals("Tree"))
        {
            _audio.PlayOneShot(Clips[1]);
        }
        if (collision.gameObject.tag.Equals("People"))
        {
            _audio.PlayOneShot(Clips[2]);
        }
    }
}
