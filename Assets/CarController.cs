using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Inputs))]
public class CarController : MonoBehaviour
{
    public Inputs inp;
    public List<WheelCollider> throttleWheels;
    public List<GameObject> steeringWheels;
    public List<GameObject> meshes;
    public float force = 4000f;
    public float turn = 20f;
    public Transform CM;
    public Rigidbody rb;

    void Start()
    {
        inp = GetComponent<Inputs>();
        rb = GetComponent<Rigidbody>();
        if (CM)
        {
            rb.centerOfMass = CM.position;
        }
    }

    void FixedUpdate()
    {

        foreach (WheelCollider wheel in throttleWheels)
        {
            wheel.motorTorque = force * Time.deltaTime;
            print(wheel.motorTorque);
            print(Time.deltaTime);
        }
        foreach (GameObject wheel in steeringWheels)
        {
            wheel.GetComponent<WheelCollider>().steerAngle = turn * inp.steer;
            wheel.transform.localEulerAngles = new Vector3(0f, inp.steer * turn, 0f);
        }

        foreach (GameObject mesh in meshes)
        {
            mesh.transform.Rotate(rb.velocity.magnitude * (transform.InverseTransformDirection(rb.velocity).z >= 0 ? 1 : -1) / (1 * Mathf.PI * 0.33f), 0f, 0f);
        }
       
    }
}
