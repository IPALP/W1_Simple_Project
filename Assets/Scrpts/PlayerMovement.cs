using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement: MonoBehaviour
{
    public float speed = 45f;
    public float turnSpeed = 60f;
    public InputAction MoveAction;
    public Vector2 moveInput;

    void Start()
    {
        MoveAction.Enable();
    }
    void Update()
    {
        moveInput = MoveAction.ReadValue<Vector2>();
        transform.Translate(Vector3.forward * moveInput.y * Time.deltaTime * speed);
        transform.Rotate(Vector3.up, moveInput.x * Time.deltaTime * turnSpeed);
    }
}