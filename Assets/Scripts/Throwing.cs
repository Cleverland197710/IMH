using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throwing : MonoBehaviour
{

    public Transform AimPoint;
    public GameObject ballPrefab;

    public float bulletForce = 20f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Snipe();
        }
    }

    void Snipe()
    {
        GameObject bullet = Instantiate(ballPrefab, AimPoint.position, AimPoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(AimPoint.up * bulletForce, ForceMode2D.Impulse);
    }
}
