namespace UnityEngine.Rendering.Universal;

[ExcludeFromPreset]
public abstract class ScriptableRendererFeature : ScriptableObject, IDisposable
{
	[HideInInspector]
	[SerializeField]
	private bool m_Active; //Field offset: 0x18

	public bool isActive
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = typeof(DecalRendererFeature), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(FullScreenPassRendererFeature), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RenderObjects), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	protected ScriptableRendererFeature() { }

	public abstract void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData) { }

	public abstract void Create() { }

	[CalledBy(Type = typeof(ScriptableRenderer), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void Dispose() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	protected override void Dispose(bool disposing) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_isActive() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void OnCameraPreCull(ScriptableRenderer renderer, in CameraData cameraData) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnEnable() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnValidate() { }

	[CallerCount(Count = 0)]
	internal override bool RequireRenderingLayers(bool isDeferred, bool needsGBufferAccurateNormals, out Event atEvent, out MaskSize maskSize) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void SetActive(bool active) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void SetupRenderPasses(ScriptableRenderer renderer, in RenderingData renderingData) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	internal override bool SupportsNativeRenderPass() { }

}

