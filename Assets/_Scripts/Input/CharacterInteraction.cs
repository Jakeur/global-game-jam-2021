using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterInteraction : MonoBehaviour
{
    [SerializeField] string InteractableTag = "Interactable";
    [SerializeField] InputReader inputReader;

    private GameLoopStep currentStep;
    private GameObject characterInteractingWith;

    public static CharacterInteraction Instance { get; private set; }

    private void CreateInstance()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    public void ChangeGameStep(GameLoopStep newStep)
    {
        currentStep = newStep;

        switch (currentStep)
        {
            case GameLoopStep.DIALOGUE:
                inputReader.EnableDialogueInput();
                break;
            case GameLoopStep.EXPLORE:
                inputReader.EnablePlayerInput();
                break;
            case GameLoopStep.INVENTORY:
                inputReader.EnableInventoryInput();
                break;
            case GameLoopStep.MENU:
                inputReader.EnableMenuInput();
                break;
        }
    }

    public int GetControllerId()
    {
        return ((int)inputReader.controller);
    }

    private void OnEnable()
    {
        // Singleton creation
        CreateInstance();

        // Init step
        currentStep = GameLoopStep.EXPLORE;

        // Subscribe to events
        inputReader.rightArmEvent += OnRightArm;
        inputReader.openDialogueEvent += OnOpenDialog;
        inputReader.equipEvent += OnEquip;
        inputReader.declineEvent += OnDecline;
        inputReader.chooseStageEvent += OnChooseStage;
    }

    private void OnDisable()
    {
        // Unsubscribe to events
        inputReader.rightArmEvent -= OnRightArm;
        inputReader.openDialogueEvent -= OnOpenDialog;
        inputReader.equipEvent -= OnEquip;
        inputReader.declineEvent -= OnDecline;
        inputReader.chooseStageEvent -= OnChooseStage;
    }

    #region Trigger events

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == InteractableTag)
        {
            other.gameObject.GetComponent<IInteractable>().Interact();
            characterInteractingWith = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == InteractableTag)
        {
            other.gameObject.GetComponent<IInteractable>().ExitInteraction();
            characterInteractingWith = null;
        }
    }

    #endregion

    #region Handle function

    private void OnRightArm()
    {
        Debug.Log("Character RightArm handler.");
    }

    private void OnOpenDialog()
    {
        if (characterInteractingWith != null)
            characterInteractingWith.GetComponent<ITrader>().OpenTrade();
    }

    private void OnEquip()
    {
        if (characterInteractingWith != null)
            characterInteractingWith.GetComponent<ITrader>().Accept();
    }

    private void OnDecline()
    {
        if (characterInteractingWith != null)
            characterInteractingWith.GetComponent<ITrader>().Decline();
    }

    private void OnChooseStage(Vector2 vector)
    {
        if (vector.x > 0 && vector.y == 0)
            Debug.Log("Choose right path");
        else if (vector.x < 0 && vector.y == 0)
            Debug.Log("Choose left path");
        else if (vector.y > 0 && vector.x == 0)
            Debug.Log("Choose up path");
        else if (vector.y < 0 && vector.x == 0)
            Debug.Log("Choose down path");
    }

    #endregion
}
