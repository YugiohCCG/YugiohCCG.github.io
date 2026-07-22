namespace UnityEngine.Rendering;

public struct SortingLayerRange : IEquatable<SortingLayerRange>
{
	private short m_LowerBound; //Field offset: 0x0
	private short m_UpperBound; //Field offset: 0x2

	public static SortingLayerRange all
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 13
	}

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(SortingLayerRange other) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	public static SortingLayerRange get_all() { }

	[CallerCount(Count = 0)]
	public virtual int GetHashCode() { }

}

