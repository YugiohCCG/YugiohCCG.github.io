namespace UnityEngine.Rendering;

internal struct BinningConfig
{
	public int viewCount; //Field offset: 0x0
	public bool supportsCrossFade; //Field offset: 0x4
	public bool supportsMotionCheck; //Field offset: 0x5

	public int visibilityConfigCount
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 38
	}

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public int get_visibilityConfigCount() { }

}

