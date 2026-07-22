namespace UnityEngine.Rendering.Universal;

internal abstract class SingleHistoryBase : CameraHistoryItem
{
	private int m_Id; //Field offset: 0x20
	private RenderTextureDescriptor m_Descriptor; //Field offset: 0x24
	private Hash128 m_DescKey; //Field offset: 0x58

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraHistoryItem), Member = ".ctor", ReturnType = typeof(void))]
	protected SingleHistoryBase() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraHistoryItem), Member = "AllocHistoryFrameRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(RenderTextureDescriptor&), typeof(string)}, ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(Hash128), Member = "Compute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(Hash128))]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Alloc(ref RenderTextureDescriptor desc) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraHistoryItem), Member = "GetCurrentFrameRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RTHandle))]
	public RTHandle GetCurrentTexture() { }

	protected abstract RenderTextureDescriptor GetHistoryDescriptor(ref RenderTextureDescriptor cameraDesc) { }

	protected abstract int GetHistoryFrameCount() { }

	protected abstract string GetHistoryName() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BufferedRTHandleSystem), Member = "GetFrameRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(RTHandle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public RTHandle GetPreviousTexture() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BufferedRTHandleSystem), Member = "GetFrameRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(RTHandle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public RTHandle GetTexture(int frameIndex = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BufferedRTHandleSystem), Member = "GetFrameRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(RTHandle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal bool IsAllocated() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hash128), Member = "Compute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(Hash128))]
	[Calls(Type = typeof(Hash128), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hash128), typeof(Hash128)}, ReturnType = typeof(bool))]
	internal bool IsDirty(ref RenderTextureDescriptor desc) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraHistoryItem), Member = "MakeId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual void OnCreate(BufferedRTHandleSystem owner, uint typeId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraHistoryItem), Member = "ReleaseHistoryFrameRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	public virtual void Reset() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hash128), Member = "Compute", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(Hash128))]
	[Calls(Type = typeof(Hash128), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hash128), typeof(Hash128)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(BufferedRTHandleSystem), Member = "GetFrameRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(CameraHistoryItem), Member = "AllocHistoryFrameRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(RenderTextureDescriptor&), typeof(string)}, ReturnType = typeof(RTHandle))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	internal bool Update(ref RenderTextureDescriptor cameraDesc) { }

}

