using UnityEngine;

public class Pulse : MonoBehaviour
{
    public AnimationCurve curve;

    public float t = 0;
    public Transform start;
    public Transform end;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if(t > 1)
        {
            t = 0;
        }
        
        transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(t));


        //float y = curve.Evaluate(t);

        //vector3.one is the same as a vector 3 with 1s in every columnS
        //Vector3 newSize = Vector3.one * y;
        //transform.localScale = Vector3.one * curve.Evaluate(t);

    }
}
