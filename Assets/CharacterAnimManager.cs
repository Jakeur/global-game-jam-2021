using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterInventory))]
public class CharacterAnimManager : MonoBehaviour
{
    CharacterInventory _inventory;

    [SerializeField] InputReader inputReader;

    private void Awake()
    {
        _inventory = GetComponent<CharacterInventory>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnEnable()
    {
        inputReader.moveEvent += Walk;
    }

    private void OnDisable()
    {
        inputReader.moveEvent -= Walk;
    }

    void Walk(Vector2 move)
    {

    }
}
