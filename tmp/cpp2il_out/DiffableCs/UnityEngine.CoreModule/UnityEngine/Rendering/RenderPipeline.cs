namespace UnityEngine.Rendering;

public abstract class RenderPipeline
{
	internal class StandardRequest
	{
		public RenderTexture destination; //Field offset: 0x10
		public int mipLevel; //Field offset: 0x18
		public CubemapFace face; //Field offset: 0x1C
		public int slice; //Field offset: 0x20

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <disposed>k__BackingField; //Field offset: 0x10

	public override RenderPipelineGlobalSettings defaultSettings
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public private bool disposed
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
		[Calls(Type = typeof(Math), Member = "ThrowAbsOverflow", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 370
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected RenderPipeline() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline+CameraRenderingScope", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected static void BeginCameraRendering(ScriptableRenderContext context, Camera camera) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline+ContextRenderingScope", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "System.Collections.Generic.List`1<Camera>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected static void BeginContextRendering(ScriptableRenderContext context, List<Camera> cameras) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void Dispose() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void Dispose(bool disposing) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline+CameraRenderingScope", Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected static void EndCameraRendering(ScriptableRenderContext context, Camera camera) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline+ContextRenderingScope", Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected static void EndContextRendering(ScriptableRenderContext context, List<Camera> cameras) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override RenderPipelineGlobalSettings get_defaultSettings() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public bool get_disposed() { }

	[CalledBy(Type = typeof(RenderPipelineManager), Member = "DoRenderLoop_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderPipelineAsset), typeof(IntPtr), typeof(Object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	internal void InternalProcessRenderRequests(ScriptableRenderContext context, Camera camera, RequestData renderRequest) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal void InternalRender(ScriptableRenderContext context, List<Camera> cameras) { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	protected private override bool IsRenderRequestSupported(Camera camera, RequestData data) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void ProcessRenderRequests(ScriptableRenderContext context, Camera camera, RequestData renderRequest) { }

	protected abstract void Render(ScriptableRenderContext context, Camera[] cameras) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected override void Render(ScriptableRenderContext context, List<Camera> cameras) { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "ThrowAbsOverflow", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_disposed(bool value) { }

}

