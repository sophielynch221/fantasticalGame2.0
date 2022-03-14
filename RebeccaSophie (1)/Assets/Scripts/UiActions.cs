using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiActions : MonoBehaviour
{
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
        SceneManager.LoadScene("Jigsaw");
    }

    public void OpenMainScene()
    {
        SceneManager.LoadScene("Sophie");
    }
}
