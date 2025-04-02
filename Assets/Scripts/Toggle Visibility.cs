using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleVisibility : MonoBehaviour
{
    public BoxCollider2D BoxCollider;

    public bool Overlap;
    public static bool visibilityOn;


    // Start is called before the first frame update
    void Start()
    {
        GetComponent<BoxCollider2D>();
        Overlap = false;
        visibilityOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Overlap == true)
        {
            visibilityOn = true;
        }

        if (Overlap == false)
        {
            visibilityOn = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {
            Overlap = true;
            Debug.Log("Overlaping");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Overlap = false;
            Debug.Log("Gone to get milk");
        }
    }
}
