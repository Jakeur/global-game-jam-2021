using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistonLeg : AEquipment
{
    private Animator animator;

    // Start is called before the first frame update
    void Awake()
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
        Debug.Log(animationTriggerId);
        animator.SetBool(animationTriggerId, false);
    }
}
