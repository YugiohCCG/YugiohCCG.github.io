namespace UnityEngine.Rendering.Universal;

public struct ShadowSliceData
{
	public Matrix4x4 viewMatrix; //Field offset: 0x0
	public Matrix4x4 projectionMatrix; //Field offset: 0x40
	public Matrix4x4 shadowTransform; //Field offset: 0x80
	public int offsetX; //Field offset: 0xC0
	public int offsetY; //Field offset: 0xC4
	public int resolution; //Field offset: 0xC8
	public ShadowSplitData splitData; //Field offset: 0xCC

	[CalledBy(Type = typeof(MainLightShadowCasterPass), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData), typeof(UniversalShadowData)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(MainLightShadowCasterPass), Member = "Clear", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	public void Clear() { }

}

