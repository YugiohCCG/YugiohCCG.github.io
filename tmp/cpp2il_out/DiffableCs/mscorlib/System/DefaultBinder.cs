namespace System;

internal class DefaultBinder : Binder
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<Type> <>9__2_0; //Field offset: 0x8

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		internal bool <SelectProperty>b__2_0(Type t) { }

	}

	public class BinderState
	{
		internal Int32[] m_argsMap; //Field offset: 0x10
		internal int m_originalSize; //Field offset: 0x18
		internal bool m_isParamArray; //Field offset: 0x1C

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal BinderState(Int32[] argsMap, int originalSize, bool isParamArray) { }

	}

	[Flags]
	private enum Primitives
	{
		Boolean = 8,
		Char = 16,
		SByte = 32,
		Byte = 64,
		Int16 = 128,
		UInt16 = 256,
		Int32 = 512,
		UInt32 = 1024,
		Int64 = 2048,
		UInt64 = 4096,
		Single = 8192,
		Double = 16384,
		Decimal = 32768,
		DateTime = 65536,
		String = 262144,
	}

	private static Primitives[] _primitiveConversions; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static DefaultBinder() { }

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DefaultBinder() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "get_IsClass", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "get_IsPrimitive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DefaultBinder), Member = "CanConvertPrimitiveObjectToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(RuntimeType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DefaultBinder), Member = "GetHierarchyDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MissingFieldException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AmbiguousMatchException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 33)]
	[ContainsUnimplementedInstructions]
	public virtual FieldInfo BindToField(BindingFlags bindingAttr, FieldInfo[] match, object value, CultureInfo cultureInfo) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MissingMethodException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AmbiguousMatchException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "UnsafeCreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Int32[])}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DefaultBinder), Member = "ReorderParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(DefaultBinder), Member = "FindMostSpecificMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(Int32[]), typeof(Type), typeof(MethodBase), typeof(Int32[]), typeof(Type), typeof(Type[]), typeof(Object[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DefaultBinder), Member = "CanConvertPrimitiveObjectToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(RuntimeType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsCOMObject", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsPrimitive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "get_IsArray", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MethodBase), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(MethodBase)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(DefaultBinder), Member = "CreateParamOrder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(ParameterInfo[]), typeof(String[])}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 53)]
	[CallsUnknownMethods(Count = 101)]
	public virtual MethodBase BindToMethod(BindingFlags bindingAttr, MethodBase[] match, ref Object[] args, ParameterModifier[] modifiers, CultureInfo cultureInfo, String[] names, out object state) { }

	[CalledBy(Type = typeof(DefaultBinder), Member = "SelectMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(MethodBase[]), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodBase))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeCode))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static bool CanChangePrimitive(Type source, Type target) { }

	[CalledBy(Type = typeof(DefaultBinder), Member = "SelectProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(PropertyInfo[]), typeof(Type), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(PropertyInfo))]
	[CalledBy(Type = typeof(DefaultBinder), Member = "FindMostSpecificType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(Type)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Type), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeCode))]
	[Calls(Type = typeof(Type), Member = "get_IsPrimitive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private static bool CanConvertPrimitive(RuntimeType source, RuntimeType target) { }

	[CalledBy(Type = typeof(DefaultBinder), Member = "BindToMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(MethodBase[]), typeof(Object[]&), typeof(ParameterModifier[]), typeof(CultureInfo), typeof(String[]), typeof(Object&)}, ReturnType = typeof(MethodBase))]
	[CalledBy(Type = typeof(DefaultBinder), Member = "BindToField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(FieldInfo[]), typeof(object), typeof(CultureInfo)}, ReturnType = typeof(FieldInfo))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsInvalidInstructions]
	private static bool CanConvertPrimitiveObjectToType(object source, RuntimeType type) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeCode))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static bool CanPrimitiveWiden(Type source, Type target) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public virtual object ChangeType(object value, Type type, CultureInfo cultureInfo) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal static bool CompareMethodSig(MethodBase m1, MethodBase m2) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal static bool CompareMethodSigAndName(MethodBase m1, MethodBase m2) { }

	[CalledBy(Type = typeof(DefaultBinder), Member = "BindToMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(MethodBase[]), typeof(Object[]&), typeof(ParameterModifier[]), typeof(CultureInfo), typeof(String[]), typeof(Object&)}, ReturnType = typeof(MethodBase))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static bool CreateParamOrder(Int32[] paramOrder, ParameterInfo[] pars, String[] names) { }

	[CalledBy(Type = typeof(RuntimeType), Member = "GetConstructorImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(Binder), typeof(CallingConventions), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(ConstructorInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DefaultBinder), Member = "FindMostDerivedNewSlotMeth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase[]), typeof(int)}, ReturnType = typeof(MethodBase))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	public static MethodBase ExactBinding(MethodBase[] match, Type[] types, ParameterModifier[] modifiers) { }

	[CalledBy(Type = typeof(RuntimeType), Member = "GetPropertyImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags), typeof(Binder), typeof(Type), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(PropertyInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AmbiguousMatchException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 10)]
	public static PropertyInfo ExactPropertyBinding(PropertyInfo[] match, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	[CalledBy(Type = typeof(DefaultBinder), Member = "ExactBinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase[]), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodBase))]
	[CalledBy(Type = typeof(RuntimeType), Member = "GetMethodImplCommon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(BindingFlags), typeof(Binder), typeof(CallingConventions), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodInfo))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(AmbiguousMatchException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	internal static MethodBase FindMostDerivedNewSlotMeth(MethodBase[] match, int cMatches) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DefaultBinder), Member = "FindMostSpecificType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(Type)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 2)]
	private static int FindMostSpecific(ParameterInfo[] p1, Int32[] paramOrder1, Type paramArrayType1, ParameterInfo[] p2, Int32[] paramOrder2, Type paramArrayType2, Type[] types, Object[] args) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DefaultBinder), Member = "GetHierarchyDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static int FindMostSpecificField(FieldInfo cur1, FieldInfo cur2) { }

	[CalledBy(Type = typeof(DefaultBinder), Member = "BindToMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(MethodBase[]), typeof(Object[]&), typeof(ParameterModifier[]), typeof(CultureInfo), typeof(String[]), typeof(Object&)}, ReturnType = typeof(MethodBase))]
	[CalledBy(Type = typeof(DefaultBinder), Member = "SelectMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(MethodBase[]), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(MethodBase))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DefaultBinder), Member = "FindMostSpecificType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(Type)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DefaultBinder), Member = "GetHierarchyDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static int FindMostSpecificMethod(MethodBase m1, Int32[] paramOrder1, Type paramArrayType1, MethodBase m2, Int32[] paramOrder2, Type paramArrayType2, Type[] types, Object[] args) { }

	[CalledBy(Type = typeof(DefaultBinder), Member = "SelectProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(PropertyInfo[]), typeof(Type), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(PropertyInfo))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DefaultBinder), Member = "GetHierarchyDepth", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static int FindMostSpecificProperty(PropertyInfo cur1, PropertyInfo cur2) { }

	[CalledBy(Type = typeof(DefaultBinder), Member = "SelectProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(PropertyInfo[]), typeof(Type), typeof(Type[]), typeof(ParameterModifier[])}, ReturnType = typeof(PropertyInfo))]
	[CalledBy(Type = typeof(DefaultBinder), Member = "FindMostSpecific", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterInfo[]), typeof(Int32[]), typeof(Type), typeof(ParameterInfo[]), typeof(Int32[]), typeof(Type), typeof(Type[]), typeof(Object[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DefaultBinder), Member = "FindMostSpecificMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(Int32[]), typeof(Type), typeof(MethodBase), typeof(Int32[]), typeof(Type), typeof(Type[]), typeof(Object[])}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Type), Member = "get_IsByRef", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "get_IsPrimitive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DefaultBinder), Member = "CanConvertPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType), typeof(RuntimeType)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 5)]
	private static int FindMostSpecificType(Type c1, Type c2, Type t) { }

	[CalledBy(Type = typeof(DefaultBinder), Member = "BindToField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(FieldInfo[]), typeof(object), typeof(CultureInfo)}, ReturnType = typeof(FieldInfo))]
	[CalledBy(Type = typeof(DefaultBinder), Member = "FindMostSpecificMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(Int32[]), typeof(Type), typeof(MethodBase), typeof(Int32[]), typeof(Type), typeof(Type[]), typeof(Object[])}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DefaultBinder), Member = "FindMostSpecificField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(FieldInfo), typeof(FieldInfo)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(DefaultBinder), Member = "FindMostSpecificProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo), typeof(PropertyInfo)}, ReturnType = typeof(int))]
	[CallerCount(Count = 8)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	internal static int GetHierarchyDepth(Type t) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DefaultBinder), Member = "ReorderParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(Object[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 19)]
	public virtual void ReorderArgumentArray(ref Object[] args, object state) { }

	[CalledBy(Type = typeof(DefaultBinder), Member = "BindToMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BindingFlags), typeof(MethodBase[]), typeof(Object[]&), typeof(ParameterModifier[]), typeof(CultureInfo), typeof(String[]), typeof(Object&)}, ReturnType = typeof(MethodBase))]
	[CalledBy(Type = typeof(DefaultBinder), Member = "ReorderArgumentArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]&), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	private static void ReorderParams(Int32[] paramOrder, Object[] vars) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "IsRuntimeImplemented", ReturnType = typeof(bool))]
	[Calls(Type = typeof(SignatureTypeExtensions), Member = "MatchesParameterTypeExactly", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(ParameterInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SignatureTypeExtensions), Member = "TryResolveAgainstGenericMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SignatureType), typeof(MethodInfo)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "get_IsPrimitive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DefaultBinder), Member = "CanChangePrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DefaultBinder), Member = "FindMostSpecificMethod", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MethodBase), typeof(Int32[]), typeof(Type), typeof(MethodBase), typeof(Int32[]), typeof(Type), typeof(Type[]), typeof(Object[])}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AmbiguousMatchException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 26)]
	public virtual MethodBase SelectMethod(BindingFlags bindingAttr, MethodBase[] match, Type[] types, ParameterModifier[] modifiers) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Predicate`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Contract), Member = "ForAll", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<T>", "System.Predicate`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Type), Member = "get_IsPrimitive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(DefaultBinder), Member = "CanConvertPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeType), typeof(RuntimeType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DefaultBinder), Member = "FindMostSpecificType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type), typeof(Type)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(DefaultBinder), Member = "FindMostSpecificProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyInfo), typeof(PropertyInfo)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AmbiguousMatchException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 32)]
	[CallsUnknownMethods(Count = 26)]
	[ContainsUnimplementedInstructions]
	public virtual PropertyInfo SelectProperty(BindingFlags bindingAttr, PropertyInfo[] match, Type returnType, Type[] indexes, ParameterModifier[] modifiers) { }

}

