using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractCommand : Command
{
    private Transform _transform;
    private IInteractable _interactedWith;

    [SerializeField] private LayerMask LayerInteractable;
    [SerializeField] private float RayLength;

    void Awake()
    {
        _transform = transform;
    }

    public override void Execute()
    {
        Physics.Raycast(_transform.position,
                  _transform.forward, out var hit, RayLength,
                  LayerInteractable);

        Debug.Log($"{gameObject.name} is trying to interact");

        if (hit.collider == null) return;

        Debug.Log($"{gameObject.name} is interacted with {hit.collider.gameObject.name}");

        _interactedWith = hit.collider.GetComponent<IInteractable>();
        _interactedWith?.Interact();
    }
}
