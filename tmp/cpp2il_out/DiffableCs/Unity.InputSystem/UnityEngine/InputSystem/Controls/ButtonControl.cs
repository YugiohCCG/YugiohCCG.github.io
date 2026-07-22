namespace UnityEngine.InputSystem.Controls;

public class ButtonControl : AxisControl
{
	internal static float s_GlobalDefaultButtonPressPoint; //Field offset: 0x0
	internal const float kMinButtonPressPoint = 0.0001; //Field offset: 0x0
	internal static float s_GlobalDefaultButtonReleaseThreshold; //Field offset: 0x4
	private bool m_NeedsToCheckFramePress; //Field offset: 0x130
	private uint m_UpdateCountLastPressed; //Field offset: 0x134
	private uint m_UpdateCountLastReleased; //Field offset: 0x138
	private bool m_LastUpdateWasPress; //Field offset: 0x13C
	[CompilerGenerated]
	private bool <needsToCheckFramePress>k__BackingField; //Field offset: 0x13D
	public float pressPoint; //Field offset: 0x140

	public bool isPressed
	{
		[CalledBy(Type = "Manager.Hotkey", Member = "get_IsHoldingCtrl", ReturnType = typeof(bool))]
		[CalledBy(Type = "Manager.Hotkey", Member = "get_IsHoldingShift", ReturnType = typeof(bool))]
		[CalledBy(Type = "Manager.Hotkey", Member = "get_IsHoldingAlt", ReturnType = typeof(bool))]
		[CalledBy(Type = "Manager.Hotkey", Member = "GetKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "Manager.Hotkey", Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionState), Member = "ReadCompositePartValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue", "TComparer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Boolean*), typeof(Int32&), "TComparer"}, ReturnType = "TValue")]
		[CalledBy(Type = "UnityEngine.Rendering.FreeCamera", Member = "UpdateInputs", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.ShaderDebugPrintInputProducer", Member = "Get", ReturnType = "UnityEngine.Rendering.ShaderDebugPrintInput")]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "OnItemSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SimpleFileBrowser.FileBrowserItem", typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "DirectionNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "ReadNextPreviousDirection", ReturnType = "UnityEngine.InputForUI.NavigationEvent+Direction")]
		[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "OnPointerPerformed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 20)]
		[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<System.Single>), Member = "get_value", ReturnType = typeof(Single&))]
		[Calls(Type = typeof(ButtonControl), Member = "IsValueConsideredPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
		 get { } //Length: 94
	}

	internal bool needsToCheckFramePress
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public float pressPointOrDefault
	{
		[CalledBy(Type = typeof(InputActionState), Member = "ProcessButtonState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TriggerState&), typeof(int), typeof(BindingState*)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionState), Member = "ProcessDefaultInteraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TriggerState&), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputActionState), Member = "ReadValueAsButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InputControl), Member = "IsValueConsideredPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(InputControlExtensions), Member = "IsPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(float)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 7)]
		 get { } //Length: 86
	}

	public bool wasPressedThisFrame
	{
		[CalledBy(Type = "Scenes.General.TextBox", Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Hotkey", Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "SimpleFileBrowser.FileBrowserDeleteConfirmationPanel", Member = "LateUpdate", ReturnType = typeof(void))]
		[CallerCount(Count = 18)]
		[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<System.Single>), Member = "get_value", ReturnType = typeof(Single&))]
		[Calls(Type = typeof(ButtonControl), Member = "IsValueConsideredPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<System.Single>), Member = "ReadValueFromPreviousFrame", ReturnType = typeof(float))]
		[Calls(Type = typeof(ButtonControl), Member = "BeginTestingForFramePresses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputDevice), Member = "get_wasUpdatedThisFrame", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 251
	}

	public bool wasReleasedThisFrame
	{
		[CalledBy(Type = "Manager.Hotkey+<ReadKey>d__82", Member = "MoveNext", ReturnType = typeof(void))]
		[CalledBy(Type = "Manager.Hotkey", Member = "Update", ReturnType = typeof(void))]
		[CallerCount(Count = 16)]
		[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<System.Single>), Member = "get_value", ReturnType = typeof(Single&))]
		[Calls(Type = typeof(ButtonControl), Member = "IsValueConsideredPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<System.Single>), Member = "ReadValueFromPreviousFrame", ReturnType = typeof(float))]
		[Calls(Type = typeof(ButtonControl), Member = "BeginTestingForFramePresses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InputDevice), Member = "get_wasUpdatedThisFrame", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 242
	}

	[CallerCount(Count = 33)]
	[Calls(Type = typeof(AxisControl), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	public ButtonControl() { }

	[CalledBy(Type = typeof(ButtonControl), Member = "get_wasPressedThisFrame", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ButtonControl), Member = "get_wasReleasedThisFrame", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void BeginTestingForFramePresses(bool currentlyPressed, bool pressedLastFrame) { }

	[CalledBy(Type = "Manager.Hotkey", Member = "get_IsHoldingCtrl", ReturnType = typeof(bool))]
	[CalledBy(Type = "Manager.Hotkey", Member = "get_IsHoldingShift", ReturnType = typeof(bool))]
	[CalledBy(Type = "Manager.Hotkey", Member = "get_IsHoldingAlt", ReturnType = typeof(bool))]
	[CalledBy(Type = "Manager.Hotkey", Member = "GetKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Key)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Manager.Hotkey", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "ReadCompositePartValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue", "TComparer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Boolean*), typeof(Int32&), "TComparer"}, ReturnType = "TValue")]
	[CalledBy(Type = "UnityEngine.Rendering.FreeCamera", Member = "UpdateInputs", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.ShaderDebugPrintInputProducer", Member = "Get", ReturnType = "UnityEngine.Rendering.ShaderDebugPrintInput")]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "OnItemSelected", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"SimpleFileBrowser.FileBrowserItem", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "DirectionNavigation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DiscreteTime)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "ReadNextPreviousDirection", ReturnType = "UnityEngine.InputForUI.NavigationEvent+Direction")]
	[CalledBy(Type = "UnityEngine.InputSystem.Plugins.InputForUI.InputSystemProvider", Member = "OnPointerPerformed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 20)]
	[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<System.Single>), Member = "get_value", ReturnType = typeof(Single&))]
	[Calls(Type = typeof(ButtonControl), Member = "IsValueConsideredPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	public bool get_isPressed() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal bool get_needsToCheckFramePress() { }

	[CalledBy(Type = typeof(InputActionState), Member = "ProcessButtonState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TriggerState&), typeof(int), typeof(BindingState*)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "ProcessDefaultInteraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TriggerState&), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionState), Member = "ReadValueAsButton", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputControl), Member = "IsValueConsideredPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputControlExtensions), Member = "IsPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl), typeof(float)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	public float get_pressPointOrDefault() { }

	[CalledBy(Type = "Scenes.General.TextBox", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Hotkey", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowser", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.FileBrowserDeleteConfirmationPanel", Member = "LateUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<System.Single>), Member = "get_value", ReturnType = typeof(Single&))]
	[Calls(Type = typeof(ButtonControl), Member = "IsValueConsideredPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<System.Single>), Member = "ReadValueFromPreviousFrame", ReturnType = typeof(float))]
	[Calls(Type = typeof(ButtonControl), Member = "BeginTestingForFramePresses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDevice), Member = "get_wasUpdatedThisFrame", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_wasPressedThisFrame() { }

	[CalledBy(Type = "Manager.Hotkey+<ReadKey>d__82", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.Hotkey", Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<System.Single>), Member = "get_value", ReturnType = typeof(Single&))]
	[Calls(Type = typeof(ButtonControl), Member = "IsValueConsideredPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<System.Single>), Member = "ReadValueFromPreviousFrame", ReturnType = typeof(float))]
	[Calls(Type = typeof(ButtonControl), Member = "BeginTestingForFramePresses", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDevice), Member = "get_wasUpdatedThisFrame", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_wasReleasedThisFrame() { }

	[CalledBy(Type = typeof(ButtonControl), Member = "get_isPressed", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ButtonControl), Member = "get_wasPressedThisFrame", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ButtonControl), Member = "get_wasReleasedThisFrame", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ButtonControl), Member = "UpdateWasPressed", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DpadControl), Member = "WriteValueIntoState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Void*)}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[ContainsUnimplementedInstructions]
	public bool IsValueConsideredPressed(float value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	private void set_needsToCheckFramePress(bool value) { }

	[CalledBy(Type = typeof(InputControl), Member = "MarkAsStaleRecursively", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "UpdateState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputUpdateType), typeof(Void*), typeof(uint), typeof(uint), typeof(double), typeof(InputEventPtr)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.InputSystem.InputControl`1<System.Single>), Member = "get_value", ReturnType = typeof(Single&))]
	[Calls(Type = typeof(ButtonControl), Member = "IsValueConsideredPressed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal void UpdateWasPressed() { }

}

