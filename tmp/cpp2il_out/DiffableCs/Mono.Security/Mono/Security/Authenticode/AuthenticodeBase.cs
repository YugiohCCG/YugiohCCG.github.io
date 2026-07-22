namespace Mono.Security.Authenticode;

public class AuthenticodeBase
{
	private Byte[] fileblock; //Field offset: 0x10
	private Stream fs; //Field offset: 0x18
	private int blockNo; //Field offset: 0x20
	private int blockLength; //Field offset: 0x24
	private int peOffset; //Field offset: 0x28
	private int dirSecurityOffset; //Field offset: 0x2C
	private int dirSecuritySize; //Field offset: 0x30
	private int coffSymbolTableOffset; //Field offset: 0x34
	private bool pe64; //Field offset: 0x38

	internal int PEOffset
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(AuthenticodeBase), Member = "ReadFirstBlock", ReturnType = typeof(void))]
		internal get { } //Length: 40
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public AuthenticodeBase() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void Close() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuthenticodeBase), Member = "ReadFirstBlock", ReturnType = typeof(void))]
	internal int get_PEOffset() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuthenticodeBase), Member = "ReadFirstBlock", ReturnType = typeof(void))]
	[Calls(Type = typeof(HashAlgorithm), Member = "TransformBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int), typeof(Byte[]), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(HashAlgorithm), Member = "TransformFinalBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(Byte[]))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal Byte[] GetHash(HashAlgorithm hash) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuthenticodeBase), Member = "ReadFirstBlock", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal Byte[] GetSecurityEntry() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(FileMode), typeof(FileAccess), typeof(FileShare)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal void Open(string filename) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal void Open(Byte[] rawdata) { }

	[CalledBy(Type = typeof(AuthenticodeBase), Member = "ReadFirstBlock", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BitConverterLE), Member = "ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(ushort))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	internal int ProcessFirstBlock() { }

	[CalledBy(Type = typeof(AuthenticodeBase), Member = "get_PEOffset", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(AuthenticodeBase), Member = "GetSecurityEntry", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(AuthenticodeBase), Member = "GetHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HashAlgorithm)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(AuthenticodeDeformatter), Member = "CheckSignature", ReturnType = typeof(bool))]
	[CallerCount(Count = 57)]
	[Calls(Type = typeof(AuthenticodeBase), Member = "ProcessFirstBlock", ReturnType = typeof(int))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	internal void ReadFirstBlock() { }

}

