using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    [SerializeField] GameObject playerRed;
	[SerializeField] GameObject playerGreen;
	private bool greenIn;
	private bool redIn;
	public int currentBuildIndex;
	public GameObject winPanel;
	
    // Start is called before the first frame update
    void Start()
    {
	    currentBuildIndex = SceneManager.GetActiveScene().buildIndex;
	    Debug.Log(currentBuildIndex);
	    greenIn = false;
	    redIn = false;
	    winPanel.SetActive((false));
    }

    // Update is called once per frame
    void Update()
    {
	    if (greenIn == true && redIn == true && currentBuildIndex==8 )
	    {
		    Time.timeScale = 0;
		    winPanel.SetActive(true);
	    }
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

	    if (greenIn == true && redIn == true && currentBuildIndex < 8)
	    {
		    SceneManager.LoadScene(currentBuildIndex+1);
	    }
    }
}