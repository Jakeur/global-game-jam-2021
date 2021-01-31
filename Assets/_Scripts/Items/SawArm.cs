using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawArm : AEquipment
{
    Animator animator;

    bool activated = false;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public override void Activate()
    {
        animator.SetBool("activated", true);
    }

    public override void Animate(string animationTriggerId)
    {
        animator.SetBool(animationTriggerId, true);
    }

    public override void Drop()
    {
        throw new System.NotImplementedException();
    }

    public override void Stop(string animationTriggerId)
    {
        animator.SetBool(animationTriggerId, false);
    }

    public override void DeActivate()
    {
        throw new System.NotImplementedException();
    }
}
