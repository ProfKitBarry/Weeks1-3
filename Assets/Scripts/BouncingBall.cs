using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class BouncingBall : MonoBehaviour
{

    float speedX = 0.1f;
    float speedY = 0.1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = the balls position in the world
        Vector3 newPosition = transform.position;

        //this adds the value of speed to the variable that is holding the value for x location
        newPosition.x += speedX;

        //this adds the value of speed to the variable that is holding the value for y location
        newPosition.y += speedY;
        
        //converts pixels in the unity editor to meters in the unity game space.
        /*had a problem where the ball was getting stuck in the top right corner. it was due to using the value of the balls position (transform.position)
         * this was solved by switching the value in the brackets to the newPosition which helps because its the latest positon of the ball. 
        */

        Vector2 screenPos = Camera.main.WorldToScreenPoint(newPosition);

        //this is checking if the ball goes smaller or larger than the screen width allows
        if (screenPos.x < 0 || screenPos.x > Screen.width)
        {
            speedX *= -1;
        }

        //this is checking if the ball goes smaller or larger than the screen height allows
        if (screenPos.y < 0 || screenPos.y > Screen.height)
        {
            speedY *= -1;
        }

        //this updates the balls current position with the new positon variable that we are holding.
        transform.position = newPosition;
    }
}
