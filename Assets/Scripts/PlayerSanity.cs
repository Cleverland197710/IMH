using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSanity : MonoBehaviour
{

    public int Sanity;
    public int maxSanity = 10;
    Rigidbody2D rb;
    public Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        Sanity = maxSanity;
        rb = GetComponent<Rigidbody2D>();
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
            //Destroy(gameObject);
            Invoke("Kill", 0f);
            Invoke("ReloadScene", 1f);
        }
    }

    void Kill()
    {
        Debug.Log("You're Dead :P");
        rb.constraints = RigidbodyConstraints2D.FreezePosition;
        GetComponent<PlayerMovement>().enabled = false;
        GetComponent<PlayerMShooting>().enabled = false;
        GetComponent<Throwing>().enabled = false;
    }

    void ReloadScene()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
    }
}
