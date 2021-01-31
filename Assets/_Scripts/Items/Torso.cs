using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torso : AEquipment
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public override void Activate()
    {
        throw new System.NotImplementedException();
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
}
