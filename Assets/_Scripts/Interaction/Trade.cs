using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trade : MonoBehaviour, IInteractable, ITrader
{
    [SerializeField] DialogueSO welcomeDialogue;
    [SerializeField] DialogueSO tradingDialogue;
    [SerializeField] ArmUiSO ArmToTrade;
    [SerializeField] InputReader inputReader;

    void OnEnable()
    {
        inputReader.acceptEvent += Accept;
        inputReader.declineEvent += Decline;
    }

    void OnDisable()
    {
        inputReader.acceptEvent -= Accept;
        inputReader.declineEvent -= Decline;
    }

    public void Interact()
    {
        DialogueManager.Instance.RefreshDialogueContent(welcomeDialogue);
        DialogueManager.Instance.ShowDialogue();
        CharacterInteraction.Instance.ChangeGameStep(GameLoopStep.DIALOGUE);
        inputReader.openDialogueEvent += OpenTrade;
    }

    public void ExitInteraction()
    {
        DialogueManager.Instance.HideDialogue();
        TradeManager.Instance.HideTrade();
        CharacterInteraction.Instance.ChangeGameStep(GameLoopStep.EXPLORE);
        inputReader.openDialogueEvent -= OpenTrade;
    }

    public void OpenTrade()
    {
        // UI content refresh
        DialogueManager.Instance.RefreshDialogueContent(tradingDialogue);
        TradeManager.Instance.RefreshTradeContent(ArmToTrade);

        TradeManager.Instance.ShowTrade();
        CharacterInteraction.Instance.ChangeGameStep(GameLoopStep.TRADE);
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
