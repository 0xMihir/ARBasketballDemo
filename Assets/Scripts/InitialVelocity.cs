using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialVelocity : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    Vector3 speed;
    void Start()
    {
        //give it the direction you want as before;
        rb = GetComponent<Rigidbody>();
        speed = new Vector3(0, 4, 5);
        rb.velocity = speed;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
