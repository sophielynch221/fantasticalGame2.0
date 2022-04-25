using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiActions : MonoBehaviour
{
   // public StarterAssets.StarterAssetsInputs mystarterAssets;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void OpenPianoScene()
    {
        SceneManager.LoadScene("Piano");
    }

    public void OpenJigsawScene()
    {
        SceneManager.LoadScene("Jigsaw2");
    }

    public void OpenMainScene()
    {
        SceneManager.LoadScene("MainGameWorldONE");
    }

    public void OpenMainSceneFinal()
    {
        SceneManager.LoadScene("MainGameWorldTWO");
    }

    public void GetCursor()
    {
       // mystarterAssets.SetCursorState(true);
        Cursor.lockState = CursorLockMode.None;
    }

    public void GetRidOfCursor()
    {
       // mystarterAssets.SetCursorState(false);
        Cursor.lockState = CursorLockMode.Locked;
    }
}
