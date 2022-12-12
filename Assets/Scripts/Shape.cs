using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    protected string shapeName;
    public Color color { get; set; }
    // Start is called before the first frame update
    void Start()
    {
        color = this.gameObject.GetComponent<Renderer>().material.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected virtual void PrintText()
    {
        if (shapeName == null)
        {
            shapeName = gameObject.name;
        }
        Debug.Log("Hello! I am " + shapeName);
    }

    protected virtual void OnMouseDown()
    {
        PrintText();
    }
}
