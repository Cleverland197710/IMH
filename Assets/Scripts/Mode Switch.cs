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
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            if(Walk == isActiveAndEnabled)
            {
                Walk.SetActive(false);
                Throw.SetActive(true);
            }

            if (Throw == isActiveAndEnabled)
            {
                Walk.SetActive(true);
                Throw.SetActive(false);
            }
        }
    }
}
