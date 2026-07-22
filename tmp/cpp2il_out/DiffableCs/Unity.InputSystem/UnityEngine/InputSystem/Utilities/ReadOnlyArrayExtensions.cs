namespace UnityEngine.InputSystem.Utilities;

[Extension]
public static class ReadOnlyArrayExtensions
{

	[CalledBy(Type = typeof(InputSystem), Member = "GetDevice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevice"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, ReturnType = "TDevice")]
	[CalledBy(Type = "UnityEngine.InputSystem.InputRemoting+ChangeUsageMsg", Member = "Process", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputRemoting), typeof(Message)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "AddDeviceUsage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InternedString)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputManager), Member = "RemoveDeviceUsage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InternedString)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(InternedString), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternedString)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[Extension]
	public static bool Contains(ReadOnlyArray<TValue> array, TValue value) { }

	[CalledBy(Type = typeof(InputAction), Member = "ActiveControlIsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControl)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PlayerInput), Member = "FindFirstPairedToDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(PlayerInput))]
	[CalledBy(Type = typeof(PlayerInput), Member = "SwitchControlSchemeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputControlScheme&), typeof(InputDevice[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputUser), Member = "UnpairDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputUser), Member = "UnpairDevices", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputUser), Member = "PerformPairingWithDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputUser), typeof(InputUserPairingOptions)}, ReturnType = typeof(InputUser))]
	[CalledBy(Type = typeof(InputUser), Member = "UpdateControlSchemeMatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputUser), Member = "OnDeviceChange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDevice), typeof(InputDeviceChange)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Extension]
	public static bool ContainsReference(ReadOnlyArray<TValue> array, TValue value) { }

	[CalledBy(Type = typeof(DeviceArray), Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Nullable`1<UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>>)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	[Extension]
	internal static bool HaveEqualReferences(ReadOnlyArray<TValue> array1, IReadOnlyList<TValue> array2, int count = 2147483647) { }

	[CalledBy(Type = typeof(ExtendedPointerEventData), Member = "GetTouchPointerId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TouchControl)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Record), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Record)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Extension]
	public static int IndexOfReference(ReadOnlyArray<TValue> array, TValue value) { }

}

