namespace UnityEngine.InputSystem.Utilities;

[Extension]
internal static class ExceptionHelpers
{

	[CalledBy(Type = typeof(InputBindingResolver), Member = "AddActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InputActionMap)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Extension]
	public static bool IsExceptionIndicatingBugInCode(Exception exception) { }

}

