namespace System.Reflection;

internal class RuntimeFieldInfo : RtFieldInfo, ISerializable
{
	internal IntPtr klass; //Field offset: 0x10
	internal RuntimeFieldHandle fhandle; //Field offset: 0x18
	private string name; //Field offset: 0x20
	private Type type; //Field offset: 0x28
	private FieldAttributes attrs; //Field offset: 0x30

	public virtual FieldAttributes Attributes
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	internal BindingFlags BindingFlags
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		internal get { } //Length: 3
	}

	public virtual Type DeclaringType
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 7
	}

	public virtual RuntimeFieldHandle FieldHandle
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public virtual Type FieldType
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 94
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
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 137
	}

	public virtual string Name
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public virtual Type ReflectedType
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 7
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
	public RuntimeFieldInfo() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentUICulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TargetException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 14)]
	internal virtual void CheckConsistency(object target) { }

	[CalledBy(Type = typeof(RuntimeFieldInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimeFieldInfo), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(BindingFlags), typeof(Binder), typeof(CultureInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void CheckGeneric() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public virtual FieldAttributes get_Attributes() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	internal BindingFlags get_BindingFlags() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual Type get_DeclaringType() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public virtual RuntimeFieldHandle get_FieldHandle() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public virtual Type get_FieldType() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal static int get_metadata_token(RuntimeFieldInfo monoField) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual int get_MetadataToken() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public virtual Module get_Module() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public virtual string get_Name() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual Type get_ReflectedType() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private RuntimeType get_ReflectedTypeInternal() { }

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

	[CalledBy(Type = typeof(TypedReference), Member = "MakeTypedReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(FieldInfo[])}, ReturnType = typeof(TypedReference))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal RuntimeType GetDeclaringTypeInternal() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal virtual int GetFieldOffset() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MemberInfoSerializationHolder), Member = "GetSerializationInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(string), typeof(RuntimeType), typeof(string), typeof(string), typeof(MemberTypes), typeof(Type[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private Type GetParentType(bool declaring) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual object GetRawConstantValue() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal RuntimeModule GetRuntimeModule() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FieldInfo), Member = "get_IsStatic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(FieldInfo), Member = "get_IsLiteral", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeFieldInfo), Member = "CheckGeneric", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TargetException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	public virtual object GetValue(object obj) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private object GetValueInternal(object obj) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(bool))]
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private Type ResolveType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FieldInfo), Member = "get_IsStatic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(FieldInfo), Member = "get_IsLiteral", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_DefaultBinder", ReturnType = typeof(Binder))]
	[Calls(Type = typeof(RuntimeFieldInfo), Member = "CheckGeneric", ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeType), Member = "CheckValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Binder), typeof(CultureInfo), typeof(BindingFlags)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(FieldAccessException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TargetException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 19)]
	public virtual void SetValue(object obj, object val, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TypedReference), Member = "get_IsNull", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeFieldHandle), Member = "SetValueDirect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeFieldInfo), typeof(RuntimeType), typeof(Void*), typeof(object), typeof(RuntimeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	[DebuggerHidden]
	[DebuggerStepThrough]
	public virtual void SetValueDirect(TypedReference obj, object value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static void SetValueInternal(FieldInfo fi, object obj, object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual object UnsafeGetValue(object obj) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[DebuggerHidden]
	[DebuggerStepThrough]
	internal virtual void UnsafeSetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

}

