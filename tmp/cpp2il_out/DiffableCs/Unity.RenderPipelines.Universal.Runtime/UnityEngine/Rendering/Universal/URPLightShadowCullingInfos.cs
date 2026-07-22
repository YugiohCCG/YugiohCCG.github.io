namespace UnityEngine.Rendering.Universal;

internal struct URPLightShadowCullingInfos
{
	public NativeArray<ShadowSliceData> slices; //Field offset: 0x0
	public uint slicesValidMask; //Field offset: 0x10

	[CalledBy(Type = typeof(AdditionalLightsShadowCasterPass), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData), typeof(UniversalShadowData)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MainLightShadowCasterPass), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData), typeof(UniversalShadowData)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	[IsReadOnly]
	public bool IsSliceValid(int i) { }

}

