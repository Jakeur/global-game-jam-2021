using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class CameraAnimationManager : MonoBehaviour
{
    Animator animator;
    private static CameraAnimationManager _instance;

    public static CameraAnimationManager Instance => _instance;

    private static int _currentStage = 0;

    public Action<Waypoint> OnTransitionTriggered;

    public int CurrentStage => _currentStage;

    private void Awake()
    {
        if (_instance != null)
        {
            Destroy(this);
        }

        _instance = this;
        animator = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void TriggerTransition(string transitionId, Waypoint targetWaypoint)
    {
        animator.SetFloat("speed", targetWaypoint.StageId == _currentStage ? -1f : 1f);

        animator.Play(transitionId);

        OnTransitionTriggered.Invoke(targetWaypoint);
    }
}
