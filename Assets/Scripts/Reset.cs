using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    private void Awake()
    {
        PlayerPrefsController.SetLymanObserved(0);
        PlayerPrefsController.SetBalmerObserved(0);
        PlayerPrefsController.SetPaschenObserved(0);
        PlayerPrefsController.SetBrackettObserved(0);
        PlayerPrefsController.SetPfundObserved(0);
        PlayerPrefsController.SetHumphreysObserved(0);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
