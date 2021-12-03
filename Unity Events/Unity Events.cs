using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnityEvents : MonoBehaviour
{
    // Practice
    public UnityEvent CalvinAndHobbesEvent, BonesEvent, GarfieldEvent;

    private void Calvin()
    {
        CalvinAndHobbesEvent.Invoke();
    }

    private void Bones()
    {
        BonesEvent.invoke();
    }

    private void Lasagna()
    {
        GarfieldEvent.Invoke();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
