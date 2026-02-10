using UnityEngine;

public class LinearInterpolation : MonoBehaviour
{
    //puts a transform in the inspector. i believe you can use transform for the position to remove having to manually type position of the starting position.
    public Transform start;
    public Transform end;
    public float t = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //as time goes on
        t += Time.deltaTime;
        
        //as long as t is less than 1
        if (t > 1)
        {
            //set t to 0
            t = 0;
        }

        // you need to add the .position after the start because unity doesnt inherently know what you are asking for.
        transform.position = Vector2.Lerp(start.position, end.position, t);
    }
}
