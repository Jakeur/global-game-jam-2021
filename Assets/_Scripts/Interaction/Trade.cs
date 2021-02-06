using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trade : MonoBehaviour, IInteractable, ITrader
{
    [SerializeField] DialogueSO welcomeDialogue;
    [SerializeField] DialogueSO tradingDialogue;
    [SerializeField] ArmUiSO ArmToTrade;

    GamepadActions controls;

    void OnEnable()
    {
        controls.Menu.Enable();
    }

    void OnDisable()
    {
        controls.Menu.Disable();
    }

    public void Interact()
    {
        DialogueManager.Instance.RefreshDialogueContent(welcomeDialogue);
        DialogueManager.Instance.ShowDialogue();
        //CharacterInteraction.Instance.ChangeGameStep(GameLoopStep.DIALOGUE);

    }

    public void ExitInteraction()
    {
        DialogueManager.Instance.HideDialogue();
        TradeManager.Instance.HideTrade();
        //CharacterInteraction.Instance.ChangeGameStep(GameLoopStep.EXPLORE);
    }

    public void OpenTrade()
    {
        // UI content refresh
        DialogueManager.Instance.RefreshDialogueContent(tradingDialogue);
        TradeManager.Instance.RefreshTradeContent(ArmToTrade);

        TradeManager.Instance.ShowTrade();
        //CharacterInteraction.Instance.ChangeGameStep(GameLoopStep.TRADE);
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
