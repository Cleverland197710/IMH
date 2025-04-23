using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDmg : MonoBehaviour
{
    public int Damage = 2;
    private PlayerSanity PlayerSanity;

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
        if (collision.gameObject.tag == "Player")
        {
            if (PlayerSanity == null)
            {
                PlayerSanity = collision.gameObject.GetComponent<PlayerSanity>();
            }
            PlayerSanity.TakeDamage(Damage);
        }

    }
}
