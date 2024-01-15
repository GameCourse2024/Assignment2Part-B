using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]
    float speed = 1f;

    [Tooltip("Button to move right")]
    [SerializeField]
    private KeyCode rightMove;
    [Tooltip("Button to move left")]
    [SerializeField]
    private KeyCode leftMove;

    [Tooltip("Button to move up")]
    [SerializeField]
    private KeyCode upMove;

    [Tooltip("Button to move down")]
    [SerializeField]
    private KeyCode downMove;



    private void Start() 
    {
        Debug.Log("These are the buttons: " + upMove +"," + downMove + "," + leftMove +"," +rightMove);    
    }
    void Update() 
    {
        float horizontalMovement = 0;
        float verticalMovement = 0;

        if (Input.GetKey(rightMove))
        {
            horizontalMovement = speed;
        }
        else if (Input.GetKey(leftMove))
        {
            horizontalMovement = -speed;
        }

        if (Input.GetKey(upMove))
        {
            verticalMovement = speed;
        }
        else if (Input.GetKey(downMove))
        {
            verticalMovement = -speed;
        }

        transform.position += new Vector3(horizontalMovement * Time.deltaTime, verticalMovement * Time.deltaTime, 0);
    }
}
