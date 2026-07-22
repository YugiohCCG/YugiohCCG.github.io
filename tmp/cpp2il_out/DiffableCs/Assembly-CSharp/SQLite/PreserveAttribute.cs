namespace SQLite;

public sealed class PreserveAttribute : Attribute
{
	public bool AllMembers; //Field offset: 0x10
	public bool Conditional; //Field offset: 0x11

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public PreserveAttribute() { }

}

