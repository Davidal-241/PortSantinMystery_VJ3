// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/UserActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @UserActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @UserActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""UserActions"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""22921f0f-5872-438d-9505-314c769f0098"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""4562e418-5ccd-4335-be26-e6840879bde3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interactue"",
                    ""type"": ""Button"",
                    ""id"": ""7a379087-7a6f-4b34-b2a6-731ca7ce814a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Inventory"",
                    ""type"": ""Button"",
                    ""id"": ""93b8a503-a0b1-4a6d-b0e9-ce2af1a13f8a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""02a8b31c-3684-4d91-a0b2-160f03ddf1f4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""AD"",
                    ""id"": ""2c6680f2-2cdb-400a-9e83-c3059ab3f4b0"",
                    ""path"": ""2DVector"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d4ec8c78-d488-49c8-925c-7efb7361b459"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d06dc0b8-9897-4335-a35e-df04bf68f85c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""<-->"",
                    ""id"": ""5a39f483-09cb-4dcc-af2f-86f4731f6a13"",
                    ""path"": ""2DVector"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""141c2fb8-d610-4e8d-aacc-12600801a752"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b16be27a-d2d2-4501-b8b1-3b698031e3d9"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f1113fd9-d23e-48b0-bd0d-a5d9b1d490eb"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and Mouse"",
                    ""action"": ""Interactue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e90618e5-f3f5-4001-a63d-bc5ed6152712"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Interactue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9d7a12f2-6c43-4ded-b402-31045519f26f"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and Mouse"",
                    ""action"": ""Inventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f6072e93-607a-4c1d-bff7-e9810803d1a1"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Inventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c04938aa-89f2-4f03-83ac-919323659944"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": ""Press,Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and Mouse"",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f0f3d67c-70ec-49c5-9188-0edd2813a7a2"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""6c962096-761c-4801-aa7f-d6948b5e5bba"",
            ""actions"": [
                {
                    ""name"": ""NextLine"",
                    ""type"": ""Button"",
                    ""id"": ""67199a24-d82d-43bc-bc3c-9704b7a91d6e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Navigate"",
                    ""type"": ""Button"",
                    ""id"": ""848289ea-8c4c-41b8-bd4e-150d9b37d213"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""EnterInSubPanel"",
                    ""type"": ""Button"",
                    ""id"": ""3ca6de08-d39d-4372-92cf-a40287917810"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ExitInSubPanel"",
                    ""type"": ""Button"",
                    ""id"": ""2ad1fb1e-7bc0-4f5f-a57e-54f997724d1d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Submit"",
                    ""type"": ""Button"",
                    ""id"": ""85faec96-3ad8-4a79-9f3f-b696c3868aaa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d5a6f7c0-d576-4e31-bd81-4da5e6aeb6ef"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and Mouse"",
                    ""action"": ""NextLine"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""KeyBoard"",
                    ""id"": ""9f703a6b-b014-42e3-ab18-8feb496f6ba8"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9ee2d83f-e87a-4ed8-b619-a9267d31f5fa"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""218046c9-4161-43f7-af94-f2f02ef37ea4"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ac4e87c9-72e9-4a7d-9312-a8c7a0a71ef1"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4b3cdcf9-fba2-4f9f-95fe-08073777322d"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""018c752f-33d5-4af6-9c35-4c51202b0ad3"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""4145ee7f-8969-4456-8e4d-1b42321b8001"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""691a2099-de4d-47bd-ae3e-86b88cd15eb4"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""bcc8d12a-f2ee-41fa-bb5c-892c7f4c670d"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""945260ac-aa75-485f-821c-e0090f94fd79"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""bd0d09c6-184d-4a88-92ff-a6d15c0fd9d1"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Interactue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eb18544e-dece-494c-b6eb-10791dd562e7"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Interactue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3a2ed115-3835-49cd-8b74-6a0d1cd09258"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""NextLine"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4e4db474-351d-42ce-a4a6-2634be566b4b"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and Mouse"",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e93412dd-9cd1-4245-bfa4-3ba76170bb7d"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""KeyBoard"",
                    ""id"": ""d3753777-cb14-4d3c-83e8-ad85ca2b90e2"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EnterInSubPanel"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ce03e7b3-7f89-447b-821c-e0954372bf91"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and Mouse"",
                    ""action"": ""EnterInSubPanel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""dc0a8156-87dc-4023-a971-57d7376bdf80"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EnterInSubPanel"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""fb359c6e-74ba-43e8-9a79-75aeb0f4e60b"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""EnterInSubPanel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""KeyBoard"",
                    ""id"": ""e6818892-7e0c-4b6e-8b07-4580c36e8cc6"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ExitInSubPanel"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4301f646-57a9-4d75-9ee0-275215f3ae69"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and Mouse"",
                    ""action"": ""ExitInSubPanel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""f0223141-0400-49cc-8100-04e3c33043d8"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ExitInSubPanel"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b5e00dd6-3f43-4ce3-ac6b-9fc042270e06"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ExitInSubPanel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Menu Pause"",
            ""id"": ""283f74c9-afb8-4043-949b-3396169f1f4e"",
            ""actions"": [
                {
                    ""name"": ""Open/Close"",
                    ""type"": ""Button"",
                    ""id"": ""33939f93-c26e-410e-94da-460a585493b3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f3c30d4e-9b14-4ff0-9492-ce6dc89cbd84"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and Mouse"",
                    ""action"": ""Open/Close"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b592153c-886d-4f7e-bcca-8624de08c332"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Open/Close"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KeyBoard and Mouse"",
            ""bindingGroup"": ""KeyBoard and Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_Interactue = m_Player.FindAction("Interactue", throwIfNotFound: true);
        m_Player_Inventory = m_Player.FindAction("Inventory", throwIfNotFound: true);
        m_Player_Sprint = m_Player.FindAction("Sprint", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_NextLine = m_UI.FindAction("NextLine", throwIfNotFound: true);
        m_UI_Navigate = m_UI.FindAction("Navigate", throwIfNotFound: true);
        m_UI_EnterInSubPanel = m_UI.FindAction("EnterInSubPanel", throwIfNotFound: true);
        m_UI_ExitInSubPanel = m_UI.FindAction("ExitInSubPanel", throwIfNotFound: true);
        m_UI_Submit = m_UI.FindAction("Submit", throwIfNotFound: true);
        // Menu Pause
        m_MenuPause = asset.FindActionMap("Menu Pause", throwIfNotFound: true);
        m_MenuPause_OpenClose = m_MenuPause.FindAction("Open/Close", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_Interactue;
    private readonly InputAction m_Player_Inventory;
    private readonly InputAction m_Player_Sprint;
    public struct PlayerActions
    {
        private @UserActions m_Wrapper;
        public PlayerActions(@UserActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @Interactue => m_Wrapper.m_Player_Interactue;
        public InputAction @Inventory => m_Wrapper.m_Player_Inventory;
        public InputAction @Sprint => m_Wrapper.m_Player_Sprint;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Interactue.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteractue;
                @Interactue.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteractue;
                @Interactue.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteractue;
                @Inventory.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInventory;
                @Inventory.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInventory;
                @Inventory.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInventory;
                @Sprint.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSprint;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Interactue.started += instance.OnInteractue;
                @Interactue.performed += instance.OnInteractue;
                @Interactue.canceled += instance.OnInteractue;
                @Inventory.started += instance.OnInventory;
                @Inventory.performed += instance.OnInventory;
                @Inventory.canceled += instance.OnInventory;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_NextLine;
    private readonly InputAction m_UI_Navigate;
    private readonly InputAction m_UI_EnterInSubPanel;
    private readonly InputAction m_UI_ExitInSubPanel;
    private readonly InputAction m_UI_Submit;
    public struct UIActions
    {
        private @UserActions m_Wrapper;
        public UIActions(@UserActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @NextLine => m_Wrapper.m_UI_NextLine;
        public InputAction @Navigate => m_Wrapper.m_UI_Navigate;
        public InputAction @EnterInSubPanel => m_Wrapper.m_UI_EnterInSubPanel;
        public InputAction @ExitInSubPanel => m_Wrapper.m_UI_ExitInSubPanel;
        public InputAction @Submit => m_Wrapper.m_UI_Submit;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @NextLine.started -= m_Wrapper.m_UIActionsCallbackInterface.OnNextLine;
                @NextLine.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnNextLine;
                @NextLine.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnNextLine;
                @Navigate.started -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                @Navigate.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                @Navigate.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                @EnterInSubPanel.started -= m_Wrapper.m_UIActionsCallbackInterface.OnEnterInSubPanel;
                @EnterInSubPanel.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnEnterInSubPanel;
                @EnterInSubPanel.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnEnterInSubPanel;
                @ExitInSubPanel.started -= m_Wrapper.m_UIActionsCallbackInterface.OnExitInSubPanel;
                @ExitInSubPanel.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnExitInSubPanel;
                @ExitInSubPanel.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnExitInSubPanel;
                @Submit.started -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                @Submit.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                @Submit.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @NextLine.started += instance.OnNextLine;
                @NextLine.performed += instance.OnNextLine;
                @NextLine.canceled += instance.OnNextLine;
                @Navigate.started += instance.OnNavigate;
                @Navigate.performed += instance.OnNavigate;
                @Navigate.canceled += instance.OnNavigate;
                @EnterInSubPanel.started += instance.OnEnterInSubPanel;
                @EnterInSubPanel.performed += instance.OnEnterInSubPanel;
                @EnterInSubPanel.canceled += instance.OnEnterInSubPanel;
                @ExitInSubPanel.started += instance.OnExitInSubPanel;
                @ExitInSubPanel.performed += instance.OnExitInSubPanel;
                @ExitInSubPanel.canceled += instance.OnExitInSubPanel;
                @Submit.started += instance.OnSubmit;
                @Submit.performed += instance.OnSubmit;
                @Submit.canceled += instance.OnSubmit;
            }
        }
    }
    public UIActions @UI => new UIActions(this);

    // Menu Pause
    private readonly InputActionMap m_MenuPause;
    private IMenuPauseActions m_MenuPauseActionsCallbackInterface;
    private readonly InputAction m_MenuPause_OpenClose;
    public struct MenuPauseActions
    {
        private @UserActions m_Wrapper;
        public MenuPauseActions(@UserActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @OpenClose => m_Wrapper.m_MenuPause_OpenClose;
        public InputActionMap Get() { return m_Wrapper.m_MenuPause; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuPauseActions set) { return set.Get(); }
        public void SetCallbacks(IMenuPauseActions instance)
        {
            if (m_Wrapper.m_MenuPauseActionsCallbackInterface != null)
            {
                @OpenClose.started -= m_Wrapper.m_MenuPauseActionsCallbackInterface.OnOpenClose;
                @OpenClose.performed -= m_Wrapper.m_MenuPauseActionsCallbackInterface.OnOpenClose;
                @OpenClose.canceled -= m_Wrapper.m_MenuPauseActionsCallbackInterface.OnOpenClose;
            }
            m_Wrapper.m_MenuPauseActionsCallbackInterface = instance;
            if (instance != null)
            {
                @OpenClose.started += instance.OnOpenClose;
                @OpenClose.performed += instance.OnOpenClose;
                @OpenClose.canceled += instance.OnOpenClose;
            }
        }
    }
    public MenuPauseActions @MenuPause => new MenuPauseActions(this);
    private int m_KeyBoardandMouseSchemeIndex = -1;
    public InputControlScheme KeyBoardandMouseScheme
    {
        get
        {
            if (m_KeyBoardandMouseSchemeIndex == -1) m_KeyBoardandMouseSchemeIndex = asset.FindControlSchemeIndex("KeyBoard and Mouse");
            return asset.controlSchemes[m_KeyBoardandMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnInteractue(InputAction.CallbackContext context);
        void OnInventory(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnNextLine(InputAction.CallbackContext context);
        void OnNavigate(InputAction.CallbackContext context);
        void OnEnterInSubPanel(InputAction.CallbackContext context);
        void OnExitInSubPanel(InputAction.CallbackContext context);
        void OnSubmit(InputAction.CallbackContext context);
    }
    public interface IMenuPauseActions
    {
        void OnOpenClose(InputAction.CallbackContext context);
    }
}
