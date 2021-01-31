using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInventory : MonoBehaviour
{
    [SerializeField] Equipmentslot leftLeg;
    [SerializeField] Equipmentslot rightLeg;
    [SerializeField] Equipmentslot torso;
    [SerializeField] Equipmentslot leftArm;
    [SerializeField] Equipmentslot rightArm;


    [SerializeField] InputReader inputReader;

    public static CharacterInventory Instance { get; private set; }

    private void OnEnable()
    {
        inputReader.moveEvent += OnMove;
        inputReader.moveEventEnd += OnStop;
    }

    private void OnDisable()
    {
        inputReader.moveEvent -= OnMove;
        inputReader.moveEventEnd -= OnStop;
    }

    public void EquipArm(ArmUiSO newArm)
    {
        Debug.Log("Equip new arm : " + newArm.Side);

        if (newArm.Side == ArmSide.LEFT)
            Debug.Log("TODO: Update LeftArm 3d model.");
        else if (newArm.Side == ArmSide.RIGHT)
            Debug.Log("TODO: Update RightArm 3d model.");
    }

    public float GetLegSpeed()
    {
        return (leftLeg.Equipment != null ? leftLeg.Equipment.AbilityValue : 0f)
            + (rightLeg.Equipment != null ? rightLeg.Equipment.AbilityValue : 0f);
    }

    private void OnMove(Vector2 move)
    {
        if (leftLeg.Equipment != null)
            leftLeg.Equipment.Animate("walk_left");
        if (rightLeg.Equipment != null)
            rightLeg.Equipment.Animate("walk_right");
        if (leftArm.Equipment != null)
            leftArm.Equipment.Animate("walk_left");
        if (rightArm.Equipment != null)
            rightArm.Equipment.Animate("walk_right");
        if (torso.Equipment != null)
            torso.Equipment.Animate("walk");
    }

    public void OnStop()
    {
        if (leftLeg.Equipment != null)
            leftLeg.Equipment.Stop("walk_left");
        if (rightLeg.Equipment != null)
            rightLeg.Equipment.Stop("walk_right");
        if (leftArm.Equipment != null)
            leftArm.Equipment.Stop("walk_left");
        if (rightArm.Equipment != null)
            rightArm.Equipment.Stop("walk_right");
        if (torso.Equipment != null)
            torso.Equipment.Stop("walk");
    }
}
