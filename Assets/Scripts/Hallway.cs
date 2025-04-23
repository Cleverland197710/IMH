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

        if (Input.GetKeyUp(KeyCode.Q))
        {
            transform.position = new Vector3(Doors.Exit.transform.position.x, Doors.Exit.transform.position.y, transform.position.z);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Doors = collision.gameObject.GetComponent<Doors>();
    }
}
