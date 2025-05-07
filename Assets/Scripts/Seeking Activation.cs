using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeekingActivation : MonoBehaviour
{

    public bool test;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AIDestinationSetter>().enabled = false;
        test = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        test = true;
        GetComponent<AIDestinationSetter>().enabled = true;
    }
}
