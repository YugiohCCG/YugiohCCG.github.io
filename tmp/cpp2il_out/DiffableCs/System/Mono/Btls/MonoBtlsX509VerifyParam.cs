namespace Mono.Btls;

internal class MonoBtlsX509VerifyParam : MonoBtlsObject
{
	public class BoringX509VerifyParamHandle : MonoBtlsHandle
	{

		[CallerCount(Count = 1)]
		[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public BoringX509VerifyParamHandle(IntPtr handle) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		protected virtual bool ReleaseHandle() { }

	}


	public bool CanModify
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MonoBtlsX509VerifyParam), Member = "get_Handle", ReturnType = typeof(BoringX509VerifyParamHandle))]
		[CallsUnknownMethods(Count = 3)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 154
	}

	internal BoringX509VerifyParamHandle Handle
	{
		[CalledBy(Type = typeof(MonoBtlsSslCtx), Member = "SetVerifyParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509VerifyParam)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoBtlsX509StoreCtx), Member = "SetVerifyParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509VerifyParam)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoBtlsX509VerifyParam), Member = "Copy", ReturnType = typeof(MonoBtlsX509VerifyParam))]
		[CalledBy(Type = typeof(MonoBtlsX509VerifyParam), Member = "get_CanModify", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(MonoBtlsX509VerifyParam), Member = "WantToModify", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoBtlsX509VerifyParam), Member = "SetHost", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoBtlsX509VerifyParam), Member = "SetTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(MonoBtlsObject), Member = "get_Handle", ReturnType = typeof(MonoBtlsHandle))]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 113
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal MonoBtlsX509VerifyParam(BoringX509VerifyParamHandle handle) { }

	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "GetVerifyParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoTlsSettings), typeof(string), typeof(bool)}, ReturnType = typeof(MonoBtlsX509VerifyParam))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsX509VerifyParam), Member = "get_Handle", ReturnType = typeof(BoringX509VerifyParamHandle))]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public MonoBtlsX509VerifyParam Copy() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsX509VerifyParam), Member = "get_Handle", ReturnType = typeof(BoringX509VerifyParamHandle))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public bool get_CanModify() { }

	[CalledBy(Type = typeof(MonoBtlsSslCtx), Member = "SetVerifyParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509VerifyParam)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509StoreCtx), Member = "SetVerifyParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509VerifyParam)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509VerifyParam), Member = "Copy", ReturnType = typeof(MonoBtlsX509VerifyParam))]
	[CalledBy(Type = typeof(MonoBtlsX509VerifyParam), Member = "get_CanModify", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MonoBtlsX509VerifyParam), Member = "WantToModify", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509VerifyParam), Member = "SetHost", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509VerifyParam), Member = "SetTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "get_Handle", ReturnType = typeof(MonoBtlsHandle))]
	[CallsUnknownMethods(Count = 1)]
	internal BoringX509VerifyParamHandle get_Handle() { }

	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "GetVerifyParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoTlsSettings), typeof(string), typeof(bool)}, ReturnType = typeof(MonoBtlsX509VerifyParam))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsX509VerifyParam), Member = "Lookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(MonoBtlsX509VerifyParam))]
	public static MonoBtlsX509VerifyParam GetSslClient() { }

	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "GetVerifyParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoTlsSettings), typeof(string), typeof(bool)}, ReturnType = typeof(MonoBtlsX509VerifyParam))]
	[CallerCount(Count = 1)]
	[ContainsInvalidInstructions]
	public static MonoBtlsX509VerifyParam GetSslServer() { }

	[CalledBy(Type = typeof(MonoBtlsX509VerifyParam), Member = "GetSslClient", ReturnType = typeof(MonoBtlsX509VerifyParam))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Marshal), Member = "StringToHGlobalAnsi", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Marshal), Member = "FreeHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public static MonoBtlsX509VerifyParam Lookup(string name, bool fail = false) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int mono_btls_x509_verify_param_can_modify(IntPtr param) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr mono_btls_x509_verify_param_copy(IntPtr handle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void mono_btls_x509_verify_param_free(IntPtr handle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr mono_btls_x509_verify_param_lookup(IntPtr name) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int mono_btls_x509_verify_param_set_host(IntPtr handle, IntPtr name, int namelen) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int mono_btls_x509_verify_param_set_time(IntPtr handle, long time) { }

	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "GetVerifyParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoTlsSettings), typeof(string), typeof(bool)}, ReturnType = typeof(MonoBtlsX509VerifyParam))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsX509VerifyParam), Member = "WantToModify", ReturnType = typeof(void))]
	[Calls(Type = typeof(Marshal), Member = "StringToHGlobalAnsi", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(MonoBtlsX509VerifyParam), Member = "get_Handle", ReturnType = typeof(BoringX509VerifyParamHandle))]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Marshal), Member = "FreeHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public void SetHost(string name) { }

	[CalledBy(Type = typeof(MonoBtlsProvider), Member = "GetVerifyParam", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoTlsSettings), typeof(string), typeof(bool)}, ReturnType = typeof(MonoBtlsX509VerifyParam))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsX509VerifyParam), Member = "WantToModify", ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(DateTimeKind)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DateTime), Member = "Subtract", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
	[Calls(Type = typeof(MonoBtlsX509VerifyParam), Member = "get_Handle", ReturnType = typeof(BoringX509VerifyParamHandle))]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetTime(DateTime time) { }

	[CalledBy(Type = typeof(MonoBtlsX509VerifyParam), Member = "SetHost", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509VerifyParam), Member = "SetTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MonoBtlsX509VerifyParam), Member = "get_Handle", ReturnType = typeof(BoringX509VerifyParamHandle))]
	[Calls(Type = typeof(MonoBtlsException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	private void WantToModify() { }

}

