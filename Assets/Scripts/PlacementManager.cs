using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlacementManager : MonoBehaviour
{
    [SerializeField]
    private GameObject Mouse, cellIndicator;

    [SerializeField]
    private InputManager inputManager;
    [SerializeField]
    private Grid grid;

    [SerializeField]
    private Vector3Int gridPosition;

    private void Update()
    {
        Vector3 mousePosition = inputManager.GetSelectedMapPosition();
        Mouse.transform.position = mousePosition;
        gridPosition = grid.WorldToCell(mousePosition);
        cellIndicator.transform.position = grid.CellToWorld(gridPosition);

    }
}