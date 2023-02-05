using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityControl : MonoBehaviour
{
    public GravityOrbit Gravity;
    private Rigidbody Rb;
    
    public float RotationSpeed = 20;
    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
    }


    // Update is called once per frame

    void FixedUpdate()
    {
        if(Gravity)
        {
            Vector3 gravityUp = Vector3.zero;
            gravityUp = (transform.position - Gravity.transform.position).normalized;
            Vector3 localUp = transform.up;

           
            Quaternion targetrotation = Quaternion.FromToRotation(localUp, gravityUp) * transform.rotation;
            Rb.GetComponent<Rigidbody>().rotation = targetrotation; 


            transform.rotation = Quaternion.Lerp(transform.rotation, targetrotation, RotationSpeed * Time.deltaTime);
            Rb.GetComponent<Rigidbody>().AddForce((-gravityUp * Gravity.Gravity) * Rb.mass);

            //transform.up = Vector3.Lerp(transform.up, gravityUp, RotationSpeed * Time.deltaTime);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetrotation, RotationSpeed * Time.deltaTime);
            Rb.GetComponent<Rigidbody>().AddForce((-gravityUp * Gravity.Gravity) * Rb.mass);
            //Rb.AddForce((-gravityUp * Gravity.Gravity) * Rb.mass);
        }
    }
}
