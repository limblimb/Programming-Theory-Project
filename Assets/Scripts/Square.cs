using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : Shape // INHERITANCE
{
    
    protected override void PrintText() // POLYMORPHISM
    {
        shapeName = name + " and what is this sphere doing ><";
        base.PrintText(); // INHERITANCE
    }
}
