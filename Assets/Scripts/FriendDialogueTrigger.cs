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

    private void OnTriggerExit2D(Collider2D collision)
    {
        Near = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            talking = true;
            Invoke("Shh", 1f);
        }

        if (talking && Near)
        {
            Convo = true;
        }

        if (Convo)
        {
            FindAnyObjectByType<DialogueManager>().StartDialogue(dialogue);
        }

        if (!talking || !Near)
        {
            Convo = false;
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

    private void Shh()
    {
        talking = false;
    }

    private void Falseify()
    {
        talking = false;
        Near = false;
    }
}
