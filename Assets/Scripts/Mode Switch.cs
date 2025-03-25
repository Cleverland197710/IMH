using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeSwitch : MonoBehaviour
{

    public Rigidbody2D rb;

    public bool ThrowMode;
    public bool WalkMode;

    private bool isInWalkMode = false;
    private bool isInThrowMode = false;

    // Start is called before the first frame update
    void Start()
    {
        // Initial setup based on starting mode
        isInWalkMode = true;
        isInThrowMode = false;
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            if (isInWalkMode)
            {
                // Switch to Throw mode
                Debug.Log("Pew!"); // You can customize this message
                GetComponent<PlayerMovement>().enabled = false;
                GetComponent<PlayerMShooting>().enabled = true;
                GetComponent<Throwing>().enabled = true;
                GetComponent<Animator>().enabled = false;

                isInWalkMode = false;
                isInThrowMode = true;
            }
            else if (isInThrowMode)
            {
                // Switch to Walk mode
                Debug.Log("WALK!"); // Customize this message
                GetComponent<PlayerMovement>().enabled = true;
                GetComponent<PlayerMShooting>().enabled = false;
                GetComponent<Throwing>().enabled = false;
                GetComponent<Animator>().enabled = true;
                rb.rotation = 0;

                isInWalkMode = true;
                isInThrowMode = false;
            }
        }
    }
}
