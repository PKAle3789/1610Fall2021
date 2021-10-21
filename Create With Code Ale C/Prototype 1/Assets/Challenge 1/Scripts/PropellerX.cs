using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerX : MonoBehaviour

{
    private float propellorSpeed = 750.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //spins the propellor
        transform.Rotate(Vector3.forward, propellorSpeed * Time.deltaTime);
    }
}
