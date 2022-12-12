using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void OnMouseDown()
    {   
        base.OnMouseDown();
        ChangeSquareColor();
    }

    private void ChangeSquareColor()
    {
        color = Random.ColorHSV();
        GameObject.Find("Square").GetComponent<Renderer>().material.color = color;
        
    }
}
