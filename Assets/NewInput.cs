//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/NewInput.inputactions
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

public partial class @NewInput : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @NewInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""NewInput"",
    ""maps"": [
        {
            ""name"": ""NewStandard"",
            ""id"": ""a235c7e8-712e-4a8a-84e3-29e40a61e5b9"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""5992f885-b30c-4dbb-a647-a6f5d06d363e"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Shooting"",
                    ""type"": ""Button"",
                    ""id"": ""c2f96064-b753-43da-a2c3-ff23d91f9779"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ffddb81b-b17a-49c5-9fda-29f8140a4b31"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shooting"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""34a8be67-2ed7-4208-98a7-c30d6e2ea32c"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""6e23b644-16e8-4414-90d3-d871e693820e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""1de3518f-6a99-4d82-8c28-080d0d0b64f6"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // NewStandard
        m_NewStandard = asset.FindActionMap("NewStandard", throwIfNotFound: true);
        m_NewStandard_Movement = m_NewStandard.FindAction("Movement", throwIfNotFound: true);
        m_NewStandard_Shooting = m_NewStandard.FindAction("Shooting", throwIfNotFound: true);
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

    // NewStandard
    private readonly InputActionMap m_NewStandard;
    private INewStandardActions m_NewStandardActionsCallbackInterface;
    private readonly InputAction m_NewStandard_Movement;
    private readonly InputAction m_NewStandard_Shooting;
    public struct NewStandardActions
    {
        private @NewInput m_Wrapper;
        public NewStandardActions(@NewInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_NewStandard_Movement;
        public InputAction @Shooting => m_Wrapper.m_NewStandard_Shooting;
        public InputActionMap Get() { return m_Wrapper.m_NewStandard; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(NewStandardActions set) { return set.Get(); }
        public void SetCallbacks(INewStandardActions instance)
        {
            if (m_Wrapper.m_NewStandardActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_NewStandardActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_NewStandardActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_NewStandardActionsCallbackInterface.OnMovement;
                @Shooting.started -= m_Wrapper.m_NewStandardActionsCallbackInterface.OnShooting;
                @Shooting.performed -= m_Wrapper.m_NewStandardActionsCallbackInterface.OnShooting;
                @Shooting.canceled -= m_Wrapper.m_NewStandardActionsCallbackInterface.OnShooting;
            }
            m_Wrapper.m_NewStandardActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Shooting.started += instance.OnShooting;
                @Shooting.performed += instance.OnShooting;
                @Shooting.canceled += instance.OnShooting;
            }
        }
    }
    public NewStandardActions @NewStandard => new NewStandardActions(this);
    public interface INewStandardActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnShooting(InputAction.CallbackContext context);
    }
}
