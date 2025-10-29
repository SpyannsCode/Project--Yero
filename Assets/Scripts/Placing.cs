using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placing : MonoBehaviour
{
    public bool DebugMode = true;
    public GameObject ArrowNorth;
    public GameObject ArrowEast;
    public GameObject ArrowSouth;
    public GameObject ArrowWest;

    public GameObject SpawnHole;
    public GameObject WallBarricade;
    public GameObject EndGoal;
    public GameObject ExtraPlatform;
    public GameObject SpawnPosition;
    public GameObject Pitfall;

    [SerializeField]
    private GameObject CursorIndicator;

    private int CurrentTile;
    private List<GameObject> SpawnedObjects = new List<GameObject>();
    public int MaxAmountOfObjects = 7 + 1;
    private int i = 0;
    private GameObject arrow;
    void Update()
    {
        
        if (DebugMode)
        {
            if (Input.GetKeyDown("5"))
            {
                CurrentTile = 5;
            }
            if (Input.GetKeyDown("7"))
            {
                CurrentTile = 7;
            }
            if (Input.GetKeyDown("1"))
            {
                CurrentTile = -1;
            }
            if (Input.GetKeyDown("2"))
            {
                CurrentTile = -2;
            }
            if (Input.GetKeyDown("3"))
            {
                CurrentTile = -3;
            }
            if (Input.GetKeyDown("4"))
            {
                CurrentTile = -4;
            }
            if (Input.GetKeyDown("8"))
            {
                CurrentTile = 8;
            }
            if(Input.GetKeyDown("6"))
            {
                CurrentTile = 6;
            }
        }

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            CurrentTile = 1;
        }
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            CurrentTile = 2;
        }
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            CurrentTile = 3;
        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            CurrentTile = 4;
        }
        if (Input.GetMouseButtonDown(0))
        {
            print("Mouse Clicked");
            if (CurrentTile == 1)
            {
                arrow=Instantiate(ArrowNorth, CursorIndicator.transform.position, ArrowNorth.transform.rotation);
                i++;
            }
            if (CurrentTile == 2)
            {
                arrow=Instantiate(ArrowWest, CursorIndicator.transform.position, ArrowWest.transform.rotation);
                i++;
            }
            if (CurrentTile == 3)
            {
                arrow=Instantiate(ArrowSouth, CursorIndicator.transform.position, ArrowSouth.transform.rotation);
                i++;
            }
            if (CurrentTile == 4)
            {
                arrow=Instantiate(ArrowEast, CursorIndicator.transform.position, ArrowEast.transform.rotation);
                i++;
            }
            if (CurrentTile == 5)
            {
                arrow = Instantiate(SpawnHole, CursorIndicator.transform.position, SpawnHole.transform.rotation);
            }
            if (CurrentTile == 7)
            {
                arrow = Instantiate(EndGoal, CursorIndicator.transform.position, EndGoal.transform.rotation);
            }
            if(CurrentTile == 6)
            {
                arrow = Instantiate(Pitfall, CursorIndicator.transform.position, Pitfall.transform.rotation);
            }
            if (CurrentTile == 8)
            {
                arrow = Instantiate(ExtraPlatform, CursorIndicator.transform.position, ExtraPlatform.transform.rotation);
            }
            if(CurrentTile == -1)
            {
                arrow = Instantiate(WallBarricade, CursorIndicator.transform.position, Quaternion.Euler(new Vector3(0, 180, 0)));
            }
            if(CurrentTile==-2)
            {
                arrow = Instantiate(WallBarricade, CursorIndicator.transform.position, Quaternion.Euler(new Vector3(0, 270, 0)));
            }
            if(CurrentTile==-3)
            {
                arrow = Instantiate(WallBarricade, CursorIndicator.transform.position, Quaternion.Euler(new Vector3(0, 0, 180)));
            }
            if(CurrentTile==-4)
            {
                arrow = Instantiate(WallBarricade, CursorIndicator.transform.position, Quaternion.Euler(new Vector3(0, 90, 180)));
            }
            if (!DebugMode)
            {
                SpawnedObjects.Add(arrow);
                arrow.name = i.ToString();
                if (SpawnedObjects.Count == MaxAmountOfObjects)
                {
                    print("Destroying:");
                    print(arrow);
                    Destroy(SpawnedObjects[0]);
                    SpawnedObjects.RemoveAt(0);
                }
            }
        }
    }
    public void ToggleDebugMode()
    {
        if (DebugMode)
        {
            DebugMode = false;
        }
        else
        {
            DebugMode = true;
        }
    }
  /*  void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            CurrentTile = 1;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            CurrentTile = 2;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            CurrentTile = 3;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            CurrentTile = 4;
        }
    }*/
  public void ChangeTileByButton(int Tile)
    {
        CurrentTile = Tile;
    }
}
