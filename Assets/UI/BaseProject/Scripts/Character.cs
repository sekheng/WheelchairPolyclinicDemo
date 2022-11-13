using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] float _speed = 3;
    [SerializeField] float _rotateSpeed = 3;
    [SerializeField] Rigidbody _rigidbody;

    Vector3 _eulerAngleVelocity;
    Vector3 _velocity;

    GameStateTrigger gst;

    public float hyperMultipler = 1.0f;
   

    // Start is called before the first frame update
    void Start()
    {
        _speed *= hyperMultipler;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            _velocity = transform.forward;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            _velocity = -transform.forward;
        }
        else
        {
            _velocity = Vector3.zero;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _eulerAngleVelocity = new Vector3(0, -_rotateSpeed, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            _eulerAngleVelocity = new Vector3(0, _rotateSpeed, 0);
        }
        else
        {
            _eulerAngleVelocity = Vector3.zero;
        }
    }

    void FixedUpdate()
    {
        UpdateMove();
        Quaternion deltaRotation = Quaternion.Euler(_eulerAngleVelocity * Time.fixedDeltaTime);
        _rigidbody.MoveRotation(_rigidbody.rotation * deltaRotation);
    }

    private void UpdateMove()
    {
        _rigidbody.MovePosition(transform.position + _velocity * Time.deltaTime * _speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        gst = other.GetComponent<GameStateTrigger>();
        print(other.name);
        GameStateManager.Instance.SetGameState(gst);
    }
}
