namespace UnityEngine.Rendering;

public abstract class CameraHistoryItem : ContextItem
{
	private BufferedRTHandleSystem m_owner; //Field offset: 0x10
	private uint m_TypeId; //Field offset: 0x18

	protected BufferedRTHandleSystem storage
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = "UnityEngine.Rendering.Universal.RawColorHistory", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RawDepthHistory", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.SingleHistoryBase", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.StpHistory", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.TaaHistory", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected CameraHistoryItem() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.RawColorHistory", Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RawColorHistory", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RawDepthHistory", Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RawDepthHistory", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.SingleHistoryBase", Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.SingleHistoryBase", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.TaaHistory", Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.TaaHistory", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(BufferedRTHandleSystem), Member = "AllocBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(bool), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(BufferedRTHandleSystem), Member = "GetFrameRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(RTHandle))]
	[CallsUnknownMethods(Count = 1)]
	protected RTHandle AllocHistoryFrameRT(int id, int count, ref RenderTextureDescriptor desc, string name = "") { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	protected BufferedRTHandleSystem get_storage() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.RawColorHistory", Member = "GetCurrentTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RTHandle))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RawColorHistory", Member = "IsAllocated", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RawColorHistory", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RawDepthHistory", Member = "GetCurrentTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RTHandle))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RawDepthHistory", Member = "IsAllocated", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RawDepthHistory", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.SingleHistoryBase", Member = "GetCurrentTexture", ReturnType = typeof(RTHandle))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.TaaHistory", Member = "GetAccumulationTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RTHandle))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.TaaHistory", Member = "IsValid", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.TaaHistory", Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTextureDescriptor&), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(BufferedRTHandleSystem), Member = "GetFrameRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(RTHandle))]
	[CallsUnknownMethods(Count = 1)]
	protected RTHandle GetCurrentFrameRT(int id) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.RawColorHistory", Member = "GetPreviousTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RTHandle))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RawDepthHistory", Member = "GetPreviousTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RTHandle))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BufferedRTHandleSystem), Member = "GetFrameRT", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(RTHandle))]
	[CallsUnknownMethods(Count = 1)]
	protected RTHandle GetPreviousFrameRT(int id) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.RawColorHistory", Member = "OnCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferedRTHandleSystem), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RawDepthHistory", Member = "OnCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferedRTHandleSystem), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.SingleHistoryBase", Member = "OnCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferedRTHandleSystem), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.TaaHistory", Member = "OnCreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BufferedRTHandleSystem), typeof(uint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	protected int MakeId(uint index) { }

	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override void OnCreate(BufferedRTHandleSystem owner, uint typeId) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.RawColorHistory", Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RawDepthHistory", Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.SingleHistoryBase", Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.TaaHistory", Member = "Reset", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BufferedRTHandleSystem), Member = "ReleaseBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected void ReleaseHistoryFrameRT(int id) { }

}

