namespace System.Reflection;

[ClassInterface(ClassInterfaceType::None (0))]
[ComDefaultInterface(typeof(_AssemblyName))]
[ComVisible(True)]
public sealed class AssemblyName : ICloneable, ISerializable, IDeserializationCallback, _AssemblyName
{
	private string name; //Field offset: 0x10
	private string codebase; //Field offset: 0x18
	private int major; //Field offset: 0x20
	private int minor; //Field offset: 0x24
	private int build; //Field offset: 0x28
	private int revision; //Field offset: 0x2C
	private CultureInfo cultureinfo; //Field offset: 0x30
	private AssemblyNameFlags flags; //Field offset: 0x38
	private AssemblyHashAlgorithm hashalg; //Field offset: 0x3C
	private StrongNameKeyPair keypair; //Field offset: 0x40
	private Byte[] publicKey; //Field offset: 0x48
	private Byte[] keyToken; //Field offset: 0x50
	private AssemblyVersionCompatibility versioncompat; //Field offset: 0x58
	private Version version; //Field offset: 0x60
	private ProcessorArchitecture processor_architecture; //Field offset: 0x68
	private AssemblyContentType contentType; //Field offset: 0x6C

	public CultureInfo CultureInfo
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public AssemblyNameFlags Flags
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public string FullName
	{
		[CalledBy(Type = typeof(AssemblyName), Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
		[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(Version), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Version), typeof(Version)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(AssemblyName), Member = "get_IsPublicKeyValid", ReturnType = typeof(bool))]
		[Calls(Type = typeof(AssemblyName), Member = "ComputePublicKeyToken", ReturnType = typeof(Byte[]))]
		[Calls(Type = typeof(byte), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(SecurityException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 6)]
		 get { } //Length: 984
	}

	private bool IsPublicKeyValid
	{
		[CalledBy(Type = typeof(AssemblyName), Member = "get_FullName", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(AssemblyName), Member = "GetPublicKeyToken", ReturnType = typeof(Byte[]))]
		[CalledBy(Type = typeof(AssemblyName), Member = "InternalGetPublicKeyToken", ReturnType = typeof(Byte[]))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 136
	}

	public string Name
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public Version Version
	{
		[CallerCount(Count = 84)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Version), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Version), typeof(Version)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 112
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public AssemblyName() { }

	[CalledBy(Type = typeof(TypeSpec), Member = "Resolve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<System.Reflection.AssemblyName, System.Reflection.Assembly>), typeof(System.Func`4<System.Reflection.Assembly, System.String, System.Boolean, System.Type>), typeof(bool), typeof(bool), typeof(StackCrawlMark&)}, ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(SerializationInfo), Member = "IsAssemblyNameAssignmentSafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ObjectReader), Member = "FastBindToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(ResourceManager), Member = "CompareNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(AssemblyName)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ResourceReader), Member = "_ReadResources", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(RuntimeMarshal), Member = "MarshalString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(SafeStringMarshal))]
	[Calls(Type = typeof(SafeStringMarshal), Member = "get_Value", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(AssemblyName), Member = "FillName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoAssemblyName*), typeof(string), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeMarshal), Member = "FreeAssemblyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoAssemblyName&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeStringMarshal), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(FileLoadException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	public AssemblyName(string assemblyName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationInfo), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CultureInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 23)]
	internal AssemblyName(SerializationInfo si, StreamingContext sc) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public override object Clone() { }

	[CalledBy(Type = typeof(AssemblyName), Member = "get_FullName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(AssemblyName), Member = "GetPublicKeyToken", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(AssemblyName), Member = "InternalGetPublicKeyToken", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private Byte[] ComputePublicKeyToken() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AssemblyName), Member = "FillName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoAssemblyName*), typeof(string), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	internal static AssemblyName Create(Assembly assembly, bool fillCodebase) { }

	[CalledBy(Type = typeof(Assembly), Member = "GetReferencedAssemblies", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly)}, ReturnType = typeof(AssemblyName[]))]
	[CalledBy(Type = typeof(AssemblyName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AssemblyName), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(bool)}, ReturnType = typeof(AssemblyName))]
	[CalledBy(Type = typeof(RuntimeAssembly), Member = "GetName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(AssemblyName))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(RuntimeMarshal), Member = "PtrToUtf8String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Version), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "CreateCulture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(RuntimeMarshal), Member = "DecodeBlobArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(RuntimeMarshal), Member = "AsciHexDigitValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 8)]
	internal void FillName(MonoAssemblyName* native, string codeBase, bool addVersion, bool addPublickey, bool defaultToken, bool assemblyRef) { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public CultureInfo get_CultureInfo() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public AssemblyNameFlags get_Flags() { }

	[CalledBy(Type = typeof(AssemblyName), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(Version), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Version), typeof(Version)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(AssemblyName), Member = "get_IsPublicKeyValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AssemblyName), Member = "ComputePublicKeyToken", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(byte), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SecurityException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	public string get_FullName() { }

	[CalledBy(Type = typeof(AssemblyName), Member = "get_FullName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(AssemblyName), Member = "GetPublicKeyToken", ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(AssemblyName), Member = "InternalGetPublicKeyToken", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private bool get_IsPublicKeyValid() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public string get_Name() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static void get_public_token(Byte* token, Byte* pubkey, int len) { }

	[CallerCount(Count = 84)]
	[DeduplicatedMethod]
	public Version get_Version() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static MonoAssemblyName* GetNativeName(IntPtr assembly_ptr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[CalledBy(Type = typeof(SerializationInfo), Member = "IsAssemblyNameAssignmentSafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ResourceManager), Member = "CompareNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(AssemblyName)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(AssemblyName), Member = "get_IsPublicKeyValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AssemblyName), Member = "ComputePublicKeyToken", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(SecurityException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public Byte[] GetPublicKeyToken() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AssemblyName), Member = "get_IsPublicKeyValid", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AssemblyName), Member = "ComputePublicKeyToken", ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(SecurityException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private Byte[] InternalGetPublicKeyToken() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Version), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Version), typeof(Version)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public override void OnDeserialization(object sender) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static bool ParseAssemblyName(IntPtr name, out MonoAssemblyName aname, out bool is_version_definited, out bool is_token_defined) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Version), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Version), typeof(Version)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public void set_Version(Version value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AssemblyName), Member = "get_FullName", ReturnType = typeof(string))]
	[Calls(Type = typeof(object), Member = "ToString", ReturnType = typeof(string))]
	public virtual string ToString() { }

}

