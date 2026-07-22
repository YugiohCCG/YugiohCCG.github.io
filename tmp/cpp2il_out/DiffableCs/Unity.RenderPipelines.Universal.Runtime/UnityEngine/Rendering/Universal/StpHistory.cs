namespace UnityEngine.Rendering.Universal;

internal sealed class StpHistory : CameraHistoryItem
{
	private HistoryContext[] m_historyContexts; //Field offset: 0x20

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraHistoryItem), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public StpHistory() { }

	[CalledBy(Type = typeof(StpUtils), Member = "PopulateStpConfig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(int), typeof(TextureHandle), typeof(TextureHandle), typeof(Texture2D), typeof(Config&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal HistoryContext GetHistoryContext(int eyeIndex) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HistoryContext), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public virtual void OnCreate(BufferedRTHandleSystem owner, uint typeId) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HistoryContext), Member = "Dispose", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public virtual void Reset() { }

	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "RenderSingleCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "UpdateTemporalAATargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "get_singlePassEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(HistoryContext), Member = "Update", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HistoryUpdateInfo&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	internal bool Update(UniversalCameraData cameraData) { }

}

