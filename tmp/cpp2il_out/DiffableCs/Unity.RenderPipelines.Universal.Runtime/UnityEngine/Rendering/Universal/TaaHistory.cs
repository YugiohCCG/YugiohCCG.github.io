namespace UnityEngine.Rendering.Universal;

public sealed class TaaHistory : CameraHistoryItem
{
	private static readonly String[] m_TaaAccumulationNames; //Field offset: 0x0
	private Int32[] m_TaaAccumulationTextureIds; //Field offset: 0x20
	private Int32[] m_TaaAccumulationVersions; //Field offset: 0x28
	private RenderTextureDescriptor m_Descriptor; //Field offset: 0x30
	private Hash128 m_DescKey; //Field offset: 0x68

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	private static TaaHistory() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraHistoryItem), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public TaaHistory() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraHistoryItem), Member = "AllocHistoryFrameRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(RenderTextureDescriptor&), typeof(string)}, ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(Hash128), Member = "Compute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(Hash128))]
	[CallsUnknownMethods(Count = 2)]
	private void Alloc(ref RenderTextureDescriptor desc, bool xrMultipassEnabled) { }

	[CalledBy(Type = typeof(TemporalAA), Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Material), typeof(CameraData&), typeof(RTHandle), typeof(RTHandle), typeof(RenderTexture)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TemporalAA), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(Material), typeof(UniversalCameraData), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CameraHistoryItem), Member = "GetCurrentFrameRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RTHandle))]
	[CallsUnknownMethods(Count = 2)]
	public RTHandle GetAccumulationTexture(int eyeIndex = 0) { }

	[CalledBy(Type = typeof(TemporalAA), Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Material), typeof(CameraData&), typeof(RTHandle), typeof(RTHandle), typeof(RenderTexture)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TemporalAA), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(Material), typeof(UniversalCameraData), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public int GetAccumulationVersion(int eyeIndex = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hash128), Member = "Compute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(Hash128))]
	[Calls(Type = typeof(Hash128), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hash128), typeof(Hash128)}, ReturnType = typeof(bool))]
	private bool IsDirty(ref RenderTextureDescriptor desc) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraHistoryItem), Member = "GetCurrentFrameRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RTHandle))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private bool IsValid() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraHistoryItem), Member = "MakeId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public virtual void OnCreate(BufferedRTHandleSystem owner, uint typeId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraHistoryItem), Member = "ReleaseHistoryFrameRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_graphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Hash128), Member = "Compute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Hash128))]
	[CallsUnknownMethods(Count = 2)]
	public virtual void Reset() { }

	[CalledBy(Type = typeof(TemporalAA), Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Material), typeof(CameraData&), typeof(RTHandle), typeof(RTHandle), typeof(RenderTexture)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TemporalAA), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(Material), typeof(UniversalCameraData), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal void SetAccumulationVersion(int eyeIndex, int version) { }

	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "RenderSingleCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "UpdateTemporalAATargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(TemporalAA), Member = "TemporalAADescFromCameraDesc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&)}, ReturnType = typeof(RenderTextureDescriptor))]
	[Calls(Type = typeof(Hash128), Member = "Compute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(Hash128))]
	[Calls(Type = typeof(Hash128), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hash128), typeof(Hash128)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CameraHistoryItem), Member = "GetCurrentFrameRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(CameraHistoryItem), Member = "AllocHistoryFrameRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(RenderTextureDescriptor&), typeof(string)}, ReturnType = typeof(RTHandle))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal bool Update(ref RenderTextureDescriptor cameraDesc, bool xrMultipassEnabled = false) { }

}

