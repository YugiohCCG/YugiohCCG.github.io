namespace UnityEngine.Rendering;

internal struct GPUInstanceIndex : IEquatable<GPUInstanceIndex>, IComparable<GPUInstanceIndex>
{
	public static readonly GPUInstanceIndex Invalid; //Field offset: 0x0
	[CompilerGenerated]
	private int <index>k__BackingField; //Field offset: 0x0

	public int index
	{
		[CallerCount(Count = 173)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 3
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 3
	}

	public bool valid
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 70
	}

	[CallerCount(Count = 0)]
	private static GPUInstanceIndex() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	public override int CompareTo(GPUInstanceIndex other) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(GPUInstanceIndex other) { }

	[CallerCount(Count = 173)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public int get_index() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public bool get_valid() { }

	[CallerCount(Count = 0)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_index(int value) { }

}

