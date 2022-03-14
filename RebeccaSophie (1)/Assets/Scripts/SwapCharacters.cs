using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SwapCharacters : MonoBehaviour
{
    public bool swap;
    public GameObject Girl;
    public GameObject penguin;
    public Camera girlCamera;
    public Camera penguinCamera;
    // Start is called before the first frame update
    void Start()
    {
        swap = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (swap) //girl is active
        {
            //camera
          //  girlCamera.enabled = true;
           // penguinCamera.enabled = false;

            //so penguin would follow
            penguin.GetComponent<NavMeshAgent>().enabled = true;
            penguin.GetComponent<Follow>().enabled = true;

            //so girl isnt following
            Girl.GetComponent<NavMeshAgent>().enabled = false;
            Girl.GetComponent<Follow>().enabled = false;

            //girl can run
            Girl.GetComponent<CharacterController>().enabled = true;

            //penguin cant run
            penguin.GetComponent<CharacterController>().enabled = false; 
        }

        if (!swap) //penguin
        {
            //camera
           // penguinCamera.enabled = true;
            // girlCamera.enabled = false;

            // so penguin wont follow
            penguin.GetComponent<NavMeshAgent>().enabled = false;
            penguin.GetComponent<Follow>().enabled = false;

            // so girl will follow
            Girl.GetComponent<NavMeshAgent>().enabled = true;
            Girl.GetComponent<Follow>().enabled = true;

            //penguin can run
            penguin.GetComponent<CharacterController>().enabled = true;

            //girl cant run
            Girl.GetComponent<CharacterController>().enabled = false;
        }
    }

    void OnChangecharacter()
    {
        swap = !swap;
    }
}
