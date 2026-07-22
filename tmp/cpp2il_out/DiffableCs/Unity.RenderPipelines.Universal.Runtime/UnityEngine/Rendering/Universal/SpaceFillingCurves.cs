namespace UnityEngine.Rendering.Universal;

internal static class SpaceFillingCurves
{

	[CallerCount(Count = 0)]
	private static uint Compact1By1(uint x) { }

	[CalledBy(Type = typeof(BuddyAllocation), Member = "get_index2D", ReturnType = typeof(uint2))]
	[CalledBy(Type = typeof(ReflectionProbeManager), Member = "GetScaleOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(float4))]
	[CallerCount(Count = 2)]
	public static uint2 DecodeMorton2D(uint code) { }

	[CallerCount(Count = 0)]
	public static uint EncodeMorton2D(uint2 coord) { }

	[CallerCount(Count = 0)]
	private static uint Part1By1(uint x) { }

}

