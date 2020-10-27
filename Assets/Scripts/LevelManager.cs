using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class LevelManager
{
    static int currentBuildIndex;
    
    public static void LoadNextLevel()
    {
        GetCurrentBuildIndex();
        SceneManager.LoadScene((currentBuildIndex + 1)%SceneManager.sceneCountInBuildSettings); 
    }

    public static void LoadPrevLevel()
    {
        GetCurrentBuildIndex();
        SceneManager.LoadScene((currentBuildIndex - 1) % SceneManager.sceneCountInBuildSettings);
    }

    public static void LoadSpecificLevel(int value)
    {
        SceneManager.LoadScene(value);
    }

    public static void ExitApplication()
    {
        Application.Quit();
    }

    private static void GetCurrentBuildIndex()
    {
        currentBuildIndex = SceneManager.GetActiveScene().buildIndex;
    }

}
