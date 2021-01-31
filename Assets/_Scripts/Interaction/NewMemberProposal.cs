using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMemberProposal : MonoBehaviour, IInteractable, ITrader
{
    [SerializeField] DialogueSO welcomeDialogue;
    [SerializeField] DialogueSO tradingDialogue;
    [SerializeField] ArmUiSO ArmToTrade;

    public void Interact()
    {
        DialogueManager.Instance.RefreshDialogueContent(welcomeDialogue);
        DialogueManager.Instance.ShowDialogue();
        CharacterInteraction.Instance.ChangeGameStep(GameLoopStep.DIALOGUE);
    }

    public void ExitInteraction()
    {
        DialogueManager.Instance.HideDialogue();
        TradeManager.Instance.HideTrade();
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

    public void OpenTrade()
    {
        // UI content refresh
        DialogueManager.Instance.RefreshDialogueContent(tradingDialogue);
        TradeManager.Instance.RefreshTradeContent(ArmToTrade);

        TradeManager.Instance.ShowTrade();
        CharacterInteraction.Instance.ChangeGameStep(GameLoopStep.INVENTORY);
    }

    public void Accept()
    {
        CharacterInventory.Instance.EquipArm(ArmToTrade);
        ExitInteraction();   
    }

    public void Decline()
    {
        ExitInteraction();
    }
}
