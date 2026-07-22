namespace UnityEngine.Rendering;

internal struct RenderersBatchersContextDesc
{
	public InstanceNumInfo instanceNumInfo; //Field offset: 0x0
	public bool supportDitheringCrossFade; //Field offset: 0x8
	public bool enableBoundingSpheresInstanceData; //Field offset: 0x9
	public float smallMeshScreenPercentage; //Field offset: 0xC
	public bool enableCullerDebugStats; //Field offset: 0x10

	[CalledBy(Type = typeof(GPUResidentDrawer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUResidentDrawerSettings), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public static RenderersBatchersContextDesc NewDefault() { }

}

