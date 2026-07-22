namespace UnityEngine.InputSystem.HID;

public static class HIDSupport
{
	internal struct HIDPageUsage
	{
		public UsagePage page; //Field offset: 0x0
		public int usage; //Field offset: 0x4

		[CallerCount(Count = 104)]
		[DeduplicatedMethod]
		public HIDPageUsage(UsagePage page, int usage) { }

		[CallerCount(Count = 0)]
		public HIDPageUsage(GenericDesktop usage) { }

	}

	private static HIDPageUsage[] s_SupportedHIDUsages; //Field offset: 0x0

	public static ReadOnlyArray<HIDPageUsage> supportedHIDUsages
	{
		[CalledBy(Type = typeof(HID), Member = "OnFindLayoutForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceDescription&), typeof(string), typeof(InputDeviceExecuteCommandDelegate)}, ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ReadOnlyArray`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>")]
		 get { } //Length: 100
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReadOnlyArray`1), Member = "ToArray", ReturnType = "TValue[]")]
		[Calls(Type = typeof(InputManager), Member = "AddAvailableDevicesThatAreNowRecognized", ReturnType = typeof(void))]
		[Calls(Type = typeof(InputSystem), Member = "get_devices", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>))]
		[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
		[Calls(Type = typeof(HID), Member = "get_hidDescriptor", ReturnType = typeof(HIDDeviceDescriptor))]
		[Calls(Type = typeof(Enumerable), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HIDPageUsage)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.InputSystem.HID.HIDSupport+HIDPageUsage>), typeof(HIDPageUsage)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(InputControl), Member = "get_layout", ReturnType = typeof(string))]
		[Calls(Type = typeof(InputSystem), Member = "RemoveLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 621
	}

	[CalledBy(Type = typeof(HID), Member = "OnFindLayoutForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceDescription&), typeof(string), typeof(InputDeviceExecuteCommandDelegate)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TValue[]"}, ReturnType = "UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<TValue>")]
	public static ReadOnlyArray<HIDPageUsage> get_supportedHIDUsages() { }

	[CalledBy(Type = typeof(InputSystem), Member = "InitializeInPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputRuntime), typeof(InputSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystem), Member = "PerformDefaultPluginInitialization", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputSystem), Member = "RegisterLayout", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Nullable`1<UnityEngine.InputSystem.Layouts.InputDeviceMatcher>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDeviceFindControlLayoutDelegate), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystem), Member = "add_onFindLayoutForDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceFindControlLayoutDelegate)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal static void Initialize() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "ToArray", ReturnType = "TValue[]")]
	[Calls(Type = typeof(InputManager), Member = "AddAvailableDevicesThatAreNowRecognized", ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystem), Member = "get_devices", ReturnType = typeof(UnityEngine.InputSystem.Utilities.ReadOnlyArray`1<UnityEngine.InputSystem.InputDevice>))]
	[Calls(Type = typeof(ReadOnlyArray`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "TValue")]
	[Calls(Type = typeof(HID), Member = "get_hidDescriptor", ReturnType = typeof(HIDDeviceDescriptor))]
	[Calls(Type = typeof(Enumerable), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HIDPageUsage)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.InputSystem.HID.HIDSupport+HIDPageUsage>), typeof(HIDPageUsage)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InputControl), Member = "get_layout", ReturnType = typeof(string))]
	[Calls(Type = typeof(InputSystem), Member = "RemoveLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static void set_supportedHIDUsages(ReadOnlyArray<HIDPageUsage> value) { }

}

