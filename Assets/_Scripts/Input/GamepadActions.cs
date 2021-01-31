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
                    ""id"": ""775afe71-6f6c-438c-8ac3-fafa1cfad662"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad"",
                    ""action"": ""OpenDialogue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""38a9e548-1186-4c96-8708-2d49e8d95ded"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad"",
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
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""c287a5d3-2ecf-4468-8534-77d98107b955"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""StickDeadzone"",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e2c69e26-b65c-4ef4-aa63-98d7add4f96e"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad"",
                    ""action"": ""RightArm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""51c8aace-5333-4ea4-b988-6438d76f5190"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad"",
                    ""action"": ""RightArm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8bd0dcc4-ff2c-4049-8503-6f9190a480ef"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad"",
                    ""action"": ""LeftArm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""23b90980-b051-41e7-b41f-dc50a7ce0a77"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad"",
                    ""action"": ""LeftArm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fdab138f-4f2c-460b-8864-783a6afbd5f5"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad"",
                    ""action"": ""Competence"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""512085c8-cb44-48db-8728-9106912d066a"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad"",
                    ""action"": ""Competence"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b5ec25b9-bb89-42af-a555-ecf8e9d5e805"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0af26827-260b-4107-b71f-75a026814dee"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4c4dae87-c1b4-4418-b336-0c58b4649ce8"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cf73f81b-147c-4709-a60a-e64dd6642651"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4365715c-bbf8-44cd-a24b-a19eb94e6f9d"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""483a64f1-2dab-4955-9940-1a79fe9964b8"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""4da7c48c-1be0-4b01-86b6-fda767fcd122"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f69a4ab0-4815-42c1-bd21-032ea649f02e"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9715263a-ab53-462f-acf1-c81614b70498"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""7c848c62-9c2c-4e4c-a9b1-98c9960cca26"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
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
                    ""name"": ""down"",
                    ""id"": ""53180c19-af7f-4180-992a-89026ffe61d8"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad"",
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
                    ""groups"": ""KeyboardOrGamepad"",
                    ""action"": ""ChooseStage"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""338d1db1-903f-493d-9812-06c500b05da9"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad"",
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
                    ""groups"": ""KeyboardOrGamepad"",
                    ""action"": ""ChooseStage"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard Arrows"",
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
                    ""groups"": ""KeyboardOrGamepad"",
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
                    ""groups"": ""KeyboardOrGamepad"",
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
                    ""groups"": ""KeyboardOrGamepad"",
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
                    ""groups"": ""KeyboardOrGamepad"",
                    ""action"": ""ChooseStage"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad Left Stick"",
                    ""id"": ""6aa05eb2-c165-4fdd-8ea8-f8bbf4d0c136"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""26c789fc-26d1-40c7-a325-9a51e5fa534b"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0d847738-b94c-433c-89ce-ed6bf7c2738b"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""cca96e20-8d2d-4422-a1e2-10b549fb2b88"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a04c4b5e-0396-4113-927b-6a9328b5a05f"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard ZSQD"",
                    ""id"": ""fb7d963e-aaf8-43dc-91c7-dab36de3b61f"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=0.6,y=0.6)"",
                    ""groups"": ""KeyboardOrGamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""36223de0-b1ba-4ca5-b437-c287fa04304e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a426490f-e61a-489e-9fad-b64fd6630e0d"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""53122e7c-f3d2-42c4-a21a-be63e8cc399f"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""22aed6a6-f1c7-43dc-b62b-37f8603eac0d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad"",
                    ""action"": ""Move"",
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
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""db27c974-d895-42a4-bf4f-0f92278c6c87"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""ChangeItemSlot"",
                    ""type"": ""Value"",
                    ""id"": ""962c4834-cfe5-425a-bf18-a2d518db879e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""StickDeadzone"",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""dd156770-55a2-4a94-a55c-a5cd0b61fe01"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""007d0f6a-8286-4848-987f-daed46d3ac1f"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ad1ad97e-caa6-42ea-a2a1-c9dbd5200dfe"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad"",
                    ""action"": ""Equip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9ad94cd5-9970-4481-a4ee-6251c22b7973"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad"",
                    ""action"": ""Equip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Gamepad Left Stick"",
                    ""id"": ""8f5ffdf3-029a-4f98-bc63-97a612b7f189"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad"",
                    ""action"": ""ChangeItemSlot"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5d4fe8d1-1a40-4d27-bb4d-f9d5d59066b1"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad"",
                    ""action"": ""ChangeItemSlot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ec8e91df-5160-4a8f-a257-131f26c96261"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad"",
                    ""action"": ""ChangeItemSlot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4ecd310c-fdd0-4809-94e5-40d451ecef9c"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad"",
                    ""action"": ""ChangeItemSlot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""040646bf-2ab4-4506-9169-b3502788d5fb"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad"",
                    ""action"": ""ChangeItemSlot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard ZSQD"",
                    ""id"": ""1536a50b-2c59-4d68-8135-1171443916f3"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=0.6,y=0.6)"",
                    ""groups"": ""KeyboardOrGamepad"",
                    ""action"": ""ChangeItemSlot"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a8c3eeb2-77e1-48de-9227-372c7246d4ee"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad"",
                    ""action"": ""ChangeItemSlot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e9154030-c42b-4378-9817-e394c5208b1a"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad"",
                    ""action"": ""ChangeItemSlot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""67663100-db92-450c-a134-afcc1bc12bae"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad"",
                    ""action"": ""ChangeItemSlot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""99cb5ce1-2f3c-41f3-b7bf-c26269edfe76"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad"",
                    ""action"": ""ChangeItemSlot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Trade"",
            ""id"": ""4d94ebb1-94ff-446c-aee7-338103fa039f"",
            ""actions"": [
                {
                    ""name"": ""Accept"",
                    ""type"": ""Button"",
                    ""id"": ""89b15787-5158-4566-8eff-970953d6bcd8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Decline"",
                    ""type"": ""Button"",
                    ""id"": ""27762f0e-847e-460e-b3d5-1362915ecbdb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a0bb16a7-d3e9-4458-b36b-b1f9b401ad64"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad"",
                    ""action"": ""Accept"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""85f0c3a9-3dbe-413a-a90f-30446ee21097"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad"",
                    ""action"": ""Accept"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a15f0d54-161d-4ffc-a8bc-663ca4cfe845"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad"",
                    ""action"": ""Decline"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""47f64b47-03e8-41ee-9ca7-a35ec07109a6"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad"",
                    ""action"": ""Decline"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KeyboardOrGamepad"",
            ""bindingGroup"": ""KeyboardOrGamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<XboxOneGampadiOS>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<DualShock4GampadiOS>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
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
        m_Player_Aim = m_Player.FindAction("Aim", throwIfNotFound: true);
        m_Player_ChooseStage = m_Player.FindAction("ChooseStage", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        // Inventory
        m_Inventory = asset.FindActionMap("Inventory", throwIfNotFound: true);
        m_Inventory_Equip = m_Inventory.FindAction("Equip", throwIfNotFound: true);
        m_Inventory_Cancel = m_Inventory.FindAction("Cancel", throwIfNotFound: true);
        m_Inventory_ChangeItemSlot = m_Inventory.FindAction("ChangeItemSlot", throwIfNotFound: true);
        // Trade
        m_Trade = asset.FindActionMap("Trade", throwIfNotFound: true);
        m_Trade_Accept = m_Trade.FindAction("Accept", throwIfNotFound: true);
        m_Trade_Decline = m_Trade.FindAction("Decline", throwIfNotFound: true);
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
    private readonly InputAction m_Player_Aim;
    private readonly InputAction m_Player_ChooseStage;
    private readonly InputAction m_Player_Move;
    public struct PlayerActions
    {
        private @GamepadActions m_Wrapper;
        public PlayerActions(@GamepadActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @RightArm => m_Wrapper.m_Player_RightArm;
        public InputAction @LeftArm => m_Wrapper.m_Player_LeftArm;
        public InputAction @Competence => m_Wrapper.m_Player_Competence;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @Interact => m_Wrapper.m_Player_Interact;
        public InputAction @Aim => m_Wrapper.m_Player_Aim;
        public InputAction @ChooseStage => m_Wrapper.m_Player_ChooseStage;
        public InputAction @Move => m_Wrapper.m_Player_Move;
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
                @Aim.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAim;
                @ChooseStage.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChooseStage;
                @ChooseStage.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChooseStage;
                @ChooseStage.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChooseStage;
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
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
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @ChooseStage.started += instance.OnChooseStage;
                @ChooseStage.performed += instance.OnChooseStage;
                @ChooseStage.canceled += instance.OnChooseStage;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Inventory
    private readonly InputActionMap m_Inventory;
    private IInventoryActions m_InventoryActionsCallbackInterface;
    private readonly InputAction m_Inventory_Equip;
    private readonly InputAction m_Inventory_Cancel;
    private readonly InputAction m_Inventory_ChangeItemSlot;
    public struct InventoryActions
    {
        private @GamepadActions m_Wrapper;
        public InventoryActions(@GamepadActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Equip => m_Wrapper.m_Inventory_Equip;
        public InputAction @Cancel => m_Wrapper.m_Inventory_Cancel;
        public InputAction @ChangeItemSlot => m_Wrapper.m_Inventory_ChangeItemSlot;
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
                @Cancel.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnCancel;
                @ChangeItemSlot.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnChangeItemSlot;
                @ChangeItemSlot.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnChangeItemSlot;
                @ChangeItemSlot.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnChangeItemSlot;
            }
            m_Wrapper.m_InventoryActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Equip.started += instance.OnEquip;
                @Equip.performed += instance.OnEquip;
                @Equip.canceled += instance.OnEquip;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
                @ChangeItemSlot.started += instance.OnChangeItemSlot;
                @ChangeItemSlot.performed += instance.OnChangeItemSlot;
                @ChangeItemSlot.canceled += instance.OnChangeItemSlot;
            }
        }
    }
    public InventoryActions @Inventory => new InventoryActions(this);

    // Trade
    private readonly InputActionMap m_Trade;
    private ITradeActions m_TradeActionsCallbackInterface;
    private readonly InputAction m_Trade_Accept;
    private readonly InputAction m_Trade_Decline;
    public struct TradeActions
    {
        private @GamepadActions m_Wrapper;
        public TradeActions(@GamepadActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Accept => m_Wrapper.m_Trade_Accept;
        public InputAction @Decline => m_Wrapper.m_Trade_Decline;
        public InputActionMap Get() { return m_Wrapper.m_Trade; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TradeActions set) { return set.Get(); }
        public void SetCallbacks(ITradeActions instance)
        {
            if (m_Wrapper.m_TradeActionsCallbackInterface != null)
            {
                @Accept.started -= m_Wrapper.m_TradeActionsCallbackInterface.OnAccept;
                @Accept.performed -= m_Wrapper.m_TradeActionsCallbackInterface.OnAccept;
                @Accept.canceled -= m_Wrapper.m_TradeActionsCallbackInterface.OnAccept;
                @Decline.started -= m_Wrapper.m_TradeActionsCallbackInterface.OnDecline;
                @Decline.performed -= m_Wrapper.m_TradeActionsCallbackInterface.OnDecline;
                @Decline.canceled -= m_Wrapper.m_TradeActionsCallbackInterface.OnDecline;
            }
            m_Wrapper.m_TradeActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Accept.started += instance.OnAccept;
                @Accept.performed += instance.OnAccept;
                @Accept.canceled += instance.OnAccept;
                @Decline.started += instance.OnDecline;
                @Decline.performed += instance.OnDecline;
                @Decline.canceled += instance.OnDecline;
            }
        }
    }
    public TradeActions @Trade => new TradeActions(this);
    private int m_KeyboardOrGamepadSchemeIndex = -1;
    public InputControlScheme KeyboardOrGamepadScheme
    {
        get
        {
            if (m_KeyboardOrGamepadSchemeIndex == -1) m_KeyboardOrGamepadSchemeIndex = asset.FindControlSchemeIndex("KeyboardOrGamepad");
            return asset.controlSchemes[m_KeyboardOrGamepadSchemeIndex];
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
        void OnAim(InputAction.CallbackContext context);
        void OnChooseStage(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IInventoryActions
    {
        void OnEquip(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
        void OnChangeItemSlot(InputAction.CallbackContext context);
    }
    public interface ITradeActions
    {
        void OnAccept(InputAction.CallbackContext context);
        void OnDecline(InputAction.CallbackContext context);
    }
}
