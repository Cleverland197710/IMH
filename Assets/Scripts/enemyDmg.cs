using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDmg : MonoBehaviour
{
    public int Damage = 2;
    private EnemyHealth EnemyHealth;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            if (EnemyHealth == null)
            {
                EnemyHealth = collision.gameObject.GetComponent<EnemyHealth>();
            }
            EnemyHealth.TakeDamage(Damage);
        }
    }
}
