namespace UnityEngine.Rendering.Universal;

public class UniversalCameraHistory : ICameraHistoryReadAccess, ICameraHistoryWriteAccess, IPerFrameHistoryAccessTracker, IDisposable
{
	private struct Item
	{
		public ContextItem storage; //Field offset: 0x0
		public int requestVersion; //Field offset: 0x8
		public int writeVersion; //Field offset: 0xC

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public void Reset() { }

	}

	private static class TypeId
	{
		public static uint value; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		private static TypeId`1() { }

	}

	private const int k_ValidVersionCount = 2; //Field offset: 0x0
	private static uint s_TypeCount; //Field offset: 0x0
	private Item[] m_Items; //Field offset: 0x10
	private int m_Version; //Field offset: 0x18
	private BufferedRTHandleSystem m_HistoryTextures; //Field offset: 0x20
	[CompilerGenerated]
	private HistoryRequestDelegate OnGatherHistoryRequests; //Field offset: 0x28

	public override event HistoryRequestDelegate OnGatherHistoryRequests
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 add { } //Length: 146
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		 remove { } //Length: 146
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BufferedRTHandleSystem), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	internal UniversalCameraHistory() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public override void add_OnGatherHistoryRequests(HistoryRequestDelegate value) { }

	[CalledBy(Type = typeof(UniversalAdditionalCameraData), Member = "OnDestroy", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "DisposeAdditionalCameraData", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(BufferedRTHandleSystem), Member = "ReleaseAll", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override void Dispose() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void GatherHistoryRequests() { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "SetupVFXCameraBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UniversalCameraHistory), Member = "IsValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 8)]
	[DeduplicatedMethod]
	public override Type GetHistoryForRead() { }

	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "InitializeAdditionalCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalAdditionalCameraData), typeof(bool), typeof(bool), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "UpdateTemporalAAData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(UniversalAdditionalCameraData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "SetupRawColorDepthHistory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(RenderTextureDescriptor&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "RenderRawColorDepthHistory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalCameraData), typeof(UniversalResourceData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(UniversalCameraHistory), Member = "IsValidRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	[DeduplicatedMethod]
	public override Type GetHistoryForWrite() { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "SetupRawColorDepthHistory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(RenderTextureDescriptor&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "RenderRawColorDepthHistory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalCameraData), typeof(UniversalResourceData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UniversalCameraHistory), Member = "IsValidRequest", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public override bool IsAccessRequested() { }

	[CalledBy(Type = typeof(UniversalCameraHistory), Member = "GetHistoryForRead", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Type"}, ReturnType = "Type")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private bool IsValid(int i) { }

	[CalledBy(Type = typeof(UniversalCameraHistory), Member = "IsAccessRequested", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Type"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UniversalCameraHistory), Member = "GetHistoryForWrite", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"Type"}, ReturnType = "Type")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private bool IsValidRequest(int i) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool IsWritten() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal void ReleaseUnusedHistory() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Delegate), typeof(Delegate)}, ReturnType = typeof(Delegate))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	public override void remove_OnGatherHistoryRequests(HistoryRequestDelegate value) { }

	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "InitializeAdditionalCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(UniversalAdditionalCameraData), typeof(bool), typeof(bool), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "UpdateTemporalAAData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(UniversalAdditionalCameraData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderer), Member = "SetupVFXCameraBuffer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	[DeduplicatedMethod]
	public override void RequestAccess() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BufferedRTHandleSystem), Member = "SwapAndSetReferenceSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void SwapAndSetReferenceSize(int cameraWidth, int cameraHeight) { }

}

