namespace System.Reflection;

[AttributeUsage(1036)]
public sealed class DefaultMemberAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string <MemberName>k__BackingField; //Field offset: 0x10

	public string MemberName
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 27)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public DefaultMemberAttribute(string memberName) { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_MemberName() { }

}

