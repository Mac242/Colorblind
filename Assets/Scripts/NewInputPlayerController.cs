using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewInputPlayerController : MonoBehaviour
{
    private Vector2 movementInput;
    public float speed = 5f;
    public bool collision;
  

    // Start is called before the first frame update
    void Start()
    {
        collision = false;
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector2.right * Time.deltaTime * speed * movementInput.x);
        transform.Translate(Vector2.up * Time.deltaTime * speed * movementInput.y);
        
        if (collision == true)
        {
            Gamepad.current.SetMotorSpeeds(0.75f, 1.5f);
            InputSystem.ResumeHaptics();
        }
        else
        {
            InputSystem.ResetHaptics();
        }
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>();
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            collision = true;
        }
        if (other.gameObject.CompareTag("Respawn"))
        {
            collision = true;
        }
    }
    
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            collision = false;
        }
        if (other.gameObject.CompareTag("Respawn"))
        {
            collision = false;
        }
    }
}
