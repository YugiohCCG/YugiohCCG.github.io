namespace System.Reflection;

public abstract class TypeInfo : Type, IReflectableType
{

	public override IEnumerable<PropertyInfo> DeclaredProperties
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 get { } //Length: 22
	}

	public override IEnumerable<Type> ImplementedInterfaces
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MemoryExtensions), Member = "IsTypeComparableAsBytes", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64&)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(SpanHelpers), Member = "SequenceEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char&), typeof(Char&), typeof(int)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(SpanHelpers), Member = "SequenceEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(Byte&), typeof(ulong)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 451
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected TypeInfo() { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	public override Type AsType() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override IEnumerable<PropertyInfo> get_DeclaredProperties() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MemoryExtensions), Member = "IsTypeComparableAsBytes", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SpanHelpers), Member = "SequenceEqual", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char&), typeof(Char&), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SpanHelpers), Member = "SequenceEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(Byte&), typeof(ulong)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	public override IEnumerable<Type> get_ImplementedInterfaces() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override FieldInfo GetDeclaredField(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BindingFlags)}, ReturnType = typeof(PropertyInfo))]
	public override PropertyInfo GetDeclaredProperty(string name) { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	private override TypeInfo System.Reflection.IReflectableType.GetTypeInfo() { }

}

