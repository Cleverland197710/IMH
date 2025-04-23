using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{

    public GameObject Exit;
    public float Destination;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(Exit.transform.position.x, Exit.transform.position.y, transform.position.z);
    }
}
