using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterInteraction : MonoBehaviour
{
    [SerializeField] string InteractableTag = "Interactable";
    [SerializeField] InputReader inputReader;

    private GameLoopStep currentStep;

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
    }

    private void OnDisable()
    {
        // Unsubscribe to events
        inputReader.rightArmEvent -= OnRightArm;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == InteractableTag)
        {
            other.gameObject.GetComponent<IInteractable>().Interact();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == InteractableTag)
        {
            other.gameObject.GetComponent<IInteractable>().ExitInteraction();
        }
    }

    private void OnRightArm()
    {
        Debug.Log("Character RightArm handler.");
    }
}
