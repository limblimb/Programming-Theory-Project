using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Shape
{
     protected override void OnMouseDown() // POLYMORPHISM
    {
        base.OnMouseDown(); // INHERITANCE
        ChangeColor(); // ABSTRACTION
    }

    private void ChangeColor()
    {
        color = Random.ColorHSV(); // INHERITANCE
        gameObject.GetComponent<Renderer>().material.color = color;
    }
}
