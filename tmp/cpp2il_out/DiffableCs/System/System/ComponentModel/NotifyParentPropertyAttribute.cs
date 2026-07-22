namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::Property (128))]
public sealed class NotifyParentPropertyAttribute : Attribute
{
	public static readonly NotifyParentPropertyAttribute Yes; //Field offset: 0x0
	public static readonly NotifyParentPropertyAttribute No; //Field offset: 0x8
	public static readonly NotifyParentPropertyAttribute Default; //Field offset: 0x10
	private bool notifyParent; //Field offset: 0x10

	public bool NotifyParent
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private static NotifyParentPropertyAttribute() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public NotifyParentPropertyAttribute(bool notifyParent) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_NotifyParent() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual bool IsDefaultAttribute() { }

}

