using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PSystemMover : MonoBehaviour
{
    [Tooltip("Object to follow")]
    [SerializeField]
    private Transform playerTransform;
    public Vector3 offset = new Vector3(0, 0, -10);

    // Update is called once per frame
    void Update()
    {
        transform.position = playerTransform.position + offset;
    }
}
