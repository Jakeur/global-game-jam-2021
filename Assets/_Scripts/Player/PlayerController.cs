using System.Collections;
using UnityEngine;

/// <summary>
/// This script allows to move the player ball and must be put on it. 
/// Arrow and space key board can be use for debugging the application.
/// </summary>
public class PlayerController : MonoBehaviour
{
    [Header("Player's parameters")]
    [SerializeField] DirectionSelectionMenu directionSelectionMenu;
    [SerializeField] float speed = 2;
    [SerializeField] float acceleration = 1f;
    [SerializeField] float jumpForce = 3;
    [SerializeField] float distGround = 0.1f;
    [SerializeField] LayerMask groundMask;

    [SerializeField] Transform playerBody;
    private bool isFlipped = false;

    [SerializeField] Torso torso;

    /// Private variables.
    private Rigidbody rb;
    private bool isDestroyed = false;
    private Vector3 initialPosition;
    private Animator animator;
    private float direction = 0;
    private bool isJump;
    private bool _isGrounded = true;
    public bool IsGrounded => _isGrounded;

    private GamepadActions controls;

    private void Awake()
    {
        controls = new GamepadActions();

        controls.Player.Move.performed += ctx => direction = -ctx.ReadValue<Vector2>().x;
        controls.Player.Move.canceled += ctx => direction = 0f;
    }

    private void OnEnable()
    {
        controls.Player.Enable();
        torso.OnJump += OnJump;
    }

    private void OnDisable()
    {
        controls.Player.Disable();
        torso.OnJump -= OnJump;
    }

    private void Start()
    {
        //PlayerSpawn();
        rb = gameObject.GetComponent<Rigidbody>();
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

    private void Update()
    {
        _isGrounded = Physics.Raycast(transform.position, -Vector3.up, distGround + 0.2f, groundMask);

        if (direction < 0 && !isFlipped)
        {
            isFlipped = true;
            playerBody.localRotation = Quaternion.Euler(0, -180, 0);
        }

        if (direction > 0 && isFlipped)
        {
            isFlipped = false;
            playerBody.localRotation = Quaternion.Euler(0, -0, 0);
        }
    }

    private void PlayerMovement()
    {
        if (_isGrounded)
        {
            Vector3 newVelocity = transform.forward * direction * speed * Time.fixedDeltaTime;
            newVelocity.y = rb.velocity.y;

            rb.velocity = newVelocity;
        }
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

    private void OnJump()
    {
        if (_isGrounded)
        {
            rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
        }
    }

    private void OnDestroy()
    {
        CameraAnimationManager.Instance.OnTransitionTriggered -= UpdateStagePosition;
    }
}
