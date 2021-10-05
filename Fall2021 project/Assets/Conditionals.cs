using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour
{
int gas = 0;
if (gas < 5) 
    {
    Console.WriteLine("Need gasoline.");
    }
else if (gas < 10)
    {
    Console.WriteLine("Need gasoline soon.");
    }
else if (gas < 14)
}
        Console.WriteLine("gasoline approaching half.");
}
else
{
    Console.WriteLine("Tank is full.");
}
// Outputs "Need gasoline."
}
