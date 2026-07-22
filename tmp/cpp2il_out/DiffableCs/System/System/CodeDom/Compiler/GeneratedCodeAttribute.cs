namespace System.CodeDom.Compiler;

[AttributeUsage(AttributeTargets::All (32767), Inherited = False, AllowMultiple = False)]
public sealed class GeneratedCodeAttribute : Attribute
{
	private readonly string tool; //Field offset: 0x10
	private readonly string version; //Field offset: 0x18

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public GeneratedCodeAttribute(string tool, string version) { }

}

