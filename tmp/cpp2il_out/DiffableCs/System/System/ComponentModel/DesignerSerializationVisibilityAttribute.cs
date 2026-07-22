namespace System.ComponentModel;

[AttributeUsage(960)]
public sealed class DesignerSerializationVisibilityAttribute : Attribute
{
	public static readonly DesignerSerializationVisibilityAttribute Content; //Field offset: 0x0
	public static readonly DesignerSerializationVisibilityAttribute Hidden; //Field offset: 0x8
	public static readonly DesignerSerializationVisibilityAttribute Visible; //Field offset: 0x10
	public static readonly DesignerSerializationVisibilityAttribute Default; //Field offset: 0x18
	[CompilerGenerated]
	private readonly DesignerSerializationVisibility <Visibility>k__BackingField; //Field offset: 0x10

	public DesignerSerializationVisibility Visibility
	{
		[CallerCount(Count = 94)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private static DesignerSerializationVisibilityAttribute() { }

	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility visibility) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 94)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public DesignerSerializationVisibility get_Visibility() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Attribute), Member = "GetHashCode", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual bool IsDefaultAttribute() { }

}

