using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipNewItem : MonoBehaviour, IInteractable, IEquipItem
{
    [SerializeField] DialogueSO welcomeDialogue;
    [SerializeField] ArmUiSO ArmToEquip;
    [SerializeField] InputReader inputReader;

    public void Interact()
    {
        DialogueManager.Instance.RefreshDialogueContent(welcomeDialogue);
        DialogueManager.Instance.ShowDialogue();
        CharacterInteraction.Instance.ChangeGameStep(GameLoopStep.DIALOGUE);
        inputReader.openDialogueEvent += OpenInventory;
    }

    public void ExitInteraction()
    {
        EquipItemManager.Instance.HideInventory();
        CharacterInteraction.Instance.ChangeGameStep(GameLoopStep.EXPLORE);
        inputReader.openDialogueEvent -= OpenInventory;
    }

    void OnEnable()
    {
        inputReader.equipEvent += Equip;
        inputReader.cancelEvent += Cancel;
    }

    void OnDisable()
    {
        inputReader.equipEvent -= Equip;
        inputReader.cancelEvent -= Cancel;
    }

    public void OpenInventory()
    {
        // UI content refresh
        DialogueManager.Instance.HideDialogue();
        EquipItemManager.Instance.RefreshInventoryUiContent(ArmToEquip);

        EquipItemManager.Instance.ShowInventory();
        CharacterInteraction.Instance.ChangeGameStep(GameLoopStep.INVENTORY);
    }

    public void Equip()
    {
        CharacterInventory.Instance.EquipArm(ArmToEquip);
        ExitInteraction();
    }

    public void Cancel()
    {
        ExitInteraction();
    }
}
