using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "InputReader", menuName = "ScriptableObjects/Input Reader")]
public class InputReader : ScriptableObject, GamepadActions.IDialogueActions, GamepadActions.IInventoryActions, GamepadActions.IMenuActions, GamepadActions.IPlayerActions
{
	// Gameplay
	public event UnityAction jumpEvent;
	public event UnityAction leftArmEvent;
	public event UnityAction openDialogueEvent;
	public event UnityAction equipEvent;
	public event UnityAction rightArmEvent;
	public event UnityAction interactEvent; // Used to talk, pickup objects, interact with tools
	public event UnityAction competenceEvent; // Extra action
	public event UnityAction<Vector2> moveEvent;
	public event UnityAction<Vector2> aimEvent;

	// Dialogue
	public event UnityAction advanceDialogueEvent = delegate { };
	public event UnityAction onMoveSelectionEvent = delegate { };

	private GamepadActions gameInput;

	private void OnEnable()
	{
		if (gameInput == null)
		{
			gameInput = new GamepadActions();
			gameInput.Player.SetCallbacks(this);
			gameInput.Dialogue.SetCallbacks(this);
			gameInput.Menu.SetCallbacks(this);
			gameInput.Inventory.SetCallbacks(this);
		}

		EnablePlayerInput();
	}

	private void OnDisable()
	{
		DisableAllInput();
	}

	public void EnableDialogueInput()
	{
		//gameInput.Dialogues.Enable();
		//gameInput.Gameplay.Disable();
	}

	public void EnablePlayerInput()
	{
		gameInput.Player.Enable();
		gameInput.Dialogue.Disable();
		gameInput.Menu.Disable();
		gameInput.Inventory.Disable();
	}

	public void DisableAllInput()
	{
		//gameInput.Gameplay.Disable();
		//gameInput.Dialogues.Disable();
	}

    public void OnOpenDialogue(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnEquip(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnNewaction(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnRightArm(InputAction.CallbackContext context)
	{
		Debug.Log("RightArm");
		if (rightArmEvent != null && context.phase == InputActionPhase.Performed)
		{
			Debug.Log("RightArm event invoke");
			rightArmEvent.Invoke();
		}
    }

    public void OnLeftArm(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnCompetence(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnJump(InputAction.CallbackContext context)
    {
		if (jumpEvent != null && context.phase == InputActionPhase.Performed)
		{
			jumpEvent.Invoke();
		}
	}

    public void OnInteract(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
		if (moveEvent != null)
		{
			moveEvent.Invoke(context.ReadValue<Vector2>());
		}
	}

    public void OnAim(InputAction.CallbackContext context)
	{
		if (aimEvent != null)
		{
			aimEvent.Invoke(context.ReadValue<Vector2>());
		}
	}
}
