using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class FirstScript : MonoBehaviour
{
    public bool mouseIsOverMe = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        float distance = Vector2.Distance(transform.position, mousePos);

        if(distance < 1)
        {
            mouseIsOverMe = true;
        }
        else
        {
            mouseIsOverMe = false;
        }

        if (mouseIsOverMe)
        {
            transform.localScale = new Vector3(2f, 2f, 2f);
        }
        else
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }
}
