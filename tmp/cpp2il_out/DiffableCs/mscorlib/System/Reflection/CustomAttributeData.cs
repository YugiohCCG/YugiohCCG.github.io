namespace System.Reflection;

[ComVisible(True)]
public class CustomAttributeData
{
	private class LazyCAttrData
	{
		internal Assembly assembly; //Field offset: 0x10
		internal IntPtr data; //Field offset: 0x18
		internal uint data_length; //Field offset: 0x20

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public LazyCAttrData() { }

	}

	private ConstructorInfo ctorInfo; //Field offset: 0x10
	private IList<CustomAttributeTypedArgument> ctorArgs; //Field offset: 0x18
	private IList<CustomAttributeNamedArgument> namedArgs; //Field offset: 0x20
	private LazyCAttrData lazyData; //Field offset: 0x28

	public Type AttributeType
	{
		[CallerCount(Count = 12)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 39
	}

	[ComVisible(True)]
	public override ConstructorInfo Constructor
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[ComVisible(True)]
	public override IList<CustomAttributeTypedArgument> ConstructorArguments
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CustomAttributeData), Member = "ResolveArguments", ReturnType = typeof(void))]
		 get { } //Length: 26
	}

	public override IList<CustomAttributeNamedArgument> NamedArguments
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CustomAttributeData), Member = "ResolveArguments", ReturnType = typeof(void))]
		 get { } //Length: 26
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected CustomAttributeData() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	internal CustomAttributeData(ConstructorInfo ctorInfo, Assembly assembly, IntPtr data, uint data_length) { }

	[CalledBy(Type = typeof(MonoCustomAttrs), Member = "GetPseudoCustomAttributesData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(CustomAttributeData[]))]
	[CalledBy(Type = typeof(FieldInfo), Member = "GetPseudoCustomAttributesData", ReturnType = typeof(CustomAttributeData[]))]
	[CalledBy(Type = typeof(RuntimeMethodInfo), Member = "GetPseudoCustomAttributesData", ReturnType = typeof(CustomAttributeData[]))]
	[CalledBy(Type = typeof(RuntimeParameterInfo), Member = "GetPseudoCustomAttributesData", ReturnType = typeof(CustomAttributeData[]))]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal CustomAttributeData(ConstructorInfo ctorInfo) { }

	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	internal CustomAttributeData(ConstructorInfo ctorInfo, IList<CustomAttributeTypedArgument> ctorArgs, IList<CustomAttributeNamedArgument> namedArgs) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConstructorInfo), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConstructorInfo), typeof(ConstructorInfo)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 12)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public Type get_AttributeType() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public override ConstructorInfo get_Constructor() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CustomAttributeData), Member = "ResolveArguments", ReturnType = typeof(void))]
	public override IList<CustomAttributeTypedArgument> get_ConstructorArguments() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CustomAttributeData), Member = "ResolveArguments", ReturnType = typeof(void))]
	public override IList<CustomAttributeNamedArgument> get_NamedArguments() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributesData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(bool)}, ReturnType = typeof(System.Collections.Generic.IList`1<System.Reflection.CustomAttributeData>))]
	public static IList<CustomAttributeData> GetCustomAttributes(ParameterInfo target) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributesData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(bool)}, ReturnType = typeof(System.Collections.Generic.IList`1<System.Reflection.CustomAttributeData>))]
	public static IList<CustomAttributeData> GetCustomAttributes(Module target) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributesData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(bool)}, ReturnType = typeof(System.Collections.Generic.IList`1<System.Reflection.CustomAttributeData>))]
	public static IList<CustomAttributeData> GetCustomAttributes(Assembly target) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributesData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(bool)}, ReturnType = typeof(System.Collections.Generic.IList`1<System.Reflection.CustomAttributeData>))]
	[DeduplicatedMethod]
	public static IList<CustomAttributeData> GetCustomAttributes(MemberInfo target) { }

	[CalledBy(Type = typeof(RuntimeType), Member = "GetCustomAttributesData", ReturnType = typeof(System.Collections.Generic.IList`1<System.Reflection.CustomAttributeData>))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MonoCustomAttrs), Member = "GetCustomAttributesData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ICustomAttributeProvider), typeof(bool)}, ReturnType = typeof(System.Collections.Generic.IList`1<System.Reflection.CustomAttributeData>))]
	internal static IList<CustomAttributeData> GetCustomAttributesInternal(RuntimeType target) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValueType), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	public virtual int GetHashCode() { }

	[CalledBy(Type = typeof(CustomAttributeData), Member = "get_ConstructorArguments", ReturnType = typeof(System.Collections.Generic.IList`1<System.Reflection.CustomAttributeTypedArgument>))]
	[CalledBy(Type = typeof(CustomAttributeData), Member = "get_NamedArguments", ReturnType = typeof(System.Collections.Generic.IList`1<System.Reflection.CustomAttributeNamedArgument>))]
	[CalledBy(Type = typeof(CustomAttributeData), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CustomAttributeData), Member = "UnboxValues", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CustomAttributeTypedArgument)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = typeof(CustomAttributeTypedArgument[]))]
	[Calls(Type = typeof(Array), Member = "AsReadOnly", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<T>")]
	[Calls(Type = typeof(CustomAttributeData), Member = "UnboxValues", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[])}, ReturnType = "T[]")]
	[CallsUnknownMethods(Count = 6)]
	private void ResolveArguments() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private static void ResolveArgumentsInternal(ConstructorInfo ctor, Assembly assembly, IntPtr data, uint data_length, out Object[] ctorArgs, out Object[] namedArgs) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CustomAttributeData), Member = "ResolveArguments", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(CustomAttributeTypedArgument), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CustomAttributeNamedArgument), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 8)]
	public virtual string ToString() { }

	[CalledBy(Type = typeof(CustomAttributeData), Member = "ResolveArguments", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	private static T[] UnboxValues(Object[] values) { }

}

