using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HourHandRot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 hourClock = transform.eulerAngles;
        hourClock.z += -0.01f;
        transform.eulerAngles = hourClock;
    }
}
