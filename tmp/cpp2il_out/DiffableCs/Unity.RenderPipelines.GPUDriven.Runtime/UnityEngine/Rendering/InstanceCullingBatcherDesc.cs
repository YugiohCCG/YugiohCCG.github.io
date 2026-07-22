namespace UnityEngine.Rendering;

internal struct InstanceCullingBatcherDesc
{
	public OnCullingCompleteCallback onCompleteCallback; //Field offset: 0x0

	[CalledBy(Type = typeof(GPUResidentDrawer), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GPUResidentDrawerSettings), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static InstanceCullingBatcherDesc NewDefault() { }

}

