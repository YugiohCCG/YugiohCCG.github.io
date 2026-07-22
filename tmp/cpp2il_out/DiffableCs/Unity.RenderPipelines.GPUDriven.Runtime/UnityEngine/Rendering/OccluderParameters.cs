namespace UnityEngine.Rendering;

public struct OccluderParameters
{
	public int viewInstanceID; //Field offset: 0x0
	public int subviewCount; //Field offset: 0x4
	public TextureHandle depthTexture; //Field offset: 0x8
	public Vector2Int depthSize; //Field offset: 0x18
	public bool depthIsArray; //Field offset: 0x20

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "UpdateInstanceOccluders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(TextureHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public OccluderParameters(int viewInstanceID) { }

}

