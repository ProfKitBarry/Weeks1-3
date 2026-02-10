using UnityEngine;

public class Looker : MonoBehaviour
{
    //variable setup, float for rotation speed, z max and z min. 
    public float rotationSpeed;
    public float zMax, zMin;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //transform.eulerAngles always returns rotations in degrees.
        Vector3 currentRotation = transform.eulerAngles;

        //rotate around z at a constant speed, independent of framerate
        currentRotation.z += rotationSpeed * Time.deltaTime;

        transform.eulerAngles = currentRotation;

        if (transform.eulerAngles.z > zMax)
        {
            rotationSpeed *= -1;
        }
        if (transform.eulerAngles.z < zMin)
        {
            rotationSpeed *= -1;
        }

        Debug.Log(transform.eulerAngles);
    }
}