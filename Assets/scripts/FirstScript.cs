using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        //float speed = 0.1f;
    }
    float speed = 0.05f;

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.x += speed;

        //Vector2 ScreenSize = new Vector2(Screen.width, Screen.height);
        //Vector2 ScreenSizeInTheWorld = new Vector2();
        //ScreenSizeInTheWorld = Camera.main.ScreenSizeInTheWorld(ScreenSize);

        //Vector2 ScreenSizeInTheWorld.x = Camera.main.ScreenSizeInTheWorld(Vector2.zero);

        if (pos.x < -9 || pos.x > 9)
        {
            speed = speed * -1;
        }
        transform.position = pos;

    }
}
