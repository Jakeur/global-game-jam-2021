using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AEquipment : MonoBehaviour, IEquipable
{
    [SerializeField] protected float _abilityValue;
    public float AbilityValue => _abilityValue;

    public abstract void Activate();

    public abstract void Animate(string animationTriggerId);

    public abstract void Drop();

    public abstract void Stop(string animationTriggerId);
}
