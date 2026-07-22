namespace UnityEngine.Categorization;

[AttributeUsage(AttributeTargets::Class (4), Inherited = False, AllowMultiple = False)]
public sealed class ElementInfoAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <Order>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private string <Name>k__BackingField; //Field offset: 0x18

	public int Order
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public ElementInfoAttribute() { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_Order(int value) { }

}

