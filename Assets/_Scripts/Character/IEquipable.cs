using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEquipable
{
    float AbilityValue { get; }

    void Animate(string animationTriggerId);

    void Stop(string animationTriggerId);

    void Drop();

    void Activate();

    void DeActivate();
}
