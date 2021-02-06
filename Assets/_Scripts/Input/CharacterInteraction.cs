using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterInteraction : MonoBehaviour
{
    [SerializeField] string InteractableTag = "Interactable";
    GamepadActions controls;

    private bool interacting = false;

    private GameLoopStep currentStep;
    private GameObject characterInteractingWith;

    public static CharacterInteraction Instance { get; private set; }

    private void Awake()
    {
        controls = new GamepadActions();
    }

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

    //public void ChangeGameStep(GameLoopStep newStep)
    //{
    //    currentStep = newStep;

    //    switch (currentStep)
    //    {
    //        case GameLoopStep.DIALOGUE:
    //            inputReader.EnableDialogueInput();
    //            break;
    //        case GameLoopStep.EXPLORE:
    //            inputReader.EnablePlayerInput();
    //            break;
    //        case GameLoopStep.INVENTORY:
    //            inputReader.EnableInventoryInput();
    //            break;
    //        case GameLoopStep.MENU:
    //            inputReader.EnableMenuInput();
    //            break;
    //        case GameLoopStep.TRADE:
    //            // When a player trade, save checkpoint
    //            CheckpointManager.Instance.UpdateCheckpoint(this.gameObject, Camera.main.transform, CameraAnimationManager.Instance.CurrentStage);

    //            inputReader.EnableTradeInput();
    //            break;
    //    }
    //}

    //public int GetControllerId()
    //{
    //    return ((int)inputReader.controller);
    //}

    private void Start()
    {
        // Singleton creation
        CreateInstance();

        // First checkpoint creation
        CheckpointManager.Instance.InstantiateCheckpoint(this.gameObject, Camera.main.transform, CameraAnimationManager.Instance.CurrentStage);
    }

    private void OnEnable()
    {
        // Init step
        currentStep = GameLoopStep.EXPLORE;
    }

    private void OnDisable()
    {
        Debug.Log("Disparu");
    }

    #region Trigger events

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == InteractableTag && !interacting)
        {
            interacting = true;
            other.gameObject.GetComponent<IInteractable>().Interact();
            characterInteractingWith = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == InteractableTag)
        {
            interacting = false;
            other.gameObject.GetComponent<IInteractable>().ExitInteraction();
            characterInteractingWith = null;
        }
    }

    #endregion

    #region Handle function

    public void PlayerDeath()
    {
        // TODO Make animation
        CheckpointManager.Instance.RestoreLastCheckpoint(this.gameObject);

        //Destroy(this.gameObject);
    }

    #endregion
}
