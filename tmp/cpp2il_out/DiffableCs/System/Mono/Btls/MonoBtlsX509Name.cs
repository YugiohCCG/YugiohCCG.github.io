namespace Mono.Btls;

internal class MonoBtlsX509Name : MonoBtlsObject
{
	public class BoringX509NameHandle : MonoBtlsHandle
	{
		private bool dontFree; //Field offset: 0x20

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
		[DeduplicatedMethod]
		internal BoringX509NameHandle(IntPtr handle, bool ownsHandle) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		protected virtual bool ReleaseHandle() { }

	}


	internal BoringX509NameHandle Handle
	{
		[CalledBy(Type = typeof(MonoBtlsUtils), Member = "AppendEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(MonoBtlsX509Name), typeof(int), typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(MonoBtlsX509Name), Member = "GetHash", ReturnType = typeof(long))]
		[CalledBy(Type = typeof(MonoBtlsX509Name), Member = "GetEntryCount", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(MonoBtlsX509Name), Member = "GetEntryType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(MonoBtlsX509NameEntryType))]
		[CalledBy(Type = typeof(MonoBtlsX509Name), Member = "GetEntryOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(MonoBtlsX509Name), Member = "GetEntryOidData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
		[CalledBy(Type = typeof(MonoBtlsX509Name), Member = "GetEntryValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&)}, ReturnType = typeof(string))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(MonoBtlsObject), Member = "get_Handle", ReturnType = typeof(MonoBtlsHandle))]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 113
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	internal MonoBtlsX509Name(BoringX509NameHandle handle) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MonoBtlsException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public static MonoBtlsX509Name CreateFromData(Byte[] data, bool use_canon_enc) { }

	[CalledBy(Type = typeof(MonoBtlsUtils), Member = "AppendEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(MonoBtlsX509Name), typeof(int), typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MonoBtlsX509Name), Member = "GetHash", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(MonoBtlsX509Name), Member = "GetEntryCount", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(MonoBtlsX509Name), Member = "GetEntryType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(MonoBtlsX509NameEntryType))]
	[CalledBy(Type = typeof(MonoBtlsX509Name), Member = "GetEntryOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(MonoBtlsX509Name), Member = "GetEntryOidData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(MonoBtlsX509Name), Member = "GetEntryValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(MonoBtlsObject), Member = "get_Handle", ReturnType = typeof(MonoBtlsHandle))]
	[CallsUnknownMethods(Count = 1)]
	internal BoringX509NameHandle get_Handle() { }

	[CalledBy(Type = typeof(MonoBtlsUtils), Member = "AppendEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(MonoBtlsX509Name), typeof(int), typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MonoBtlsUtils), Member = "FormatName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Name), typeof(bool), typeof(string), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(MonoBtlsX509Name), Member = "GetEntryType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(MonoBtlsX509NameEntryType))]
	[CalledBy(Type = typeof(MonoBtlsX509Name), Member = "GetEntryOid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(MonoBtlsX509Name), Member = "GetEntryValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(MonoBtlsX509Name), Member = "get_Handle", ReturnType = typeof(BoringX509NameHandle))]
	[CallsUnknownMethods(Count = 3)]
	public int GetEntryCount() { }

	[CalledBy(Type = typeof(MonoBtlsUtils), Member = "AppendEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(MonoBtlsX509Name), typeof(int), typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsX509Name), Member = "GetEntryCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(MonoBtlsX509Name), Member = "get_Handle", ReturnType = typeof(BoringX509NameHandle))]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Marshal), Member = "PtrToStringAnsi", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Marshal), Member = "FreeHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	[ContainsUnimplementedInstructions]
	public string GetEntryOid(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsX509Name), Member = "get_Handle", ReturnType = typeof(BoringX509NameHandle))]
	[Calls(Type = typeof(MonoBtlsObject), Member = "CheckError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Marshal), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public Byte[] GetEntryOidData(int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoBtlsX509Name), Member = "GetEntryCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(MonoBtlsX509Name), Member = "get_Handle", ReturnType = typeof(BoringX509NameHandle))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public MonoBtlsX509NameEntryType GetEntryType(int index) { }

	[CalledBy(Type = typeof(MonoBtlsUtils), Member = "AppendEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(MonoBtlsX509Name), typeof(int), typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoBtlsX509Name), Member = "GetEntryCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(MonoBtlsX509Name), Member = "get_Handle", ReturnType = typeof(BoringX509NameHandle))]
	[Calls(Type = typeof(UTF8Encoding), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoding), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(MonoBtlsObject), Member = "FreeDataPtr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public string GetEntryValue(int index, out int tag) { }

	[CalledBy(Type = typeof(MonoBtlsX509), Member = "GetSubjectNameHash", ReturnType = typeof(long))]
	[CalledBy(Type = typeof(MonoBtlsX509LookupMonoCollection), Member = "OnGetBySubject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoBtlsX509Name)}, ReturnType = typeof(MonoBtlsX509))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MonoBtlsX509Name), Member = "get_Handle", ReturnType = typeof(BoringX509NameHandle))]
	[CallsUnknownMethods(Count = 3)]
	public long GetHash() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void mono_btls_x509_name_free(IntPtr handle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr mono_btls_x509_name_from_data(Void* data, int len, int use_canon_enc) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int mono_btls_x509_name_get_entry_count(IntPtr handle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int mono_btls_x509_name_get_entry_oid(IntPtr name, int index, IntPtr buffer, int size) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int mono_btls_x509_name_get_entry_oid_data(IntPtr name, int index, out IntPtr data) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static MonoBtlsX509NameEntryType mono_btls_x509_name_get_entry_type(IntPtr name, int index) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int mono_btls_x509_name_get_entry_value(IntPtr name, int index, out int tag, out IntPtr str) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static long mono_btls_x509_name_hash(IntPtr handle) { }

}

