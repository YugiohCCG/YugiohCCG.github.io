namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::Class (4), Inherited = True)]
public sealed class TypeDescriptionProviderAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string <TypeName>k__BackingField; //Field offset: 0x10

	public string TypeName
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public TypeDescriptionProviderAttribute(string typeName) { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_TypeName() { }

}

