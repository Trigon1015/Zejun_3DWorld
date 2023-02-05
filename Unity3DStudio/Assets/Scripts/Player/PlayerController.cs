using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 15;
    private Vector3 moveDir;
    private Vector3 direction;
    public Rigidbody rb;
    public Transform cam;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;
    float turnSpeed = 90f;


    // Update is called once per frame
    void Update()
    {
        direction = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical")).normalized;

        rb.MovePosition(rb.position + transform.forward * Input.GetAxisRaw("Vertical") * moveSpeed  * Time.deltaTime);
        transform.Rotate(Vector3.up * Input.GetAxisRaw("Horizontal") * turnSpeed * Time.deltaTime);

    }

    /*
    private void FixedUpdate()
    {
        
        if (direction.magnitude >= 0.1f)
        {
            //float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
           

            //float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            //transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);

            //Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;

            rb.MovePosition(rb.position + transform.TransformDirection(direction) * moveSpeed * Time.deltaTime);


        }
        

    }
    */
}
