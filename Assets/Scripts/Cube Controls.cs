//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.3
//     from Assets/Control Schemes/Cube Controls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @CubeControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @CubeControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Cube Controls"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""5cceead0-ac2d-4c02-ac19-1c892f731943"",
            ""actions"": [
                {
                    ""name"": ""Grow"",
                    ""type"": ""Button"",
                    ""id"": ""772ea4f8-38e3-484f-8b54-15c4e46e0d7e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Shrink"",
                    ""type"": ""Button"",
                    ""id"": ""a00cb61e-4bd4-4214-b4bd-2d6349882d1b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""746da599-2428-42f4-9974-adb3187c1501"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Value"",
                    ""id"": ""7feb28c5-5bc0-49ec-b688-f256605597f4"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""15e5a885-d400-4add-9e18-8de62e6d0489"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0881f48e-72f1-4363-9402-82c4696a0316"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f6d9b0d7-fd3c-4dcc-ac10-bf6acd352207"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""578de4f7-9ed7-42f0-8286-4393e17ccb33"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4322b4bc-08a2-429b-94e7-7a22033dfc3d"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shrink"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b221b18d-cac5-4027-bc0e-3b0027d14fc5"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shrink"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""35ca4bb3-82fc-414e-8fb3-e9b4be0e760e"",
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
                    ""id"": ""dcfaeaf6-5aad-49a8-a7d9-c53e01873da1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""6805533c-f8cd-4700-b4eb-412b009e3f44"",
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
                    ""id"": ""99ada337-f551-43cb-8b22-b866588a1d01"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ba0ddd34-6d7d-4d75-8c35-e56ff677112e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_Grow = m_Movement.FindAction("Grow", throwIfNotFound: true);
        m_Movement_Shrink = m_Movement.FindAction("Shrink", throwIfNotFound: true);
        m_Movement_Move = m_Movement.FindAction("Move", throwIfNotFound: true);
        m_Movement_Rotate = m_Movement.FindAction("Rotate", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Movement
    private readonly InputActionMap m_Movement;
    private IMovementActions m_MovementActionsCallbackInterface;
    private readonly InputAction m_Movement_Grow;
    private readonly InputAction m_Movement_Shrink;
    private readonly InputAction m_Movement_Move;
    private readonly InputAction m_Movement_Rotate;
    public struct MovementActions
    {
        private @CubeControls m_Wrapper;
        public MovementActions(@CubeControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Grow => m_Wrapper.m_Movement_Grow;
        public InputAction @Shrink => m_Wrapper.m_Movement_Shrink;
        public InputAction @Move => m_Wrapper.m_Movement_Move;
        public InputAction @Rotate => m_Wrapper.m_Movement_Rotate;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void SetCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterface != null)
            {
                @Grow.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnGrow;
                @Grow.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnGrow;
                @Grow.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnGrow;
                @Shrink.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnShrink;
                @Shrink.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnShrink;
                @Shrink.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnShrink;
                @Move.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
                @Rotate.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnRotate;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Grow.started += instance.OnGrow;
                @Grow.performed += instance.OnGrow;
                @Grow.canceled += instance.OnGrow;
                @Shrink.started += instance.OnShrink;
                @Shrink.performed += instance.OnShrink;
                @Shrink.canceled += instance.OnShrink;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
            }
        }
    }
    public MovementActions @Movement => new MovementActions(this);
    public interface IMovementActions
    {
        void OnGrow(InputAction.CallbackContext context);
        void OnShrink(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
    }
}
