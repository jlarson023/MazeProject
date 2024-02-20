using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float rotationSpeed = 360; // Degrees per second
    public float thrustSpeed; // How fast the space ship moves

    //Player Inputs
    //------------------------
    private float verticalInput;
    private float horizontalInput;
    //------------------------

    private Rigidbody2D rb;//Player rigidbody

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //Rotate Character do not touch
        //------------------------
        Vector3 mouseScreenPosition = Input.mousePosition;
        Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(mouseScreenPosition);
        mouseWorldPosition.z = transform.position.z;
        Vector3 directionToMouse = mouseWorldPosition - transform.position;
        Quaternion targetRotation = Quaternion.LookRotation(forward: Vector3.forward, upwards: directionToMouse);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        //------------------------


        //Player Movement
        //------------------------
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        rb.AddForce(Vector2.up * verticalInput * thrustSpeed);
        rb.AddForce(Vector2.right * horizontalInput * thrustSpeed);
        //------------------------
    }
}
