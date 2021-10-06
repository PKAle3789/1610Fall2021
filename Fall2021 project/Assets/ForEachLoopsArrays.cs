using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForEachLoopsArrays : MonoBehaviour
{
    string[] name = { "Ale", "Cardenas", "Morelos", "Medrano", "Ambriz"};
    foreach (string i in name) 
    {
    Console.WriteLine(i);
    }
}
