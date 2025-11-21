using UnityEngine;
using UnityEngine.InputSystem;



public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rigidBody;
    [SerializeField] float moveSpeed;
    [SerializeField] float jumpSpeed;
    Vector2 movementInput;
    Animator animator;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rigidBody.linearVelocity = new Vector3(movementInput.x * moveSpeed, rigidBody.linearVelocity.y, 0);
        animator.SetBool("isMoving", movementInput.magnitude > 0 ? true : false);
    }

    public void Move(InputAction.CallbackContext input)
    {
        movementInput = input.ReadValue<Vector2>();
    }

    public void Jump(InputAction.CallbackContext input)
    {
        if (input.started)
        {
            rigidBody.AddForce(Vector3.up * jumpSpeed, ForceMode2D.Impulse);
            animator.SetTrigger("jump");
        }
    }
}
