namespace Mono.Btls;

internal class MonoBtlsBio : MonoBtlsObject
{
	private class BoringBioHandle : MonoBtlsHandle
	{

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SafeHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		public BoringBioHandle(IntPtr handle) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		protected virtual bool ReleaseHandle() { }

	}


	protected private BoringBioHandle Handle
	{
		[CalledBy(Type = typeof(MonoBtlsBioMemory), Member = "GetData", ReturnType = typeof(Byte[]))]
		[CalledBy(Type = typeof(MonoBtlsBioMono), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMonoBtlsBioMono)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoBtlsSsl), Member = "SetBio", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsBio)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(MonoBtlsX509), Member = "GetRawData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Format)}, ReturnType = typeof(Byte[]))]
		[CalledBy(Type = "System.Dynamic.ExpandoObject+ValueCollection", Member = "get_Count", ReturnType = typeof(int))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 117
	}

	[CallerCount(Count = 98)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal MonoBtlsBio(BoringBioHandle handle) { }

	[CalledBy(Type = typeof(MonoBtlsBioMemory), Member = "GetData", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(MonoBtlsBioMono), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IMonoBtlsBioMono)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsSsl), Member = "SetBio", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsBio)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MonoBtlsX509), Member = "GetRawData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Format)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = "System.Dynamic.ExpandoObject+ValueCollection", Member = "get_Count", ReturnType = typeof(int))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckThrow", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected private BoringBioHandle get_Handle() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void mono_btls_bio_free(IntPtr handle) { }

}

