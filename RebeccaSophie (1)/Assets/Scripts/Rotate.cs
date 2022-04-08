using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] private GameObject Inventory;
    public bool piano;
    public float rotatespeed;
    // Start is called before the first frame update
    void Start()
    {
        rotatespeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0f,30f*rotatespeed*Time.deltaTime, 0f, Space.Self);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (piano)
            {
                Inventory.GetComponent<Inventory>().PianoPieces++; ;
            }
            
            if (!piano)
            {
                Inventory.GetComponent<Inventory>().JigsawPuzzle++;
            }
        }
    }

}
