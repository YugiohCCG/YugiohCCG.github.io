namespace UnityEngine.Bindings;

[VisibleToOtherModules]
internal static class ThrowHelper
{

	[CallerCount(Count = 462)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DoesNotReturn]
	public static void ThrowArgumentNullException(object obj, string parameterName) { }

	[CallerCount(Count = 1685)]
	[Calls(Type = typeof(NullReferenceException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DoesNotReturn]
	public static void ThrowNullReferenceException(object obj) { }

}

