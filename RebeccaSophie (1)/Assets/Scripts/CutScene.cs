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

    void Start()
    {
        StartCoroutine("Fade1", 5f);
        /*Invoke("Fade2", 10f);
        Invoke("Fade3", 15f);
        Invoke("Fade4", 20f);
        Invoke("Fade4", 25f);*/
        Invoke("changescene", 30f);
    }

    IEnumerator Fade1()
    {
        // Image1.enabled = false;
        yield return new WaitForSeconds(3);
        float time = 0;
        while (time <5f)
        {
            Image1.GetComponent<CanvasGroup>().alpha = Mathf.Lerp(1, 0, time) ;
            time += Time.deltaTime;
            yield return null;
        }
        StartCoroutine("Fade2", 5f);
    }

    IEnumerator Fade2()
    {
        // Image2.enabled = false
        // Image2.GetComponent<CanvasGroup>().alpha -= Time.deltaTime;
        yield return new WaitForSeconds(3);
        float time = 0;
        while (time < 5f)
        {
            Image2.GetComponent<CanvasGroup>().alpha = Mathf.Lerp(1, 0, time);
            time += Time.deltaTime;
            yield return null;
        }
        StartCoroutine("Fade3", 5f);
    }

    IEnumerator Fade3()
    {
        // Image3.enabled = false
        //Image3.GetComponent<CanvasGroup>().alpha -= Time.deltaTime;
        yield return new WaitForSeconds(3);
        float time = 0;
        while (time < 5f)
        {
            Image3.GetComponent<CanvasGroup>().alpha = Mathf.Lerp(1, 0, time);
            time += Time.deltaTime;
            yield return null;
        }
        StartCoroutine("Fade4", 5f);
    }

    IEnumerator Fade4()
    {
        // Image4.enabled = false
        //Image4.GetComponent<CanvasGroup>().alpha -= Time.deltaTime;
        yield return new WaitForSeconds(3);
        float time = 0;
        while (time < 5f)
        {
            Image4.GetComponent<CanvasGroup>().alpha = Mathf.Lerp(1, 0, time);
            time += Time.deltaTime;
            yield return null;
        }
        StartCoroutine("Fade5", 5f);
    }

    IEnumerator Fade5()
    {
        // Image5.enabled = false
        //Image5.GetComponent<CanvasGroup>().alpha -= Time.deltaTime;
        yield return new WaitForSeconds(3);
        float time = 0;
        while (time < 5f)
        {
            Image5.GetComponent<CanvasGroup>().alpha = Mathf.Lerp(1, 0, time);
            time += Time.deltaTime;
            yield return null;
        }
        
    }

    private void changescene()
    {
        SceneManager.LoadScene("MainGameWorld");
    }
}
