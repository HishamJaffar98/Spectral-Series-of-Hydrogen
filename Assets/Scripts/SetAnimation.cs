using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SetAnimation : MonoBehaviour
{
    [SerializeField] Animator electronAnimator;
    void Start()
    {
        if(SceneManager.GetActiveScene().buildIndex==5)
        {
            electronAnimator.SetInteger("seriesIndex", 1);
        }
        else if(SceneManager.GetActiveScene().buildIndex == 6)
        {
            electronAnimator.SetInteger("seriesIndex", 2);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 7)
        {
            electronAnimator.SetInteger("seriesIndex", 3);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 8)
        {
            electronAnimator.SetInteger("seriesIndex", 4);
        }
        else if (SceneManager.GetActiveScene().buildIndex == 9)
        {
            electronAnimator.SetInteger("seriesIndex", 5);
        }
    }

    void Update()
    {
        
    }
}
