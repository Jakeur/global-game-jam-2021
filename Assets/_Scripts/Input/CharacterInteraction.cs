using System.Collections;
using UnityEngine;

[RequireComponent(typeof(ThirdPersonCharacter))]
public class CharacterInteraction : MonoBehaviour
{
    [SerializeField] string InteractableTag = "Interactable";
    [SerializeField] InputReader inputReader;

    /// Private variables.
    private Rigidbody rb;
    private bool isDestroyed = false;
    private Vector3 initialPosition;
    private bool isJump;

    private ThirdPersonCharacter m_Character;
    private Vector3 m_Move;
    private float z;

    private void OnEnable()
    {
        inputReader.rightArmEvent += OnRightArm;
        inputReader.leftArmEvent += OnLeftArm;
        inputReader.jumpEvent += OnJump;
        inputReader.moveEvent += OnPlayerMove;
    }

    private void OnDisable()
    {
        inputReader.rightArmEvent -= OnRightArm;
        inputReader.leftArmEvent -= OnLeftArm;
        inputReader.jumpEvent -= OnJump;
        inputReader.moveEvent -= OnPlayerMove;
    }

    private void Start()
    {
        PlayerSpawn();
        rb = GetComponent<Rigidbody>();

        m_Character = GetComponent<ThirdPersonCharacter>();
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
        bool crouch = Input.GetKey(KeyCode.C);

        Debug.Log("Z: " + z);
        m_Move = z * transform.forward;

        m_Character.Move(m_Move, crouch, isJump);
        isJump = false;
    }


    private IEnumerator Wait(float seconds)
    {
        yield return new WaitForSeconds(seconds);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == InteractableTag)
        {
            other.gameObject.GetComponent<IInteractable>().Interact();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == InteractableTag)
        {
            other.gameObject.GetComponent<IInteractable>().ExitInteraction();
        }
    }

    private void OnRightArm()
    {
        Debug.Log("Character RightArm handler.");       
    }

    private void OnLeftArm()
    {
        Debug.Log("Character left arm handler.");
    }

    private void OnJump()
    {
        isJump = true;
    }

    private void OnPlayerMove(Vector2 vector2)
    {
        z = vector2.x;
    }

}
