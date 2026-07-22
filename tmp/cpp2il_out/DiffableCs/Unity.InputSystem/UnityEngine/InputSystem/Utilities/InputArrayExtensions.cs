namespace UnityEngine.InputSystem.Utilities;

[Extension]
internal static class InputArrayExtensions
{

	[CalledBy(Type = typeof(Keyboard), Member = "add_onTextInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<System.Char>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Keyboard), Member = "add_onIMECompositionChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Action`1<UnityEngine.InputSystem.LowLevel.IMECompositionString>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CallbackArray`1), Member = "AddCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CallbackArray`1), Member = "RemoveCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TDelegate"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(CallbackArray`1), Member = "UnlockForChanges", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Extension]
	public static bool Contains(InlinedArray<TValue> array, TValue value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	public static bool ContainsReference(InlinedArray<TValue> array, TValue value) { }

	[CalledBy(Type = typeof(TrackedDeviceRaycaster), Member = "OnDisable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EnhancedTouchSupport), Member = "OnDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputDeviceChange)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Touch), Member = "RemoveTouchscreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Touchscreen)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.LowLevel.InputEventListener+DisposableObserver", Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionTrace), Member = "SubscribeToAll", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionTrace), Member = "UnsubscribeFromAll", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionTrace), Member = "UnsubscribeFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputAction)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionTrace), Member = "UnsubscribeFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionTrace), Member = "RecordAction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputActionTrace), Member = "CloneActionStateBeforeBindingsChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Extension]
	public static int IndexOfReference(InlinedArray<TValue> array, TValue value) { }

}

