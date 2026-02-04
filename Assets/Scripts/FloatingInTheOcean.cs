using JetBrains.Annotations;
using UnityEditor.IMGUI.Controls;
using UnityEngine;

public class FloatingInTheOcean : MonoBehaviour
{

    //speed of bob
    public float speed = 1f;

    //contols the shape of the bob
    public AnimationCurve curve;

    //how high the bob goes up and down
    public float height = 0.5f;

    //tracks the time from (0-1)
    float timer = 0f;

    //starting position of the sprite
    Vector2 startPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //save the starting position so that the sprite bobs around that position
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //moves the timer forward.
        //+= means add, not replace
        timer += Time.deltaTime * speed;

        //loop the timer back to zero when it gets larger than 1
        if (timer > 1f)
        {
            timer -= 1f;
        }

        //evaluate the curve (usually returns a value between 0 and 1)
        float yOffset = curve.Evaluate(timer) * height;

        //apply vertical offset
        transform.position = new Vector2(startPos.x, startPos.y + yOffset);

    }
}
