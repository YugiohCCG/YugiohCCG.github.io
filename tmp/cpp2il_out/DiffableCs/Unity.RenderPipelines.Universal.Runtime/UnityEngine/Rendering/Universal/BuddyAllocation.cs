namespace UnityEngine.Rendering.Universal;

internal struct BuddyAllocation
{
	public int level; //Field offset: 0x0
	public int index; //Field offset: 0x4

	public uint2 index2D
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(SpaceFillingCurves), Member = "DecodeMorton2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint2))]
		 get { } //Length: 10
	}

	[CallerCount(Count = 104)]
	[DeduplicatedMethod]
	public BuddyAllocation(int level, int index) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SpaceFillingCurves), Member = "DecodeMorton2D", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint2))]
	public uint2 get_index2D() { }

}

