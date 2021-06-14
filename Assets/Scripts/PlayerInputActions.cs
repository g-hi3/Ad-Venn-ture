// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Overworld"",
            ""id"": ""18854d3a-d1b1-441e-af4a-621c8044024d"",
            ""actions"": [
                {
                    ""name"": ""Move Left Character"",
                    ""type"": ""Value"",
                    ""id"": ""7430be0a-516d-484e-b55f-1928cc336e0f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move Right Character"",
                    ""type"": ""Value"",
                    ""id"": ""9799f050-e839-4905-9680-66b75fb42e7d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact As Left Character"",
                    ""type"": ""Button"",
                    ""id"": ""55791e13-ef97-438d-ab9f-db4952b3259c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact As Right Character"",
                    ""type"": ""Button"",
                    ""id"": ""cb242d12-33fc-478a-865b-a3a025801ce8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""850637bb-92c3-4593-a886-a4bc877a61e5"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move Left Character"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""c95f498f-ac8c-4543-b1d1-2ae6d946aaf8"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Left Character"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""de568e81-f70b-4286-afd8-bf17bb43daf6"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move Left Character"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c83ed294-d1df-4787-a6f6-62d3db68c35b"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move Left Character"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0e9babec-dfbe-46ab-8316-a2ff6bca151d"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move Left Character"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d3d99ee0-79d3-4616-a90f-8339d96de966"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move Left Character"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e9697aa9-4425-4686-98b4-4f77ccc40dba"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move Right Character"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Arrow Keys"",
                    ""id"": ""39ebec2f-1985-4212-937e-2a809d902d4e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Right Character"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""24539ad3-5349-4f31-9191-2d679682c6a6"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move Right Character"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""90d67fe0-ff4d-4983-a41f-3a71026f59a0"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move Right Character"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""60ddf9dd-7baf-44e8-923f-285e88cd3522"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move Right Character"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c5492d4f-468d-4d6c-b46a-ff2679d87a60"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move Right Character"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ad252210-fabb-4d2d-ad81-5051810c8671"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Interact As Left Character"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d073b70c-8fc1-4749-ab6e-a05cefb73b0b"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Interact As Left Character"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""98986c9a-a6ef-4889-ba53-4bd2a031d2ad"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Interact As Right Character"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b7f76e54-55e5-48d9-93c7-e157b154c12e"",
                    ""path"": ""<Keyboard>/u"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Interact As Right Character"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
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
        },
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Overworld
        m_Overworld = asset.FindActionMap("Overworld", throwIfNotFound: true);
        m_Overworld_MoveLeftCharacter = m_Overworld.FindAction("Move Left Character", throwIfNotFound: true);
        m_Overworld_MoveRightCharacter = m_Overworld.FindAction("Move Right Character", throwIfNotFound: true);
        m_Overworld_InteractAsLeftCharacter = m_Overworld.FindAction("Interact As Left Character", throwIfNotFound: true);
        m_Overworld_InteractAsRightCharacter = m_Overworld.FindAction("Interact As Right Character", throwIfNotFound: true);
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

    // Overworld
    private readonly InputActionMap m_Overworld;
    private IOverworldActions m_OverworldActionsCallbackInterface;
    private readonly InputAction m_Overworld_MoveLeftCharacter;
    private readonly InputAction m_Overworld_MoveRightCharacter;
    private readonly InputAction m_Overworld_InteractAsLeftCharacter;
    private readonly InputAction m_Overworld_InteractAsRightCharacter;
    public struct OverworldActions
    {
        private @PlayerInputActions m_Wrapper;
        public OverworldActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveLeftCharacter => m_Wrapper.m_Overworld_MoveLeftCharacter;
        public InputAction @MoveRightCharacter => m_Wrapper.m_Overworld_MoveRightCharacter;
        public InputAction @InteractAsLeftCharacter => m_Wrapper.m_Overworld_InteractAsLeftCharacter;
        public InputAction @InteractAsRightCharacter => m_Wrapper.m_Overworld_InteractAsRightCharacter;
        public InputActionMap Get() { return m_Wrapper.m_Overworld; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(OverworldActions set) { return set.Get(); }
        public void SetCallbacks(IOverworldActions instance)
        {
            if (m_Wrapper.m_OverworldActionsCallbackInterface != null)
            {
                @MoveLeftCharacter.started -= m_Wrapper.m_OverworldActionsCallbackInterface.OnMoveLeftCharacter;
                @MoveLeftCharacter.performed -= m_Wrapper.m_OverworldActionsCallbackInterface.OnMoveLeftCharacter;
                @MoveLeftCharacter.canceled -= m_Wrapper.m_OverworldActionsCallbackInterface.OnMoveLeftCharacter;
                @MoveRightCharacter.started -= m_Wrapper.m_OverworldActionsCallbackInterface.OnMoveRightCharacter;
                @MoveRightCharacter.performed -= m_Wrapper.m_OverworldActionsCallbackInterface.OnMoveRightCharacter;
                @MoveRightCharacter.canceled -= m_Wrapper.m_OverworldActionsCallbackInterface.OnMoveRightCharacter;
                @InteractAsLeftCharacter.started -= m_Wrapper.m_OverworldActionsCallbackInterface.OnInteractAsLeftCharacter;
                @InteractAsLeftCharacter.performed -= m_Wrapper.m_OverworldActionsCallbackInterface.OnInteractAsLeftCharacter;
                @InteractAsLeftCharacter.canceled -= m_Wrapper.m_OverworldActionsCallbackInterface.OnInteractAsLeftCharacter;
                @InteractAsRightCharacter.started -= m_Wrapper.m_OverworldActionsCallbackInterface.OnInteractAsRightCharacter;
                @InteractAsRightCharacter.performed -= m_Wrapper.m_OverworldActionsCallbackInterface.OnInteractAsRightCharacter;
                @InteractAsRightCharacter.canceled -= m_Wrapper.m_OverworldActionsCallbackInterface.OnInteractAsRightCharacter;
            }
            m_Wrapper.m_OverworldActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveLeftCharacter.started += instance.OnMoveLeftCharacter;
                @MoveLeftCharacter.performed += instance.OnMoveLeftCharacter;
                @MoveLeftCharacter.canceled += instance.OnMoveLeftCharacter;
                @MoveRightCharacter.started += instance.OnMoveRightCharacter;
                @MoveRightCharacter.performed += instance.OnMoveRightCharacter;
                @MoveRightCharacter.canceled += instance.OnMoveRightCharacter;
                @InteractAsLeftCharacter.started += instance.OnInteractAsLeftCharacter;
                @InteractAsLeftCharacter.performed += instance.OnInteractAsLeftCharacter;
                @InteractAsLeftCharacter.canceled += instance.OnInteractAsLeftCharacter;
                @InteractAsRightCharacter.started += instance.OnInteractAsRightCharacter;
                @InteractAsRightCharacter.performed += instance.OnInteractAsRightCharacter;
                @InteractAsRightCharacter.canceled += instance.OnInteractAsRightCharacter;
            }
        }
    }
    public OverworldActions @Overworld => new OverworldActions(this);
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IOverworldActions
    {
        void OnMoveLeftCharacter(InputAction.CallbackContext context);
        void OnMoveRightCharacter(InputAction.CallbackContext context);
        void OnInteractAsLeftCharacter(InputAction.CallbackContext context);
        void OnInteractAsRightCharacter(InputAction.CallbackContext context);
    }
}
