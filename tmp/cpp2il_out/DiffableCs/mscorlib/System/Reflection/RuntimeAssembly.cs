namespace System.Reflection;

[ClassInterface(ClassInterfaceType::None (0))]
[ComDefaultInterface(typeof(_Assembly))]
[ComVisible(True)]
internal class RuntimeAssembly : Assembly
{
	internal IntPtr _mono_assembly; //Field offset: 0x10
	private object _evidence; //Field offset: 0x18
	internal ResolveEventHolder resolve_event_holder; //Field offset: 0x20
	private object _minimum; //Field offset: 0x28
	private object _optional; //Field offset: 0x30
	private object _refuse; //Field offset: 0x38
	private object _granted; //Field offset: 0x40
	private object _denied; //Field offset: 0x48
	internal bool fromByteArray; //Field offset: 0x50
	internal string assemblyName; //Field offset: 0x58

	public virtual string CodeBase
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 7
	}

	public virtual string FullName
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public virtual string Location
	{
		[CallerCount(Count = 0)]
		[ContainsInvalidInstructions]
		 get { } //Length: 28
	}

	internal virtual IntPtr MonoAssembly
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected RuntimeAssembly() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object o) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private static string get_code_base(Assembly a, bool escaped) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string get_CodeBase() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal static string get_fullname(Assembly a) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string get_FullName() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private string get_location() { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	public virtual string get_Location() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	internal virtual IntPtr get_MonoAssembly() { }

	[CalledBy(Type = typeof(StackTrace), Member = "GetAotId", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	internal static Byte[] GetAotId() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	internal static bool GetAotIdInternal(Byte[] aotid) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal static string GetCodeBase(Assembly a, bool escaped) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(bool)}, ReturnType = typeof(Object[]))]
	public virtual Object[] GetCustomAttributes(bool inherit) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(Object[]))]
	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	[CallerCount(Count = 19)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CalledBy(Type = typeof(MSCompatUnicodeTable), Member = "GetResource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal IntPtr GetManifestResourceInternal(string name, out int size, out Module module) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	public virtual Module GetModule(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public virtual Module[] GetModules(bool getResourceModules) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal virtual Module[] GetModulesInternal() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AssemblyName), Member = "FillName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoAssemblyName*), typeof(string), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public virtual AssemblyName GetName(bool copiedName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnitySerializationHolder), Member = "GetUnitySerializationInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(int), typeof(string), typeof(RuntimeAssembly)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Assembly), Member = "GetReferencedAssemblies", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly)}, ReturnType = typeof(AssemblyName[]))]
	public virtual AssemblyName[] GetReferencedAssemblies() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public virtual Type GetType(string name, bool throwOnError, bool ignoreCase) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(bool))]
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	[CalledBy(Type = typeof(ObjectReader), Member = "ResolveSimpleAssemblyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssemblyName)}, ReturnType = typeof(Assembly))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NullReferenceException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	internal static RuntimeAssembly LoadWithPartialNameInternal(AssemblyName an, Evidence securityEvidence, ref StackCrawlMark stackMark) { }

	[CalledBy(Type = typeof(ObjectReader), Member = "ResolveSimpleAssemblyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AssemblyName)}, ReturnType = typeof(Assembly))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NullReferenceException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	internal static RuntimeAssembly LoadWithPartialNameInternal(string partialName, Evidence securityEvidence, ref StackCrawlMark stackMark) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ToString() { }

}

