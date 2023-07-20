using UnityEngine;

public class FreeCameraController : MonoBehaviour
{
    public Transform player; // The player's GameObject or Transform
    public float rotationSpeed = 3f;
    public float moveSpeed = 5f;

    private Vector3 offset;

    void Start()
    {
        if (player == null)
        {
            Debug.LogError("Player reference is not set in the FreeCameraController script!");
            return;
        }

        offset = transform.position - player.position;
    }

    void Update()
    {
        // Check if the player reference is set
        if (player == null)
            return;

        // Get mouse input for camera rotation
        float horizontalInput = Input.GetAxis("Mouse X");
        float verticalInput = Input.GetAxis("Mouse Y");

        // Rotate the camera around the player based on the mouse input
        transform.RotateAround(player.position, Vector3.up, horizontalInput * rotationSpeed);
        transform.RotateAround(player.position, transform.right, -verticalInput * rotationSpeed);

        // Get keyboard input for directional movement
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");

        // Move the player's position based on directional input
        Vector3 moveDirection = (player.forward * verticalMove + player.right * horizontalMove).normalized;
        player.position += moveDirection * moveSpeed * Time.deltaTime;

        // Update the camera position to maintain the offset from the player
        transform.position = player.position + offset;
    }
}
