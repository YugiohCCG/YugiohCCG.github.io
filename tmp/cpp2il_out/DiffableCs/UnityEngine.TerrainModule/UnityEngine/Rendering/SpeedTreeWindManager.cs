namespace UnityEngine.Rendering;

[NativeHeader("Modules/Terrain/Public/SpeedTreeWindManager.h")]
[StaticAccessor("GetSpeedTreeWindManager()", StaticAccessorType::Dot (0))]
internal static class SpeedTreeWindManager
{

	[CalledBy(Type = "UnityEngine.Rendering.GPUResidentBatcher", Member = "UpdateSpeedTreeWindAndUploadWindParamsToGPU", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeArray`1<Int32>", "Unity.Collections.NativeArray`1<InstanceHandle>", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static void UpdateWindAndWriteBufferWindParams(ReadOnlySpan<Int32> renderersID, SpeedTreeWindParamsBufferIterator windParams, bool history) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void UpdateWindAndWriteBufferWindParams_Injected(ref ManagedSpanWrapper renderersID, in SpeedTreeWindParamsBufferIterator windParams, bool history) { }

}

