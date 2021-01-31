using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BasicMovement : MonoBehaviour
{
    public float acceleration = 1;

    [SerializeField] DirectionSelectionMenu directionSelectionMenu;
    [SerializeField] InputReader inputReader;

    private bool movementLocked = false;

    float horizontalAxis = 0f;

    private Rigidbody rigidBody;
    private CharacterInventory inventory;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
        inventory = GetComponent<CharacterInventory>();
    }

    // Start is called before the first frame update
    void Start()
    {
        CameraAnimationManager.Instance.OnTransitionTriggered += UpdateStagePosition;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float topSpeed = inventory.GetLegSpeed();

        rigidBody.velocity += transform.forward * horizontalAxis * acceleration;

        rigidBody.velocity = new Vector3(0, rigidBody.velocity.y, Mathf.Clamp(rigidBody.velocity.z, -topSpeed, topSpeed));
    }

    private void OnMove(Vector2 move)
    {
        horizontalAxis = move.y;
    }

    private void OnEnable()
    {
        inputReader.moveEvent += OnMove;
    }

    private void OnDisable()
    {
        inputReader.moveEvent -= OnMove;
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
