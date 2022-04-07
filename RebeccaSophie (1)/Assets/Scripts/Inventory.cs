using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private float PianoPieces;
    private float JigsawPuzzle;
    // Start is called before the first frame update
    void Start()
    {
        PianoPieces = 0f;
        JigsawPuzzle = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Piano"))
        {
            PianoPieces++;
        }

        if (other.gameObject.CompareTag("Jigsaw"))
        {
            JigsawPuzzle++;
        }
    }

    
}
