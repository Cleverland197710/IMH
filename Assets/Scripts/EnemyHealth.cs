using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public int Health;
    public int maxHealth = 10;


    // Start is called before the first frame update
    void Start()
    {
        Health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDamage(int amount)
    {
        Health -= amount;

        if (Health < 0)
        {
            Destroy(gameObject);
        }
    }

    void Kill()
    {
        Debug.Log("Nice Kill Loser");
    }
}
