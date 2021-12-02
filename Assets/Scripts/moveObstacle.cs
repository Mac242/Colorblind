using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObstacle : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 30f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((Vector3.down) * speed * Time.deltaTime);
    }
}
