using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throwing : MonoBehaviour
{

    public Transform AimPoint;
    public GameObject ballPrefab;
    public static bool hasBall;
    public static int ball;

    public float bulletForce = 20f;

    void Start()
    {
        ball = 1;        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1") && ball >= 1)
        {
            Snipe();
        }
    }

    void Snipe()
    {
        GameObject bullet = Instantiate(ballPrefab, AimPoint.position, AimPoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(AimPoint.up * bulletForce, ForceMode2D.Impulse);
        ball -= 1;
    }
}
