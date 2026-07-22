namespace System.Reflection;

[ClassInterface(ClassInterfaceType::None (0))]
[ComDefaultInterface(typeof(_Assembly))]
[ComVisible(True)]
public class Assembly : ICustomAttributeProvider, ISerializable, _Assembly
{
	public class ResolveEventHolder
	{

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public ResolveEventHolder() { }

	}


	public override string CodeBase
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 62
	}

	public override string FullName
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 62
	}

	[MonoTODO]
	public bool IsFullyTrusted
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public override string Location
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 62
	}

	internal override IntPtr MonoAssembly
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		internal get { } //Length: 62
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public Assembly() { }

	[CalledBy(Type = typeof(Assembly), Member = "GetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(Assembly), Member = "GetModule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Module))]
	[CalledBy(Type = typeof(Assembly), Member = "GetReferencedAssemblies", ReturnType = typeof(AssemblyName[]))]
	[CalledBy(Type = typeof(Assembly), Member = "GetModules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Module[]))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	private static Exception CreateNIE() { }

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual bool Equals(object o) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public override string get_CodeBase() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public override string get_FullName() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public bool get_IsFullyTrusted() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public override string get_Location() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal override IntPtr get_MonoAssembly() { }

	[CalledBy(Type = typeof(BinaryConverter), Member = "GetParserBinaryTypeInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Object&)}, ReturnType = typeof(BinaryTypeEnum))]
	[CalledBy(Type = typeof(Converter), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public static Assembly GetAssembly(Type type) { }

	[CalledBy(Type = typeof(ResourceManager), Member = "Init", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Assembly GetCallingAssembly() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public override Object[] GetCustomAttributes(bool inherit) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public override Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static Assembly GetExecutingAssembly() { }

	[CallerCount(Count = 19)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Assembly), Member = "CreateNIE", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	public override Module GetModule(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Assembly), Member = "CreateNIE", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	public override Module[] GetModules(bool getResourceModules) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal override Module[] GetModulesInternal() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public override AssemblyName GetName(bool copiedName) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public override AssemblyName GetName() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[CalledBy(Type = typeof(RuntimeAssembly), Member = "GetReferencedAssemblies", ReturnType = typeof(AssemblyName[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AssemblyName), Member = "FillName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MonoAssemblyName*), typeof(string), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 9)]
	internal static AssemblyName[] GetReferencedAssemblies(Assembly module) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Assembly), Member = "CreateNIE", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	public override AssemblyName[] GetReferencedAssemblies() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Assembly), Member = "CreateNIE", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	public override Type GetType(string name, bool throwOnError, bool ignoreCase) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Type GetType(string name) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override Type[] GetTypes() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal override Type[] GetTypes(bool exportedOnly) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static IntPtr InternalGetReferencedAssemblies(Assembly module) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal Type InternalGetType(Module module, string name, bool throwOnError, bool ignoreCase) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public override bool IsDefined(Type attributeType, bool inherit) { }

	[CalledBy(Type = typeof(UnitySerializationHolder), Member = "GetRealObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StreamingContext)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(ObjectReader), Member = "CheckTypeForwardedTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(Assembly), typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectReader), Member = "FastBindToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(FormatterServices), Member = "LoadAssemblyFromStringNoThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Assembly))]
	[CalledBy(Type = typeof(FormatterServices), Member = "LoadAssemblyFromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Assembly))]
	[CalledBy(Type = typeof(WellKnownServiceTypeEntry), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(WellKnownObjectMode)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(WellKnownClientTypeEntry), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConfigHandler), Member = "ReadPreload", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAttrList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConfigHandler), Member = "ReadClientWellKnown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAttrList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConfigHandler), Member = "ReadServiceWellKnown", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAttrList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConfigHandler), Member = "ReadClientActivated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAttrList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConfigHandler), Member = "ParseElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IAttrList)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ActivatedServiceTypeEntry), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ActivatedClientTypeEntry), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(EncodingHelper), Member = "InvokeI18N", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(TypeSpec), Member = "Resolve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<System.Reflection.AssemblyName, System.Reflection.Assembly>), typeof(System.Func`4<System.Reflection.Assembly, System.String, System.Boolean, System.Type>), typeof(bool), typeof(bool), typeof(StackCrawlMark&)}, ReturnType = typeof(Type))]
	[CalledBy(Type = "System.DelegateSerializationHolder+DelegateEntry", Member = "DeserializeDelegate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(int)}, ReturnType = typeof(Delegate))]
	[CalledBy(Type = typeof(ConfigHandler), Member = "ReadServiceActivated", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAttrList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(AppDomain), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Assembly))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Assembly Load(string assemblyString) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static Assembly load_with_partial_name(string name, Evidence e) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NullReferenceException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[Obsolete("This method has been deprecated. Please use Assembly.Load() instead. http://go.microsoft.com/fwlink/?linkid=14202")]
	public static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(NullReferenceException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	internal static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence, bool oldBehavior) { }

	[CalledBy(Type = "Newtonsoft.Json.Serialization.DefaultSerializationBinder", Member = "GetTypeFromTypeNameKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Utilities.StructMultiKey`2<String, String>"}, ReturnType = typeof(Type))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NullReferenceException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[Obsolete("This method has been deprecated. Please use Assembly.Load() instead. http://go.microsoft.com/fwlink/?linkid=14202")]
	public static Assembly LoadWithPartialName(string partialName) { }

	[CallerCount(Count = 32)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool op_Equality(Assembly left, Assembly right) { }

	[CalledBy(Type = typeof(AppDomain), Member = "DoAssemblyResolve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Assembly), typeof(bool)}, ReturnType = typeof(Assembly))]
	[CalledBy(Type = typeof(AppDomain), Member = "DoTypeResolve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Assembly))]
	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "IsUserCattrProvider", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ObjectReader), Member = "CheckTypeForwardedTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Assembly), typeof(Assembly), typeof(Type)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Properties.Internal.PropertyBagStore", Member = "AddPropertyBag", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TContainer"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Properties.IPropertyBag`1<TContainer>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool op_Inequality(Assembly left, Assembly right) { }

	[CalledBy(Type = typeof(RuntimeTypeHandle), Member = "GetTypeByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(bool), typeof(StackCrawlMark&), typeof(bool)}, ReturnType = typeof(RuntimeType))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AppDomain), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Evidence), typeof(bool), typeof(StackCrawlMark&)}, ReturnType = typeof(Assembly))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Assembly ReflectionOnlyLoad(string assemblyString) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "ToString", ReturnType = typeof(string))]
	[DeduplicatedMethod]
	public virtual string ToString() { }

}

