using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StageDirection
{
    UP,
    RIGHT,
    DOWN,
    LEFT,
    NONE
}

[Serializable]
public class StageTransition
{
    [SerializeField] Waypoint endStage;
    public Waypoint EndPoint => endStage;

    [SerializeField] StageDirection _key;
    public StageDirection Key => _key;

    public StageDirection GetDirection(int currentStage)
    {
        if (currentStage == endStage.StageId)
        {
            return SwitchDirection();
        }

        return _key;
    }

    private StageDirection SwitchDirection()
    {
        switch (_key)
        {
            case StageDirection.UP:
                return StageDirection.DOWN;
            case StageDirection.DOWN:
                return StageDirection.UP;
            case StageDirection.LEFT:
                return StageDirection.RIGHT;
            case StageDirection.RIGHT:
                return StageDirection.LEFT;
            default:
                return StageDirection.NONE;
        }
    }
}
