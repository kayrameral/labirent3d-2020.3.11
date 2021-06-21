using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class newJoystick : MonoBehaviour
{
    public Joystick joyistic;
    private Rigidbody rb;
    public float speed = 1f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        Vector3 move = new Vector3(joyistic.Horizontal * speed, 0f, +joyistic.Vertical * speed);
        //  transform.Translate(move*Time.deltaTime* speed);
        // float vertical = Input.GetAxis("Vertical");
        //float horizontal = Input.GetAxis("Horizontal");
        //Vector3 move = new Vector3(-vertical*speed ,0.0f, horizontal*speed);
        rb.AddForce(move);
    }
}
