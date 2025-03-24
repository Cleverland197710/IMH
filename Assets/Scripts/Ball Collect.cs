using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class BallCollect : MonoBehaviour
{
    public Rigidbody2D rb;
    public BoxCollider2D StressBall;
    public bool colliding;
    public bool pickUp;
    public static bool vault;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        BoxCollider StressBall = GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        colliding = true;
        Invoke("Colliding", 0f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        colliding = true;
        Invoke("Colliding", 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (colliding == true)
        {
            pickUp = true;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            Invoke("Falseify", 1f);
        }
    }

    void Colliding()
    {
        colliding = true;
    }

    void Falseify()
    {
        pickUp = false;
        colliding = false;
    }
}