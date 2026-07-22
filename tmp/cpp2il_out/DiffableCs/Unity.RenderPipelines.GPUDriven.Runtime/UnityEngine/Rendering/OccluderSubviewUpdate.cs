namespace UnityEngine.Rendering;

public struct OccluderSubviewUpdate
{
	public int subviewIndex; //Field offset: 0x0
	public int depthSliceIndex; //Field offset: 0x4
	public Vector2Int depthOffset; //Field offset: 0x8
	public Matrix4x4 viewMatrix; //Field offset: 0x10
	public Matrix4x4 invViewMatrix; //Field offset: 0x50
	public Matrix4x4 gpuProjMatrix; //Field offset: 0x90
	public Vector3 viewOffsetWorldSpace; //Field offset: 0xD0

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "UpdateInstanceOccluders", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(TextureHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public OccluderSubviewUpdate(int subviewIndex) { }

}

