using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GirlController : MonoBehaviour
{

    public Animator girlAnimator;

    // Start is called before the first frame update
    void Start()
    {
        girlAnimator = gameObject.GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnJump(Input input)
    {
        girlAnimator.SetBool("jump", true);
    }

    void OnWalking(Input input)
    {
        girlAnimator.SetBool("walking", true);
    }

    void OnRunning(Input input)
    {
        girlAnimator.SetBool("running", true);
    }

    void OnSlash(Input input)
    {
        girlAnimator.SetBool("slash", true);
    }
}
