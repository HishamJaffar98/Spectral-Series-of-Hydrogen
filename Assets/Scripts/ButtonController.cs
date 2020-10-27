using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    bool explanationToggled;
    void Start()
    {
        explanationToggled = false;
    }

    void Update()
    {
        
    }

    public void StartButton()
    {
        LevelManager.LoadNextLevel();
    }

    public void ExitButton()
    {
        LevelManager.ExitApplication();
    }

    public void BackButton()
    {
        StartCoroutine(DelayAndGoBack());
    }

    public void NextButton()
    {
        StartCoroutine(DelayAndGoForward()) ;
    }

    IEnumerator DelayAndGoForward()
    {
        yield return new WaitForSecondsRealtime(1f);
        LevelManager.LoadNextLevel();
    }
    
    public void SelectionButton()
    {
        StartCoroutine(DelayAndGoToSelection());
    }
    
    IEnumerator DelayAndGoToSelection()
    {
        yield return new WaitForSeconds(1f);
        LevelManager.LoadSpecificLevel(3);
    }
    public void ExplanationButton()
    {
        if(!explanationToggled)
        {
            GameObject.FindGameObjectWithTag("Narrator").GetComponent<AudioSource>().Play();
            FindObjectOfType<MusicManager>().gameObject.GetComponent<AudioSource>().volume = 0.3f;
            FindObjectOfType<Explanation>().ExplanationStarted = true;
            explanationToggled = true;
        }
        else
        {
            GameObject.FindGameObjectWithTag("Narrator").GetComponent<AudioSource>().Stop();
            FindObjectOfType<MusicManager>().gameObject.GetComponent<AudioSource>().volume = 0.7f;
            FindObjectOfType<Explanation>().ExplanationStarted = false;
            explanationToggled = false;
        }
        
    }
    
    IEnumerator DelayAndGoBack()
    {
        yield return new WaitForSecondsRealtime(1f);
        LevelManager.LoadPrevLevel();
    }
}
