using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerPrefsController
{
    const string LYMAN = "Lyman";
    const string BALMER = "Balmer";
    const string PASCHEN = "Paschen";
    const string BRACKETT = "Brackett";
    const string PFUND = "Pfund";
    const string HUMPHREYS = "Humphreys";
    public static void SetLymanObserved(int value)
    {
        PlayerPrefs.SetInt(LYMAN, value);
    }

    public static int GetLymanObserved()
    {
        return PlayerPrefs.GetInt(LYMAN);
    }

    public static void SetBalmerObserved(int value)
    {
        PlayerPrefs.SetInt(BALMER, value);
    }

    public static int GetBalmerObserved()
    {
        return PlayerPrefs.GetInt(BALMER);
    }
    public static void SetPaschenObserved(int value)
    {
        PlayerPrefs.SetInt(PASCHEN, value);
    }

    public static int GetPaschenObserved()
    {
        return PlayerPrefs.GetInt(PASCHEN);
    }
    public static void SetBrackettObserved(int value)
    {
        PlayerPrefs.SetInt(BRACKETT, value);
    }

    public static int GetBrackettObserved()
    {
        return PlayerPrefs.GetInt(BRACKETT);
    }
    public static void SetPfundObserved(int value)
    {
        PlayerPrefs.SetInt(PFUND, value);
    }

    public static int GetPfundObserved()
    {
        return PlayerPrefs.GetInt(PFUND);
    }
    public static void SetHumphreysObserved(int value)
    {
        PlayerPrefs.SetInt(HUMPHREYS, value);
    }

    public static int GetHumphreysObserved()
    {
        return PlayerPrefs.GetInt(HUMPHREYS);
    }

}