using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendDialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    Rigidbody2D rb;
    BoxCollider2D Table;

    public bool Near;
    public bool talking;
    public bool Convo;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Table = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Near = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Near = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            talking = true;
        }

        if (talking && Near)
        {
            Convo = true;
            Debug.Log("Rizz Time");
        }

        if (Input.GetKeyUp(KeyCode.Q))
        {
            DialogueManager dialogueManager = FindObjectOfType<DialogueManager>();
            if (dialogueManager != null)
            {
                dialogueManager.StartDialogue(dialogue);
            }
            else
            {
                Debug.LogError("DialogueManager not found in the scene!");
            }
        }
    }

    private void Speak()
    {
        talking = true;
    }

    private void Falseify()
    {
        talking = false;
        Near = false;
    }
}
