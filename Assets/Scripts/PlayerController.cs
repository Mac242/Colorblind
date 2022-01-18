using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEditor;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public Transform player;
    public Transform target;
    [SerializeField] private Transform[] points;
    private LineRenderer lineRenderer;
    public float maxRange;
    private bool toFar;
    public BoxCollider2D boxColliderTop;
    public BoxCollider2D boxColliderBottom;
    public BoxCollider2D boxColliderLeft;
    public BoxCollider2D boxColliderRight;
    
    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        maxRange = 13f;
        Cursor.visible = false;
        boxColliderBottom.enabled = false;
        boxColliderTop.enabled = false;
        boxColliderLeft.enabled = false;
        boxColliderRight.enabled = false;
        toFar = false;

    }

    // Update is called once per frame
    void Update()
    {

        if (toFar == true)
        {
            lineRenderer.enabled = true;
            
            for (int i = 0; i < points.Length; i++)
            {
                lineRenderer.SetPosition(i, points[i].position);
            }
        }

        if (toFar== false)
        {
            lineRenderer.enabled = false;
        }

        var heading = player.position - target.position;

        if (heading.sqrMagnitude > maxRange * maxRange)
        {
            Debug.Log("to Far");
            
            toFar = true;
            boxColliderBottom.enabled = true;
            boxColliderTop.enabled = true;
            boxColliderLeft.enabled = true;
            boxColliderRight.enabled = true;
        }

        else
        {
            toFar = false;
            boxColliderBottom.enabled = false;
            boxColliderTop.enabled = false;
            boxColliderLeft.enabled = false;
            boxColliderRight.enabled = false;
        }

        void LineSetUp()
        {
            lineRenderer.positionCount = points.Length;
            this.points = points;
        }
    }
}
