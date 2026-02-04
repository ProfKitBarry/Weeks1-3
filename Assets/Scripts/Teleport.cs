using UnityEngine;

public class Teleport : MonoBehaviour
{
    //set variables for timer starting time & countdown time
    float timer = 0f;
    float waitTime = 3f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //time.deltatime = time since last frame
        //+= means add on not replace
        timer += Time.deltaTime;

        //this is checking to see if the 3 seconds is up. if timer (counting variable) is larger than wait time (3 seconds) do this : ______
        if (timer >= waitTime)
        {
            //set x and y values as two random values between 0 and 1 (viewport coordinates not world space)
            //viewport coordinates work as so ((0,0) is the bottom right of the screen, (1,1) is the top right)
            float randomX = Random.Range(0.05f, 0.95f);
            float randomY = Random.Range(0.05f, 0.95f);

            //our sprite lives in the world space, the camera uses viewport space
            //unity is not able to change the position unless the coordinates are localized
            Vector2 worldPos = Camera.main.ViewportToWorldPoint(new Vector2(randomX, randomY));

            //this moves the object to the new position
            transform.position = worldPos;

            //this resets the timer back to zero
            timer = 0f;
        }
;
    }
}
