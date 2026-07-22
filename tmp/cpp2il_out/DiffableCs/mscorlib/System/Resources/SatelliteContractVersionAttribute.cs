namespace System.Resources;

[AttributeUsage(AttributeTargets::Assembly (1), AllowMultiple = False)]
public sealed class SatelliteContractVersionAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string <Version>k__BackingField; //Field offset: 0x10

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public SatelliteContractVersionAttribute(string version) { }

}

