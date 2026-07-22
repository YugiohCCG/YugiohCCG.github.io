namespace UnityEngine.Rendering;

public class BatchLayer
{
	public const byte InstanceCullingDirect = 29; //Field offset: 0x0
	public const byte InstanceCullingIndirect = 28; //Field offset: 0x0
	public const uint InstanceCullingDirectMask = 536870912; //Field offset: 0x0
	public const uint InstanceCullingIndirectMask = 268435456; //Field offset: 0x0
	public const uint InstanceCullingMask = 805306368; //Field offset: 0x0

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public BatchLayer() { }

}

