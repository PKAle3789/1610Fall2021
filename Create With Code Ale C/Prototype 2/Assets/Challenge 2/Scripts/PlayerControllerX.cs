using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    // prevents player from spamming dogs
    private float shotFrequency = 1;
    private float nextShot = 0;
    public GameObject dogPrefab;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog when enough time has passed
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextShot)
        {
            nextShot = Time.time + shotFrequency; // resets next shot
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
