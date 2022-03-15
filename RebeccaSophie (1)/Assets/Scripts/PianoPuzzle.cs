using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PianoPuzzle : MonoBehaviour
{
    public Image Right1;
    public Image Right2;
    public Image Right3;
    public Image Right4;
    public Image Right5;
    public Image Right6;

    // Start is called before the first frame update
    void Start()
    {
        Right1.GetComponent<Image>().material.color = Color.white;
        Right2.GetComponent<Image>().material.color = Color.white;
        Right3.GetComponent<Image>().material.color = Color.white;
        Right4.GetComponent<Image>().material.color = Color.white;
        Right5.GetComponent<Image>().material.color = Color.white;
        Right6.GetComponent<Image>().material.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void WrongKey()
    {
        Right1.GetComponent<Image>().material.color = Color.white;
        Right2.GetComponent<Image>().material.color = Color.white;
        Right3.GetComponent<Image>().material.color = Color.white;
        Right4.GetComponent<Image>().material.color = Color.white;
        Right5.GetComponent<Image>().material.color = Color.white;
        Right6.GetComponent<Image>().material.color = Color.white;
    }

    public void FirstKey()
    {
        Right1.GetComponent<Image>().material.color = Color.green;
    }

    public void SecondKey()
    {
        if(Right1.GetComponent<Image>().material.color == Color.green)
        {
            Right2.GetComponent<Image>().material.color = Color.green;
        }
       
        else
        {
            WrongKey();
        }
    }

    public void ThirdKey()
    {
        if (Right1.GetComponent<Image>().material.color == Color.green)
        {
            if (Right2.GetComponent<Image>().material.color == Color.green)
            {
                Right3.GetComponent<Image>().material.color = Color.green;
            }
        } 
        
        else
        {
            WrongKey();
        }
    }

    public void ForthKey()
    {
        if (Right1.GetComponent<Image>().material.color == Color.green)
        {
            if (Right2.GetComponent<Image>().material.color == Color.green)
            {
                if (Right3.GetComponent<Image>().material.color == Color.green)
                {
                    Right4.GetComponent<Image>().material.color = Color.green;
                }
            }
        }
       
        else
        {
            WrongKey();
        }
    }

    public void FifthKey()
    {
        if (Right1.GetComponent<Image>().material.color == Color.green)
        {
            if (Right2.GetComponent<Image>().material.color == Color.green)
            {
                if (Right3.GetComponent<Image>().material.color == Color.green)
                {
                    if (Right4.GetComponent<Image>().material.color == Color.green)
                    {
                        Right5.GetComponent<Image>().material.color = Color.green;
                    }
                }
            }
        }
       
        else
        {
            WrongKey();
        }
    }

    public void SixthKey()
    {
        if (Right1.GetComponent<Image>().material.color == Color.green)
        {
            if (Right2.GetComponent<Image>().material.color == Color.green)
            {
                if (Right3.GetComponent<Image>().material.color == Color.green)
                {
                    if (Right4.GetComponent<Image>().material.color == Color.green)
                    {
                        if(Right5.GetComponent<Image>().material.color == Color.green)
                        {
                            Right6.GetComponent<Image>().material.color = Color.green;
                        }
                    }
                }
            }
        }
        
        else
        {
            WrongKey();
        }
    }
}
