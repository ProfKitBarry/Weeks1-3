using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;

public class ScriptChanger : MonoBehaviour
{
    public SpriteRenderer SpriteRenderer;
    public Color col;
    public Sprite[] barrels;
    public int randomNumber;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //PickARandomColor();
        PickARandonSprite();
    }

    // Update is called once per frame
    void Update()
    {
        if(Keyboard.current.anyKey.wasPressedThisFrame)
        {
            //    PickARandomColor();
            PickARandonSprite();
        }

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
        
        if(Mouse.current.leftButton.wasPressedThisFrame == true)
        {
           
        }
  
    
    
    }
    void PickARandomColor()
    {
        SpriteRenderer.color = Random.ColorHSV();
    }

    void PickARandonSprite()
    {
        //SpriteRenderer.sprite = mySprite;
        
        //pick a random number
        randomNumber = Random.Range(0,barrels.Length);
        //use that number to choose a sprite
        //asign that sprite
       SpriteRenderer.sprite = barrels[randomNumber];
    }
}
