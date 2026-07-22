namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::All (32767))]
public sealed class ListBindableAttribute : Attribute
{
	public static readonly ListBindableAttribute Yes; //Field offset: 0x0
	public static readonly ListBindableAttribute No; //Field offset: 0x8
	public static readonly ListBindableAttribute Default; //Field offset: 0x10
	private bool _isDefault; //Field offset: 0x10
	[CompilerGenerated]
	private readonly bool <ListBindable>k__BackingField; //Field offset: 0x11

	public bool ListBindable
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private static ListBindableAttribute() { }

	[CalledBy(Type = "System.Data.DataColumnPropertyDescriptor", Member = "get_Attributes", ReturnType = typeof(AttributeCollection))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public ListBindableAttribute(bool listBindable) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_ListBindable() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual bool IsDefaultAttribute() { }

}

