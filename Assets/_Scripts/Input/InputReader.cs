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
	public event UnityAction declineEvent;
	public event UnityAction rightArmEvent;
	public event UnityAction interactEvent; // Used to talk, pickup objects, interact with tools
	public event UnityAction competenceEvent; // Extra action
	public event UnityAction<Vector2> moveEvent;
	public event UnityAction<Vector2> aimEvent;
	public event UnityAction<Vector2> chooseStageEvent;

	// Dialogue
	public event UnityAction advanceDialogueEvent = delegate { };
	public event UnityAction onMoveSelectionEvent = delegate { };

	private GamepadActions gameInput;

	// Public accessor
	public GameController controller;

	private void OnEnable()
	{
		// Init controller
		if (Input.GetJoystickNames().Length > 0 &&
			Input.GetJoystickNames()[0].Contains("Sony"))
			controller = GameController.PLAYSTATION;
		else
			controller = GameController.XBOX;

		// Init callbacks
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
		gameInput.Player.Disable();
		gameInput.Dialogue.Enable();
		gameInput.Menu.Disable();
		gameInput.Inventory.Disable();
	}

	public void EnableMenuInput()
	{
		gameInput.Player.Disable();
		gameInput.Dialogue.Disable();
		gameInput.Menu.Enable();
		gameInput.Inventory.Disable();
	}

	public void EnableInventoryInput()
	{
		gameInput.Player.Disable();
		gameInput.Dialogue.Disable();
		gameInput.Menu.Disable();
		gameInput.Inventory.Enable();
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
		gameInput.Player.Disable();
		gameInput.Dialogue.Disable();
		gameInput.Menu.Disable();
		gameInput.Inventory.Disable();
	}

	public void OnOpenDialogue(InputAction.CallbackContext context)
	{
		if (openDialogueEvent != null && context.phase == InputActionPhase.Performed)
		{
			openDialogueEvent.Invoke();
		}
	}

    public void OnEquip(InputAction.CallbackContext context)
	{
		if (equipEvent != null && context.phase == InputActionPhase.Performed)
		{
			equipEvent.Invoke();
		}
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

	public void OnChooseStage(InputAction.CallbackContext context)
	{
		if (chooseStageEvent != null && context.phase == InputActionPhase.Performed)
		{
			chooseStageEvent.Invoke(context.ReadValue<Vector2>());
		}
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

    public void OnRefuse(InputAction.CallbackContext context)
	{
		if (declineEvent != null && context.phase == InputActionPhase.Performed)
		{
			declineEvent.Invoke();
		}
	}
}
