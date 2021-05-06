using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caranimation : MonoBehaviour
{
    //public GameObject finalp;
    public Vector3 finalposition;
    private Vector3 initialposition;

    private void Awake()
    {
        initialposition = transform.position;
    }

    private void Update()
    {

        transform.position = Vector3.Lerp(transform.position, finalposition, 0.1f);
    }
    private void OnDisable()
    {
        transform.position = initialposition;
    }
}