using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed = 0.02f;
    public float xMax;
    public float Xmin;
    public Camera gamecamera;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moverXPos = transform.position;
        moverXPos.x = moverXPos.x + speed * Time.deltaTime ;
        transform.position = moverXPos;

        Vector3 screenTransformPosition = gamecamera.WorldToScreenPoint(transform.position);
        xMax = Screen.width;

        //set xMin to wherever is too far to the left for the player to see
        Xmin = 0;

        if (screenTransformPosition.x>xMax)
        {
            speed = speed * -1 ;

        }else if (screenTransformPosition.x < Xmin)
        {
            speed = speed * -1;
        }
      
    }
}
