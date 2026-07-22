namespace DG.Tweening.Plugins.Options;

public struct FloatOptions : IPlugOptions
{
	public bool snapping; //Field offset: 0x0

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public override void Reset() { }

}

