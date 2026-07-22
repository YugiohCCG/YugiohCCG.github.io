namespace System.Reflection;

internal sealed class RuntimeEventInfo : EventInfo, ISerializable
{
	private IntPtr klass; //Field offset: 0x18
	private IntPtr handle; //Field offset: 0x20

	internal BindingFlags BindingFlags
	{
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(RuntimeEventInfo), Member = "GetDeclaringTypeInternal", ReturnType = typeof(RuntimeType))]
		[Calls(Type = typeof(RuntimeType), Member = "FilterPreCalculate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(BindingFlags))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal get { } //Length: 299
	}

	public virtual Type DeclaringType
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 47
	}

	public virtual int MetadataToken
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public virtual Module Module
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RuntimeEventInfo), Member = "GetDeclaringTypeInternal", ReturnType = typeof(RuntimeType))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 35
	}

	public virtual string Name
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 47
	}

	public virtual Type ReflectedType
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 47
	}

	private RuntimeType ReflectedTypeInternal
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 122
	}

	[CallerCount(Count = 26)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public RuntimeEventInfo() { }

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(RuntimeEventInfo), Member = "GetDeclaringTypeInternal", ReturnType = typeof(RuntimeType))]
	[Calls(Type = typeof(RuntimeType), Member = "FilterPreCalculate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(BindingFlags))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal BindingFlags get_BindingFlags() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual Type get_DeclaringType() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static void get_event_info(RuntimeEventInfo ev, out MonoEventInfo info) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal static int get_metadata_token(RuntimeEventInfo monoEvent) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual int get_MetadataToken() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeEventInfo), Member = "GetDeclaringTypeInternal", ReturnType = typeof(RuntimeType))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual Module get_Module() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string get_Name() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual Type get_ReflectedType() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private RuntimeType get_ReflectedTypeInternal() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual MethodInfo GetAddMethod(bool nonPublic) { }

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(RuntimeEventInfo), Member = "GetDeclaringTypeInternal", ReturnType = typeof(RuntimeType))]
	[Calls(Type = typeof(RuntimeType), Member = "FilterPreCalculate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(BindingFlags))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal BindingFlags GetBindingFlags() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(Object[]))]
	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(bool)}, ReturnType = typeof(Object[]))]
	public virtual Object[] GetCustomAttributes(bool inherit) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributesData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(bool)}, ReturnType = typeof(System.Collections.Generic.IList`1<System.Reflection.CustomAttributeData>))]
	[DeduplicatedMethod]
	public virtual IList<CustomAttributeData> GetCustomAttributesData() { }

	[CalledBy(Type = typeof(RuntimeEventInfo), Member = "get_Module", ReturnType = typeof(Module))]
	[CalledBy(Type = typeof(RuntimeEventInfo), Member = "get_BindingFlags", ReturnType = typeof(BindingFlags))]
	[CalledBy(Type = typeof(RuntimeEventInfo), Member = "GetRuntimeModule", ReturnType = typeof(RuntimeModule))]
	[CalledBy(Type = typeof(RuntimeEventInfo), Member = "GetBindingFlags", ReturnType = typeof(BindingFlags))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal RuntimeType GetDeclaringTypeInternal() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static MonoEventInfo GetEventInfo(RuntimeEventInfo ev) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MemberInfoSerializationHolder), Member = "GetSerializationInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(string), typeof(RuntimeType), typeof(string), typeof(string), typeof(MemberTypes), typeof(Type[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual MethodInfo GetRaiseMethod(bool nonPublic) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual MethodInfo GetRemoveMethod(bool nonPublic) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeEventInfo), Member = "GetDeclaringTypeInternal", ReturnType = typeof(RuntimeType))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal RuntimeModule GetRuntimeModule() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(bool))]
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 3)]
	public virtual string ToString() { }

}

