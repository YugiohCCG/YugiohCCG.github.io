namespace UnityEngine.Rendering;

[UsedByNativeCode]
public struct VertexAttributeDescriptor : IEquatable<VertexAttributeDescriptor>
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private VertexAttribute <attribute>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private VertexAttributeFormat <format>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <dimension>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <stream>k__BackingField; //Field offset: 0xC

	public VertexAttribute attribute
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

	public int dimension
	{
		[CallerCount(Count = 28)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 4
		[CallerCount(Count = 4)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public VertexAttributeFormat format
	{
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 4
		[CallerCount(Count = 9)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public int stream
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[IsReadOnly]
		 get { } //Length: 4
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CallerCount(Count = 19)]
	[DeduplicatedMethod]
	public VertexAttributeDescriptor(VertexAttribute attribute = 0, VertexAttributeFormat format = 0, int dimension = 3, int stream = 0) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object other) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool Equals(VertexAttributeDescriptor other) { }

	[CallerCount(Count = 173)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public VertexAttribute get_attribute() { }

	[CallerCount(Count = 28)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public int get_dimension() { }

	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public VertexAttributeFormat get_format() { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[IsReadOnly]
	public int get_stream() { }

	[CallerCount(Count = 0)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_attribute(VertexAttribute value) { }

	[CallerCount(Count = 4)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_dimension(int value) { }

	[CallerCount(Count = 9)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_format(VertexAttributeFormat value) { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_stream(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 18)]
	public virtual string ToString() { }

}

