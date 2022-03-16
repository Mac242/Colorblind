using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    public PUZZLE_C _PuzzleC;
    public Puzzle_O _PuzzleO;
    public Puzzle_N _PuzzleN;
    public Puzzle_T _PuzzleT;
    public Puzzle_I _PuzzleI;
    public Puzzle_N2 _PuzzleN2;
    public Puzzle_U _PuzzleU;
    public Puzzle_E _PuzzleE;

    public GameObject door;
    public GameObject doorTwo;
    public GameObject doorTwoTwo;
    public GameObject arrow;

    public PlaceC  _PlaceC ;
    public PlaceO  _PlaceO ;
    public PlaceN  _PlaceN ;
    public PlaceT  _PlaceT ;
    public PlaceI  _PlaceI ;
    public PlaceN2 _PlaceN2;
    public PlaceU  _PlaceU ;
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
        if (_PuzzleC.completed == true && _PuzzleO.completed == true && _PuzzleN.completed == true &&
            _PuzzleT.completed == true && _PuzzleI.completed == true && _PuzzleN2.completed == true &&
            _PuzzleU.completed == true && _PuzzleE.completed)
        {
            door.SetActive(false);
            arrow.SetActive(true);
        }

        if (_PlaceC.cPlacedtrue == true && _PlaceO.oPlacedtrue == true && _PlaceN.nPlacedtrue == true &&
            _PlaceT.tPlacedtrue == true && _PlaceI.iPlacedtrue == true && _PlaceN2.n2Placedtrue &&
            _PlaceU.uPlacedtrue == true && _PlaceE.ePlacedtrue == true)
        {
            allLettersPlaced = true;
            doorTwo.SetActive(false);
            doorTwoTwo.SetActive(false);
        }
    }
}
