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
            case GameLoopStep.TRADE:
                inputReader.EnableTradeInput();
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

    #endregion
}
