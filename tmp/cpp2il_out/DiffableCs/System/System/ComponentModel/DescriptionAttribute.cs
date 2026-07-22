namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::All (32767))]
public class DescriptionAttribute : Attribute
{
	public static readonly DescriptionAttribute Default; //Field offset: 0x0
	[CompilerGenerated]
	private string <DescriptionValue>k__BackingField; //Field offset: 0x10

	public override string Description
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	protected string DescriptionValue
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static DescriptionAttribute() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public DescriptionAttribute() { }

	[CallerCount(Count = 27)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public DescriptionAttribute(string description) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public override string get_Description() { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected string get_DescriptionValue() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual bool IsDefaultAttribute() { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	protected void set_DescriptionValue(string value) { }

}

