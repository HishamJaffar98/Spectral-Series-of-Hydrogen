using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Spectrum : MonoBehaviour
{
    List<Image> buttons = new List<Image>();
    Color partiallyTransparent = new Color(1, 1, 1, 0.3f);
    Color opaque = new Color(1, 1, 1, 1);

    private void Awake()
    {
        FillList();
        SetOpacity();
    }
    void FillList()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            buttons.Add(transform.GetChild(i).gameObject.GetComponent<Image>());
        }
    }
    private void SetOpacity()
    {
        if (PlayerPrefsController.GetLymanObserved() == 1)
        {
            buttons[0].color = partiallyTransparent;
        }
        else
        {
            buttons[0].color = opaque;
        }
        if (PlayerPrefsController.GetBalmerObserved() == 1)
        {
            buttons[1].color = partiallyTransparent;
        }
        else
        {
            buttons[1].color = opaque;
        }
        if (PlayerPrefsController.GetPaschenObserved() == 1)
        {
            buttons[2].color = partiallyTransparent;
        }
        else
        {
            buttons[2].color = opaque;
        }
        if (PlayerPrefsController.GetBrackettObserved() == 1)
        {
            buttons[3].color = partiallyTransparent;
        }
        else
        {
            buttons[3].color = opaque;
        }
        if (PlayerPrefsController.GetPfundObserved() == 1)
        {
            buttons[4].color = partiallyTransparent;
        }
        else
        {
            buttons[4].color = opaque;
        }
        if (PlayerPrefsController.GetHumphreysObserved() == 1)
        {
            buttons[5].color = partiallyTransparent;
        }
        else
        {
            buttons[5].color = opaque;
        }
    }

    public void ButtonClicked()
    {
        if (EventSystem.current.currentSelectedGameObject.tag == "Spectrum")
        {
            EventSystem.current.currentSelectedGameObject.GetComponent<Image>().color = partiallyTransparent;
        }
        SetFlag();
    }

    private static void SetFlag()
    {
        switch (EventSystem.current.currentSelectedGameObject.name)
        {
            case "Lyman":
                if (PlayerPrefsController.GetLymanObserved() == 0)
                {
                    PlayerPrefsController.SetLymanObserved(1);   
                }
                LevelManager.LoadSpecificLevel(4);
                break;
            case "Balmer":
                if (PlayerPrefsController.GetBalmerObserved() == 0)
                {
                    PlayerPrefsController.SetBalmerObserved(1);
                }
                LevelManager.LoadSpecificLevel(5);
                break;
            case "Paschen":
                if (PlayerPrefsController.GetPaschenObserved() == 0)
                {
                    PlayerPrefsController.SetPaschenObserved(1);
                }
                LevelManager.LoadSpecificLevel(6);
                break;
            case "Brackett":
                if (PlayerPrefsController.GetBrackettObserved() == 0)
                {
                    PlayerPrefsController.SetBrackettObserved(1);
                }
                LevelManager.LoadSpecificLevel(7);
                break;
            case "Pfund":
                if (PlayerPrefsController.GetPfundObserved() == 0)
                {
                    PlayerPrefsController.SetPfundObserved(1);
                }
                LevelManager.LoadSpecificLevel(8);
                break;
            case "Humphreys":
                if (PlayerPrefsController.GetHumphreysObserved() == 0)
                {
                    PlayerPrefsController.SetHumphreysObserved(1);
                }
                LevelManager.LoadSpecificLevel(9);
                break;
        }
    }
}
