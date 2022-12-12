using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Shape
{
     protected override void OnMouseDown()
    {
        base.OnMouseDown();
        ChangeColor();
    }

    private void ChangeColor()
    {
        color = Random.ColorHSV();
        gameObject.GetComponent<Renderer>().material.color = color;
    }
}
