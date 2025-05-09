using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlasterActivation : MonoBehaviour
{

    private ModeSwitch ModeSwitch;
    public GameObject Door;

    // Start is called before the first frame update
    void Start()
    {
        Door.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (ModeSwitch == null)
        {
            ModeSwitch = collision.gameObject.GetComponent<ModeSwitch>();
        }
        ModeSwitch.canThrow = true;
        Door.SetActive(true);
    }
}
