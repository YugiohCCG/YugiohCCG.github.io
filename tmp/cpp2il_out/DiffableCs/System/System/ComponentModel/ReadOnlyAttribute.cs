namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::All (32767))]
public sealed class ReadOnlyAttribute : Attribute
{
	public static readonly ReadOnlyAttribute Yes; //Field offset: 0x0
	public static readonly ReadOnlyAttribute No; //Field offset: 0x8
	public static readonly ReadOnlyAttribute Default; //Field offset: 0x10
	[CompilerGenerated]
	private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x10

	public bool IsReadOnly
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private static ReadOnlyAttribute() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public ReadOnlyAttribute(bool isReadOnly) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_IsReadOnly() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool IsDefaultAttribute() { }

}

