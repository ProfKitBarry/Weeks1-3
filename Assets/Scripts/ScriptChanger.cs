using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;

public class ScriptChanger : MonoBehaviour
{
    public SpriteRenderer SpriteRenderer;
    public Color col;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //PickARandomColor();
    }

    // Update is called once per frame
    void Update()
    {
        //if(Keyboard.current.anyKey.wasPressedThisFrame)
        //{
        //    PickARandomColor();
        //}

        //get mouse position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //is it over the shape
        if (SpriteRenderer.bounds.Contains(mousePos)) 
        {
            SpriteRenderer.color = col;
            //Y: set the color
        }
        else
        {
            //N: set to white
            SpriteRenderer.color = Color.white;
        }
  
    
    
    }
    void PickARandomColor()
    {
        SpriteRenderer.color = Random.ColorHSV();
    }
}
