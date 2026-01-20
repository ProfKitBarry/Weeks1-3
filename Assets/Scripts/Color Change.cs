using UnityEngine;
using UnityEngine.InputSystem;

public class ColorChange : MonoBehaviour
{
    public SpriteRenderer SpriteRenderer;
    public float clock = 1;
    float now;
    float then;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PickARandomColor();
    }

    // Update is called once per frame
    void Update()
    {
        now = Time.realtimeSinceStartup;
        if (now - then == clock)
        {
           PickARandomColor();
            now = then;
            
        }
    }
    void PickARandomColor()
    {
        SpriteRenderer.color = Random.ColorHSV();
    }
}
