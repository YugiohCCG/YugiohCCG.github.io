namespace System.Runtime.CompilerServices;

[AttributeUsage(5148, Inherited = False, AllowMultiple = False)]
public sealed class TypeForwardedFromAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string <AssemblyFullName>k__BackingField; //Field offset: 0x10

	public string AssemblyFullName
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public TypeForwardedFromAttribute(string assemblyFullName) { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_AssemblyFullName() { }

}

