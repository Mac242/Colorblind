using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle_N : MonoBehaviour
{
    public GameObject top;
    public GameObject bottom;
    public GameObject complete;
    public bool completed;
    public ParticleSystem _ParticleSystem;
    public GameObject letterComplete;
    private bool emitting;
    private float counting;

    // Start is called before the first frame update
    void Start()
    {
        complete.SetActive(false);
        top.SetActive(true);
        bottom.SetActive(true);
        completed = false;
        letterComplete.SetActive(false);
        emitting = false;
        counting = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        CountDown();
        
        if (emitting == true && counting < 0)
        {
            letterComplete.SetActive(false);
            top.SetActive(false);
            bottom.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("N"))
        {
            Debug.Log("N Created");
            complete.SetActive(true);
            completed = true;
            DoEmit();
            emitting = true;
            letterComplete.SetActive(true);
        }
    }
    void DoEmit()
    {
        _ParticleSystem.Emit(100);
    }

    private void CountDown()
    {
        if (emitting == true)
        {
            counting -= Time.deltaTime;
        }
        
    }
}
