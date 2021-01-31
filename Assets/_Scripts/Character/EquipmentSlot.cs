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
    [SerializeField] IEquipable equipment;
    [SerializeField] SlotType[] slotTypes;
}
