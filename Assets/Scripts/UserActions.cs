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
                    ""path"": ""<Keyboard>/tab"",
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
                    ""name"": ""NavigateUp"",
                    ""type"": ""Button"",
                    ""id"": ""848289ea-8c4c-41b8-bd4e-150d9b37d213"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""NavigateDown"",
                    ""type"": ""Button"",
                    ""id"": ""6d904d58-6736-4a7f-80e6-d17b5a6b7273"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""NavigateLeft"",
                    ""type"": ""Button"",
                    ""id"": ""31722422-8c81-451d-b338-9b337ef9d035"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""NavigateRight"",
                    ""type"": ""Button"",
                    ""id"": ""6bcf4784-814e-43c7-aeda-898cad0f31c1"",
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
                },
                {
                    ""name"": ""PreviousTab"",
                    ""type"": ""Button"",
                    ""id"": ""987e88fc-c5b5-4a0e-8a5c-4c839cc9ce1c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""NextTab"",
                    ""type"": ""Button"",
                    ""id"": ""66b6a83d-7048-40ed-8c8f-8963041933e7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""9929aa74-5d70-470d-ba9e-0e648890fe45"",
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
                    ""action"": ""NavigateUp"",
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
                    ""action"": ""NavigateUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""KeyBoard"",
                    ""id"": ""e0f2c211-d253-4db7-818f-2be5f1397f66"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NavigateUp"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5b5d7368-6d72-4e13-8011-58a20643120c"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and Mouse"",
                    ""action"": ""NavigateUp"",
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
                    ""action"": ""NavigateUp"",
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
                    ""action"": ""NavigateUp"",
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
                    ""name"": """",
                    ""id"": ""919dcec0-70a8-42d4-8f82-9bb65ac2c236"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and Mouse"",
                    ""action"": ""PreviousTab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""28449e9d-6134-464e-bc36-789fd239d16b"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and Mouse;Gamepad"",
                    ""action"": ""NextTab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""KeyBoard"",
                    ""id"": ""2d7eca00-94cc-4b21-86df-5f33ce2beaf2"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NavigateDown"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f3d553ce-bcd5-4e8e-907c-aa6fef2363b5"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and Mouse"",
                    ""action"": ""NavigateDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""KeyBoard"",
                    ""id"": ""bddc3c25-5eb4-4be8-aaee-48a017b4fa64"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NavigateDown"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2dcbe54d-a2c1-408f-8225-ea81fe56802a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and Mouse"",
                    ""action"": ""NavigateDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""f81fcd68-08ce-40a0-a4ad-dab45f2a32d5"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NavigateDown"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""down"",
                    ""id"": ""40f0f52f-6e3e-418f-a308-deb57b259d8c"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""NavigateDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1f302cfa-5070-4054-b109-ff97570044a3"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""KeyBoard"",
                    ""id"": ""5282763e-6246-4de1-bd85-31bfced7afe6"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NavigateLeft"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""092be7a2-82c3-4b79-81f9-ba07474b988d"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and Mouse"",
                    ""action"": ""NavigateLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""KeyBoard"",
                    ""id"": ""9be0ceee-80d9-473e-beef-af2311b1b346"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NavigateLeft"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""a14fd3b0-48d2-47b3-92e8-5a883eca9c8d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and Mouse"",
                    ""action"": ""NavigateLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""34c47581-764b-4bb1-ab67-d5993ddc4f3b"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NavigateLeft"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""5ca595b2-eadc-49b5-adc2-77fc9b36511e"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""NavigateLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""KeyBoard"",
                    ""id"": ""9e9de423-fc6e-4a40-8fbc-4abdd86b5a16"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NavigateRight"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ab26fb9d-03b9-4e72-a800-926302ec52f4"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and Mouse"",
                    ""action"": ""NavigateRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""KeyBoard"",
                    ""id"": ""e4b06a86-d04a-4329-8946-6cbc3920d463"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NavigateRight"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""right"",
                    ""id"": ""84b3821b-0fff-4231-88f6-5793f61a79f8"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and Mouse"",
                    ""action"": ""NavigateRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""935d3bcd-421d-466e-9aa3-bc9c516754c0"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NavigateRight"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""down"",
                    ""id"": ""6c6d99f2-dc86-4963-bfc5-6615aade11cd"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""NavigateRight"",
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
        m_UI_NavigateUp = m_UI.FindAction("NavigateUp", throwIfNotFound: true);
        m_UI_NavigateDown = m_UI.FindAction("NavigateDown", throwIfNotFound: true);
        m_UI_NavigateLeft = m_UI.FindAction("NavigateLeft", throwIfNotFound: true);
        m_UI_NavigateRight = m_UI.FindAction("NavigateRight", throwIfNotFound: true);
        m_UI_Submit = m_UI.FindAction("Submit", throwIfNotFound: true);
        m_UI_PreviousTab = m_UI.FindAction("PreviousTab", throwIfNotFound: true);
        m_UI_NextTab = m_UI.FindAction("NextTab", throwIfNotFound: true);
        m_UI_Newaction = m_UI.FindAction("New action", throwIfNotFound: true);
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
    private readonly InputAction m_UI_NavigateUp;
    private readonly InputAction m_UI_NavigateDown;
    private readonly InputAction m_UI_NavigateLeft;
    private readonly InputAction m_UI_NavigateRight;
    private readonly InputAction m_UI_Submit;
    private readonly InputAction m_UI_PreviousTab;
    private readonly InputAction m_UI_NextTab;
    private readonly InputAction m_UI_Newaction;
    public struct UIActions
    {
        private @UserActions m_Wrapper;
        public UIActions(@UserActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @NextLine => m_Wrapper.m_UI_NextLine;
        public InputAction @NavigateUp => m_Wrapper.m_UI_NavigateUp;
        public InputAction @NavigateDown => m_Wrapper.m_UI_NavigateDown;
        public InputAction @NavigateLeft => m_Wrapper.m_UI_NavigateLeft;
        public InputAction @NavigateRight => m_Wrapper.m_UI_NavigateRight;
        public InputAction @Submit => m_Wrapper.m_UI_Submit;
        public InputAction @PreviousTab => m_Wrapper.m_UI_PreviousTab;
        public InputAction @NextTab => m_Wrapper.m_UI_NextTab;
        public InputAction @Newaction => m_Wrapper.m_UI_Newaction;
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
                @NavigateUp.started -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigateUp;
                @NavigateUp.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigateUp;
                @NavigateUp.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigateUp;
                @NavigateDown.started -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigateDown;
                @NavigateDown.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigateDown;
                @NavigateDown.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigateDown;
                @NavigateLeft.started -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigateLeft;
                @NavigateLeft.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigateLeft;
                @NavigateLeft.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigateLeft;
                @NavigateRight.started -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigateRight;
                @NavigateRight.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigateRight;
                @NavigateRight.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigateRight;
                @Submit.started -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                @Submit.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                @Submit.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                @PreviousTab.started -= m_Wrapper.m_UIActionsCallbackInterface.OnPreviousTab;
                @PreviousTab.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnPreviousTab;
                @PreviousTab.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnPreviousTab;
                @NextTab.started -= m_Wrapper.m_UIActionsCallbackInterface.OnNextTab;
                @NextTab.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnNextTab;
                @NextTab.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnNextTab;
                @Newaction.started -= m_Wrapper.m_UIActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @NextLine.started += instance.OnNextLine;
                @NextLine.performed += instance.OnNextLine;
                @NextLine.canceled += instance.OnNextLine;
                @NavigateUp.started += instance.OnNavigateUp;
                @NavigateUp.performed += instance.OnNavigateUp;
                @NavigateUp.canceled += instance.OnNavigateUp;
                @NavigateDown.started += instance.OnNavigateDown;
                @NavigateDown.performed += instance.OnNavigateDown;
                @NavigateDown.canceled += instance.OnNavigateDown;
                @NavigateLeft.started += instance.OnNavigateLeft;
                @NavigateLeft.performed += instance.OnNavigateLeft;
                @NavigateLeft.canceled += instance.OnNavigateLeft;
                @NavigateRight.started += instance.OnNavigateRight;
                @NavigateRight.performed += instance.OnNavigateRight;
                @NavigateRight.canceled += instance.OnNavigateRight;
                @Submit.started += instance.OnSubmit;
                @Submit.performed += instance.OnSubmit;
                @Submit.canceled += instance.OnSubmit;
                @PreviousTab.started += instance.OnPreviousTab;
                @PreviousTab.performed += instance.OnPreviousTab;
                @PreviousTab.canceled += instance.OnPreviousTab;
                @NextTab.started += instance.OnNextTab;
                @NextTab.performed += instance.OnNextTab;
                @NextTab.canceled += instance.OnNextTab;
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
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
        void OnNavigateUp(InputAction.CallbackContext context);
        void OnNavigateDown(InputAction.CallbackContext context);
        void OnNavigateLeft(InputAction.CallbackContext context);
        void OnNavigateRight(InputAction.CallbackContext context);
        void OnSubmit(InputAction.CallbackContext context);
        void OnPreviousTab(InputAction.CallbackContext context);
        void OnNextTab(InputAction.CallbackContext context);
        void OnNewaction(InputAction.CallbackContext context);
    }
    public interface IMenuPauseActions
    {
        void OnOpenClose(InputAction.CallbackContext context);
    }
}
