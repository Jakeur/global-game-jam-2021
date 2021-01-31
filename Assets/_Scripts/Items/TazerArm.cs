using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TazerArm : AEquipment
{

    Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();    
    }

    public override void Activate()
    {
        animator.SetBool("activate", true);
    }

    public override void DeActivate()
    {
        animator.SetBool("activate", false);
    }

    public override void Animate(string animationTriggerId)
    {
        return;
    }

    public override void Drop()
    {
        throw new System.NotImplementedException();
    }

    public override void Stop(string animationTriggerId)
    {
        return;
    }
}
