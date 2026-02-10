using UnityEngine;
using UnityEngine.InputSystem;

public class upNdownArrowV22 : MonoBehaviour
{
    public float moveSpeed;
    public float rotateSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //bool leftIsHeld = Mouse.current.leftButton.isPressed;
        //if(leftIsHeld)
        //{
        //    Debug.Log("Left mouse is held");
        //}

        //bool leftIsPressed = Mouse.current.leftButton.wasPressedThisFrame;
        //if(leftIsPressed)
        //{
        //    Debug.Log("Left mouse is pressed.");
        //}

        //bool leftIsReleased = Mouse.current.leftButton.wasReleasedThisFrame;
        //if (leftIsReleased)
        //{
        //    Debug.Log("Left mouse is released.");
        //}

        //bool spaceIsPressed = Keyboard.current.spaceKey.isPressed;

        bool leftArrowHeld = Keyboard.current.leftArrowKey.isPressed;
        bool rightArrowHeld = Keyboard.current.rightArrowKey.isPressed;
        bool upArrowHeld = Keyboard.current.upArrowKey.isPressed;
        bool downArrowHeld = Keyboard.current.downArrowKey.isPressed;
        if (leftArrowHeld)
        {
            transform.eulerAngles += transform.forward * rotateSpeed * Time.deltaTime;
        }
        if (rightArrowHeld)
        {
            transform.eulerAngles -= transform.forward * rotateSpeed * Time.deltaTime;
        }
        if (upArrowHeld)
        {
            transform.position += transform.up * moveSpeed * Time.deltaTime;
        }
        if (downArrowHeld)
        {
            transform.position -= transform.up * moveSpeed * Time.deltaTime;
        }


    }
}