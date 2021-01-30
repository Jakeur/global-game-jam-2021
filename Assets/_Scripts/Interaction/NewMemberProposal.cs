using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMemberProposal : MonoBehaviour, IInteractable
{
    [SerializeField] DialogueSO dialogueContent;

    public void Interact()
    {
        DialogueManager.Instance.RefreshDialogueContent(dialogueContent);
        DialogueManager.Instance.ShowDialogue();
        Debug.Log("Crossed next step");
    }

    public void ExitInteraction()
    {
        Debug.Log("Crossed next step");
        DialogueManager.Instance.HideDialogue();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
