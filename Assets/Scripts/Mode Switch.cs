using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeSwitch : MonoBehaviour
{

    public bool ThrowMode;
    public bool WalkMode;

    public GameObject Walk;
    public GameObject Throw;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.LeftShift))
        {

              if (GetComponent<PlayerMovement>().enabled == false && GetComponent<PlayerMShooting>().enabled == true)
              {
                  Debug.Log("WALK!");
                  GetComponent<PlayerMovement>().enabled = true;
                  //GetComponent<Animator>().enabled = false;
                  GetComponent<PlayerMShooting>().enabled = false;
                  GetComponent<Throwing>() .enabled = false;
              }

              if (GetComponent<PlayerMovement>().enabled == true && GetComponent<PlayerMShooting>().enabled == false)
              {
                  Debug.Log("Pew!");
                  GetComponent<PlayerMovement>().enabled = false;
                  //GetComponent <Animator>().enabled = false;
                  GetComponent<PlayerMShooting>().enabled = true;
                  GetComponent <Throwing>() .enabled = true;
              }
            
        }
    }
}
