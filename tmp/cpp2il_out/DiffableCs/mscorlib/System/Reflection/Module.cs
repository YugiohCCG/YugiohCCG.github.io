namespace System.Reflection;

public abstract class Module : ICustomAttributeProvider, ISerializable, _Module
{
	public static readonly TypeFilter FilterTypeName; //Field offset: 0x0
	private const BindingFlags DefaultLookup = 28; //Field offset: 0x0
	public static readonly TypeFilter FilterTypeNameIgnoreCase; //Field offset: 0x8

	public override Assembly Assembly
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotImplemented), Member = "get_ByDesign", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 39
	}

	public override Guid ModuleVersionId
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotImplemented), Member = "get_ByDesign", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 39
	}

	public override string ScopeName
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotImplemented), Member = "get_ByDesign", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 39
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static Module() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected Module() { }

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual bool Equals(object o) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(string), typeof(int), typeof(int), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(InvalidFilterCriteriaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	private static bool FilterTypeNameIgnoreCaseImpl(Type cls, object filterCriteria) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(StringComparison)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(InvalidFilterCriteriaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private static bool FilterTypeNameImpl(Type cls, object filterCriteria) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplemented), Member = "get_ByDesign", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	public override Assembly get_Assembly() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplemented), Member = "get_ByDesign", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	public override Guid get_ModuleVersionId() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplemented), Member = "get_ByDesign", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	public override string get_ScopeName() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplemented), Member = "get_ByDesign", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	public override Object[] GetCustomAttributes(bool inherit) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplemented), Member = "get_ByDesign", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	public override Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	[CallerCount(Count = 19)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal override Guid GetModuleVersionId() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplemented), Member = "get_ByDesign", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplemented), Member = "get_ByDesign", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	public override bool IsDefined(Type attributeType, bool inherit) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplemented), Member = "get_ByDesign", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	public override bool IsResource() { }

	[CallerCount(Count = 264)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public static bool op_Equality(Module left, Module right) { }

	[CallerCount(Count = 44)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual string ToString() { }

}

