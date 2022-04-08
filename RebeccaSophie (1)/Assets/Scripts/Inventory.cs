using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Inventory : MonoBehaviour
{
    public bool AllPianoPieces;
    public bool yaay;
    public float PianoPieces;
    public float JigsawPuzzle;

    // Start is called before the first frame update
    void Start()
    {
        PianoPieces = 0f;
        JigsawPuzzle = 0f;
        AllPianoPieces = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (PianoPieces == 3f)
        {
            AllPianoPieces = true;
        }

        if (JigsawPuzzle == 5f)
        {
            yaay = true;
        }

    }
    
}
