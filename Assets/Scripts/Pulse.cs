using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulse : MonoBehaviour
{
    // adjusting the sizes
    [Tooltip("Minimum Size In Percentage")]
    [SerializeField]
    float minSize = 0.5f;

    [Tooltip("Maximum Size In Percentage")]
    [SerializeField] 
    float maxSize = 1.5f;
    
    // speed of the pulse
    [Tooltip("Pulse Speed")]
    [SerializeField]
    float speed = 0.76f;


    private Vector3 previousPosition;
    private float stoppedTime = 0;
    private float secondStoppedTime = 0;

    void Start() 
    {
        previousPosition = transform.position;
        stoppedTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {

        if(transform.position != previousPosition)
        {
            float t = Mathf.PingPong(stoppedTime * speed, 1.0f); // PingPong between 0 and 1
            float scale = Mathf.Lerp(minSize, maxSize, t);

            // Apply the scale to the object
            transform.localScale = new Vector3(scale, scale, scale);
            stoppedTime = Time.time - secondStoppedTime;
        }
        else
        {
            secondStoppedTime = Time.time;

        }
        previousPosition = transform.position;
    }
}
