namespace UnityEngine.XR;

[NativeConditional("ENABLE_XR")]
[NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshingSubsystem.h")]
[NativeHeader("Modules/XR/XRPrefix.h")]
[UsedByNativeCode]
public class XRMeshSubsystem : IntegratedSubsystem<XRMeshSubsystemDescriptor>
{
	[IsReadOnly]
	[NativeConditional("ENABLE_XR")]
	private struct MeshTransformList : IDisposable
	{
		private readonly IntPtr m_Self; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		public override void Dispose() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[FreeFunction("UnityXRMeshTransformList_Dispose")]
		private static void Dispose(IntPtr self) { }

	}


	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public XRMeshSubsystem() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	private void InvokeMeshReadyDelegate(MeshGenerationResult result, Action<MeshGenerationResult> onMeshGenerationComplete) { }

}

