using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SlotType
{
    ARM,
    LEG,
    BACK,
    HEAD
}

[Serializable]
public class Equipmentslot
{
    [SerializeField] Transform pivot;
    [SerializeField] SlotType slotType;

    private IEquipable _equipment;

    public IEquipable Equipment => _equipment;

    public void AttachEquipment(IEquipable equipment)
    {
        if (_equipment != null)
        {
            _equipment.Drop();
        }
    }
}
