using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class SceneChange : MonoBehaviour
{
    
    public UnityEvent changeScene;
 //   public UnityEvent ifnotenough;
   // public UnityEvent TurnOff;
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {

     //       if(col.gameObject.GetComponent<Inventory>().AllPianoPieces == true)
       //     {
                changeScene.Invoke();
         //   }

           // else
            //{
              //  ifnotenough.Invoke();
                //Invoke("TurnOff", 2f);
            //}


        }
    }


}
