namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets::Field (256), Inherited = False)]
public sealed class FixedBufferAttribute : Attribute
{
	[CompilerGenerated]
	private readonly Type <ElementType>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly int <Length>k__BackingField; //Field offset: 0x18

	public Type ElementType
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public int Length
	{
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public FixedBufferAttribute(Type elementType, int length) { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public Type get_ElementType() { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public int get_Length() { }

}

