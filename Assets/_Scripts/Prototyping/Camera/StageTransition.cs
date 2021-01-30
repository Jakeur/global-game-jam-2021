using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class StageTransition
{
    [SerializeField] Waypoint endStage;
    public Waypoint EndPoint => endStage;

    [SerializeField] KeyCode _key;
    public KeyCode Key => _key;

    public KeyCode GetDirection(int currentStage)
    {
        if (currentStage == endStage.StageId)
        {
            return SwitchDirection();
        }

        return _key;
    }

    private KeyCode SwitchDirection()
    {
        switch (_key)
        {
            case KeyCode.UpArrow:
                return KeyCode.DownArrow;
            case KeyCode.DownArrow:
                return KeyCode.UpArrow;
            case KeyCode.LeftArrow:
                return KeyCode.RightArrow;
            case KeyCode.RightArrow:
                return KeyCode.LeftArrow;
            default:
                return KeyCode.None;
        }
    }
}
