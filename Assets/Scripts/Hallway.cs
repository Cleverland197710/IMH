using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hallway : MonoBehaviour
{

    public Doors Doors;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Doors != null)
        {
            transform.position = new Vector3(Doors.Exit.transform.position.x, Doors.Exit.transform.position.y, transform.position.z);
            Doors = null;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        transform.position = new Vector3(Doors.Exit.transform.position.x, Doors.Exit.transform.position.y, transform.position.z); 
        Doors = collision.gameObject.GetComponent<Doors>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Doors = collision.gameObject.GetComponent<Doors>();
    }
}
