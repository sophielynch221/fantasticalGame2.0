using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishJigsaw : MonoBehaviour
{
    [SerializeField] private GameObject piece1;
    [SerializeField] private GameObject piece2;
    [SerializeField] private GameObject piece3;
    [SerializeField] private GameObject piece4;
    [SerializeField] private GameObject piece5;
    [SerializeField] private GameObject piece6;

    [SerializeField] private GameObject placeholder1;
    [SerializeField] private GameObject placeholder2;
    [SerializeField] private GameObject placeholder3;
    [SerializeField] private GameObject placeholder4;
    [SerializeField] private GameObject placeholder5;
    [SerializeField] private GameObject placeholder6;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(piece1.GetComponent<RectTransform>().anchoredPosition == placeholder1.GetComponent<RectTransform>().anchoredPosition &&
           piece2.GetComponent<RectTransform>().anchoredPosition == placeholder2.GetComponent<RectTransform>().anchoredPosition &&
           piece3.GetComponent<RectTransform>().anchoredPosition == placeholder3.GetComponent<RectTransform>().anchoredPosition &&
           piece4.GetComponent<RectTransform>().anchoredPosition == placeholder4.GetComponent<RectTransform>().anchoredPosition &&
           piece5.GetComponent<RectTransform>().anchoredPosition == placeholder5.GetComponent<RectTransform>().anchoredPosition &&
           piece6.GetComponent<RectTransform>().anchoredPosition == placeholder6.GetComponent<RectTransform>().anchoredPosition)
        {
            Debug.Log("Well Done");
        }
    }
}
