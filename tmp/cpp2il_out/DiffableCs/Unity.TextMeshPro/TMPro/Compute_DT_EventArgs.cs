namespace TMPro;

public class Compute_DT_EventArgs
{
	public Compute_DistanceTransform_EventTypes EventType; //Field offset: 0x10
	public float ProgressPercentage; //Field offset: 0x14
	public Color[] Colors; //Field offset: 0x18

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Compute_DT_EventArgs(Compute_DistanceTransform_EventTypes type, float progress) { }

	[CallerCount(Count = 157)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public Compute_DT_EventArgs(Compute_DistanceTransform_EventTypes type, Color[] colors) { }

}

