using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellorX : MonoBehaviour
{
    private float turnSpeed = 45.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, turnSpeed);
    }
}
