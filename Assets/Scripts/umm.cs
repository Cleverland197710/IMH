using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class umm : MonoBehaviour
{
    public float CurrentHealth;
    public float MaxHealth = 100;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        CurrentHealth = MaxHealth;  // Use MaxHealth instead of hardcoding 100
        rb = GetComponent<Rigidbody2D>(); // Assign Rigidbody2D
    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentHealth <= 0)
        {
            Invoke("Kill", 0f);
            if (rb != null) // Check if rb is assigned before using it
            {
                rb.simulated = false; // Disabling simulation instead of rb.enabled
            }
        }
    }

    void Kill()
    {
        Debug.Log("You're Dead :P");
    }
}
