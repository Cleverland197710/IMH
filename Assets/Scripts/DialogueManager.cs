 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{

    private Queue<string> sentences;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue (Dialogue dialogue)
    {
        Debug.Log("Starting conversation with " + dialogue.name);

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence ()
    {
        if (sentences.Count == 0)
        {
            EndDialouge();
            return;
        }

        string sentences = sentences.Dequeue();

        void EndDialouge ()
        {
            Debug.Log("End of Conversation.");
        }
    }
}
