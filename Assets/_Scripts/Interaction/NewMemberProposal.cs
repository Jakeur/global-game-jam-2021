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
        CharacterInteraction.Instance.ChangeGameStep(GameLoopStep.DIALOGUE);
    }

    public void ExitInteraction()
    {
        DialogueManager.Instance.HideDialogue();
        CharacterInteraction.Instance.ChangeGameStep(GameLoopStep.EXPLORE);
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
