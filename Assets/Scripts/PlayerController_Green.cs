using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_Green : MonoBehaviour
{
    public float speed = 200f;
    private float horizontalInput; 
    private float verticalInput; 

    // Start is called before the first frame update
    void Start()
    {
        
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
            transform.Translate(Vector2.right * Time.deltaTime * speed * horizontalInput);

            verticalInput = Input.GetAxis("Vertical");
                transform.Translate(Vector2.up * Time.deltaTime * speed * verticalInput);
    }
}
