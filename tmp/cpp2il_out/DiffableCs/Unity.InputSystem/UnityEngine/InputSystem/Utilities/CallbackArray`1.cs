namespace UnityEngine.InputSystem.Utilities;

[DefaultMember("Item")]
internal struct CallbackArray
{
	private bool m_CannotMutateCallbacksArray; //Field offset: 0x0
	private InlinedArray<TDelegate> m_Callbacks; //Field offset: 0x0
	private InlinedArray<TDelegate> m_CallbacksToAdd; //Field offset: 0x0
	private InlinedArray<TDelegate> m_CallbacksToRemove; //Field offset: 0x0

	public TDelegate Item
	{
		[CalledBy(Type = typeof(InputDevice), Member = "ExecuteCommand", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TCommand"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCommand&"}, ReturnType = typeof(long))]
		[CalledBy(Type = typeof(InputManager), Member = "TryFindMatchingControlLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceDescription&), typeof(int)}, ReturnType = typeof(InternedString))]
		[CalledBy(Type = typeof(InputUser), Member = "Notify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputUserChange), typeof(InputDevice)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputUser), Member = "OnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DelegateHelpers), Member = "InvokeCallbacksSafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackArray`1<Action>&), typeof(ProfilerMarker), typeof(string), typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DelegateHelpers), Member = "InvokeCallbacksSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.CallbackArray`1<Action`1<TValue>>&", "TValue", typeof(string), typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DelegateHelpers), Member = "InvokeCallbacksSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue1", "TValue2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.CallbackArray`1<Action`2<TValue1, TValue2>>&", "TValue1", "TValue2", typeof(ProfilerMarker), typeof(string), typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DelegateHelpers), Member = "InvokeCallbacksSafe_AnyCallbackReturnsTrue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue1", "TValue2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.CallbackArray`1<Func`3<TValue1, TValue2, Boolean>>&", "TValue1", "TValue2", typeof(string), typeof(object)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 68
	}

	public int length
	{
		[CallerCount(Count = 28)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 35)]
	[Calls(Type = typeof(InputArrayExtensions), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.InlinedArray`1<TValue>", "TValue"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Object>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Object>), Member = "RemoveAtByMovingTailWithCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Object>), Member = "AppendWithCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public void AddCallback(TDelegate dlg) { }

	[CalledBy(Type = typeof(InputActionState), Member = "ResetGlobals", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InlinedArray`1), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public void Clear() { }

	[CalledBy(Type = typeof(InputDevice), Member = "ExecuteCommand", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TCommand"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCommand&"}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(InputManager), Member = "TryFindMatchingControlLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceDescription&), typeof(int)}, ReturnType = typeof(InternedString))]
	[CalledBy(Type = typeof(InputUser), Member = "Notify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputUserChange), typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputUser), Member = "OnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DelegateHelpers), Member = "InvokeCallbacksSafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackArray`1<Action>&), typeof(ProfilerMarker), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DelegateHelpers), Member = "InvokeCallbacksSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.CallbackArray`1<Action`1<TValue>>&", "TValue", typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DelegateHelpers), Member = "InvokeCallbacksSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue1", "TValue2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.CallbackArray`1<Action`2<TValue1, TValue2>>&", "TValue1", "TValue2", typeof(ProfilerMarker), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DelegateHelpers), Member = "InvokeCallbacksSafe_AnyCallbackReturnsTrue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue1", "TValue2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.CallbackArray`1<Func`3<TValue1, TValue2, Boolean>>&", "TValue1", "TValue2", typeof(string), typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public TDelegate get_Item(int index) { }

	[CallerCount(Count = 28)]
	[DeduplicatedMethod]
	public int get_length() { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public void LockForChanges() { }

	[CallerCount(Count = 35)]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Object>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Object>), Member = "RemoveAtWithCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputArrayExtensions), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.InlinedArray`1<TValue>", "TValue"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Object>), Member = "RemoveAtByMovingTailWithCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Object>), Member = "AppendWithCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public void RemoveCallback(TDelegate dlg) { }

	[CalledBy(Type = typeof(DelegateHelpers), Member = "InvokeCallbacksSafe_AnyCallbackReturnsTrue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue1", "TValue2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.CallbackArray`1<Func`3<TValue1, TValue2, Boolean>>&", "TValue1", "TValue2", typeof(string), typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(InputDevice), Member = "ExecuteCommand", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TCommand"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCommand&"}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(InputManager), Member = "TryFindMatchingControlLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceDescription&), typeof(int)}, ReturnType = typeof(InternedString))]
	[CalledBy(Type = typeof(InputUser), Member = "Notify", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(InputUserChange), typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputUser), Member = "OnEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputEventPtr), typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DelegateHelpers), Member = "InvokeCallbacksSafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CallbackArray`1<Action>&), typeof(ProfilerMarker), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DelegateHelpers), Member = "InvokeCallbacksSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.CallbackArray`1<Action`1<TValue>>&", "TValue", typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DelegateHelpers), Member = "InvokeCallbacksSafe", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue1", "TValue2"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.CallbackArray`1<Action`2<TValue1, TValue2>>&", "TValue1", "TValue2", typeof(ProfilerMarker), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(InlinedArray`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(InlinedArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Object>), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Object>), Member = "RemoveAtWithCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputArrayExtensions), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.Utilities.InlinedArray`1<TValue>", "TValue"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Object>), Member = "RemoveAtByMovingTailWithCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.InputSystem.Utilities.InlinedArray`1<System.Object>), Member = "AppendWithCapacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 18)]
	[DeduplicatedMethod]
	public void UnlockForChanges() { }

}

