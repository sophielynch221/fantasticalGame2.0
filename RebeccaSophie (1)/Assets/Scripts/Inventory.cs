using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Inventory : MonoBehaviour
{
    public bool yay;
    public bool yaay;
    public float PianoPieces;
    public float JigsawPuzzle;

    [SerializeField] private GameObject jigsawSign;
    [SerializeField] private GameObject PianoSign;



    // Start is called before the first frame update
    void Start()
    {
        PianoPieces = 0f;
        JigsawPuzzle = 0f;
        yay = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (PianoPieces == 3f)
        {
            yay = true;
        }

        if (JigsawPuzzle == 5f)
        {
            yaay = true;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Piano"))
        {
            PianoPieces++;
            other.gameObject.SetActive(false);
        }

        if (other.gameObject.CompareTag("Jigsaw"))
        {
            JigsawPuzzle++;

        }


    }
    
}
