using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SwapCharacters : MonoBehaviour
{
    bool swap;
    public GameObject Girl;
    public GameObject penguin;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (swap)
        {
            penguin.GetComponent<NavMeshAgent>().enabled = true;
            Girl.GetComponent<NavMeshAgent>().enabled = false;
            penguin.GetComponent<Follow>().enabled = false;
            Girl.GetComponent<Follow>().enabled = true;
        }

        if (!swap)
        {
            penguin.GetComponent<NavMeshAgent>().enabled = false;
            Girl.GetComponent<NavMeshAgent>().enabled = true;
            penguin.GetComponent<Follow>().enabled = true;
            Girl.GetComponent<Follow>().enabled = false;
        }
    }

    void checkcharacters()
    {
        swap = !swap;
    }
}
