//Type is in global namespace

internal static class UISupport
{

	[CalledBy(Type = typeof(InputSystem), Member = "InitializeInPlayer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IInputRuntime), typeof(InputSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputSystem), Member = "PerformDefaultPluginInitialization", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InputSystem), Member = "RegisterLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(System.Nullable`1<UnityEngine.InputSystem.Layouts.InputDeviceMatcher>)}, ReturnType = typeof(void))]
	public static void Initialize() { }

}

