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
                    ""name"": ""OpenMenu"",
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
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox control scheme;PS4 control scheme"",
                    ""action"": ""OpenMenu"",
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
                    ""name"": ""LeftLeg"",
                    ""type"": ""Button"",
                    ""id"": ""ebb1145c-3521-45aa-b7bd-86af90387d6a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""RightLeg"",
                    ""type"": ""Button"",
                    ""id"": ""4aee12f1-6772-47d1-9b70-f6a1592ac9cc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
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
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""aba864e9-d8a3-4993-a910-92d534a45d97"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4 control scheme;Xbox control scheme"",
                    ""action"": ""LeftLeg"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2c8aefc1-da8a-4643-8269-8191c937ce31"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4 control scheme;Xbox control scheme"",
                    ""action"": ""RightLeg"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4a473fdb-17d6-4ba5-a88a-95665b6473e8"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4 control scheme;Xbox control scheme"",
                    ""action"": ""RightArm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e9d5f91f-8641-4094-a300-8c8ec61254f3"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4 control scheme;Xbox control scheme"",
                    ""action"": ""LeftArm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""28c3d684-0fc2-46b0-8996-d5e9334f049f"",
                    ""path"": ""<Gamepad>/buttonEast"",
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
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
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
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""38231de9-0e96-4cf4-8663-eb435643e11c"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox control scheme;PS4 control scheme"",
                    ""action"": ""Equip"",
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
        m_Dialogue_OpenMenu = m_Dialogue.FindAction("OpenMenu", throwIfNotFound: true);
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_LeftLeg = m_Player.FindAction("LeftLeg", throwIfNotFound: true);
        m_Player_RightLeg = m_Player.FindAction("RightLeg", throwIfNotFound: true);
        m_Player_RightArm = m_Player.FindAction("RightArm", throwIfNotFound: true);
        m_Player_LeftArm = m_Player.FindAction("LeftArm", throwIfNotFound: true);
        m_Player_Competence = m_Player.FindAction("Competence", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        // Inventory
        m_Inventory = asset.FindActionMap("Inventory", throwIfNotFound: true);
        m_Inventory_Equip = m_Inventory.FindAction("Equip", throwIfNotFound: true);
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
    private readonly InputAction m_Dialogue_OpenMenu;
    public struct DialogueActions
    {
        private @GamepadActions m_Wrapper;
        public DialogueActions(@GamepadActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @OpenMenu => m_Wrapper.m_Dialogue_OpenMenu;
        public InputActionMap Get() { return m_Wrapper.m_Dialogue; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DialogueActions set) { return set.Get(); }
        public void SetCallbacks(IDialogueActions instance)
        {
            if (m_Wrapper.m_DialogueActionsCallbackInterface != null)
            {
                @OpenMenu.started -= m_Wrapper.m_DialogueActionsCallbackInterface.OnOpenMenu;
                @OpenMenu.performed -= m_Wrapper.m_DialogueActionsCallbackInterface.OnOpenMenu;
                @OpenMenu.canceled -= m_Wrapper.m_DialogueActionsCallbackInterface.OnOpenMenu;
            }
            m_Wrapper.m_DialogueActionsCallbackInterface = instance;
            if (instance != null)
            {
                @OpenMenu.started += instance.OnOpenMenu;
                @OpenMenu.performed += instance.OnOpenMenu;
                @OpenMenu.canceled += instance.OnOpenMenu;
            }
        }
    }
    public DialogueActions @Dialogue => new DialogueActions(this);

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_LeftLeg;
    private readonly InputAction m_Player_RightLeg;
    private readonly InputAction m_Player_RightArm;
    private readonly InputAction m_Player_LeftArm;
    private readonly InputAction m_Player_Competence;
    private readonly InputAction m_Player_Jump;
    public struct PlayerActions
    {
        private @GamepadActions m_Wrapper;
        public PlayerActions(@GamepadActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftLeg => m_Wrapper.m_Player_LeftLeg;
        public InputAction @RightLeg => m_Wrapper.m_Player_RightLeg;
        public InputAction @RightArm => m_Wrapper.m_Player_RightArm;
        public InputAction @LeftArm => m_Wrapper.m_Player_LeftArm;
        public InputAction @Competence => m_Wrapper.m_Player_Competence;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @LeftLeg.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftLeg;
                @LeftLeg.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftLeg;
                @LeftLeg.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftLeg;
                @RightLeg.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightLeg;
                @RightLeg.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightLeg;
                @RightLeg.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightLeg;
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
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LeftLeg.started += instance.OnLeftLeg;
                @LeftLeg.performed += instance.OnLeftLeg;
                @LeftLeg.canceled += instance.OnLeftLeg;
                @RightLeg.started += instance.OnRightLeg;
                @RightLeg.performed += instance.OnRightLeg;
                @RightLeg.canceled += instance.OnRightLeg;
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
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Inventory
    private readonly InputActionMap m_Inventory;
    private IInventoryActions m_InventoryActionsCallbackInterface;
    private readonly InputAction m_Inventory_Equip;
    public struct InventoryActions
    {
        private @GamepadActions m_Wrapper;
        public InventoryActions(@GamepadActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Equip => m_Wrapper.m_Inventory_Equip;
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
            }
            m_Wrapper.m_InventoryActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Equip.started += instance.OnEquip;
                @Equip.performed += instance.OnEquip;
                @Equip.canceled += instance.OnEquip;
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
        void OnOpenMenu(InputAction.CallbackContext context);
    }
    public interface IPlayerActions
    {
        void OnLeftLeg(InputAction.CallbackContext context);
        void OnRightLeg(InputAction.CallbackContext context);
        void OnRightArm(InputAction.CallbackContext context);
        void OnLeftArm(InputAction.CallbackContext context);
        void OnCompetence(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
    public interface IInventoryActions
    {
        void OnEquip(InputAction.CallbackContext context);
    }
}
