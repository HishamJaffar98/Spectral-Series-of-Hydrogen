using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoints : MonoBehaviour
{
    int enterCount=0;

    public int EnterCount
    {
        get
        {
            return enterCount;
        }
        set
        {
            enterCount = value;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        enterCount++;
    } 
}
