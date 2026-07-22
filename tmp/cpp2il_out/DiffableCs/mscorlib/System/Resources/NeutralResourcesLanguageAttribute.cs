namespace System.Resources;

[AttributeUsage(AttributeTargets::Assembly (1), AllowMultiple = False)]
public sealed class NeutralResourcesLanguageAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string <CultureName>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly UltimateResourceFallbackLocation <Location>k__BackingField; //Field offset: 0x18

	public string CultureName
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public UltimateResourceFallbackLocation Location
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public NeutralResourcesLanguageAttribute(string cultureName) { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_CultureName() { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public UltimateResourceFallbackLocation get_Location() { }

}

