using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CutScene : MonoBehaviour
{
    [SerializeField] private Image Image1;
    [SerializeField] private Image Image2;
    [SerializeField] private Image Image3;
    [SerializeField] private Image Image4;
    [SerializeField] private Image Image5;

    void Update()
    {
        Invoke("Fade1", 5f);
        Invoke("Fade2", 10f);
        Invoke("Fade3", 15f);
        Invoke("Fade4", 20f);
        Invoke("Fade4", 25f);
        Invoke("changescene", 30f);
    }

    private void Fade1()
    {
        Image1.GetComponent<CanvasGroup>().alpha -= Time.deltaTime;
    }

    private void Fade2()
    {
        Image2.GetComponent<CanvasGroup>().alpha -= Time.deltaTime;
    }

    private void Fade3()
    {
        Image3.GetComponent<CanvasGroup>().alpha -= Time.deltaTime;
    }

    private void Fade4()
    {
        Image4.GetComponent<CanvasGroup>().alpha -= Time.deltaTime;
    }

    private void Fade5()
    {
        Image5.GetComponent<CanvasGroup>().alpha -= Time.deltaTime;
    }

    private void changescene()
    {
        SceneManager.LoadScene("MainGameWorld");
    }
}
