using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public float speed = 2;

    [SerializeField] DirectionSelectionMenu directionSelectionMenu;

    private bool movementLocked = false;

    // Start is called before the first frame update
    void Start()
    {
        CameraAnimationManager.Instance.OnTransitionTriggered += UpdateStagePosition;
    }

    // Update is called once per frame
    void Update()
    {
        float direction = Input.GetAxis("Horizontal");
        transform.position -= transform.forward * direction * speed * Time.deltaTime;
    }

    void UpdateStagePosition(Waypoint stageEndpoint)
    {
        transform.LookAt(stageEndpoint.transform.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "CameraTrigger")
        {
            Waypoint wp = other.gameObject.GetComponent<Waypoint>();

            if (wp.Transitions != null && wp.Transitions.Length > 0)
            {
                if (wp.TriggerCamera)
                    directionSelectionMenu.Open(wp);
            }
            else if (wp.Transitions.Length == 1)
            {
                UpdateStagePosition(wp.Transitions[0].EndPoint);
            }
        }
    }

    private void OnDestroy()
    {
        CameraAnimationManager.Instance.OnTransitionTriggered -= UpdateStagePosition;
    }
}
