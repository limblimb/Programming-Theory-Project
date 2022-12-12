using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape // INHERITANCE
{
    
    protected override void OnMouseDown() // POLYMORPHISM
    {   
        base.OnMouseDown(); // INHERITANCE
        ChangeSquareColor(); // ABSTRACTION
    }

    private void ChangeSquareColor()
    {
        color = Random.ColorHSV(); // INHERITANCE
        GameObject.Find("Square").GetComponent<Renderer>().material.color = color;
        
    }
}
