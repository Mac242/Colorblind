using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObstacle : MonoBehaviour
{
    public float speed;

    public float moveX;

    public float moveY;
    
    // Start is called before the first frame update
    void Start()
    {
        speed = 30f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(moveX, moveY) * speed * Time.deltaTime);
    }
}
