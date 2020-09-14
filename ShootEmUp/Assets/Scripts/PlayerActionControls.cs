// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerActionControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace ShootEmUp
{
    public class @PlayerActionControls : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @PlayerActionControls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerActionControls"",
    ""maps"": [
        {
            ""name"": ""Basic"",
            ""id"": ""e54577c9-c640-45a9-80a8-b02dba861cd5"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""f3496b32-6f97-4644-8c16-02ecc7c15479"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""4b2792ca-596e-4cdd-92b4-7850b88e6d6e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""259ec495-3f35-429f-872b-a66c775804e8"",
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
                    ""id"": ""967410ca-0e3c-4dcd-b284-aace6c2a032f"",
                    ""path"": ""<Keyboard>/#(W)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8fdceb06-103d-4bd1-8424-abc48fe3cf66"",
                    ""path"": ""<Keyboard>/#(A)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1812fba9-ff3f-4587-ada2-3b607cecf66e"",
                    ""path"": ""<Keyboard>/#(S)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""04675dfd-605d-4845-9e88-50834b2d3124"",
                    ""path"": ""<Keyboard>/#(D)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""690d38f1-7a46-4d13-92d2-33114fa5321e"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Basic
            m_Basic = asset.FindActionMap("Basic", throwIfNotFound: true);
            m_Basic_Move = m_Basic.FindAction("Move", throwIfNotFound: true);
            m_Basic_Shoot = m_Basic.FindAction("Shoot", throwIfNotFound: true);
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

        // Basic
        private readonly InputActionMap m_Basic;
        private IBasicActions m_BasicActionsCallbackInterface;
        private readonly InputAction m_Basic_Move;
        private readonly InputAction m_Basic_Shoot;
        public struct BasicActions
        {
            private @PlayerActionControls m_Wrapper;
            public BasicActions(@PlayerActionControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @Move => m_Wrapper.m_Basic_Move;
            public InputAction @Shoot => m_Wrapper.m_Basic_Shoot;
            public InputActionMap Get() { return m_Wrapper.m_Basic; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(BasicActions set) { return set.Get(); }
            public void SetCallbacks(IBasicActions instance)
            {
                if (m_Wrapper.m_BasicActionsCallbackInterface != null)
                {
                    @Move.started -= m_Wrapper.m_BasicActionsCallbackInterface.OnMove;
                    @Move.performed -= m_Wrapper.m_BasicActionsCallbackInterface.OnMove;
                    @Move.canceled -= m_Wrapper.m_BasicActionsCallbackInterface.OnMove;
                    @Shoot.started -= m_Wrapper.m_BasicActionsCallbackInterface.OnShoot;
                    @Shoot.performed -= m_Wrapper.m_BasicActionsCallbackInterface.OnShoot;
                    @Shoot.canceled -= m_Wrapper.m_BasicActionsCallbackInterface.OnShoot;
                }
                m_Wrapper.m_BasicActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Move.started += instance.OnMove;
                    @Move.performed += instance.OnMove;
                    @Move.canceled += instance.OnMove;
                    @Shoot.started += instance.OnShoot;
                    @Shoot.performed += instance.OnShoot;
                    @Shoot.canceled += instance.OnShoot;
                }
            }
        }
        public BasicActions @Basic => new BasicActions(this);
        public interface IBasicActions
        {
            void OnMove(InputAction.CallbackContext context);
            void OnShoot(InputAction.CallbackContext context);
        }
    }
}
