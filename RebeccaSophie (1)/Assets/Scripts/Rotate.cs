using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
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
}
