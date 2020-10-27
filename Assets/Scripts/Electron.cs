using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Electron : MonoBehaviour
{
    float angle = 0f;
    public bool isRotating;
    [SerializeField] public float radius;
    [SerializeField] Transform centralPosition;
    [SerializeField] float movementSpeed;
    void Start()
    {
        isRotating = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(isRotating)
        {
            angle += Time.deltaTime * movementSpeed;
            Vector3 newPosition = new Vector3(Mathf.Cos(angle), Mathf.Sin(angle), 0) * radius + centralPosition.position;
            transform.position = newPosition;
        }
    }
}
