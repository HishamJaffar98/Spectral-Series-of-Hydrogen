using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Explanation : MonoBehaviour
{
    [SerializeField] GameObject[] buttonItems;
    [SerializeField] Animator atomAnimator;
    Animator explanationAnimator;

    bool explanationStarted;
    
    public bool ExplanationStarted
    {
        get
        {
            return explanationStarted;
        }
        set
        {
            explanationStarted = value;
        }
    }
    void Start()
    {
        explanationStarted = false;
        explanationAnimator = gameObject.GetComponent<Animator>();
    }

    
    void Update()
    {
        ToggleOpacity();
    }

    private void ToggleOpacity()
    {
        if (explanationStarted == true)
        {
            buttonItems[0].GetComponent<Image>().color = new Color(1, 1, 1, 0.5f);
            buttonItems[1].GetComponent<TextMeshProUGUI>().color = new Color(1, 1, 1, 0.5f);
            explanationAnimator.SetBool("slideIn",true);
            atomAnimator.SetBool("atomMove",true);
        }
        else
        {
            buttonItems[0].GetComponent<Image>().color = new Color(1, 1, 1, 1f);
            buttonItems[1].GetComponent<TextMeshProUGUI>().color = new Color(1, 1, 1, 1f);
            explanationAnimator.SetBool("slideIn", false);
            atomAnimator.SetBool("atomMove", false);
        }
    }
}
