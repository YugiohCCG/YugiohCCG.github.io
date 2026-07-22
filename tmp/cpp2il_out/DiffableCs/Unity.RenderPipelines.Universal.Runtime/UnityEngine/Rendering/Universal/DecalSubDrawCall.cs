namespace UnityEngine.Rendering.Universal;

internal struct DecalSubDrawCall
{
	public int start; //Field offset: 0x0
	public int end; //Field offset: 0x4

	public int count
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 6
	}

	[CallerCount(Count = 0)]
	public int get_count() { }

}

