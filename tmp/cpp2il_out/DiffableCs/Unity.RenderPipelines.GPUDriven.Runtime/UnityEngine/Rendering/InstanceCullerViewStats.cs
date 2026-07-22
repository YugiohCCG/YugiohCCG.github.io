namespace UnityEngine.Rendering;

internal struct InstanceCullerViewStats
{
	public BatchCullingViewType viewType; //Field offset: 0x0
	public int viewInstanceID; //Field offset: 0x4
	public int splitIndex; //Field offset: 0x8
	public int visibleInstancesOnCPU; //Field offset: 0xC
	public int visibleInstancesOnGPU; //Field offset: 0x10
	public int visiblePrimitivesOnCPU; //Field offset: 0x14
	public int visiblePrimitivesOnGPU; //Field offset: 0x18
	public int drawCommands; //Field offset: 0x1C

}

