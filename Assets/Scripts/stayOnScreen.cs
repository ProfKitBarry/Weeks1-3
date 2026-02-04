using UnityEngine;

public class stayOnScreen : MonoBehaviour
{
    float speed = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition =  transform.position;
        newPosition.x += speed;
        transform.position = newPosition;

        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if(screenPosition.x < 0 || screenPosition.x > Screen.width)
        {
            speed *= -1;
        }
    }
}
