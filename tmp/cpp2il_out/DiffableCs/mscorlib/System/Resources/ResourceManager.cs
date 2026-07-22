namespace System.Resources;

[ComVisible(True)]
public class ResourceManager
{
	public class CultureNameResourceSetPair
	{

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public CultureNameResourceSetPair() { }

	}

	public class ResourceManagerMediator
	{
		private ResourceManager _rm; //Field offset: 0x10

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		internal ResourceManagerMediator(ResourceManager rm) { }

	}

	public static readonly int MagicNumber; //Field offset: 0x0
	public static readonly int HeaderVersionNumber; //Field offset: 0x4
	private static readonly Type _minResourceSet; //Field offset: 0x8
	internal static readonly string ResReaderTypeName; //Field offset: 0x10
	internal static readonly string ResSetTypeName; //Field offset: 0x18
	internal static readonly string MscorlibName; //Field offset: 0x20
	internal static readonly int DEBUG; //Field offset: 0x28
	[Obsolete("call InternalGetResourceSet instead")]
	protected Hashtable ResourceSets; //Field offset: 0x10
	private Dictionary<String, ResourceSet> _resourceSets; //Field offset: 0x18
	protected Assembly MainAssembly; //Field offset: 0x20
	private CultureInfo _neutralResourcesCulture; //Field offset: 0x28
	private CultureNameResourceSetPair _lastUsedResourceCache; //Field offset: 0x30
	private bool UseManifest; //Field offset: 0x38
	[OptionalField(VersionAdded = 1)]
	private bool UseSatelliteAssem; //Field offset: 0x39
	[OptionalField]
	private UltimateResourceFallbackLocation _fallbackLoc; //Field offset: 0x3C
	[OptionalField(VersionAdded = 1)]
	private Assembly _callingAssembly; //Field offset: 0x40
	[OptionalField(VersionAdded = 4)]
	private RuntimeAssembly m_callingAssembly; //Field offset: 0x48
	private IResourceGroveler resourceGroveler; //Field offset: 0x50

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private static ResourceManager() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ResourceManager), Member = "Init", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	protected ResourceManager() { }

	[CalledBy(Type = typeof(ResourceReader), Member = "_ReadResources", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(string), typeof(int), typeof(int), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(AssemblyName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(AssemblyName), Member = "GetPublicKeyToken", ReturnType = typeof(Byte[]))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal static bool CompareNames(string asmTypeName1, string typeName2, AssemblyName asmName2) { }

	[CalledBy(Type = typeof(ResourceManager), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Assembly), Member = "GetCallingAssembly", ReturnType = typeof(Assembly))]
	[CallsUnknownMethods(Count = 3)]
	private void Init() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Assembly), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(Assembly)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ManifestBasedResourceGroveler), Member = "GetNeutralResourcesLanguage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(UltimateResourceFallbackLocation&)}, ReturnType = typeof(CultureInfo))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	[OnDeserialized]
	private void OnDeserialized(StreamingContext ctx) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[OnDeserializing]
	private void OnDeserializing(StreamingContext ctx) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[OnSerializing]
	private void OnSerializing(StreamingContext ctx) { }

}

