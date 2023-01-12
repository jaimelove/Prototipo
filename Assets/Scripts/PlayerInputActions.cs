//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Scripts/PlayerInputActions.inputactions
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

public partial class @PlayerInputActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""move"",
            ""id"": ""09ca34e7-c80c-4141-aabb-3b5d2578c640"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Value"",
                    ""id"": ""95af6105-ccd3-48c2-ae8e-72c064398d11"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MoveRight"",
                    ""type"": ""Button"",
                    ""id"": ""0ca4d232-d40d-49f0-94bc-10a6b8eb2a1f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MoveLeft"",
                    ""type"": ""Button"",
                    ""id"": ""b0fb3a8e-d046-4bdc-8a87-492bd4d9112b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""none"",
                    ""type"": ""Button"",
                    ""id"": ""e6af0341-03e8-4274-b531-207041595899"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""598147dc-7aab-45fa-be46-c5f384070ca0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MoveRightLeft"",
                    ""type"": ""Button"",
                    ""id"": ""c5be8305-c7b3-489d-abd5-72d60c3f37f1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""30658315-0faf-4dae-a601-180ba6193934"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""05a04de2-7bb5-48c9-a1ce-539f02fb6076"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""c47d3b19-285d-4cae-afd6-1f907acc51e3"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRightLeft"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b5126296-61ae-4564-a043-5c6b1385467c"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRightLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""ae847698-b29e-49ef-9b81-3688a8993c93"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRightLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""876a292b-f9df-4dae-8fd1-c9c10be6e705"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // move
        m_move = asset.FindActionMap("move", throwIfNotFound: true);
        m_move_Jump = m_move.FindAction("Jump", throwIfNotFound: true);
        m_move_MoveRight = m_move.FindAction("MoveRight", throwIfNotFound: true);
        m_move_MoveLeft = m_move.FindAction("MoveLeft", throwIfNotFound: true);
        m_move_none = m_move.FindAction("none", throwIfNotFound: true);
        m_move_Shoot = m_move.FindAction("Shoot", throwIfNotFound: true);
        m_move_MoveRightLeft = m_move.FindAction("MoveRightLeft", throwIfNotFound: true);
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

    // move
    private readonly InputActionMap m_move;
    private IMoveActions m_MoveActionsCallbackInterface;
    private readonly InputAction m_move_Jump;
    private readonly InputAction m_move_MoveRight;
    private readonly InputAction m_move_MoveLeft;
    private readonly InputAction m_move_none;
    private readonly InputAction m_move_Shoot;
    private readonly InputAction m_move_MoveRightLeft;
    public struct MoveActions
    {
        private @PlayerInputActions m_Wrapper;
        public MoveActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_move_Jump;
        public InputAction @MoveRight => m_Wrapper.m_move_MoveRight;
        public InputAction @MoveLeft => m_Wrapper.m_move_MoveLeft;
        public InputAction @none => m_Wrapper.m_move_none;
        public InputAction @Shoot => m_Wrapper.m_move_Shoot;
        public InputAction @MoveRightLeft => m_Wrapper.m_move_MoveRightLeft;
        public InputActionMap Get() { return m_Wrapper.m_move; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MoveActions set) { return set.Get(); }
        public void SetCallbacks(IMoveActions instance)
        {
            if (m_Wrapper.m_MoveActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnJump;
                @MoveRight.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnMoveRight;
                @MoveRight.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnMoveRight;
                @MoveRight.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnMoveRight;
                @MoveLeft.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnMoveLeft;
                @none.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnNone;
                @none.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnNone;
                @none.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnNone;
                @Shoot.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnShoot;
                @MoveRightLeft.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnMoveRightLeft;
                @MoveRightLeft.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnMoveRightLeft;
                @MoveRightLeft.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnMoveRightLeft;
            }
            m_Wrapper.m_MoveActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @MoveRight.started += instance.OnMoveRight;
                @MoveRight.performed += instance.OnMoveRight;
                @MoveRight.canceled += instance.OnMoveRight;
                @MoveLeft.started += instance.OnMoveLeft;
                @MoveLeft.performed += instance.OnMoveLeft;
                @MoveLeft.canceled += instance.OnMoveLeft;
                @none.started += instance.OnNone;
                @none.performed += instance.OnNone;
                @none.canceled += instance.OnNone;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @MoveRightLeft.started += instance.OnMoveRightLeft;
                @MoveRightLeft.performed += instance.OnMoveRightLeft;
                @MoveRightLeft.canceled += instance.OnMoveRightLeft;
            }
        }
    }
    public MoveActions @move => new MoveActions(this);
    public interface IMoveActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnMoveRight(InputAction.CallbackContext context);
        void OnMoveLeft(InputAction.CallbackContext context);
        void OnNone(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnMoveRightLeft(InputAction.CallbackContext context);
    }
}