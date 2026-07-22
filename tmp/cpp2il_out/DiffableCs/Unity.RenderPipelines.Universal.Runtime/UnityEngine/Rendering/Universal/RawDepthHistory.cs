namespace UnityEngine.Rendering.Universal;

public sealed class RawDepthHistory : CameraHistoryItem
{
	private static readonly String[] m_Names; //Field offset: 0x0
	private Int32[] m_Ids; //Field offset: 0x20
	private RenderTextureDescriptor m_Descriptor; //Field offset: 0x28
	private Hash128 m_DescKey; //Field offset: 0x60

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	private static RawDepthHistory() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraHistoryItem), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public RawDepthHistory() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraHistoryItem), Member = "AllocHistoryFrameRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(RenderTextureDescriptor&), typeof(string)}, ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(Hash128), Member = "Compute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(Hash128))]
	[CallsUnknownMethods(Count = 2)]
	private void Alloc(ref RenderTextureDescriptor desc, bool xrMultipassEnabled) { }

	[CallerCount(Count = 10)]
	[Calls(Type = typeof(CameraHistoryItem), Member = "GetCurrentFrameRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RTHandle))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public RTHandle GetCurrentTexture(int eyeIndex = 0) { }

	[CallerCount(Count = 0)]
	internal RenderTextureDescriptor GetHistoryDescriptor(ref RenderTextureDescriptor cameraDesc) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraHistoryItem), Member = "GetPreviousFrameRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RTHandle))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public RTHandle GetPreviousTexture(int eyeIndex = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraHistoryItem), Member = "GetCurrentFrameRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RTHandle))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private bool IsAllocated() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hash128), Member = "Compute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(Hash128))]
	[Calls(Type = typeof(Hash128), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hash128), typeof(Hash128)}, ReturnType = typeof(bool))]
	private bool IsDirty(ref RenderTextureDescriptor desc) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraHistoryItem), Member = "MakeId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public virtual void OnCreate(BufferedRTHandleSystem owner, uint typeId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraHistoryItem), Member = "ReleaseHistoryFrameRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public virtual void Reset() { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "SetupRawColorDepthHistory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(RenderTextureDescriptor&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "RenderRawColorDepthHistory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalCameraData), typeof(UniversalResourceData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Hash128), Member = "Compute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(Hash128))]
	[Calls(Type = typeof(Hash128), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hash128), typeof(Hash128)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CameraHistoryItem), Member = "GetCurrentFrameRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(CameraHistoryItem), Member = "AllocHistoryFrameRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(RenderTextureDescriptor&), typeof(string)}, ReturnType = typeof(RTHandle))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal bool Update(ref RenderTextureDescriptor cameraDesc, bool xrMultipassEnabled) { }

}

