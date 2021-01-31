using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SlotType
{
    ARM,
    LEG,
    BACK,
    HEAD,
    TORSO
}

[Serializable]
public class Equipmentslot
{
    [SerializeField] Transform pivot;
    [SerializeField] SlotType slotType;

    [SerializeField] private AEquipment _equipment;

    public IEquipable Equipment => _equipment;

    public void AttachEquipment(IEquipable equipment)
    {
        if (_equipment != null)
        {
            _equipment.Drop();
        }
    }
}
