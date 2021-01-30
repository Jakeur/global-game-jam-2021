using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterInteraction : MonoBehaviour
{
    [SerializeField] string InteractableTag = "Interactable";
    [SerializeField] InputReader inputReader;

    private void OnEnable()
    {
        inputReader.rightArmEvent += OnRightArm;
    }

    private void OnDisable()
    {
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
