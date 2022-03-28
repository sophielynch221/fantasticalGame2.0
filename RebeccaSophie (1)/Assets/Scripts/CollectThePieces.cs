using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectThePieces : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private GameObject JigsawPiece1;
    [SerializeField] private GameObject JigsawPiece2;
    [SerializeField] private GameObject JigsawPiece3;
    [SerializeField] private GameObject PianoPiece1;
    [SerializeField] private GameObject PianoPiece2;
    [SerializeField] private GameObject PianoPiece3;
    [SerializeField] private GameObject PianoPiece4;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(""))
        {

        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
