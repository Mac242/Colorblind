using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager_easy : MonoBehaviour
{
    public PUZZLE_C _PuzzleC;
    
    public Puzzle_N _PuzzleN;
    
    public Puzzle_I _PuzzleI;
    
    
    public Puzzle_E _PuzzleE;

    public GameObject door;
    public GameObject doorTwo;
    public GameObject doorTwoTwo;
    public GameObject arrow;

    public PlaceC  _PlaceC ;
    public PlaceN  _PlaceN ;
    public PlaceI  _PlaceI ;
    public PlaceE  _PlaceE ;

    public bool allLettersPlaced;
    
    // Start is called before the first frame update

    void Start()
    {
        door.SetActive(true);
        doorTwo.SetActive(true);
        doorTwoTwo.SetActive(true);
        arrow.SetActive(false);
        allLettersPlaced = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (_PuzzleC.completed == true &&  _PuzzleN.completed == true && _PuzzleI.completed == true && _PuzzleE.completed)
        {
            door.SetActive(false);
            arrow.SetActive(true);
        }

        if (_PlaceC.cPlacedtrue == true &&  _PlaceN.nPlacedtrue == true && _PlaceI.iPlacedtrue == true &&
             _PlaceE.ePlacedtrue == true)
        {
            allLettersPlaced = true;
            doorTwo.SetActive(false);
            doorTwoTwo.SetActive(false);
        }
    }
}

