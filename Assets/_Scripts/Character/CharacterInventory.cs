using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInventory : MonoBehaviour
{
    [SerializeField] Equipmentslot leftLeg;
    [SerializeField] Equipmentslot rightLeg;
    [SerializeField] Equipmentslot torso;
    [SerializeField] Equipmentslot leftArm;
    [SerializeField] Transform leftArmPivot;
    private bool leftArmActive = false;
    private bool rightArmActive = false;

    [SerializeField] Transform rightArmPivot;
    [SerializeField] Equipmentslot rightArm;


    private GamepadActions controls;

    public static CharacterInventory Instance { get; private set; }

    private PlayerController controller;

    private void Awake()
    {
        controller = GetComponent<PlayerController>();
        controls = new GamepadActions();

        controls.Player.Move.performed += ctx => OnMove();
        controls.Player.Move.canceled += ctx => OnStop();

        controls.Player.Jump.performed += ctx => Jump();
    }

    private void OnEnable()
    {
        controls.Player.Enable();
    }

    private void OnDisable()
    {
        controls.Player.Disable();
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

    private void OnMove()
    {
        if (controller.IsGrounded)
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
        else
        {
            OnStop();
        }
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

    public void ActivateLeftArm()
    {
        if (leftArm.Equipment != null)
        {
            leftArm.Equipment.Activate();
            leftArmActive = true;
        }
    }

    public void StopLeftArm()
    {
        if (leftArm.Equipment != null)
        {
            leftArm.Equipment.DeActivate();
            leftArmActive = false;
            leftArmPivot.localRotation = Quaternion.Euler(0,0,-90);
        }        
    }

    public void ActivateRightArm()
    {
        if (rightArm.Equipment != null)
        {
            rightArm.Equipment.Activate();
            rightArmActive = true;
        }
    }

    public void StopRighttArm()
    {
        if (rightArm.Equipment != null)
        {
            rightArm.Equipment.DeActivate();
            rightArmActive = false;
            rightArmPivot.localRotation = Quaternion.Euler(0, 0, -90f);
        }
    }

    public void MoveArm(Vector2 direction)
    {
        float angle =  Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        //Quaternion rotation = Quaternion.AngleAxis(Vector2.SignedAngle(Vector2.up, direction), leftArmPivot.right);

        if (leftArmActive)
        {
            leftArmPivot.rotation = Quaternion.Euler(leftArmPivot.rotation.x, leftArmPivot.rotation.y, angle);
        }
        if (rightArmActive)
        {
            rightArmPivot.rotation = Quaternion.Euler(leftArmPivot.rotation.x, leftArmPivot.rotation.y, angle);
        }
    }

    public void Jump()
    {
        if (controller.IsGrounded)
        {
            if (leftLeg.Equipment != null)
                leftLeg.Equipment.Activate();
            if (rightLeg.Equipment != null)
                rightLeg.Equipment.Activate();
            if (torso.Equipment != null)
                torso.Equipment.Activate();
        }
    }
}
