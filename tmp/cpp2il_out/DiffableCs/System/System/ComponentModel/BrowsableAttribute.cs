namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::All (32767))]
public sealed class BrowsableAttribute : Attribute
{
	public static readonly BrowsableAttribute Yes; //Field offset: 0x0
	public static readonly BrowsableAttribute No; //Field offset: 0x8
	public static readonly BrowsableAttribute Default; //Field offset: 0x10
	[CompilerGenerated]
	private readonly bool <Browsable>k__BackingField; //Field offset: 0x10

	public bool Browsable
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private static BrowsableAttribute() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public BrowsableAttribute(bool browsable) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_Browsable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual bool IsDefaultAttribute() { }

}

