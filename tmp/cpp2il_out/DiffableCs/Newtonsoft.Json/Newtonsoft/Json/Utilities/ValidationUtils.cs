namespace Newtonsoft.Json.Utilities;

internal static class ValidationUtils
{

	[CallerCount(Count = 140)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[NullableContext(1)]
	public static void ArgumentNotNull(object value, string parameterName) { }

}

