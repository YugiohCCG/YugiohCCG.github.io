namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::All (32767))]
public sealed class DesignOnlyAttribute : Attribute
{
	public static readonly DesignOnlyAttribute Yes; //Field offset: 0x0
	public static readonly DesignOnlyAttribute No; //Field offset: 0x8
	public static readonly DesignOnlyAttribute Default; //Field offset: 0x10
	[CompilerGenerated]
	private readonly bool <IsDesignOnly>k__BackingField; //Field offset: 0x10

	public bool IsDesignOnly
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private static DesignOnlyAttribute() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DesignOnlyAttribute(bool isDesignOnly) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_IsDesignOnly() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool IsDefaultAttribute() { }

}

