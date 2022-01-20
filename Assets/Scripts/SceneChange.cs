using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    [SerializeField] GameObject playerRed;
	[SerializeField] GameObject playerGreen;
	private bool greenIn;
	private bool redIn;
	public int currentBuildIndex;
	
    // Start is called before the first frame update
    void Start()
    {
	    currentBuildIndex = SceneManager.GetActiveScene().buildIndex;
	    Debug.Log(currentBuildIndex);
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
		    SceneManager.LoadScene(currentBuildIndex+1);
	    }
    }
}