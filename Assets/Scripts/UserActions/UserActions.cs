// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/UserActions/UserActions.inputactions'

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
                    ""name"": ""Open"",
                    ""type"": ""Button"",
                    ""id"": ""d377ccfb-6566-43a5-b21a-d35bdc5ceaac"",
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
                },
                {
                    ""name"": """",
                    ""id"": ""e0b55c5a-9484-47f9-ae1f-c5abb5139cd1"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and Mouse"",
                    ""action"": ""Open"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c20e8a36-4050-4f40-b2c7-e85f820ded9e"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Open"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Inventory"",
            ""id"": ""6c962096-761c-4801-aa7f-d6948b5e5bba"",
            ""actions"": [
                {
                    ""name"": ""NavigateUp"",
                    ""type"": ""Button"",
                    ""id"": ""848289ea-8c4c-41b8-bd4e-150d9b37d213"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CloseInventory"",
                    ""type"": ""Button"",
                    ""id"": ""d7874d5d-df06-4f6d-b7ef-530e9b639d4d"",
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
                }
            ],
            ""bindings"": [
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
                },
                {
                    ""name"": """",
                    ""id"": ""264b171e-8b1f-4978-9ea1-9337950705bc"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and Mouse"",
                    ""action"": ""CloseInventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dc1fd936-de9c-4338-b22f-c68fbecff7f0"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""CloseInventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""OptionsMenu"",
            ""id"": ""283f74c9-afb8-4043-949b-3396169f1f4e"",
            ""actions"": [
                {
                    ""name"": ""Close"",
                    ""type"": ""Button"",
                    ""id"": ""33939f93-c26e-410e-94da-460a585493b3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""NavigateUp"",
                    ""type"": ""Button"",
                    ""id"": ""52c6cd65-4fbd-4699-9394-35acd31df400"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""NavigateDown"",
                    ""type"": ""Button"",
                    ""id"": ""b96d5ba0-d873-454c-8cd1-22569d286350"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""NavigateLeft"",
                    ""type"": ""Button"",
                    ""id"": ""c0599197-76a7-4b80-84c7-5bb9bd468882"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Submit"",
                    ""type"": ""Button"",
                    ""id"": ""cbcead6e-3af4-4678-8ade-b3360d12d48c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""NavigateRight"",
                    ""type"": ""Button"",
                    ""id"": ""638a5c55-9ce0-4b86-8835-a6c489b24274"",
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
                    ""action"": ""Close"",
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
                    ""action"": ""Close"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""KeyBoard"",
                    ""id"": ""91a647a6-326a-49fa-a156-768ba3ec7b85"",
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
                    ""id"": ""d234e0f7-f8bd-4828-9733-d76a872f5a3d"",
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
                    ""id"": ""7cc9d989-8e2e-4a30-ae9c-b3e52249ad22"",
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
                    ""id"": ""b89c1fe8-949c-4deb-a949-15a43242a4e8"",
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
                    ""id"": ""8a268f4a-96f2-4825-bfc8-8e2e2a17c072"",
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
                    ""id"": ""54f59fe8-774e-4bac-be11-2cce7677165e"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""NavigateRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9f7d7dfc-02cd-401a-8376-cea405db6f10"",
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
                    ""id"": ""b4c41b6e-a6b5-41b9-8e7a-744a2e878b58"",
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
                    ""id"": ""34eed04a-6594-4f5c-8845-498c1c1b7242"",
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
                    ""id"": ""95b7246b-857b-4947-96f4-faf456defa01"",
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
                    ""id"": ""a1a34576-2db2-463a-9f7f-da07688eeed1"",
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
                    ""id"": ""241ce52a-7606-49bd-a439-76a271918e91"",
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
                    ""id"": ""788345af-af80-476c-97f2-f64789a6954c"",
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
                    ""id"": ""2c1469e2-91d0-4577-982b-b24e7a015207"",
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
                    ""id"": ""1fbef39c-515f-4ddb-98df-6059f1580eea"",
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
                    ""id"": ""2c9f404e-deb1-423f-90b0-db1db8eb78f3"",
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
                    ""id"": ""97bbf10e-09b7-49da-b033-9e03b418197d"",
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
                    ""id"": ""eb331503-e8f8-49a0-a3b3-607956e60d56"",
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
                    ""id"": ""226d4826-701f-4b9e-81e3-ed6eceb6e124"",
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
                    ""id"": ""c2ed5731-2495-4876-b3db-f4089f0651b1"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""NavigateDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""KeyBoard"",
                    ""id"": ""fd9f6554-5e08-412a-9e6a-b19442505e29"",
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
                    ""id"": ""aa43574c-ca49-4d72-b512-fddd9d37284a"",
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
                    ""id"": ""c92acbad-e43d-4154-b005-deec4df4a0ca"",
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
                    ""id"": ""087e33d4-3069-49ae-8d16-06cf174add70"",
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
                    ""id"": ""e8e6d14d-8cff-4288-baeb-3429f29356f5"",
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
                    ""id"": ""8d33bd21-35e8-49a7-a817-02b33e4a81c9"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""NavigateUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Conversation"",
            ""id"": ""600f17ee-d507-487f-9cba-131aa805d43b"",
            ""actions"": [
                {
                    ""name"": ""NextLine"",
                    ""type"": ""Button"",
                    ""id"": ""516bf608-e63d-48df-834d-8ddcf72c683c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""87972fb6-6552-47b5-904c-af2e20c78f5b"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""KeyBoard and Mouse"",
                    ""action"": ""NextLine"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b405c5f-3270-461b-a4ae-be90507eadc0"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""NextLine"",
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
        m_Player_Open = m_Player.FindAction("Open", throwIfNotFound: true);
        m_Player_Inventory = m_Player.FindAction("Inventory", throwIfNotFound: true);
        m_Player_Sprint = m_Player.FindAction("Sprint", throwIfNotFound: true);
        // Inventory
        m_Inventory = asset.FindActionMap("Inventory", throwIfNotFound: true);
        m_Inventory_NavigateUp = m_Inventory.FindAction("NavigateUp", throwIfNotFound: true);
        m_Inventory_CloseInventory = m_Inventory.FindAction("CloseInventory", throwIfNotFound: true);
        m_Inventory_NavigateDown = m_Inventory.FindAction("NavigateDown", throwIfNotFound: true);
        m_Inventory_NavigateLeft = m_Inventory.FindAction("NavigateLeft", throwIfNotFound: true);
        m_Inventory_NavigateRight = m_Inventory.FindAction("NavigateRight", throwIfNotFound: true);
        m_Inventory_Submit = m_Inventory.FindAction("Submit", throwIfNotFound: true);
        m_Inventory_PreviousTab = m_Inventory.FindAction("PreviousTab", throwIfNotFound: true);
        m_Inventory_NextTab = m_Inventory.FindAction("NextTab", throwIfNotFound: true);
        // OptionsMenu
        m_OptionsMenu = asset.FindActionMap("OptionsMenu", throwIfNotFound: true);
        m_OptionsMenu_Close = m_OptionsMenu.FindAction("Close", throwIfNotFound: true);
        m_OptionsMenu_NavigateUp = m_OptionsMenu.FindAction("NavigateUp", throwIfNotFound: true);
        m_OptionsMenu_NavigateDown = m_OptionsMenu.FindAction("NavigateDown", throwIfNotFound: true);
        m_OptionsMenu_NavigateLeft = m_OptionsMenu.FindAction("NavigateLeft", throwIfNotFound: true);
        m_OptionsMenu_Submit = m_OptionsMenu.FindAction("Submit", throwIfNotFound: true);
        m_OptionsMenu_NavigateRight = m_OptionsMenu.FindAction("NavigateRight", throwIfNotFound: true);
        // Conversation
        m_Conversation = asset.FindActionMap("Conversation", throwIfNotFound: true);
        m_Conversation_NextLine = m_Conversation.FindAction("NextLine", throwIfNotFound: true);
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
    private readonly InputAction m_Player_Open;
    private readonly InputAction m_Player_Inventory;
    private readonly InputAction m_Player_Sprint;
    public struct PlayerActions
    {
        private @UserActions m_Wrapper;
        public PlayerActions(@UserActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @Interactue => m_Wrapper.m_Player_Interactue;
        public InputAction @Open => m_Wrapper.m_Player_Open;
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
                @Open.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnOpen;
                @Open.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnOpen;
                @Open.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnOpen;
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
                @Open.started += instance.OnOpen;
                @Open.performed += instance.OnOpen;
                @Open.canceled += instance.OnOpen;
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

    // Inventory
    private readonly InputActionMap m_Inventory;
    private IInventoryActions m_InventoryActionsCallbackInterface;
    private readonly InputAction m_Inventory_NavigateUp;
    private readonly InputAction m_Inventory_CloseInventory;
    private readonly InputAction m_Inventory_NavigateDown;
    private readonly InputAction m_Inventory_NavigateLeft;
    private readonly InputAction m_Inventory_NavigateRight;
    private readonly InputAction m_Inventory_Submit;
    private readonly InputAction m_Inventory_PreviousTab;
    private readonly InputAction m_Inventory_NextTab;
    public struct InventoryActions
    {
        private @UserActions m_Wrapper;
        public InventoryActions(@UserActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @NavigateUp => m_Wrapper.m_Inventory_NavigateUp;
        public InputAction @CloseInventory => m_Wrapper.m_Inventory_CloseInventory;
        public InputAction @NavigateDown => m_Wrapper.m_Inventory_NavigateDown;
        public InputAction @NavigateLeft => m_Wrapper.m_Inventory_NavigateLeft;
        public InputAction @NavigateRight => m_Wrapper.m_Inventory_NavigateRight;
        public InputAction @Submit => m_Wrapper.m_Inventory_Submit;
        public InputAction @PreviousTab => m_Wrapper.m_Inventory_PreviousTab;
        public InputAction @NextTab => m_Wrapper.m_Inventory_NextTab;
        public InputActionMap Get() { return m_Wrapper.m_Inventory; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InventoryActions set) { return set.Get(); }
        public void SetCallbacks(IInventoryActions instance)
        {
            if (m_Wrapper.m_InventoryActionsCallbackInterface != null)
            {
                @NavigateUp.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnNavigateUp;
                @NavigateUp.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnNavigateUp;
                @NavigateUp.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnNavigateUp;
                @CloseInventory.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnCloseInventory;
                @CloseInventory.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnCloseInventory;
                @CloseInventory.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnCloseInventory;
                @NavigateDown.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnNavigateDown;
                @NavigateDown.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnNavigateDown;
                @NavigateDown.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnNavigateDown;
                @NavigateLeft.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnNavigateLeft;
                @NavigateLeft.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnNavigateLeft;
                @NavigateLeft.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnNavigateLeft;
                @NavigateRight.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnNavigateRight;
                @NavigateRight.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnNavigateRight;
                @NavigateRight.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnNavigateRight;
                @Submit.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnSubmit;
                @Submit.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnSubmit;
                @Submit.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnSubmit;
                @PreviousTab.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnPreviousTab;
                @PreviousTab.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnPreviousTab;
                @PreviousTab.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnPreviousTab;
                @NextTab.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnNextTab;
                @NextTab.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnNextTab;
                @NextTab.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnNextTab;
            }
            m_Wrapper.m_InventoryActionsCallbackInterface = instance;
            if (instance != null)
            {
                @NavigateUp.started += instance.OnNavigateUp;
                @NavigateUp.performed += instance.OnNavigateUp;
                @NavigateUp.canceled += instance.OnNavigateUp;
                @CloseInventory.started += instance.OnCloseInventory;
                @CloseInventory.performed += instance.OnCloseInventory;
                @CloseInventory.canceled += instance.OnCloseInventory;
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
            }
        }
    }
    public InventoryActions @Inventory => new InventoryActions(this);

    // OptionsMenu
    private readonly InputActionMap m_OptionsMenu;
    private IOptionsMenuActions m_OptionsMenuActionsCallbackInterface;
    private readonly InputAction m_OptionsMenu_Close;
    private readonly InputAction m_OptionsMenu_NavigateUp;
    private readonly InputAction m_OptionsMenu_NavigateDown;
    private readonly InputAction m_OptionsMenu_NavigateLeft;
    private readonly InputAction m_OptionsMenu_Submit;
    private readonly InputAction m_OptionsMenu_NavigateRight;
    public struct OptionsMenuActions
    {
        private @UserActions m_Wrapper;
        public OptionsMenuActions(@UserActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Close => m_Wrapper.m_OptionsMenu_Close;
        public InputAction @NavigateUp => m_Wrapper.m_OptionsMenu_NavigateUp;
        public InputAction @NavigateDown => m_Wrapper.m_OptionsMenu_NavigateDown;
        public InputAction @NavigateLeft => m_Wrapper.m_OptionsMenu_NavigateLeft;
        public InputAction @Submit => m_Wrapper.m_OptionsMenu_Submit;
        public InputAction @NavigateRight => m_Wrapper.m_OptionsMenu_NavigateRight;
        public InputActionMap Get() { return m_Wrapper.m_OptionsMenu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(OptionsMenuActions set) { return set.Get(); }
        public void SetCallbacks(IOptionsMenuActions instance)
        {
            if (m_Wrapper.m_OptionsMenuActionsCallbackInterface != null)
            {
                @Close.started -= m_Wrapper.m_OptionsMenuActionsCallbackInterface.OnClose;
                @Close.performed -= m_Wrapper.m_OptionsMenuActionsCallbackInterface.OnClose;
                @Close.canceled -= m_Wrapper.m_OptionsMenuActionsCallbackInterface.OnClose;
                @NavigateUp.started -= m_Wrapper.m_OptionsMenuActionsCallbackInterface.OnNavigateUp;
                @NavigateUp.performed -= m_Wrapper.m_OptionsMenuActionsCallbackInterface.OnNavigateUp;
                @NavigateUp.canceled -= m_Wrapper.m_OptionsMenuActionsCallbackInterface.OnNavigateUp;
                @NavigateDown.started -= m_Wrapper.m_OptionsMenuActionsCallbackInterface.OnNavigateDown;
                @NavigateDown.performed -= m_Wrapper.m_OptionsMenuActionsCallbackInterface.OnNavigateDown;
                @NavigateDown.canceled -= m_Wrapper.m_OptionsMenuActionsCallbackInterface.OnNavigateDown;
                @NavigateLeft.started -= m_Wrapper.m_OptionsMenuActionsCallbackInterface.OnNavigateLeft;
                @NavigateLeft.performed -= m_Wrapper.m_OptionsMenuActionsCallbackInterface.OnNavigateLeft;
                @NavigateLeft.canceled -= m_Wrapper.m_OptionsMenuActionsCallbackInterface.OnNavigateLeft;
                @Submit.started -= m_Wrapper.m_OptionsMenuActionsCallbackInterface.OnSubmit;
                @Submit.performed -= m_Wrapper.m_OptionsMenuActionsCallbackInterface.OnSubmit;
                @Submit.canceled -= m_Wrapper.m_OptionsMenuActionsCallbackInterface.OnSubmit;
                @NavigateRight.started -= m_Wrapper.m_OptionsMenuActionsCallbackInterface.OnNavigateRight;
                @NavigateRight.performed -= m_Wrapper.m_OptionsMenuActionsCallbackInterface.OnNavigateRight;
                @NavigateRight.canceled -= m_Wrapper.m_OptionsMenuActionsCallbackInterface.OnNavigateRight;
            }
            m_Wrapper.m_OptionsMenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Close.started += instance.OnClose;
                @Close.performed += instance.OnClose;
                @Close.canceled += instance.OnClose;
                @NavigateUp.started += instance.OnNavigateUp;
                @NavigateUp.performed += instance.OnNavigateUp;
                @NavigateUp.canceled += instance.OnNavigateUp;
                @NavigateDown.started += instance.OnNavigateDown;
                @NavigateDown.performed += instance.OnNavigateDown;
                @NavigateDown.canceled += instance.OnNavigateDown;
                @NavigateLeft.started += instance.OnNavigateLeft;
                @NavigateLeft.performed += instance.OnNavigateLeft;
                @NavigateLeft.canceled += instance.OnNavigateLeft;
                @Submit.started += instance.OnSubmit;
                @Submit.performed += instance.OnSubmit;
                @Submit.canceled += instance.OnSubmit;
                @NavigateRight.started += instance.OnNavigateRight;
                @NavigateRight.performed += instance.OnNavigateRight;
                @NavigateRight.canceled += instance.OnNavigateRight;
            }
        }
    }
    public OptionsMenuActions @OptionsMenu => new OptionsMenuActions(this);

    // Conversation
    private readonly InputActionMap m_Conversation;
    private IConversationActions m_ConversationActionsCallbackInterface;
    private readonly InputAction m_Conversation_NextLine;
    public struct ConversationActions
    {
        private @UserActions m_Wrapper;
        public ConversationActions(@UserActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @NextLine => m_Wrapper.m_Conversation_NextLine;
        public InputActionMap Get() { return m_Wrapper.m_Conversation; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ConversationActions set) { return set.Get(); }
        public void SetCallbacks(IConversationActions instance)
        {
            if (m_Wrapper.m_ConversationActionsCallbackInterface != null)
            {
                @NextLine.started -= m_Wrapper.m_ConversationActionsCallbackInterface.OnNextLine;
                @NextLine.performed -= m_Wrapper.m_ConversationActionsCallbackInterface.OnNextLine;
                @NextLine.canceled -= m_Wrapper.m_ConversationActionsCallbackInterface.OnNextLine;
            }
            m_Wrapper.m_ConversationActionsCallbackInterface = instance;
            if (instance != null)
            {
                @NextLine.started += instance.OnNextLine;
                @NextLine.performed += instance.OnNextLine;
                @NextLine.canceled += instance.OnNextLine;
            }
        }
    }
    public ConversationActions @Conversation => new ConversationActions(this);
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
        void OnOpen(InputAction.CallbackContext context);
        void OnInventory(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
    }
    public interface IInventoryActions
    {
        void OnNavigateUp(InputAction.CallbackContext context);
        void OnCloseInventory(InputAction.CallbackContext context);
        void OnNavigateDown(InputAction.CallbackContext context);
        void OnNavigateLeft(InputAction.CallbackContext context);
        void OnNavigateRight(InputAction.CallbackContext context);
        void OnSubmit(InputAction.CallbackContext context);
        void OnPreviousTab(InputAction.CallbackContext context);
        void OnNextTab(InputAction.CallbackContext context);
    }
    public interface IOptionsMenuActions
    {
        void OnClose(InputAction.CallbackContext context);
        void OnNavigateUp(InputAction.CallbackContext context);
        void OnNavigateDown(InputAction.CallbackContext context);
        void OnNavigateLeft(InputAction.CallbackContext context);
        void OnSubmit(InputAction.CallbackContext context);
        void OnNavigateRight(InputAction.CallbackContext context);
    }
    public interface IConversationActions
    {
        void OnNextLine(InputAction.CallbackContext context);
    }
}
