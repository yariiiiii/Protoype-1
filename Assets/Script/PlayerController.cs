using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 20;
    float horizontalInput;
    float forwardInput;
    public float turnSpeed = 45;

    public Camera camOne; 
    public Camera camTwo;
    // Start is called before the first frame update
    void Start()
    {
        
    }



    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up * turnSpeed * horizontalInput * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Y))
        {
            camOne.enabled = !camOne.enabled;
            camTwo.enabled = !camTwo.enabled;

        }
    }

}