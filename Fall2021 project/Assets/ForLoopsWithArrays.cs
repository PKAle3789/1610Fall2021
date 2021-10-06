using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoopsWithArrays : MonoBehaviour
{
    
    static void Main(string[] args)
    {
        string[] name = { "Ale", "Cardenas", "Morelos", "Medrano", "Ambriz" };
        for (int i = 0; i < name.Length; i++)
        {
            Console.WriteLine(name[i]);
        }
    }
}
