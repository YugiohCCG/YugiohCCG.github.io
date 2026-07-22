namespace System;

[ComVisible(True)]
public struct RuntimeTypeHandle : ISerializable
{
	private IntPtr value; //Field offset: 0x0

	public IntPtr Value
	{
		[CallerCount(Count = 138)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 26)]
	[DeduplicatedMethod]
	internal RuntimeTypeHandle(IntPtr val) { }

	[CalledBy(Type = typeof(RuntimeType), Member = "get_TypeHandle", ReturnType = typeof(RuntimeTypeHandle))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetMethodsByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(MemberListType), typeof(RuntimeType)}, ReturnType = typeof(RuntimeMethodInfo[]))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetConstructors_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(RuntimeType)}, ReturnType = typeof(RuntimeConstructorInfo[]))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetPropertiesByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(MemberListType), typeof(RuntimeType)}, ReturnType = typeof(RuntimePropertyInfo[]))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetFields_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(MemberListType), typeof(RuntimeType)}, ReturnType = typeof(RuntimeFieldInfo[]))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetEvents_internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(MemberListType), typeof(RuntimeType)}, ReturnType = typeof(RuntimeEventInfo[]))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	internal RuntimeTypeHandle(RuntimeType type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "GetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	private RuntimeTypeHandle(SerializationInfo info, StreamingContext context) { }

	[CalledBy(Type = typeof(RuntimeType), Member = "IsAssignableFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool CanCastTo(RuntimeType type, RuntimeType target) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	public IntPtr get_Value() { }

	[CalledBy(Type = typeof(RuntimeType), Member = "GetArrayRank", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static int GetArrayRank(RuntimeType type) { }

	[CalledBy(Type = typeof(RuntimeType), Member = "get_Assembly", ReturnType = typeof(Assembly))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetRuntimeAssembly", ReturnType = typeof(RuntimeAssembly))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal static RuntimeAssembly GetAssembly(RuntimeType type) { }

	[CalledBy(Type = typeof(RuntimeType), Member = "GetAttributeFlagsImpl", ReturnType = typeof(TypeAttributes))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static TypeAttributes GetAttributes(RuntimeType type) { }

	[CalledBy(Type = typeof(RuntimeType), Member = "GetBaseType", ReturnType = typeof(RuntimeType))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static RuntimeType GetBaseType(RuntimeType type) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static CorElementType GetCorElementType(RuntimeType type) { }

	[CalledBy(Type = typeof(RuntimeType), Member = "GetElementType", ReturnType = typeof(Type))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static RuntimeType GetElementType(RuntimeType type) { }

	[CalledBy(Type = typeof(RuntimeType), Member = "get_GenericParameterAttributes", ReturnType = typeof(GenericParameterAttributes))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetGenericParameterConstraints", ReturnType = typeof(Type[]))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetGenericParameterAttributes", ReturnType = typeof(GenericParameterAttributes))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	internal static IntPtr GetGenericParameterInfo(RuntimeType type) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal static Type GetGenericTypeDefinition(RuntimeType type) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private static Type GetGenericTypeDefinition_impl(RuntimeType type) { }

	[CallerCount(Count = 173)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private static int GetMetadataToken(RuntimeType type) { }

	[CalledBy(Type = typeof(RuntimeType), Member = "get_Module", ReturnType = typeof(Module))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetRuntimeModule", ReturnType = typeof(RuntimeModule))]
	[CalledBy(Type = typeof(RuntimeConstructorInfo), Member = "get_Module", ReturnType = typeof(Module))]
	[CalledBy(Type = typeof(RuntimeConstructorInfo), Member = "GetRuntimeModule", ReturnType = typeof(RuntimeModule))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	internal static RuntimeModule GetModule(RuntimeType type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(RuntimeTypeHandle))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SerializationInfo), Member = "AddValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal static int GetToken(RuntimeType type) { }

	[CalledBy(Type = typeof(RuntimeType), Member = "GetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(bool), typeof(StackCrawlMark&)}, ReturnType = typeof(RuntimeType))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Assembly), Member = "ReflectionOnlyLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Assembly))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TypeLoadException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 24)]
	internal static RuntimeType GetTypeByName(string typeName, bool throwOnError, bool ignoreCase, bool reflectionOnly, ref StackCrawlMark stackMark, bool loadTypeFromPartialName) { }

	[CalledBy(Type = typeof(RuntimeType), Member = "HasElementTypeImpl", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static bool HasElementType(RuntimeType type) { }

	[CalledBy(Type = typeof(RuntimeType), Member = "get_IsGenericType", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool HasInstantiation(RuntimeType type) { }

	[CalledBy(Type = typeof(RuntimeHelpers), Member = "IsReferenceOrContainsReferences", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool HasReferences(RuntimeType type) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static RuntimeType internal_from_name(string name, ref StackCrawlMark stackMark, Assembly callerAssembly, bool throwOnError, bool ignoreCase, bool reflectionOnly) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool is_subclass_of(IntPtr childType, IntPtr baseType) { }

	[CalledBy(Type = typeof(RuntimeType), Member = "IsArrayImpl", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static bool IsArray(RuntimeType type) { }

	[CalledBy(Type = typeof(RuntimeType), Member = "IsByRefImpl", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static bool IsByRef(RuntimeType type) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	internal static bool IsComObject(RuntimeType type) { }

	[CalledBy(Type = typeof(RuntimeType), Member = "IsCOMObjectImpl", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	internal static bool IsComObject(RuntimeType type, bool isGenericCOM) { }

	[CalledBy(Type = typeof(RuntimeType), Member = "IsContextfulImpl", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool IsContextful(RuntimeType type) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	internal static bool IsEquivalentTo(RuntimeType rtType1, RuntimeType rtType2) { }

	[CalledBy(Type = typeof(RuntimeType), Member = "get_IsGenericTypeDefinition", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool IsGenericTypeDefinition(RuntimeType type) { }

	[CalledBy(Type = typeof(RuntimeType), Member = "GetBaseType", ReturnType = typeof(RuntimeType))]
	[CalledBy(Type = typeof(RuntimeType), Member = "get_IsGenericParameter", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool IsGenericVariable(RuntimeType type) { }

	[CalledBy(Type = typeof(RuntimeType), Member = "IsInstanceOfType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static bool IsInstanceOfType(RuntimeType type, object o) { }

	[CalledBy(Type = typeof(Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "get_Attributes", ReturnType = typeof(TypeAttributes))]
	[CallsUnknownMethods(Count = 1)]
	internal static bool IsInterface(RuntimeType type) { }

	[CalledBy(Type = typeof(RuntimeType), Member = "IsPointerImpl", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static bool IsPointer(RuntimeType type) { }

	[CalledBy(Type = typeof(RuntimeType), Member = "IsPrimitiveImpl", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static bool IsPrimitive(RuntimeType type) { }

	[CalledBy(Type = typeof(RuntimeType), Member = "IsSubclassOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static bool IsSubclassOf(RuntimeType childType, RuntimeType baseType) { }

	[CalledBy(Type = typeof(RuntimeType), Member = "get_IsSzArray", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static bool IsSzArray(RuntimeType type) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static bool type_is_assignable_from(Type a, Type b) { }

}

