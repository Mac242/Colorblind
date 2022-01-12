using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform player;
    public Transform target;
    public float maxRange;
    public BoxCollider2D boxColliderTop;
    public BoxCollider2D boxColliderBottom;
    public BoxCollider2D boxColliderLeft;
    public BoxCollider2D boxColliderRight;
    
    // Start is called before the first frame update
    void Start()
    {
        maxRange = 10f;
        Cursor.visible = false;
        boxColliderBottom.enabled = false;
        boxColliderTop.enabled = false;
        boxColliderLeft.enabled = false;
        boxColliderRight.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        var heading = player.position - target.position;

        if (heading.sqrMagnitude > maxRange * maxRange)
        {
            Debug.Log("to Far");
            boxColliderBottom.enabled = true;
            boxColliderTop.enabled = true;
            boxColliderLeft.enabled = true;
            boxColliderRight.enabled = true;
        }
        else
        {
            boxColliderBottom.enabled = false;
            boxColliderTop.enabled = false;
            boxColliderLeft.enabled = false;
            boxColliderRight.enabled = false;
        }
    }
}
