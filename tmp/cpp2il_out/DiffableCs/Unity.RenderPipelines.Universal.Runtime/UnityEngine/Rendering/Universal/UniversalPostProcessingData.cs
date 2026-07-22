namespace UnityEngine.Rendering.Universal;

public class UniversalPostProcessingData : ContextItem
{
	public bool isEnabled; //Field offset: 0x10
	public ColorGradingMode gradingMode; //Field offset: 0x14
	public int lutSize; //Field offset: 0x18
	public bool useFastSRGBLinearConversion; //Field offset: 0x1C
	public bool supportScreenSpaceLensFlare; //Field offset: 0x1D
	public bool supportDataDrivenLensFlare; //Field offset: 0x1E

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public UniversalPostProcessingData() { }

	[CallerCount(Count = 0)]
	public virtual void Reset() { }

}

