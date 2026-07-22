namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets::Assembly (1), AllowMultiple = True, Inherited = False)]
public sealed class InternalsVisibleToAttribute : Attribute
{
	private string _assemblyName; //Field offset: 0x10
	private bool _allInternalsVisible; //Field offset: 0x18

	public bool AllInternalsVisible
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public InternalsVisibleToAttribute(string assemblyName) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_AllInternalsVisible(bool value) { }

}

