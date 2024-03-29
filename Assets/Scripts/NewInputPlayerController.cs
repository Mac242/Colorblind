using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Haptics;

public class NewInputPlayerController : MonoBehaviour
{
    public Vector2 movementInput;
    private Vector2 movementInputX;
    private float jumpInput;
    public float speed = 50f;
    public float jumpForce;
    public bool onGround;
    

    // Start is called before the first frame update
    void Start()
    {
        jumpForce = 65;
        Debug.Log(onGround);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * speed * movementInputX);
        transform.Translate(Vector2.right * Time.deltaTime * speed * movementInput.x);
        transform.Translate(Vector2.up * Time.deltaTime * speed * movementInput.y);
        transform.Translate(Vector2.up * Time.deltaTime * jumpForce * jumpInput);

        Cursor.visible = false;

    }
    
    public void OnMove(InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>();
    }

    public void OnMoveX(InputAction.CallbackContext context)
    {
        movementInputX = context.ReadValue<Vector2>();
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        if (onGround == true)
        {
            jumpInput = context.ReadValue<float>();
            Debug.Log("JUMP");
        }
        else
        {
            jumpInput = 0;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.CompareTag("Ground") || CompareTag("Player"))
        {
            onGround = true;
        }
        else
        {
            onGround = false;
        }
    }
}
