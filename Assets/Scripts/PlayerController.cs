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
    private LineRenderer _lineRenderer;
    public float maxRange;
    private bool toFar;
    public BoxCollider2D boxColliderTop;
    public BoxCollider2D boxColliderBottom;
    public BoxCollider2D boxColliderLeft;
    public BoxCollider2D boxColliderRight;
    
    // Start is called before the first frame update
    void Start()
    {
        _lineRenderer = GetComponent<LineRenderer>();
        maxRange = 13f;
        
        boxColliderBottom.enabled = false;
        boxColliderTop.enabled = false;
        boxColliderLeft.enabled = false;
        boxColliderRight.enabled = false;
        toFar = false;

    }

    // Update is called once per frame
    void Update()
    {
        Cursor.visible = false;
        
        LineSetUp();
        
        if (toFar == true)
        {
            _lineRenderer.enabled = true;
            
            for (int i = 0; i < points.Length; i++)
            {
                _lineRenderer.SetPosition(i, points[i].position);
            }
        }

        if (toFar== false)
        {
            _lineRenderer.enabled = false;
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
            _lineRenderer.positionCount = points.Length;
        }
    }
}
