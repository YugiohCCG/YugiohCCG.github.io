namespace Mono.Unity;

internal static class Debug
{

	[CalledBy(Type = typeof(UnityTlsContext), Member = "Read", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(System.ValueTuple`2<System.Int32, System.Boolean>))]
	[CalledBy(Type = typeof(UnityTlsContext), Member = "Write", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(System.ValueTuple`2<System.Int32, System.Boolean>))]
	[CalledBy(Type = typeof(UnityTlsContext), Member = "ProcessHandshake", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TlsException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AlertDescription), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public static void CheckAndThrow(unitytls_errorstate errorState, string context, AlertDescription defaultAlert = 80) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(UnityTlsConversions), Member = "VerifyResultToAlertDescription", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(unitytls_x509verify_result), typeof(AlertDescription)}, ReturnType = typeof(AlertDescription))]
	[Calls(Type = typeof(TlsException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AlertDescription), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 11)]
	public static void CheckAndThrow(unitytls_errorstate errorState, unitytls_x509verify_result verifyResult, string context, AlertDescription defaultAlert = 80) { }

}

