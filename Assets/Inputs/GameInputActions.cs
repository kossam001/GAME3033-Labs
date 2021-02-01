// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/GameInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @GameInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @GameInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameInputActions"",
    ""maps"": [
        {
            ""name"": ""ThirdPerson"",
            ""id"": ""dd0a6bf5-8b46-49e6-a3e8-d912485781bf"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""d4824b3e-6f8e-4bc8-81dc-adbd17465fe9"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""710a4bb5-2dd2-441e-ae00-6cf8e3ca0ef8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""8d1faede-c3d1-42be-9f9a-5169cca7b382"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""58956121-d0f1-4daa-bd1d-e2eb1287ec48"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""cbb32e52-9cc6-44fb-adab-ec16832a815d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a1dbd5e0-14da-481f-9519-9abd9886cf2e"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""96fb9875-ea12-434d-b917-3dbf5fb2df16"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5711ec62-e462-4081-b811-94b7a2c1f18c"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""6f6e0de5-5663-4be8-aa5c-3afc24050d74"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4dfe8483-b313-4c7c-bbef-652b64abfb42"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""83bb09d8-6c45-4139-a766-df6e512b183e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1b32b742-d834-425b-9d66-223942363630"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d42c9c91-75a4-40db-b7b2-7acf17c693d6"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6705a034-e4dd-4792-9488-1547bf5f9486"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
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
        }
    ]
}");
        // ThirdPerson
        m_ThirdPerson = asset.FindActionMap("ThirdPerson", throwIfNotFound: true);
        m_ThirdPerson_Movement = m_ThirdPerson.FindAction("Movement", throwIfNotFound: true);
        m_ThirdPerson_Jump = m_ThirdPerson.FindAction("Jump", throwIfNotFound: true);
        m_ThirdPerson_Fire = m_ThirdPerson.FindAction("Fire", throwIfNotFound: true);
        m_ThirdPerson_Run = m_ThirdPerson.FindAction("Run", throwIfNotFound: true);
        m_ThirdPerson_Look = m_ThirdPerson.FindAction("Look", throwIfNotFound: true);
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

    // ThirdPerson
    private readonly InputActionMap m_ThirdPerson;
    private IThirdPersonActions m_ThirdPersonActionsCallbackInterface;
    private readonly InputAction m_ThirdPerson_Movement;
    private readonly InputAction m_ThirdPerson_Jump;
    private readonly InputAction m_ThirdPerson_Fire;
    private readonly InputAction m_ThirdPerson_Run;
    private readonly InputAction m_ThirdPerson_Look;
    public struct ThirdPersonActions
    {
        private @GameInputActions m_Wrapper;
        public ThirdPersonActions(@GameInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_ThirdPerson_Movement;
        public InputAction @Jump => m_Wrapper.m_ThirdPerson_Jump;
        public InputAction @Fire => m_Wrapper.m_ThirdPerson_Fire;
        public InputAction @Run => m_Wrapper.m_ThirdPerson_Run;
        public InputAction @Look => m_Wrapper.m_ThirdPerson_Look;
        public InputActionMap Get() { return m_Wrapper.m_ThirdPerson; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ThirdPersonActions set) { return set.Get(); }
        public void SetCallbacks(IThirdPersonActions instance)
        {
            if (m_Wrapper.m_ThirdPersonActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnJump;
                @Fire.started -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnFire;
                @Run.started -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnRun;
                @Look.started -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_ThirdPersonActionsCallbackInterface.OnLook;
            }
            m_Wrapper.m_ThirdPersonActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
            }
        }
    }
    public ThirdPersonActions @ThirdPerson => new ThirdPersonActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IThirdPersonActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
    }
}
