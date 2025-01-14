using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minuethand : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float hourspeed = 0.05f;

    // Update is called once per frame
    void Update()
    {
        Vector3 hour = transform.eulerAngles;
        hour.z += hourspeed*12;
        transform.eulerAngles = hour;
    }
}
