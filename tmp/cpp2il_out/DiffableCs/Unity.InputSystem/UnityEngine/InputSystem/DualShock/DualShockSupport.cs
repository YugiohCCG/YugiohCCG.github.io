namespace UnityEngine.InputSystem.DualShock;

internal static class DualShockSupport
{

	[CalledBy(Type = typeof(InputSystem), Member = "InitializeInPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputRuntime), typeof(InputSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystem), Member = "PerformDefaultPluginInitialization", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputSystem), Member = "RegisterLayout", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(System.Nullable`1<UnityEngine.InputSystem.Layouts.InputDeviceMatcher>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDeviceMatcher), Member = "WithInterface", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputDeviceMatcher))]
	[Calls(Type = typeof(InputDeviceMatcher), Member = "WithCapability", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TValue"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "TValue"}, ReturnType = typeof(InputDeviceMatcher))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputSystem), Member = "RegisterLayoutMatcher", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TDevice"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputDeviceMatcher)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InputDeviceMatcher), Member = "WithManufacturerContains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(InputDeviceMatcher))]
	[Calls(Type = typeof(InputDeviceMatcher), Member = "WithProduct", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(InputDeviceMatcher))]
	public static void Initialize() { }

}

