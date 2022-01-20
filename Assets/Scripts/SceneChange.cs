using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    [SerializeField] GameObject playerRed;
	[SerializeField] GameObject playerGreen;
	private bool greenIn;
	private bool redIn;
	public int buildIndex;
	
    // Start is called before the first frame update
    void Start()
    {
	    buildIndex = SceneManager.GetActiveScene().buildIndex;
	    Debug.Log(buildIndex);
	    greenIn = false;
	    redIn = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D other)
    {
	    if (other.gameObject == playerGreen)
	    {
		    Debug.Log("GreenIn");
		    greenIn = true;
	    }
	    
	    if (other.gameObject == playerRed)
	    {
		    Debug.Log("redIn");
		    redIn = true;
	    }

	    if (greenIn == true && redIn == true)
	    {
		    SceneManager.LoadScene(buildIndex+1);
	    }
    }
}