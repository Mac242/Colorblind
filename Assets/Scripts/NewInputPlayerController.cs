using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewInputPlayerController : MonoBehaviour
{
    private Vector2 movementInput;
    public float speed = 5f;
  

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector2.right * Time.deltaTime * speed * movementInput.x);
        transform.Translate(Vector2.up * Time.deltaTime * speed * movementInput.y);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>();
    }
    
}
