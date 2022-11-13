using UnityEngine;
public class ChairMovement : MonoBehaviour
{
    public CharacterController characterController;

    Vector3 vMovement;
    Vector3 vVelocity;
    public float speed = 4f;
    public float gravity = 9f;

    float xMove;
    float zMove;

    // Start is called before the first frame update
    void Start()
    {
        // rb = GetComponent<Rigidbody>(); //rb equals the rigidbody on the player
    }

    // Update is called once per frame
    void Update()
    {
        xMove = Input.GetAxisRaw("Horizontal"); // d key changes value to 1, a key changes value to -1
        zMove = Input.GetAxisRaw("Vertical"); // w key changes value to 1, s key changes value to -1
    }

    private void FixedUpdate()
    {
        if (characterController.isGrounded)
        {
            vVelocity.y = 0f;
        }
        else
        {
            vVelocity.y -= gravity * Time.deltaTime;
        }

        vMovement = characterController.transform.forward * zMove;

        characterController.transform.Rotate(Vector3.up * xMove * Controls.RotateSpeed * (100f * Time.deltaTime));

        characterController.Move(vMovement * Controls.MoveSpeed * Time.deltaTime);
        characterController.Move(vVelocity);
    }
}