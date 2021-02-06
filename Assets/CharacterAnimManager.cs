using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterInventory))]
public class CharacterAnimManager : MonoBehaviour
{
    CharacterInventory _inventory;

    GamepadActions controls;

    private void Awake()
    {
        _inventory = GetComponent<CharacterInventory>();
        controls = new GamepadActions();
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    void Walk(Vector2 move)
    {

    }
}
