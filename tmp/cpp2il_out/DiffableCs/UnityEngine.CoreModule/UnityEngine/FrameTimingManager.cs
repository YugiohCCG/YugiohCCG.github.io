namespace UnityEngine;

[StaticAccessor("GetUncheckedRealGfxDevice().GetFrameTimingManager()", StaticAccessorType::Dot (0))]
public static class FrameTimingManager
{

	[CalledBy(Type = "UnityEngine.Rendering.DebugFrameTiming", Member = "UpdateFrameTiming", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static void CaptureFrameTimings() { }

	[CalledBy(Type = "UnityEngine.Rendering.DebugFrameTiming", Member = "UpdateFrameTiming", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static uint GetLatestTimings(uint numFrames, FrameTiming[] timings) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static uint GetLatestTimings_Injected(uint numFrames, ref ManagedSpanWrapper timings) { }

}

