namespace System;

internal class RuntimeType : TypeInfo, ISerializable, ICloneable
{
	[DefaultMember("Item")]
	private struct ListBuilder
	{
		private T[] _items; //Field offset: 0x0
		private T _item; //Field offset: 0x0
		private int _count; //Field offset: 0x0
		private int _capacity; //Field offset: 0x0

		public int Count
		{
			[CallerCount(Count = 94)]
			[DeduplicatedMethod]
			 get { } //Length: 4
		}

		public T Item
		{
			[CalledBy(Type = typeof(RuntimeType), Member = "GetConstructorImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(Binder), typeof(CallingConventions), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(ConstructorInfo))]
			[CalledBy(Type = typeof(RuntimeType), Member = "GetPropertyImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(Type), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(PropertyInfo))]
			[CalledBy(Type = typeof(RuntimeType), Member = "GetMethodImplCommon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(BindingFlags), typeof(Binder), typeof(CallingConventions), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodInfo))]
			[CallerCount(Count = 4)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			 get { } //Length: 46
		}

		[CalledBy(Type = typeof(RuntimeType), Member = "GetMethodCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[]), typeof(int), typeof(bool)}, ReturnType = "System.RuntimeType+ListBuilder`1<MethodInfo>")]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetConstructorCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[]), typeof(bool)}, ReturnType = "System.RuntimeType+ListBuilder`1<ConstructorInfo>")]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetPropertyCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Type[]), typeof(bool)}, ReturnType = "System.RuntimeType+ListBuilder`1<PropertyInfo>")]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetEventCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(bool)}, ReturnType = "System.RuntimeType+ListBuilder`1<EventInfo>")]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetFieldCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(bool)}, ReturnType = "System.RuntimeType+ListBuilder`1<FieldInfo>")]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetNestedTypeCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(bool)}, ReturnType = "System.RuntimeType+ListBuilder`1<Type>")]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetMethodCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[]), typeof(bool)}, ReturnType = "System.RuntimeType+ListBuilder`1<MethodInfo>")]
		[CallerCount(Count = 8)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public ListBuilder`1(int capacity) { }

		[CalledBy(Type = typeof(RuntimeType), Member = "GetMethodCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[]), typeof(int), typeof(bool)}, ReturnType = "System.RuntimeType+ListBuilder`1<MethodInfo>")]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetConstructorCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[]), typeof(bool)}, ReturnType = "System.RuntimeType+ListBuilder`1<ConstructorInfo>")]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetPropertyCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Type[]), typeof(bool)}, ReturnType = "System.RuntimeType+ListBuilder`1<PropertyInfo>")]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetEventCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(bool)}, ReturnType = "System.RuntimeType+ListBuilder`1<EventInfo>")]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetFieldCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(bool)}, ReturnType = "System.RuntimeType+ListBuilder`1<FieldInfo>")]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetNestedTypeCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(bool)}, ReturnType = "System.RuntimeType+ListBuilder`1<Type>")]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetMethodCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[]), typeof(bool)}, ReturnType = "System.RuntimeType+ListBuilder`1<MethodInfo>")]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 8)]
		[DeduplicatedMethod]
		public void Add(T item) { }

		[CalledBy(Type = typeof(RuntimeType), Member = "GetMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags)}, ReturnType = typeof(MemberInfo[]))]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MemberTypes), typeof(BindingFlags)}, ReturnType = typeof(MemberInfo[]))]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		[DeduplicatedMethod]
		public void CopyTo(Object[] array, int index) { }

		[CallerCount(Count = 94)]
		[DeduplicatedMethod]
		public int get_Count() { }

		[CalledBy(Type = typeof(RuntimeType), Member = "GetConstructorImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(Binder), typeof(CallingConventions), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(ConstructorInfo))]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetPropertyImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(Type), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(PropertyInfo))]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetMethodImplCommon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(BindingFlags), typeof(Binder), typeof(CallingConventions), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodInfo))]
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		public T get_Item(int index) { }

		[CalledBy(Type = typeof(RuntimeType), Member = "GetMethods", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags)}, ReturnType = typeof(MethodInfo[]))]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetConstructors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags)}, ReturnType = typeof(ConstructorInfo[]))]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags)}, ReturnType = typeof(PropertyInfo[]))]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags)}, ReturnType = typeof(EventInfo[]))]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetFields", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags)}, ReturnType = typeof(FieldInfo[]))]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetConstructorImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(Binder), typeof(CallingConventions), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(ConstructorInfo))]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetPropertyImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(Type), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(PropertyInfo))]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MemberTypes), typeof(BindingFlags)}, ReturnType = typeof(MemberInfo[]))]
		[CalledBy(Type = typeof(RuntimeType), Member = "GetMethodImplCommon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(BindingFlags), typeof(Binder), typeof(CallingConventions), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodInfo))]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 8)]
		[DeduplicatedMethod]
		public T[] ToArray() { }

	}

	public enum MemberListType
	{
		All = 0,
		CaseSensitive = 1,
		CaseInsensitive = 2,
		HandleToInfo = 3,
	}

	internal static readonly RuntimeType ValueType; //Field offset: 0x0
	private const BindingFlags ClassicBindingMask = 61696; //Field offset: 0x0
	private const BindingFlags BinderNonFieldGetSet = 16773888; //Field offset: 0x0
	private const BindingFlags BinderSetInvokeField = 2304; //Field offset: 0x0
	private const BindingFlags BinderGetSetField = 3072; //Field offset: 0x0
	private const BindingFlags BinderSetInvokeProperty = 8448; //Field offset: 0x0
	private const BindingFlags BinderNonCreateInstance = 15616; //Field offset: 0x0
	private const BindingFlags InvocationMask = 65280; //Field offset: 0x0
	private const BindingFlags BinderGetSetProperty = 12288; //Field offset: 0x0
	private const BindingFlags MemberBindingMask = 255; //Field offset: 0x0
	private const int GenericParameterCountAny = -1; //Field offset: 0x0
	internal static readonly RuntimeType EnumType; //Field offset: 0x8
	private static readonly RuntimeType ObjectType; //Field offset: 0x10
	private static readonly RuntimeType StringType; //Field offset: 0x18
	private static readonly RuntimeType DelegateType; //Field offset: 0x20
	private static Type[] s_SICtorParamTypes; //Field offset: 0x28
	internal static Func<Type, Type[], Type> MakeTypeBuilderInstantiation; //Field offset: 0x30
	private static RuntimeType s_typedRef; //Field offset: 0x38
	private MonoTypeInfo type_info; //Field offset: 0x18
	internal object GenericCache; //Field offset: 0x20
	private RuntimeConstructorInfo m_serializationCtor; //Field offset: 0x28

	public virtual Assembly Assembly
	{
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(RuntimeTypeHandle), Member = "GetAssembly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(RuntimeAssembly))]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public virtual string AssemblyQualifiedName
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 12
	}

	public virtual Type BaseType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RuntimeType), Member = "GetBaseType", ReturnType = typeof(RuntimeType))]
		 get { } //Length: 7
	}

	public virtual bool ContainsGenericParameters
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "get_HasElementType", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 275
	}

	public virtual MethodBase DeclaringMethod
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 5
	}

	public virtual Type DeclaringType
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 5
	}

	public virtual string FullName
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetRootElementType", ReturnType = typeof(Type))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 257
	}

	public virtual GenericParameterAttributes GenericParameterAttributes
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RuntimeTypeHandle), Member = "GetGenericParameterInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(IntPtr))]
		[Calls(Type = typeof(RuntimeGenericParamInfoHandle), Member = "get_Attributes", ReturnType = typeof(GenericParameterAttributes))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 189
	}

	public virtual int GenericParameterPosition
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 5)]
		 get { } //Length: 137
	}

	public virtual bool IsConstructedGenericType
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 65
	}

	public virtual bool IsEnum
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RuntimeType), Member = "GetBaseType", ReturnType = typeof(RuntimeType))]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 98
	}

	public virtual bool IsGenericParameter
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RuntimeTypeHandle), Member = "IsGenericVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(bool))]
		 get { } //Length: 7
	}

	public virtual bool IsGenericType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RuntimeTypeHandle), Member = "HasInstantiation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(bool))]
		 get { } //Length: 7
	}

	public virtual bool IsGenericTypeDefinition
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RuntimeTypeHandle), Member = "IsGenericTypeDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(bool))]
		 get { } //Length: 7
	}

	internal virtual bool IsSzArray
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RuntimeTypeHandle), Member = "IsSzArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(bool))]
		internal get { } //Length: 7
	}

	public virtual bool IsSZArray
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "get_IsArray", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 87
	}

	public virtual MemberTypes MemberType
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "get_IsPublic", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Type), Member = "get_IsNotPublic", ReturnType = typeof(bool))]
		 get { } //Length: 64
	}

	public virtual int MetadataToken
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 7
	}

	public virtual Module Module
	{
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(RuntimeTypeHandle), Member = "GetModule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(RuntimeModule))]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public virtual string Name
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 5
	}

	public virtual string Namespace
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 5
	}

	public virtual Type ReflectedType
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 17
	}

	public virtual RuntimeTypeHandle TypeHandle
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RuntimeTypeHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(void))]
		 get { } //Length: 39
	}

	public virtual Type UnderlyingSystemType
	{
		[CallerCount(Count = 2063)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsUnknownMethods(Count = 18)]
	private static RuntimeType() { }

	[CalledBy(Type = typeof(ReflectionOnlyType), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal RuntimeType() { }

	[CalledBy(Type = typeof(RuntimeFieldInfo), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object), typeof(BindingFlags), typeof(Binder), typeof(CultureInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RuntimeMethodInfo), Member = "ConvertValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Binder), typeof(Object[]), typeof(ParameterInfo[]), typeof(CultureInfo), typeof(BindingFlags)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RuntimeType), Member = "TryConvertToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Type), Member = "get_DefaultBinder", ReturnType = typeof(Binder))]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentUICulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 14)]
	internal object CheckValue(object value, Binder binder, CultureInfo culture, BindingFlags invokeAttr) { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	public override object Clone() { }

	[CalledBy(Type = typeof(RuntimeType), Member = "CreateInstanceImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo), typeof(Object[]), typeof(StackCrawlMark&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimeType), Member = "CreateInstanceDefaultCtor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(StackCrawlMark&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimeType), Member = "CreateInstanceSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetRootElementType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 20)]
	private void CreateInstanceCheckThis() { }

	[CalledBy(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[CalledBy(Type = typeof(RuntimeType), Member = "CreateInstanceImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo), typeof(Object[]), typeof(StackCrawlMark&)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(RuntimeType), Member = "CreateInstanceCheckThis", ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeType), Member = "CreateInstanceMono", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[DebuggerHidden]
	[DebuggerStepThrough]
	internal object CreateInstanceDefaultCtor(bool publicOnly, bool skipCheckThis, bool fillCache, bool wrapExceptions, ref StackCrawlMark stackMark) { }

	[CalledBy(Type = typeof(Comparer`1), Member = "CreateComparer", ReturnType = "System.Collections.Generic.Comparer`1<T>")]
	[CalledBy(Type = typeof(EqualityComparer`1), Member = "CreateComparer", ReturnType = "System.Collections.Generic.EqualityComparer`1<T>")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(RuntimeType), Member = "GetDefaultConstructor", ReturnType = typeof(RuntimeConstructorInfo))]
	[Calls(Type = typeof(RuntimeConstructorInfo), Member = "InternalInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[]), typeof(bool)}, ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 8)]
	internal static object CreateInstanceForAnotherGenericParameter(Type genericType, RuntimeType genericArgument) { }

	[CalledBy(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo), typeof(Object[])}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MissingMethodException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(bool), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(MethodBase), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(MethodBase)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeType), Member = "FilterApplyMethodBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(BindingFlags), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeType), Member = "CreateInstanceDefaultCtor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(StackCrawlMark&)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_DefaultBinder", ReturnType = typeof(Binder))]
	[Calls(Type = typeof(RuntimeType), Member = "CreateInstanceCheckThis", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 54)]
	internal object CreateInstanceImpl(BindingFlags bindingAttr, Binder binder, Object[] args, CultureInfo culture, Object[] activationAttributes, ref StackCrawlMark stackMark) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static object CreateInstanceInternal(Type type) { }

	[CalledBy(Type = typeof(RuntimeType), Member = "CreateInstanceDefaultCtor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool), typeof(bool), typeof(StackCrawlMark&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimeType), Member = "CreateInstanceSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MissingMethodException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(MissingMethodException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetRootElementType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(RuntimeConstructorInfo), Member = "InternalInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[]), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Type), Member = "get_IsAbstract", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MethodBase), Member = "get_IsPublic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ConstructorInfo), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConstructorInfo), typeof(ConstructorInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeType), Member = "GetDefaultConstructor", ReturnType = typeof(RuntimeConstructorInfo))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 16)]
	private object CreateInstanceMono(bool nonPublic, bool wrapExceptions) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeType), Member = "CreateInstanceCheckThis", ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeType), Member = "CreateInstanceMono", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(object))]
	internal object CreateInstanceSlow(bool publicOnly, bool wrapExceptions, bool skipCheckThis, bool fillCache) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CalledBy(Type = typeof(RuntimeType), Member = "FilterApplyType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(BindingFlags), typeof(string), typeof(bool), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetNestedTypeCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Type>))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetNestedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(Type))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RuntimeType), Member = "FilterApplyPrefixLookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MethodBase), Member = "get_IsVirtual", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MethodBase), Member = "get_IsAbstract", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static bool FilterApplyBase(MemberInfo memberInfo, BindingFlags bindingFlags, bool isPublic, bool isNonProtectedInternal, bool isStatic, string name, bool prefixLookup) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeType), Member = "FilterApplyMethodBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(BindingFlags), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[])}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static bool FilterApplyConstructorInfo(RuntimeConstructorInfo constructor, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	[CalledBy(Type = typeof(RuntimeType), Member = "FilterApplyMethodInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeMethodInfo), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RuntimeType), Member = "FilterApplyConstructorInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeConstructorInfo), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetConstructorCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[]), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.ConstructorInfo>))]
	[CalledBy(Type = typeof(RuntimeType), Member = "InvokeMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(object), typeof(Object[]), typeof(ParameterModifier[]), typeof(CultureInfo), typeof(String[])}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimeType), Member = "CreateInstanceImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo), typeof(Object[]), typeof(StackCrawlMark&)}, ReturnType = typeof(object))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(SignatureTypeExtensions), Member = "MatchesParameterTypeExactly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(ParameterInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ParameterInfo), Member = "get_IsOptional", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsArray", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static bool FilterApplyMethodBase(MethodBase methodBase, BindingFlags methodFlags, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	[CalledBy(Type = typeof(RuntimeType), Member = "GetMethodCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[]), typeof(int), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.MethodInfo>))]
	[CalledBy(Type = typeof(RuntimeType), Member = "InvokeMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(object), typeof(Object[]), typeof(ParameterModifier[]), typeof(CultureInfo), typeof(String[])}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetMethodCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[]), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.MethodInfo>))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(RuntimeType), Member = "FilterApplyMethodBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(BindingFlags), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[])}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static bool FilterApplyMethodInfo(RuntimeMethodInfo method, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	[CalledBy(Type = typeof(RuntimeType), Member = "FilterApplyBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(BindingFlags), typeof(bool), typeof(bool), typeof(bool), typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static bool FilterApplyPrefixLookup(MemberInfo memberInfo, string name, bool ignoreCase) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "get_IsNestedPublic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsPublic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsNestedAssembly", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeType), Member = "FilterApplyBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(BindingFlags), typeof(bool), typeof(bool), typeof(bool), typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static bool FilterApplyType(Type type, BindingFlags bindingFlags, string name, bool prefixLookup, string ns) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	private static void FilterHelper(BindingFlags bindingFlags, ref string name, bool allowPrefixLookup, out bool prefixLookup, out bool ignoreCase, out MemberListType listType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	private static void FilterHelper(BindingFlags bindingFlags, ref string name, out bool ignoreCase, out MemberListType listType) { }

	[CalledBy(Type = typeof(RuntimeEventInfo), Member = "get_BindingFlags", ReturnType = typeof(BindingFlags))]
	[CalledBy(Type = typeof(RuntimeEventInfo), Member = "GetBindingFlags", ReturnType = typeof(BindingFlags))]
	[CallerCount(Count = 2)]
	internal static BindingFlags FilterPreCalculate(bool isPublic, bool isInherited, bool isStatic) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetRootElementType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "get_IsNested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsPrimitive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	internal virtual string FormatTypeName(bool serialization) { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "GetAssembly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(RuntimeAssembly))]
	[DeduplicatedMethod]
	public virtual Assembly get_Assembly() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string get_AssemblyQualifiedName() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeType), Member = "GetBaseType", ReturnType = typeof(RuntimeType))]
	public virtual Type get_BaseType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "get_HasElementType", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	public virtual bool get_ContainsGenericParameters() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual MethodBase get_DeclaringMethod() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual Type get_DeclaringType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetRootElementType", ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public virtual string get_FullName() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "GetGenericParameterInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(RuntimeGenericParamInfoHandle), Member = "get_Attributes", ReturnType = typeof(GenericParameterAttributes))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public virtual GenericParameterAttributes get_GenericParameterAttributes() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public virtual int get_GenericParameterPosition() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public virtual bool get_IsConstructedGenericType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeType), Member = "GetBaseType", ReturnType = typeof(RuntimeType))]
	[ContainsUnimplementedInstructions]
	public virtual bool get_IsEnum() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "IsGenericVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(bool))]
	public virtual bool get_IsGenericParameter() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "HasInstantiation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(bool))]
	public virtual bool get_IsGenericType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "IsGenericTypeDefinition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(bool))]
	public virtual bool get_IsGenericTypeDefinition() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "IsSzArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(bool))]
	internal virtual bool get_IsSzArray() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "get_IsArray", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool get_IsSZArray() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "get_IsPublic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsNotPublic", ReturnType = typeof(bool))]
	public virtual MemberTypes get_MemberType() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual int get_MetadataToken() { }

	[CallerCount(Count = 8)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "GetModule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(RuntimeModule))]
	[DeduplicatedMethod]
	public virtual Module get_Module() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string get_Name() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string get_Namespace() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual Type get_ReflectedType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(void))]
	public virtual RuntimeTypeHandle get_TypeHandle() { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	public virtual Type get_UnderlyingSystemType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "GetArrayRank", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public virtual int GetArrayRank() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "GetAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(TypeAttributes))]
	protected virtual TypeAttributes GetAttributeFlagsImpl() { }

	[CalledBy(Type = typeof(RuntimeType), Member = "get_BaseType", ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(RuntimeType), Member = "get_IsEnum", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "IsGenericVariable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "GetBaseType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(RuntimeType))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	private RuntimeType GetBaseType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private string GetCachedName(TypeNameKind kind) { }

	[CalledBy(Type = typeof(RuntimeType), Member = "GetConstructors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags)}, ReturnType = typeof(ConstructorInfo[]))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags)}, ReturnType = typeof(MemberInfo[]))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetConstructorImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(Binder), typeof(CallingConventions), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(ConstructorInfo))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MemberTypes), typeof(BindingFlags)}, ReturnType = typeof(MemberInfo[]))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ListBuilder`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeType), Member = "FilterApplyMethodBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(BindingFlags), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeType), Member = "GetConstructors_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(RuntimeType)}, ReturnType = typeof(RuntimeConstructorInfo[]))]
	[Calls(Type = typeof(ListBuilder`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private ListBuilder<ConstructorInfo> GetConstructorCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, bool allowPrefixLookup) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeType), Member = "GetConstructorCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[]), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.ConstructorInfo>))]
	[Calls(Type = typeof(ListBuilder`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Type), Member = "get_DefaultBinder", ReturnType = typeof(Binder))]
	[Calls(Type = typeof(ListBuilder`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(DefaultBinder), Member = "ExactBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase[]), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodBase))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	protected virtual ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeType), Member = "GetConstructorCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[]), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.ConstructorInfo>))]
	[Calls(Type = typeof(ListBuilder`1), Member = "ToArray", ReturnType = "T[]")]
	[ComVisible(True)]
	public virtual ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	[CalledBy(Type = typeof(RuntimeType), Member = "GetConstructorCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[]), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.ConstructorInfo>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeMethodInfo), Member = "GetMethodFromHandleNoGenericCheck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeMethodHandle), typeof(RuntimeTypeHandle)}, ReturnType = typeof(MethodBase))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 10)]
	private RuntimeConstructorInfo[] GetConstructors_internal(BindingFlags bindingAttr, RuntimeType reflectedType) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private IntPtr GetConstructors_native(BindingFlags bindingAttr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(Object[]))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public virtual Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(Object[]))]
	public virtual Object[] GetCustomAttributes(bool inherit) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CustomAttributeData), Member = "GetCustomAttributesInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(System.Collections.Generic.IList`1<System.Reflection.CustomAttributeData>))]
	public virtual IList<CustomAttributeData> GetCustomAttributesData() { }

	[CalledBy(Type = typeof(RuntimeType), Member = "CreateInstanceMono", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(RuntimeType), Member = "CreateInstanceForAnotherGenericParameter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(RuntimeType)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	internal RuntimeConstructorInfo GetDefaultConstructor() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private string GetDefaultMemberName() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "GetElementType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(RuntimeType))]
	public virtual Type GetElementType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "IsIntegerType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enum), Member = "GetCachedValuesAndNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType), typeof(bool)}, ReturnType = "System.Enum+ValuesAndNames")]
	[Calls(Type = typeof(Enum), Member = "ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(Array), Member = "BinarySearch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "T"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	public virtual string GetEnumName(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "GetCachedValuesAndNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType), typeof(bool)}, ReturnType = "System.Enum+ValuesAndNames")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public virtual String[] GetEnumNames() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public virtual Type GetEnumUnderlyingType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enum), Member = "GetCachedValuesAndNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType), typeof(bool)}, ReturnType = "System.Enum+ValuesAndNames")]
	[Calls(Type = typeof(Array), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(int)}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(Enum), Member = "ToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(ulong)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Array), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public virtual Array GetEnumValues() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RuntimeType), Member = "GetEvents_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(MemberListType), typeof(RuntimeType)}, ReturnType = typeof(RuntimeEventInfo[]))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(AmbiguousMatchException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 10)]
	public virtual EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	[CalledBy(Type = typeof(RuntimeType), Member = "GetEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags)}, ReturnType = typeof(EventInfo[]))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags)}, ReturnType = typeof(MemberInfo[]))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MemberTypes), typeof(BindingFlags)}, ReturnType = typeof(MemberInfo[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RuntimeType), Member = "GetEvents_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(MemberListType), typeof(RuntimeType)}, ReturnType = typeof(RuntimeEventInfo[]))]
	[Calls(Type = typeof(ListBuilder`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ListBuilder`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private ListBuilder<EventInfo> GetEventCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeType), Member = "GetEventCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.EventInfo>))]
	[Calls(Type = typeof(ListBuilder`1), Member = "ToArray", ReturnType = "T[]")]
	public virtual EventInfo[] GetEvents(BindingFlags bindingAttr) { }

	[CalledBy(Type = typeof(RuntimeType), Member = "GetEventCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.EventInfo>))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(EventInfo))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeStringMarshal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeStringMarshal), Member = "get_Value", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(EventInfo), Member = "GetEventFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeEventHandle), typeof(RuntimeTypeHandle)}, ReturnType = typeof(EventInfo))]
	[Calls(Type = typeof(SafeStringMarshal), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	private RuntimeEventInfo[] GetEvents_internal(string name, BindingFlags bindingAttr, MemberListType listType, RuntimeType reflectedType) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private IntPtr GetEvents_native(IntPtr name, MemberListType listType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RuntimeType), Member = "GetFields_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(MemberListType), typeof(RuntimeType)}, ReturnType = typeof(RuntimeFieldInfo[]))]
	[Calls(Type = typeof(Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(AmbiguousMatchException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 14)]
	public virtual FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	[CalledBy(Type = typeof(RuntimeType), Member = "GetFields", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags)}, ReturnType = typeof(FieldInfo[]))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags)}, ReturnType = typeof(MemberInfo[]))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MemberTypes), typeof(BindingFlags)}, ReturnType = typeof(MemberInfo[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RuntimeType), Member = "GetFields_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(MemberListType), typeof(RuntimeType)}, ReturnType = typeof(RuntimeFieldInfo[]))]
	[Calls(Type = typeof(ListBuilder`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ListBuilder`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private ListBuilder<FieldInfo> GetFieldCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeType), Member = "GetFieldCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.FieldInfo>))]
	[Calls(Type = typeof(ListBuilder`1), Member = "ToArray", ReturnType = "T[]")]
	public virtual FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	[CalledBy(Type = typeof(RuntimeType), Member = "GetFieldCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.FieldInfo>))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(FieldInfo))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeStringMarshal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeStringMarshal), Member = "get_Value", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(FieldInfo), Member = "GetFieldFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeFieldHandle), typeof(RuntimeTypeHandle)}, ReturnType = typeof(FieldInfo))]
	[Calls(Type = typeof(SafeStringMarshal), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 11)]
	private RuntimeFieldInfo[] GetFields_internal(string name, BindingFlags bindingAttr, MemberListType listType, RuntimeType reflectedType) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private IntPtr GetFields_native(IntPtr name, BindingFlags bindingAttr, MemberListType listType) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal string getFullName(bool full_name, bool assembly_qualified) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual Type[] GetGenericArguments() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private Type[] GetGenericArgumentsInternal(bool runtimeArray) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	internal RuntimeType[] GetGenericArgumentsInternal() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "GetGenericParameterInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(RuntimeGenericParamInfoHandle), Member = "get_Attributes", ReturnType = typeof(GenericParameterAttributes))]
	[CallsDeduplicatedMethods(Count = 1)]
	private GenericParameterAttributes GetGenericParameterAttributes() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "GetGenericParameterInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(RuntimeGenericParamInfoHandle), Member = "get_Constraints", ReturnType = typeof(Type[]))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public virtual Type[] GetGenericParameterConstraints() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private int GetGenericParameterPosition() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public virtual Type GetGenericTypeDefinition() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual Type[] GetInterfaces() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeType), Member = "GetMethodCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[]), typeof(int), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.MethodInfo>))]
	[Calls(Type = typeof(RuntimeType), Member = "GetConstructorCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[]), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.ConstructorInfo>))]
	[Calls(Type = typeof(RuntimeType), Member = "GetPropertyCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Type[]), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.PropertyInfo>))]
	[Calls(Type = typeof(RuntimeType), Member = "GetEventCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.EventInfo>))]
	[Calls(Type = typeof(RuntimeType), Member = "GetFieldCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.FieldInfo>))]
	[Calls(Type = typeof(RuntimeType), Member = "GetNestedTypeCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Type>))]
	[Calls(Type = typeof(ListBuilder`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ListBuilder`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public virtual MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeType), Member = "GetMethodCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[]), typeof(int), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.MethodInfo>))]
	[Calls(Type = typeof(RuntimeType), Member = "GetConstructorCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[]), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.ConstructorInfo>))]
	[Calls(Type = typeof(RuntimeType), Member = "GetPropertyCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Type[]), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.PropertyInfo>))]
	[Calls(Type = typeof(RuntimeType), Member = "GetEventCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.EventInfo>))]
	[Calls(Type = typeof(RuntimeType), Member = "GetFieldCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.FieldInfo>))]
	[Calls(Type = typeof(RuntimeType), Member = "GetNestedTypeCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Type>))]
	[Calls(Type = typeof(ListBuilder`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(int)}, ReturnType = typeof(void))]
	public virtual MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	[CalledBy(Type = typeof(RuntimeType), Member = "GetMethods", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags)}, ReturnType = typeof(MethodInfo[]))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags)}, ReturnType = typeof(MemberInfo[]))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MemberTypes), typeof(BindingFlags)}, ReturnType = typeof(MemberInfo[]))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RuntimeType), Member = "GetMethodsByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(MemberListType), typeof(RuntimeType)}, ReturnType = typeof(RuntimeMethodInfo[]))]
	[Calls(Type = typeof(ListBuilder`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeType), Member = "FilterApplyMethodInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeMethodInfo), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ListBuilder`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private ListBuilder<MethodInfo> GetMethodCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, int genericParamCount, bool allowPrefixLookup) { }

	[CalledBy(Type = typeof(RuntimeType), Member = "GetMethodImplCommon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(BindingFlags), typeof(Binder), typeof(CallingConventions), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RuntimeType), Member = "GetMethodsByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(MemberListType), typeof(RuntimeType)}, ReturnType = typeof(RuntimeMethodInfo[]))]
	[Calls(Type = typeof(ListBuilder`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RuntimeType), Member = "FilterApplyMethodInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeMethodInfo), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ListBuilder`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private ListBuilder<MethodInfo> GetMethodCandidates(string name, int genericParameterCount, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, bool allowPrefixLookup) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeType), Member = "GetMethodImplCommon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(BindingFlags), typeof(Binder), typeof(CallingConventions), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodInfo))]
	protected virtual MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConv, Type[] types, ParameterModifier[] modifiers) { }

	[CalledBy(Type = typeof(RuntimeType), Member = "GetMethodImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(CallingConventions), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RuntimeType), Member = "GetMethodCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[]), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.MethodInfo>))]
	[Calls(Type = typeof(ListBuilder`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Type), Member = "get_DefaultBinder", ReturnType = typeof(Binder))]
	[Calls(Type = typeof(ListBuilder`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(DefaultBinder), Member = "FindMostDerivedNewSlotMeth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase[]), typeof(int)}, ReturnType = typeof(MethodBase))]
	[Calls(Type = typeof(AmbiguousMatchException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 6)]
	private MethodInfo GetMethodImplCommon(string name, int genericParameterCount, BindingFlags bindingAttr, Binder binder, CallingConventions callConv, Type[] types, ParameterModifier[] modifiers) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeType), Member = "GetMethodCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[]), typeof(int), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.MethodInfo>))]
	[Calls(Type = typeof(ListBuilder`1), Member = "ToArray", ReturnType = "T[]")]
	public virtual MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	[CalledBy(Type = typeof(RuntimeType), Member = "GetMethodCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[]), typeof(int), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.MethodInfo>))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetMethodCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[]), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.MethodInfo>))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeStringMarshal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeStringMarshal), Member = "get_Value", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(RuntimeMethodInfo), Member = "GetMethodFromHandleNoGenericCheck", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeMethodHandle), typeof(RuntimeTypeHandle)}, ReturnType = typeof(MethodBase))]
	[Calls(Type = typeof(SafeStringMarshal), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 11)]
	internal RuntimeMethodInfo[] GetMethodsByName(string name, BindingFlags bindingAttr, MemberListType listType, RuntimeType reflectedType) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal IntPtr GetMethodsByName_native(IntPtr namePtr, BindingFlags bindingAttr, MemberListType listType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RuntimeType), Member = "GetNestedTypes_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(MemberListType)}, ReturnType = typeof(RuntimeType[]))]
	[Calls(Type = typeof(Type), Member = "get_IsNestedPublic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsPublic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsNestedAssembly", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeType), Member = "FilterApplyBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(BindingFlags), typeof(bool), typeof(bool), typeof(bool), typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(AmbiguousMatchException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	public virtual Type GetNestedType(string fullname, BindingFlags bindingAttr) { }

	[CalledBy(Type = typeof(RuntimeType), Member = "GetMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags)}, ReturnType = typeof(MemberInfo[]))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MemberTypes), typeof(BindingFlags)}, ReturnType = typeof(MemberInfo[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ListBuilder`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeType), Member = "FilterApplyBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo), typeof(BindingFlags), typeof(bool), typeof(bool), typeof(bool), typeof(string), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsNestedAssembly", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsPublic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsNestedPublic", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeType), Member = "GetNestedTypes_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(MemberListType)}, ReturnType = typeof(RuntimeType[]))]
	[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ListBuilder`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	private ListBuilder<Type> GetNestedTypeCandidates(string fullname, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	[CalledBy(Type = typeof(RuntimeType), Member = "GetNestedTypeCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Type>))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetNestedType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(Type))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SafeStringMarshal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeStringMarshal), Member = "get_Value", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SafeStringMarshal), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 13)]
	private RuntimeType[] GetNestedTypes_internal(string displayName, BindingFlags bindingAttr, MemberListType listType) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private IntPtr GetNestedTypes_native(IntPtr name, BindingFlags bindingAttr, MemberListType listType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnitySerializationHolder), Member = "GetUnitySerializationInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SerializationInfo), typeof(RuntimeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeType), Member = "GetPropertyCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Type[]), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.PropertyInfo>))]
	[Calls(Type = typeof(ListBuilder`1), Member = "ToArray", ReturnType = "T[]")]
	public virtual PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	[CalledBy(Type = typeof(RuntimeType), Member = "GetPropertyCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Type[]), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.PropertyInfo>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeStringMarshal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SafeStringMarshal), Member = "get_Value", ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(RuntimePropertyInfo), Member = "GetPropertyFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimePropertyHandle), typeof(RuntimeTypeHandle)}, ReturnType = typeof(PropertyInfo))]
	[Calls(Type = typeof(SafeStringMarshal), Member = "Dispose", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 11)]
	private RuntimePropertyInfo[] GetPropertiesByName(string name, BindingFlags bindingAttr, MemberListType listType, RuntimeType reflectedType) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private IntPtr GetPropertiesByName_native(IntPtr name, BindingFlags bindingAttr, MemberListType listType) { }

	[CalledBy(Type = typeof(RuntimeType), Member = "GetProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags)}, ReturnType = typeof(PropertyInfo[]))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags)}, ReturnType = typeof(MemberInfo[]))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetPropertyImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(Type), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(PropertyInfo))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(MemberTypes), typeof(BindingFlags)}, ReturnType = typeof(MemberInfo[]))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureInfo)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RuntimeType), Member = "GetPropertiesByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(MemberListType), typeof(RuntimeType)}, ReturnType = typeof(RuntimePropertyInfo[]))]
	[Calls(Type = typeof(ListBuilder`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ListBuilder`1), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private ListBuilder<PropertyInfo> GetPropertyCandidates(string name, BindingFlags bindingAttr, Type[] types, bool allowPrefixLookup) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeType), Member = "GetPropertyCandidates", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Type[]), typeof(bool)}, ReturnType = typeof(System.RuntimeType+ListBuilder`1<System.Reflection.PropertyInfo>))]
	[Calls(Type = typeof(Type), Member = "get_DefaultBinder", ReturnType = typeof(Binder))]
	[Calls(Type = typeof(ListBuilder`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(DefaultBinder), Member = "ExactPropertyBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo[]), typeof(Type), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(PropertyInfo))]
	[Calls(Type = typeof(ListBuilder`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(AmbiguousMatchException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	protected virtual PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "GetAssembly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(RuntimeAssembly))]
	[DeduplicatedMethod]
	internal RuntimeAssembly GetRuntimeAssembly() { }

	[CallerCount(Count = 8)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "GetModule", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(RuntimeModule))]
	[DeduplicatedMethod]
	internal RuntimeModule GetRuntimeModule() { }

	[CalledBy(Type = typeof(ObjectManager), Member = "CompleteISerializableObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(SerializationInfo), typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ObjectManager), Member = "GetConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(RuntimeConstructorInfo))]
	[CalledBy(Type = typeof(SafeSerializationManager), Member = "System.Runtime.Serialization.IObjectReference.GetRealObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StreamingContext)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetConstructor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(Binder), typeof(CallingConventions), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(ConstructorInfo))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 11)]
	internal RuntimeConstructorInfo GetSerializationCtor() { }

	[CalledBy(Type = typeof(Type), Member = "GetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool)}, ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(Type), Member = "GetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(Type), Member = "GetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Type))]
	[CalledBy(Type = typeof(TypeSpec), Member = "Resolve", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`2<System.Reflection.AssemblyName, System.Reflection.Assembly>), typeof(System.Func`4<System.Reflection.Assembly, System.String, System.Boolean, System.Type>), typeof(bool), typeof(bool), typeof(StackCrawlMark&)}, ReturnType = typeof(Type))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "GetTypeByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(bool), typeof(StackCrawlMark&), typeof(bool)}, ReturnType = typeof(RuntimeType))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal static RuntimeType GetType(string typeName, bool throwOnError, bool ignoreCase, bool reflectionOnly, ref StackCrawlMark stackMark) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual TypeCode GetTypeCodeImpl() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static TypeCode GetTypeCodeImplInternal(Type type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "HasElementType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(bool))]
	protected virtual bool HasElementTypeImpl() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeType), Member = "FilterApplyMethodBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(BindingFlags), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(BindingFlags), typeof(Binder), typeof(Object[]), typeof(CultureInfo), typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(MethodBase), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(MethodBase)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RuntimeType), Member = "FilterApplyMethodInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeMethodInfo), typeof(BindingFlags), typeof(CallingConventions), typeof(Type[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Array), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Type), Member = "get_IsArray", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_DefaultBinder", ReturnType = typeof(Binder))]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MissingMethodException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MissingFieldException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 39)]
	[CallsUnknownMethods(Count = 126)]
	[ContainsUnimplementedInstructions]
	[DebuggerHidden]
	[DebuggerStepThrough]
	public virtual object InvokeMember(string name, BindingFlags bindingFlags, Binder binder, object target, Object[] providedArgs, ParameterModifier[] modifiers, CultureInfo culture, String[] namedParams) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "IsArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(bool))]
	protected virtual bool IsArrayImpl() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "CanCastTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType), typeof(RuntimeType)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual bool IsAssignableFrom(Type c) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "IsByRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(bool))]
	protected virtual bool IsByRefImpl() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "IsComObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType), typeof(bool)}, ReturnType = typeof(bool))]
	protected virtual bool IsCOMObjectImpl() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "IsContextful", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(bool))]
	protected virtual bool IsContextfulImpl() { }

	[CalledBy(Type = typeof(RuntimeType), Member = "TryConvertToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeCode))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 52)]
	[ContainsUnimplementedInstructions]
	private static object IsConvertibleToPrimitiveType(object value, Type targetType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "IsDefined", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(Type), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "IsIntegerType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enum), Member = "InternalGetValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(UInt64[]))]
	[Calls(Type = typeof(Enum), Member = "ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(Array), Member = "BinarySearch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "T"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Enum), Member = "GetCachedValuesAndNames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType), typeof(bool)}, ReturnType = "System.Enum+ValuesAndNames")]
	[Calls(Type = typeof(Array), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(object)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 56)]
	[ContainsUnimplementedInstructions]
	public virtual bool IsEnumDefined(object value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual bool IsEquivalentTo(Type other) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	private bool IsGenericCOMObjectImpl() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "IsInstanceOfType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType), typeof(object)}, ReturnType = typeof(bool))]
	public virtual bool IsInstanceOfType(object o) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "IsPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(bool))]
	protected virtual bool IsPointerImpl() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "IsPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(bool))]
	protected virtual bool IsPrimitiveImpl() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeTypeHandle), Member = "IsSubclassOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType), typeof(RuntimeType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[ComVisible(True)]
	public virtual bool IsSubclassOf(Type type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 3)]
	protected virtual bool IsValueTypeImpl() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private Type make_array_type(int rank) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private Type make_byref_type() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual Type MakeArrayType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public virtual Type MakeArrayType(int rank) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeLoadException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public virtual Type MakeByRefType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "MakeGenericSignatureType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type[])}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(RuntimeType), Member = "SanityCheckGenericArguments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType[]), typeof(RuntimeType[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(TypeLoadException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 40)]
	public virtual Type MakeGenericType(Type[] instantiation) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static Type MakeGenericType(Type gt, Type[] types) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static Type MakePointerType(Type type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TypeLoadException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public virtual Type MakePointerType() { }

	[CallerCount(Count = 1987)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Equality(RuntimeType left, RuntimeType right) { }

	[CallerCount(Count = 544)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Inequality(RuntimeType left, RuntimeType right) { }

	[CalledBy(Type = typeof(RuntimeType), Member = "MakeGenericType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type[])}, ReturnType = typeof(Type))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RuntimeType), Member = "ThrowIfTypeNeverValidGenericArgument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 21)]
	internal static void SanityCheckGenericArguments(RuntimeType[] genericArguments, RuntimeType[] genericParamters) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 5)]
	private static void SplitName(string fullname, out string name, out string ns) { }

	[CalledBy(Type = typeof(RuntimeType), Member = "SanityCheckGenericArguments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType[]), typeof(RuntimeType[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Environment), Member = "GetResourceString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	private static void ThrowIfTypeNeverValidGenericArgument(RuntimeType type) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ToString() { }

	[CalledBy(Type = typeof(RuntimeType), Member = "CheckValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Binder), typeof(CultureInfo), typeof(BindingFlags)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsPrimitive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(RuntimeType), Member = "IsConvertibleToPrimitiveType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Enum), Member = "GetUnderlyingType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	private object TryConvertToType(object value, ref bool failed) { }

}

