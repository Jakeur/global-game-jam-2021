using System.Collections;
using UnityEngine;

/// <summary>
/// This script allows to move the player ball and must be put on it. 
/// Arrow and space key board can be use for debugging the application.
/// </summary>
public class PlayerController : MonoBehaviour
{
    [Header("Player's parameters")]
    [SerializeField] InputReader inputReader;
    [SerializeField] DirectionSelectionMenu directionSelectionMenu;
    [SerializeField] float speed = 2;
    [SerializeField] float decelleration = 1f;
    [SerializeField] float jumpForce = 3;
    [SerializeField] float distGround = 0.1f;

    /// Private variables.
    private Rigidbody rb;
    private bool isDestroyed = false;
    private Vector3 initialPosition;
    private Animator animator;
    private float direction = 0;
    private bool isJump;

    private void OnEnable()
    {
        inputReader.moveEvent += OnMove;
        inputReader.jumpEvent += OnJump;
    }

    private void OnDisable()
    {
        inputReader.moveEvent -= OnMove;
        inputReader.jumpEvent -= OnJump;
    }

    private void Start()
    {
        // PlayerSpawn();
        rb = gameObject.GetComponent<Rigidbody>();
        // animator = gameObject.GetComponent<Animator>();
    }

    private void PlayerSpawn()
    {
        Vector3 spawnPosition = new Vector3();
        if (!PlayerPrefs.HasKey("Spawn"))
        {
            initialPosition = transform.position;
            PlayerPrefs.SetString("Spawn", gameObject.transform.position.ToString());
        }
        string spawn = PlayerPrefs.GetString("Spawn");
        spawn = spawn.Replace("(", "");
        spawn = spawn.Replace(")", "");
        spawn = spawn.Replace(",", ";");

#if UNITY_EDITOR
        spawn = spawn.Replace(".", ",");
#endif

        string[] splitPosition = spawn.Split(";"[0]);

        spawnPosition = new Vector3(float.Parse(splitPosition[0]), float.Parse(splitPosition[1]), float.Parse(splitPosition[2]));

        gameObject.transform.position = spawnPosition;
    }

    private void FixedUpdate()
    {
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        float z = 0.0f;

        if (IsGrounded())
        {
            if (direction != 0)
            {
                z = -direction*speed;
            }
            else
            {
                z = -rb.velocity.z * decelleration;
            }
        }
        if (isJump && rb.velocity.y <= 0.1f && IsGrounded())
        {
            float y = jumpForce - rb.velocity.y;
            rb.AddForce(0, y, 0, ForceMode.Impulse);
            isJump = false;
        }

        if ((rb.velocity.z > speed) || (rb.velocity.z < -speed ))
        {
            z = 0;
        }

        rb.AddRelativeForce(0, 0, z, ForceMode.Impulse);
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

    /// <summary> Detect if the player is on the ground. </summary>
    private bool IsGrounded()
    {
        return Physics.Raycast(transform.position, -Vector3.up, distGround + 0.2f);
    }

    private void OnMove(Vector2 move)
    {
        direction = move.x;
    }
    private void OnJump()
    {
        isJump = true;
    }
    private void OnDestroy()
    {
        CameraAnimationManager.Instance.OnTransitionTriggered -= UpdateStagePosition;
    }
}
