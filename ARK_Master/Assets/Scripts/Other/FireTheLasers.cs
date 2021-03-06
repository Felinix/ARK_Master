﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/// \class FireTheLasers
/// \brief This class is responsible for management of firing the laser.
///
public class FireTheLasers : MonoBehaviour
{

    const float INITIAL_SPEED = 5f;
    public float speed = 3f;
    
    private Rigidbody rb;
    public float angle = 0f;

    Vector3 start;

    Vector3 direction;

    //public Text output;


    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        Debug.Log(this.transform.position);
        start = this.transform.position;

    }

    ///
    /// \brief <b>Brief Description:</b> Destory the object if it hits the roof.
    ///
    void OnTriggerEnter(Collider col)
    {
        Destroy(this);

        switch (col.name)
        {
            case "Border":
                Destroy(this);
                break;
        }

    }

    ///
    /// \brief <b>Brief Description:</b> Add force to the laser on the y-axis.
    ///
    void Update()
    {    
        float step = speed;
       // transform.position = Vector3.MoveTowards(transform.position, this.direction, step);

        transform.position += (this.direction - this.start) * speed * Time.deltaTime;





        //this.transform.LookAt(this.direction);
        //this.transform.Translate(Vector3.back * speed);
    }


    public void Trajectory(Vector3 v)
    {

        this.direction = v;

        //this.angle = Vector3.AngleBetween(this.transform.position, this.direction);
        //Debug.Log(this.direction);
        //this.direction.x *= 2;
        //this.direction.y *= 2;

        //Debug.Log(this.transform.position);

        //Debug.Log(this.direction);
        Debug.Log(this.angle);
    }

}

