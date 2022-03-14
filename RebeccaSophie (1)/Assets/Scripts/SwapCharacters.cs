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
        swap = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (swap)
        {
            //so penguin would follow
            penguin.GetComponent<NavMeshAgent>().enabled = true;
            penguin.GetComponent<Follow>().enabled = false;

            //so girl isnt following
            Girl.GetComponent<NavMeshAgent>().enabled = false;
            Girl.GetComponent<Follow>().enabled = true;

            //girl can run
            Girl.GetComponent<NavMeshAgent>().enabled = false;
            Girl.GetComponent<Follow>().enabled = true;
          //  Girl.GetComponent<ThirdPersonController>().enabled = true;
            Girl.GetComponent<CharacterController>().enabled = true;

            //penguin cant run
            penguin.GetComponent<NavMeshAgent>().enabled = true;
            penguin.GetComponent<Follow>().enabled = false;
           // penguin.GetComponent<ThirdPersonController>().enabled = false;
            penguin.GetComponent<CharacterController>().enabled = false; 
        }

        if (!swap)
        {
            // so penguin wont follow
            penguin.GetComponent<NavMeshAgent>().enabled = false;
            penguin.GetComponent<Follow>().enabled = true;

            // so girl wont run
            Girl.GetComponent<NavMeshAgent>().enabled = true;
            Girl.GetComponent<Follow>().enabled = false;

            //penguin can run
            penguin.GetComponent<NavMeshAgent>().enabled = false;
            penguin.GetComponent<Follow>().enabled = true;
            //penguin.GetComponent<ThirdPersonController>().enabled = true;
            penguin.GetComponent<CharacterController>().enabled = true;

            //girl cant run
            Girl.GetComponent<NavMeshAgent>().enabled = true;
            Girl.GetComponent<Follow>().enabled = false;
          //  Girl.GetComponent<ThirdPersonController>().enabled = false;
            Girl.GetComponent<CharacterController>().enabled = false;
        }
    }

    void OnChangecharacter()
    {
        swap = !swap;
    }
}
