using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSanity : MonoBehaviour
{

    public int Sanity;
    public int maxSanity = 10;
    

    // Start is called before the first frame update
    void Start()
    {
        Sanity = maxSanity;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int amount)
    {
        Sanity -= amount;

        if (Sanity < 0)
        {
            Destroy(gameObject);
        }
    }

    void Kill()
    {
        Debug.Log("You're Dead :P");
    }
}
