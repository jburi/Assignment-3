/*
* Jacob Buri
* SpinPropellerX.cs
* Assignment 3
* Spins the propeller every frame
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public Vector3 RotateAmount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(RotateAmount * Time.deltaTime);
    }
}
