// GENERATED AUTOMATICALLY FROM 'Assets/Input/GamepadActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @GamepadActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @GamepadActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GamepadActions"",
    ""maps"": [
        {
            ""name"": ""Menu"",
            ""id"": ""e9926f42-bbd7-4c5b-9384-2ff3ebf06cc0"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""ec0dfc20-2092-462a-badc-c4a903ea1eaa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""401669e9-4987-4474-953a-c7aa21c5295f"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Dialogue"",
            ""id"": ""767ff35e-7513-4ca5-ad19-e0f2f387a917"",
            ""actions"": [
                {
                    ""name"": ""OpenDialogue"",
                    ""type"": ""Button"",
                    ""id"": ""901e5110-296d-4bd2-b9a9-a0e3272221b6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""626d760f-99a8-417f-8127-60e1447e5dc4"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox control scheme;PS4 control scheme"",
                    ""action"": ""OpenDialogue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player"",
            ""id"": ""f37a309e-1f02-48fc-a513-f6532a24c325"",
            ""actions"": [
                {
                    ""name"": ""RightArm"",
                    ""type"": ""Button"",
                    ""id"": ""0b7d472b-1bb9-435d-915b-d094b7816ffc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""LeftArm"",
                    ""type"": ""Button"",
                    ""id"": ""2d10524f-06ad-4cec-bddc-019238403e59"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Competence"",
                    ""type"": ""Button"",
                    ""id"": ""6ae2adb2-2659-4a25-8d4b-62777ac493c4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""b187c776-605b-4eb1-baf9-302ddef156d5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""f40350df-d0ec-4ed2-b46e-70af9bbcbd60"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""ddd9af10-d3ac-4aab-8927-acaada6d6d3c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""StickDeadzone"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Value"",
                    ""id"": ""d8345618-95d1-45f2-9777-0b1b732e4a8f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""StickDeadzone"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChooseStage"",
                    ""type"": ""Value"",
                    ""id"": ""7d77adfb-02ad-444c-873f-835afe627338"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""StickDeadzone"",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4a473fdb-17d6-4ba5-a88a-95665b6473e8"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4 control scheme;Xbox control scheme"",
                    ""action"": ""RightArm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e2c69e26-b65c-4ef4-aa63-98d7add4f96e"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightArm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e9d5f91f-8641-4094-a300-8c8ec61254f3"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4 control scheme;Xbox control scheme"",
                    ""action"": ""LeftArm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8bd0dcc4-ff2c-4049-8503-6f9190a480ef"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftArm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""28c3d684-0fc2-46b0-8996-d5e9334f049f"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox control scheme;PS4 control scheme"",
                    ""action"": ""Competence"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fdab138f-4f2c-460b-8864-783a6afbd5f5"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Competence"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e473e777-1d30-4962-9ace-f6746671c056"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox control scheme;PS4 control scheme"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b5ec25b9-bb89-42af-a555-ecf8e9d5e805"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5dae82e3-3aa8-4913-a612-848b6278520d"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox control scheme;PS4 control scheme"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4c4dae87-c1b4-4418-b336-0c58b4649ce8"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""948c44b9-8a2c-4e43-b17c-9fee674115db"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox control scheme;PS4 control scheme"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""5a624c8e-a2b0-40e3-8255-b94911136b88"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7fbabfd2-d745-4600-b908-b22776a5fc23"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""eb674f44-d262-476c-b90f-739e844de339"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""45934096-3916-4453-956e-e16078f22008"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0f982100-1735-40dd-ae03-fc935163ebce"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""7ef02720-74c1-4c44-b5cf-ec87ded82ea4"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": ""Xbox control scheme;PS4 control scheme"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4365715c-bbf8-44cd-a24b-a19eb94e6f9d"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""d011384c-ea09-4831-ab4c-eb8770297dc4"",
                    ""path"": ""2DVector(mode=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChooseStage"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""19d3d89a-af8d-4a9b-aac9-e8f6ee21120c"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox control scheme;PS4 control scheme"",
                    ""action"": ""ChooseStage"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""53180c19-af7f-4180-992a-89026ffe61d8"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChooseStage"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""56e21749-b892-4f55-b378-82c0a0699be8"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChooseStage"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""535b3a79-a443-452c-be29-f29d55d3db27"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChooseStage"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""96ee0179-c5b0-4ce4-ac6e-4a04d69f4939"",
                    ""path"": ""2DVector(mode=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChooseStage"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d829eb33-1d08-4bb1-84fd-298d6a1b26ba"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChooseStage"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""21fd4367-9ed6-4d42-9678-fc0ee6fea30a"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChooseStage"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8b2af122-8fff-456f-acaf-9277218a68a5"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChooseStage"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1f282f8b-914c-4e89-92be-6eaca3dc06b0"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChooseStage"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Inventory"",
            ""id"": ""d839e154-433d-44f4-bf10-21c3266bbe79"",
            ""actions"": [
                {
                    ""name"": ""Equip"",
                    ""type"": ""Button"",
                    ""id"": ""4051cc87-04fa-4b62-9635-966bbf3514e4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Refuse"",
                    ""type"": ""Button"",
                    ""id"": ""db27c974-d895-42a4-bf4f-0f92278c6c87"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""38231de9-0e96-4cf4-8663-eb435643e11c"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox control scheme;PS4 control scheme"",
                    ""action"": ""Equip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dd156770-55a2-4a94-a55c-a5cd0b61fe01"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Refuse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Xbox control scheme"",
            ""bindingGroup"": ""Xbox control scheme"",
            ""devices"": [
                {
                    ""devicePath"": ""<XboxOneGampadiOS>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""PS4 control scheme"",
            ""bindingGroup"": ""PS4 control scheme"",
            ""devices"": [
                {
                    ""devicePath"": ""<DualShock4GampadiOS>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_Newaction = m_Menu.FindAction("New action", throwIfNotFound: true);
        // Dialogue
        m_Dialogue = asset.FindActionMap("Dialogue", throwIfNotFound: true);
        m_Dialogue_OpenDialogue = m_Dialogue.FindAction("OpenDialogue", throwIfNotFound: true);
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_RightArm = m_Player.FindAction("RightArm", throwIfNotFound: true);
        m_Player_LeftArm = m_Player.FindAction("LeftArm", throwIfNotFound: true);
        m_Player_Competence = m_Player.FindAction("Competence", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_Interact = m_Player.FindAction("Interact", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_Aim = m_Player.FindAction("Aim", throwIfNotFound: true);
        m_Player_ChooseStage = m_Player.FindAction("ChooseStage", throwIfNotFound: true);
        // Inventory
        m_Inventory = asset.FindActionMap("Inventory", throwIfNotFound: true);
        m_Inventory_Equip = m_Inventory.FindAction("Equip", throwIfNotFound: true);
        m_Inventory_Refuse = m_Inventory.FindAction("Refuse", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_Newaction;
    public struct MenuActions
    {
        private @GamepadActions m_Wrapper;
        public MenuActions(@GamepadActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_Menu_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);

    // Dialogue
    private readonly InputActionMap m_Dialogue;
    private IDialogueActions m_DialogueActionsCallbackInterface;
    private readonly InputAction m_Dialogue_OpenDialogue;
    public struct DialogueActions
    {
        private @GamepadActions m_Wrapper;
        public DialogueActions(@GamepadActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @OpenDialogue => m_Wrapper.m_Dialogue_OpenDialogue;
        public InputActionMap Get() { return m_Wrapper.m_Dialogue; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DialogueActions set) { return set.Get(); }
        public void SetCallbacks(IDialogueActions instance)
        {
            if (m_Wrapper.m_DialogueActionsCallbackInterface != null)
            {
                @OpenDialogue.started -= m_Wrapper.m_DialogueActionsCallbackInterface.OnOpenDialogue;
                @OpenDialogue.performed -= m_Wrapper.m_DialogueActionsCallbackInterface.OnOpenDialogue;
                @OpenDialogue.canceled -= m_Wrapper.m_DialogueActionsCallbackInterface.OnOpenDialogue;
            }
            m_Wrapper.m_DialogueActionsCallbackInterface = instance;
            if (instance != null)
            {
                @OpenDialogue.started += instance.OnOpenDialogue;
                @OpenDialogue.performed += instance.OnOpenDialogue;
                @OpenDialogue.canceled += instance.OnOpenDialogue;
            }
        }
    }
    public DialogueActions @Dialogue => new DialogueActions(this);

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_RightArm;
    private readonly InputAction m_Player_LeftArm;
    private readonly InputAction m_Player_Competence;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_Interact;
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_Aim;
    private readonly InputAction m_Player_ChooseStage;
    public struct PlayerActions
    {
        private @GamepadActions m_Wrapper;
        public PlayerActions(@GamepadActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @RightArm => m_Wrapper.m_Player_RightArm;
        public InputAction @LeftArm => m_Wrapper.m_Player_LeftArm;
        public InputAction @Competence => m_Wrapper.m_Player_Competence;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @Interact => m_Wrapper.m_Player_Interact;
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @Aim => m_Wrapper.m_Player_Aim;
        public InputAction @ChooseStage => m_Wrapper.m_Player_ChooseStage;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @RightArm.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightArm;
                @RightArm.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightArm;
                @RightArm.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightArm;
                @LeftArm.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftArm;
                @LeftArm.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftArm;
                @LeftArm.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftArm;
                @Competence.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCompetence;
                @Competence.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCompetence;
                @Competence.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCompetence;
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Interact.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Aim.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAim;
                @ChooseStage.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChooseStage;
                @ChooseStage.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChooseStage;
                @ChooseStage.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChooseStage;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @RightArm.started += instance.OnRightArm;
                @RightArm.performed += instance.OnRightArm;
                @RightArm.canceled += instance.OnRightArm;
                @LeftArm.started += instance.OnLeftArm;
                @LeftArm.performed += instance.OnLeftArm;
                @LeftArm.canceled += instance.OnLeftArm;
                @Competence.started += instance.OnCompetence;
                @Competence.performed += instance.OnCompetence;
                @Competence.canceled += instance.OnCompetence;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @ChooseStage.started += instance.OnChooseStage;
                @ChooseStage.performed += instance.OnChooseStage;
                @ChooseStage.canceled += instance.OnChooseStage;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Inventory
    private readonly InputActionMap m_Inventory;
    private IInventoryActions m_InventoryActionsCallbackInterface;
    private readonly InputAction m_Inventory_Equip;
    private readonly InputAction m_Inventory_Refuse;
    public struct InventoryActions
    {
        private @GamepadActions m_Wrapper;
        public InventoryActions(@GamepadActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Equip => m_Wrapper.m_Inventory_Equip;
        public InputAction @Refuse => m_Wrapper.m_Inventory_Refuse;
        public InputActionMap Get() { return m_Wrapper.m_Inventory; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InventoryActions set) { return set.Get(); }
        public void SetCallbacks(IInventoryActions instance)
        {
            if (m_Wrapper.m_InventoryActionsCallbackInterface != null)
            {
                @Equip.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnEquip;
                @Equip.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnEquip;
                @Equip.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnEquip;
                @Refuse.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnRefuse;
                @Refuse.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnRefuse;
                @Refuse.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnRefuse;
            }
            m_Wrapper.m_InventoryActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Equip.started += instance.OnEquip;
                @Equip.performed += instance.OnEquip;
                @Equip.canceled += instance.OnEquip;
                @Refuse.started += instance.OnRefuse;
                @Refuse.performed += instance.OnRefuse;
                @Refuse.canceled += instance.OnRefuse;
            }
        }
    }
    public InventoryActions @Inventory => new InventoryActions(this);
    private int m_XboxcontrolschemeSchemeIndex = -1;
    public InputControlScheme XboxcontrolschemeScheme
    {
        get
        {
            if (m_XboxcontrolschemeSchemeIndex == -1) m_XboxcontrolschemeSchemeIndex = asset.FindControlSchemeIndex("Xbox control scheme");
            return asset.controlSchemes[m_XboxcontrolschemeSchemeIndex];
        }
    }
    private int m_PS4controlschemeSchemeIndex = -1;
    public InputControlScheme PS4controlschemeScheme
    {
        get
        {
            if (m_PS4controlschemeSchemeIndex == -1) m_PS4controlschemeSchemeIndex = asset.FindControlSchemeIndex("PS4 control scheme");
            return asset.controlSchemes[m_PS4controlschemeSchemeIndex];
        }
    }
    public interface IMenuActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
    public interface IDialogueActions
    {
        void OnOpenDialogue(InputAction.CallbackContext context);
    }
    public interface IPlayerActions
    {
        void OnRightArm(InputAction.CallbackContext context);
        void OnLeftArm(InputAction.CallbackContext context);
        void OnCompetence(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnChooseStage(InputAction.CallbackContext context);
    }
    public interface IInventoryActions
    {
        void OnEquip(InputAction.CallbackContext context);
        void OnRefuse(InputAction.CallbackContext context);
    }
}
