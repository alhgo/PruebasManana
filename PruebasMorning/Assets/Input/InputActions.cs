// GENERATED AUTOMATICALLY FROM 'Assets/Input/InputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""Game"",
            ""id"": ""08a1d520-079e-4b48-b6b9-30acf4970f09"",
            ""actions"": [
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""f7c3a2fe-7aea-4578-b8fe-c2b0f4932940"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5ecb7177-0f69-47e3-8e90-46b4c5872565"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player"",
            ""id"": ""84bd3c1f-4d24-4cb8-ae09-7334936202f7"",
            ""actions"": [
                {
                    ""name"": ""JoyV"",
                    ""type"": ""Value"",
                    ""id"": ""12797826-1522-44fd-94ea-ce6b235f32f8"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""JoyH"",
                    ""type"": ""Value"",
                    ""id"": ""4be3655d-1de3-4b1b-b9cb-9e2932fb46f2"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""33ae6f9b-c181-4ecb-b077-83b597109c67"",
                    ""path"": ""<Gamepad>/leftStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""JoyV"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""78c015ab-e57d-45eb-ac9d-9869a6521768"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""JoyH"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Game
        m_Game = asset.FindActionMap("Game", throwIfNotFound: true);
        m_Game_Pause = m_Game.FindAction("Pause", throwIfNotFound: true);
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_JoyV = m_Player.FindAction("JoyV", throwIfNotFound: true);
        m_Player_JoyH = m_Player.FindAction("JoyH", throwIfNotFound: true);
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

    // Game
    private readonly InputActionMap m_Game;
    private IGameActions m_GameActionsCallbackInterface;
    private readonly InputAction m_Game_Pause;
    public struct GameActions
    {
        private @InputActions m_Wrapper;
        public GameActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pause => m_Wrapper.m_Game_Pause;
        public InputActionMap Get() { return m_Wrapper.m_Game; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameActions set) { return set.Get(); }
        public void SetCallbacks(IGameActions instance)
        {
            if (m_Wrapper.m_GameActionsCallbackInterface != null)
            {
                @Pause.started -= m_Wrapper.m_GameActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_GameActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public GameActions @Game => new GameActions(this);

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_JoyV;
    private readonly InputAction m_Player_JoyH;
    public struct PlayerActions
    {
        private @InputActions m_Wrapper;
        public PlayerActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @JoyV => m_Wrapper.m_Player_JoyV;
        public InputAction @JoyH => m_Wrapper.m_Player_JoyH;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @JoyV.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJoyV;
                @JoyV.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJoyV;
                @JoyV.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJoyV;
                @JoyH.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJoyH;
                @JoyH.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJoyH;
                @JoyH.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJoyH;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @JoyV.started += instance.OnJoyV;
                @JoyV.performed += instance.OnJoyV;
                @JoyV.canceled += instance.OnJoyV;
                @JoyH.started += instance.OnJoyH;
                @JoyH.performed += instance.OnJoyH;
                @JoyH.canceled += instance.OnJoyH;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IGameActions
    {
        void OnPause(InputAction.CallbackContext context);
    }
    public interface IPlayerActions
    {
        void OnJoyV(InputAction.CallbackContext context);
        void OnJoyH(InputAction.CallbackContext context);
    }
}
