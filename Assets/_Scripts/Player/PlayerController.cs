using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// This script allows to move the player ball and must be put on it. 
/// Arrow and space key board can be use for debugging the application.
/// </summary>
public class PlayerController : MonoBehaviour
{
    [Header("Player's parameters")]
    [SerializeField] InputReader inputReader;
    public float speed = 2;
    public float jumpForce = 3;
    public float distGround = 0.1f;

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
    }

    private void OnDisable()
    {
        inputReader.moveEvent -= OnMove;
    }

    private void Start()
    {
        // PlayerSpawn();

        Manager.manager.currentTable = SceneManager.GetActiveScene().name;
        rb = GetComponent<Rigidbody>();

        animator = gameObject.GetComponent<Animator>();
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
        transform.position -= transform.forward * direction * speed * Time.deltaTime;
    }

    /// <summary> Detect if the player is on the ground. </summary>
    private bool IsGrounded()
    {
        return Physics.Raycast(transform.position, -Vector3.up, distGround + 0.2f);
    }

    /// <summary> Wait a specific time defined by the user. </summary>
    /// <param name="seconds"> Time to wait in seconds. </param>
    /// <returns> Return true if the waiting time is over. </returns>
    private IEnumerator Wait(float seconds)
    {
        yield return new WaitForSeconds(seconds);
    }

    private void OnMove(Vector2 move)
    {
        direction = move.y;
    }
    private void OnJump()
    {
        isJump = true;
    }
}
