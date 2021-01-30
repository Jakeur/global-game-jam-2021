using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterInput : MonoBehaviour, IInteractInput
{
    public Command interactInput;
    private GamepadActions _inputActions;

    [SerializeField] string InteractableTag = "Interactable";

    public bool IsPressingInteract { get; private set; }

    private void Awake()
    {
        _inputActions = new GamepadActions();
    }

    private void OnEnable()
    {
        _inputActions.Enable();
        _inputActions.Player.Jump.performed += OnInteractButton;
        _inputActions.Player.LeftArm.performed += OnInteractButton;
        _inputActions.Player.RightArm.performed += OnInteractButton;
        _inputActions.Player.Competence.performed += OnInteractButton;
        _inputActions.Player.Interact.performed += OnInteractButton;
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

    private void OnInteractButton(InputAction.CallbackContext context)
    {
        var value = context.ReadValue<float>();
        IsPressingInteract = value >= 0.15;

        if (interactInput != null && IsPressingInteract)
            interactInput.Execute();
    }


    private void OnDisable()
    {
        _inputActions.Disable();
        _inputActions.Player.Jump.performed -= OnInteractButton;
        _inputActions.Player.LeftArm.performed -= OnInteractButton;
        _inputActions.Player.RightArm.performed -= OnInteractButton;
        _inputActions.Player.Competence.performed -= OnInteractButton;
        _inputActions.Player.Interact.performed += OnInteractButton;

    }

}
