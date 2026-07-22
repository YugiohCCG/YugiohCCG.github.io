namespace UnityEngine.Rendering;

internal static class ProbeVolumeConstantRuntimeResources
{
	private static ComputeBuffer m_SkySamplingDirectionsBuffer; //Field offset: 0x0
	private const int NB_SKY_PRECOMPUTED_DIRECTIONS = 255; //Field offset: 0x0
	private static ComputeBuffer m_AntiLeakDataBuffer; //Field offset: 0x8
	private static Vector3[] k_SkyDirections; //Field offset: 0x10
	private static UInt32[] k_AntiLeakData; //Field offset: 0x18

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private static ProbeVolumeConstantRuntimeResources() { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "Cleanup", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CoreUtils), Member = "SafeRelease", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ComputeBuffer)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal static void Cleanup() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "Normalize", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	private static Vector3[] GenerateSkyDirections() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal static void GetRuntimeResources(ref RuntimeResources rr) { }

	[CallerCount(Count = 0)]
	public static Vector3[] GetSkySamplingDirections() { }

	[CalledBy(Type = typeof(ProbeReferenceVolume), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProbeVolumeSystemParameters&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "Normalize", ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputeBuffer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ComputeBuffer), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 13)]
	[ContainsUnimplementedInstructions]
	internal static void Initialize() { }

}

