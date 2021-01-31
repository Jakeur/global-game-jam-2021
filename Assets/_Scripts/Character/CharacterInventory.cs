using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInventory : MonoBehaviour
{
    [SerializeField] public ArmSO LeftArm;
    [SerializeField] public ArmSO RightArm;

    public static CharacterInventory Instance { get; private set; }

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

    private void Awake()
    {
        // Singleton creation
        CreateInstance();
    }

    public void EquipArm(ArmUiSO newArm)
    {
        Debug.Log("Equip new arm : " + newArm.Side);

        if (newArm.Side == ArmSide.LEFT)
            Debug.Log("TODO: Update LeftArm 3d model.");
        else if (newArm.Side == ArmSide.RIGHT)
            Debug.Log("TODO: Update RightArm 3d model.");
    }
}
