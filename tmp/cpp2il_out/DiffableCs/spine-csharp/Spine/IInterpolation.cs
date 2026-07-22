namespace Spine;

public abstract class IInterpolation
{
	public static IInterpolation Pow2; //Field offset: 0x0
	public static IInterpolation Pow2Out; //Field offset: 0x8

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static IInterpolation() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected IInterpolation() { }

	protected abstract float Apply(float a) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public float Apply(float start, float end, float a) { }

}

