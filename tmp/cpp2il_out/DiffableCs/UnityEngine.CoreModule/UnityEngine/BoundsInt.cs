namespace UnityEngine;

[UsedByNativeCode]
public struct BoundsInt : IEquatable<BoundsInt>, IFormattable
{
	private Vector3Int m_Position; //Field offset: 0x0
	private Vector3Int m_Size; //Field offset: 0xC

	public Vector3Int position
	{
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		 get { } //Length: 18
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 15
	}

	public Vector3Int size
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 19
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 16
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public BoundsInt(Vector3Int position, Vector3Int size) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object other) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(BoundsInt other) { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public Vector3Int get_position() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public Vector3Int get_size() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3Int), Member = "GetHashCode", ReturnType = typeof(int))]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_position(Vector3Int value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_size(Vector3Int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = "UnityEngine.UnityString", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	public override string ToString(string format, IFormatProvider formatProvider) { }

}

