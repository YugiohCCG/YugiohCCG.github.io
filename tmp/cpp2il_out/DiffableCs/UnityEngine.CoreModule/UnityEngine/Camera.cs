namespace UnityEngine;

[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
[NativeHeader("Runtime/Camera/Camera.h")]
[NativeHeader("Runtime/Camera/RenderManager.h")]
[NativeHeader("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
[NativeHeader("Runtime/Shaders/Shader.h")]
[NativeHeader("Runtime/Graphics/RenderTexture.h")]
[NativeHeader("Runtime/Misc/GameObjectUtility.h")]
[RequireComponent(typeof(Transform))]
[UsedByNativeCode]
public sealed class Camera : Behaviour
{
	internal sealed class CameraCallback : MulticastDelegate
	{

		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		public CameraCallback(object object, IntPtr method) { }

		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(Camera cam) { }

	}

	internal enum MonoOrStereoscopicEye
	{
		Left = 0,
		Right = 1,
		Mono = 2,
	}

	internal enum SceneViewFilterMode
	{
		Off = 0,
		ShowFiltered = 1,
	}

	internal enum StereoscopicEye
	{
		Left = 0,
		Right = 1,
	}

	public const float kMinAperture = 0.7; //Field offset: 0x0
	public const float kMaxAperture = 32; //Field offset: 0x0
	public const int kMinBladeCount = 3; //Field offset: 0x0
	public const int kMaxBladeCount = 11; //Field offset: 0x0
	public static CameraCallback onPreCull; //Field offset: 0x0
	public static CameraCallback onPreRender; //Field offset: 0x8
	public static CameraCallback onPostRender; //Field offset: 0x10
	internal uint m_NonSerializedVersion; //Field offset: 0x18

	public static Camera[] allCameras
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "DisposeAdditionalCameraData", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 get { } //Length: 179
	}

	public static int allCamerasCount
	{
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 42
	}

	public bool allowDynamicResolution
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetPerCameraShaderVariables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(Vector2Int), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraData", Member = "IsTemporalAAEnabled", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraData", Member = "IsSTPEnabled", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.TemporalAA", Member = "ValidateAndWarn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData", typeof(bool)}, ReturnType = typeof(string))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "CreateRenderTextureDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(bool), "UnityEngine.Rendering.Universal.HDRColorBufferPrecision", typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(RenderTextureDescriptor))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "SetupLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(Vector2Int), "UnityEngine.Rendering.Universal.UniversalLightData", typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 118
	}

	public bool allowHDR
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "InitializeStackedCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 118
	}

	public bool allowMSAA
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "UpdateFinalStoreActions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32[]", "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "CreateCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ContextContainer", typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", typeof(bool)}, ReturnType = "UnityEngine.Rendering.Universal.UniversalCameraData")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 118
	}

	public float aspect
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "InitializeAdditionalCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", typeof(bool), typeof(bool), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass0_0", Member = "<DOAspect>b__0", ReturnType = typeof(float))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 118
		[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass0_0", Member = "<DOAspect>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 134
	}

	public Color backgroundColor
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "InitializeAdditionalCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", typeof(bool), typeof(bool), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass1_0", Member = "<DOColor>b__0", ReturnType = typeof(Color))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 142
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "GetCameraClearFlag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = "UnityEngine.Rendering.ClearFlag")]
		[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass1_0", Member = "<DOColor>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 133
	}

	public Matrix4x4 cameraToWorldMatrix
	{
		[CalledBy(Type = "UnityEngine.LightAnchor", Member = "GetWorldSpaceAxes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = "UnityEngine.LightAnchor+Axes")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 154
	}

	public CameraType cameraType
	{
		[CallerCount(Count = 37)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 118
	}

	public CameraClearFlags clearFlags
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "GetCameraClearFlag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = "UnityEngine.Rendering.ClearFlag")]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "CreateRenderGraphCameraRenderTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraph", typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "OnMainRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraph", typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 118
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", Member = "Start", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", Member = "OnValidate", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 131
	}

	public int cullingMask
	{
		[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "IsLensFlareSRPHidden", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.LensFlareComponentSRP", "UnityEngine.Rendering.LensFlareDataSRP"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalSkipCulledSystem", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalSkipCulledSystem", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DecalCulledChunk", typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalUpdateCullingGroupSystem", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalUpdateCullingGroupSystem", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DecalCachedChunk", "UnityEngine.Rendering.Universal.DecalCulledChunk", typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.XRDepthMotionPass", Member = "InitObjectMotionRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"PassData&", typeof(CullingResults&), "UnityEngine.Rendering.RenderGraphModule.RenderGraph", typeof(Camera)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.EventSystems.PhysicsRaycaster", Member = "get_finalEventMask", ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 118
	}

	public static Camera current
	{
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 84
	}

	private static Camera currentInternal
	{
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[FreeFunction("GetCurrentCameraPPtr")]
		private get { } //Length: 84
	}

	public float depth
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline+<>c", Member = "<.ctor>b__47_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Camera)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.EventSystems.EventSystem", Member = "RaycastComparer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.RaycastResult", "UnityEngine.EventSystems.RaycastResult"}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.EventSystems.PhysicsRaycaster", Member = "get_depth", ReturnType = typeof(int))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 118
	}

	public DepthTextureMode depthTextureMode
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.MotionVectorRenderPass", Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.MotionVectorRenderPass+PassData", typeof(RendererList)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.XRDepthMotionPass", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraph", "UnityEngine.Rendering.ContextContainer"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 118
		[CalledBy(Type = "UnityEngine.Rendering.Universal.MotionVectorRenderPass", Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.MotionVectorRenderPass+PassData", typeof(RendererList)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.XRDepthMotionPass", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraph", "UnityEngine.Rendering.ContextContainer"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 131
	}

	public int eventMask
	{
		[CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 118
	}

	[NativeProperty("Far")]
	public float farClipPlane
	{
		[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRLayout", Member = "AddCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass2_0", Member = "<DOFarClipPlane>b__0", ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.EventSystems.PhysicsRaycaster", Member = "ComputeRayAndDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", typeof(Ray&), typeof(Int32&), typeof(Single&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Canvas", typeof(Camera), typeof(Vector2), "System.Collections.Generic.IList`1<Graphic>", "System.Collections.Generic.List`1<Graphic>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "InitializeAdditionalCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", typeof(bool), typeof(bool), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.ForwardLights", Member = "PreSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRenderingData", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.UniversalLightData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderObjectsPass", Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.RenderObjectsPass+PassData", "UnityEngine.Rendering.RasterCommandBuffer", typeof(RendererList), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetPerCameraShaderVariables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(Vector2Int), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.LensFlareComponentSRP", Member = "celestialProjectedOcclusionRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "DoLensFlareDataDrivenCommon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), typeof(Rect), "UnityEngine.Experimental.Rendering.XRPass", typeof(int), typeof(float), typeof(float), typeof(bool), typeof(float), typeof(float), typeof(bool), typeof(Vector3), typeof(Matrix4x4), typeof(CommandBuffer), typeof(bool), typeof(bool), typeof(Texture), typeof(Texture), typeof(RenderTargetIdentifier), "System.Func`4<Light, Camera, Vector3, Single>", typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "ComputeOcclusion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), "UnityEngine.Experimental.Rendering.XRPass", typeof(int), typeof(float), typeof(float), typeof(bool), typeof(float), typeof(float), typeof(bool), typeof(Vector3), typeof(Matrix4x4), typeof(CommandBuffer), typeof(bool), typeof(bool), typeof(Texture), typeof(Texture)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.StpUtils", Member = "PopulateStpConfig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.RenderGraphModule.TextureHandle", "UnityEngine.Rendering.RenderGraphModule.TextureHandle", "UnityEngine.Rendering.RenderGraphModule.TextureHandle", typeof(int), "UnityEngine.Rendering.RenderGraphModule.TextureHandle", "UnityEngine.Rendering.RenderGraphModule.TextureHandle", typeof(Texture2D), "Config&"}, ReturnType = typeof(void))]
		[CallerCount(Count = 17)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 118
		[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass2_0", Member = "<DOFarClipPlane>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 134
	}

	[NativeProperty("VerticalFieldOfView")]
	public float fieldOfView
	{
		[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "ComputeOcclusion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), "UnityEngine.Experimental.Rendering.XRPass", typeof(int), typeof(float), typeof(float), typeof(bool), typeof(float), typeof(float), typeof(bool), typeof(Vector3), typeof(Matrix4x4), typeof(CommandBuffer), typeof(bool), typeof(bool), typeof(Texture), typeof(Texture)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "DoLensFlareDataDrivenCommon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), typeof(Rect), "UnityEngine.Experimental.Rendering.XRPass", typeof(int), typeof(float), typeof(float), typeof(bool), typeof(float), typeof(float), typeof(bool), typeof(Vector3), typeof(Matrix4x4), typeof(CommandBuffer), typeof(bool), typeof(bool), typeof(Texture), typeof(Texture), typeof(RenderTargetIdentifier), "System.Func`4<Light, Camera, Vector3, Single>", typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "DoPaniniProjection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(CommandBuffer), "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.RTHandle"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "CalcViewExtents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "CalcCropExtents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(float)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "RenderPaniniProjection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraph", typeof(Camera), "UnityEngine.Rendering.RenderGraphModule.TextureHandle&", "UnityEngine.Rendering.RenderGraphModule.TextureHandle&"}, ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass3_0", Member = "<DOFieldOfView>b__0", ReturnType = typeof(float))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 118
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "TryGetCullingParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData", typeof(ScriptableCullingParameters&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "RenderSingleCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass3_0", Member = "<DOFieldOfView>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 134
	}

	public static Camera main
	{
		[CalledBy(Type = "UnityEngine.InputSystem.OnScreen.OnScreenStick", Member = "GetCameraFromCanvas", ReturnType = typeof(Camera))]
		[CalledBy(Type = "UnityEngine.LightAnchor", Member = "GetWorldSpaceAxes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = "UnityEngine.LightAnchor+Axes")]
		[CalledBy(Type = "UnityEngine.LightAnchor", Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.LightAnchor", Member = "OnDrawGizmosSelected", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "ComputeOcclusion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), "UnityEngine.Experimental.Rendering.XRPass", typeof(int), typeof(float), typeof(float), typeof(bool), typeof(float), typeof(float), typeof(bool), typeof(Vector3), typeof(Matrix4x4), typeof(CommandBuffer), typeof(bool), typeof(bool), typeof(Texture), typeof(Texture)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "DoLensFlareDataDrivenCommon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), typeof(Rect), "UnityEngine.Experimental.Rendering.XRPass", typeof(int), typeof(float), typeof(float), typeof(bool), typeof(float), typeof(float), typeof(bool), typeof(Vector3), typeof(Matrix4x4), typeof(CommandBuffer), typeof(bool), typeof(bool), typeof(Texture), typeof(Texture), typeof(RenderTargetIdentifier), "System.Func`4<Light, Camera, Vector3, Single>", typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.CameraExtensions", Member = "GetVolumeLayerMaskAndTrigger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", typeof(LayerMask&), typeof(Transform&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "get_eventCamera", ReturnType = typeof(Camera))]
		[CalledBy(Type = "UnityEngine.EventSystems.PhysicsRaycaster", Member = "get_eventCamera", ReturnType = typeof(Camera))]
		[CalledBy(Type = "Coffee.UISoftMask.SoftMask", Member = "UpdateMaskTexture", ReturnType = typeof(void))]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 2)]
		[FreeFunction("FindMainCamera")]
		 get { } //Length: 84
	}

	[NativeProperty("Near")]
	public float nearClipPlane
	{
		[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRLayout", Member = "AddCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetPerCameraShaderVariables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(Vector2Int), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderObjectsPass", Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.RenderObjectsPass+PassData", "UnityEngine.Rendering.RasterCommandBuffer", typeof(RendererList), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass", Member = "SetupKeywordsAndParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionSettings&", "UnityEngine.Rendering.Universal.UniversalCameraData&"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.StpUtils", Member = "PopulateStpConfig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.RenderGraphModule.TextureHandle", "UnityEngine.Rendering.RenderGraphModule.TextureHandle", "UnityEngine.Rendering.RenderGraphModule.TextureHandle", typeof(int), "UnityEngine.Rendering.RenderGraphModule.TextureHandle", "UnityEngine.Rendering.RenderGraphModule.TextureHandle", typeof(Texture2D), "Config&"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "InitializeAdditionalCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", typeof(bool), typeof(bool), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.ForwardLights", Member = "PreSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRenderingData", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.UniversalLightData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.EventSystems.PhysicsRaycaster", Member = "ComputeRayAndDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", typeof(Ray&), typeof(Int32&), typeof(Single&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass4_0", Member = "<DONearClipPlane>b__0", ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 16)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 118
		[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass4_0", Member = "<DONearClipPlane>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 134
	}

	public OpaqueSortMode opaqueSortMode
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "InitializeStackedCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 118
	}

	public bool orthographic
	{
		[CalledBy(Type = "UnityEngine.LightAnchor", Member = "GetWorldSpaceAxes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = "UnityEngine.LightAnchor+Axes")]
		[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "WorldToViewport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(bool), typeof(bool), typeof(Matrix4x4), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetPerCameraShaderVariables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(Vector2Int), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetPerCameraClippingPlaneProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.UniversalCameraData&", typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass", Member = "SetupKeywordsAndParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionSettings&", "UnityEngine.Rendering.Universal.UniversalCameraData&"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "InitializeAdditionalCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", typeof(bool), typeof(bool), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "ExecuteDeferredPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.UniversalLightData", "UnityEngine.Rendering.Universal.UniversalShadowData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.ForwardLights", Member = "GetViewParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "Unity.Mathematics.float4x4", typeof(Single&), typeof(Single&), "Unity.Mathematics.float4&"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.ForwardLights", Member = "PreSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRenderingData", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.UniversalLightData"}, ReturnType = typeof(void))]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 118
	}

	public float orthographicSize
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetPerCameraShaderVariables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(Vector2Int), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass5_0", Member = "<DOOrthoSize>b__0", ReturnType = typeof(float))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 118
		[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass5_0", Member = "<DOOrthoSize>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 134
	}

	public int pixelHeight
	{
		[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume", Member = "DrawProbeDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Texture)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetPerCameraShaderVariables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(Vector2Int), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraData", Member = "get_scaledHeight", ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessUtils", Member = "ConfigureDithering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessData", typeof(int), typeof(Camera), typeof(Material)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessUtils", Member = "ConfigureFilmGrain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessData", "UnityEngine.Rendering.Universal.FilmGrain", typeof(Camera), typeof(Material)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "RenderSingleCameraInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData&", typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "InitializeStackedCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "SetupFinalPassDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[FreeFunction("CameraScripting::GetPixelHeight", HasExplicitThis = True)]
		 get { } //Length: 118
	}

	[NativeProperty("ScreenViewportRect")]
	public Rect pixelRect
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "InitializeStackedCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "InitializeAdditionalCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", typeof(bool), typeof(bool), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.EventSystems.PhysicsRaycaster", Member = "ComputeRayAndDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", typeof(Ray&), typeof(Int32&), typeof(Single&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass6_0", Member = "<DOPixelRect>b__0", ReturnType = typeof(Rect))]
		[CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 142
		[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass6_0", Member = "<DOPixelRect>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 133
	}

	public int pixelWidth
	{
		[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume", Member = "DrawProbeDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Texture)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetPerCameraShaderVariables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(Vector2Int), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraData", Member = "get_scaledWidth", ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessUtils", Member = "ConfigureDithering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessData", typeof(int), typeof(Camera), typeof(Material)}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessUtils", Member = "ConfigureFilmGrain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessData", "UnityEngine.Rendering.Universal.FilmGrain", typeof(Camera), typeof(Material)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "RenderSingleCameraInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData&", typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "InitializeStackedCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "SetupFinalPassDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[FreeFunction("CameraScripting::GetPixelWidth", HasExplicitThis = True)]
		 get { } //Length: 118
	}

	public Matrix4x4 projectionMatrix
	{
		[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "WorldToViewport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(bool), typeof(bool), typeof(Matrix4x4), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "WorldToViewportDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3), typeof(bool)}, ReturnType = typeof(Vector3))]
		[CalledBy(Type = "UnityEngine.Rendering.XRGraphicsAutomatedTests", Member = "OverrideLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Experimental.Rendering.XRLayout", typeof(Camera)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass+<>c", Member = "<LensFlareDataDrivenComputeOcclusion>b__149_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessPass+LensFlarePassData", "UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass+<>c", Member = "<RenderLensFlareDataDriven>b__150_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessPass+LensFlarePassData", "UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "LensFlareDataDrivenComputeOcclusion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData&", typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(bool), typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "LensFlareDataDriven", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData&", typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(bool), typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "InitializeAdditionalCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", typeof(bool), typeof(bool), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Coffee.UISoftMask.SoftMask", Member = "UpdateMaskTextures", ReturnType = typeof(void))]
		[CalledBy(Type = "Coffee.UISoftMask.SoftMask", Member = "UpdateMaskTexture", ReturnType = typeof(void))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 154
	}

	[NativeProperty("NormalizedViewportRect")]
	public Rect rect
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "UpdateCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Experimental.Rendering.XRPass&"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "InitializeStackedCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass7_0", Member = "<DORect>b__0", ReturnType = typeof(Rect))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 142
		[CalledBy(Type = "UnityEngine.InputSystem.PlayerInputManager", Member = "set_splitScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputSystem.PlayerInputManager", Member = "UpdateSplitScreen", ReturnType = typeof(void))]
		[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass7_0", Member = "<DORect>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 set { } //Length: 133
	}

	[NativeConditional("UNITY_EDITOR")]
	public SceneViewFilterMode sceneViewFilterMode
	{
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		 get { } //Length: 118
	}

	public int targetDisplay
	{
		[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.EventSystems.PhysicsRaycaster", Member = "ComputeRayAndDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", typeof(Ray&), typeof(Int32&), typeof(Single&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 118
	}

	public RenderTexture targetTexture
	{
		[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRLayout", Member = "AddCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRMirrorView", Member = "RenderMirrorView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(Material), "UnityEngine.XR.XRDisplaySubsystem"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "SetScaleBiasRt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.UniversalCameraData&", "UnityEngine.Rendering.RTHandle"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "SetScaleBiasRt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "ProcessRenderRequests", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"RequestData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), "RequestData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "RenderSingleCameraInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData&", typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "RenderCameraStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "CreateCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ContextContainer", typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", typeof(bool)}, ReturnType = "UnityEngine.Rendering.Universal.UniversalCameraData")]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "InitializeStackedCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "CreateRenderTextureDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(bool), "UnityEngine.Rendering.Universal.HDRColorBufferPrecision", typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(RenderTextureDescriptor))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "OnRecordRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraph", typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 21)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 144
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "ProcessRenderRequests", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"RequestData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), "RequestData"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		 set { } //Length: 177
	}

	public bool usePhysicalProperties
	{
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "TryGetCullingParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData", typeof(ScriptableCullingParameters&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "RenderSingleCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 118
	}

	public Matrix4x4 worldToCameraMatrix
	{
		[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "WorldToViewport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(bool), typeof(bool), typeof(Matrix4x4), typeof(Vector3)}, ReturnType = typeof(Vector3))]
		[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "WorldToViewportDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3), typeof(bool)}, ReturnType = typeof(Vector3))]
		[CalledBy(Type = "UnityEngine.Rendering.XRGraphicsAutomatedTests", Member = "OverrideLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Experimental.Rendering.XRLayout", typeof(Camera)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass+<>c", Member = "<LensFlareDataDrivenComputeOcclusion>b__149_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessPass+LensFlarePassData", "UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass+<>c", Member = "<RenderLensFlareDataDriven>b__150_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessPass+LensFlarePassData", "UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "LensFlareDataDrivenComputeOcclusion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData&", typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(bool), typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "LensFlareDataDriven", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData&", typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(bool), typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "InitializeAdditionalCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", typeof(bool), typeof(bool), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Coffee.UISoftMask.SoftMask", Member = "UpdateMaskTextures", ReturnType = typeof(void))]
		[CalledBy(Type = "Coffee.UISoftMask.SoftMask", Member = "UpdateMaskTexture", ReturnType = typeof(void))]
		[CallerCount(Count = 10)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 154
	}

	[CallerCount(Count = 36)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public Camera() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[RequiredByNativeCode]
	private static void BumpNonSerializedVersion(Camera cam) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	private static void FireOnPostRender(Camera cam) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	private static void FireOnPreCull(Camera cam) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	private static void FireOnPreRender(Camera cam) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "DisposeAdditionalCameraData", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static Camera[] get_allCameras() { }

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static int get_allCamerasCount() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetPerCameraShaderVariables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(Vector2Int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraData", Member = "IsTemporalAAEnabled", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraData", Member = "IsSTPEnabled", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.TemporalAA", Member = "ValidateAndWarn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData", typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "CreateRenderTextureDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(bool), "UnityEngine.Rendering.Universal.HDRColorBufferPrecision", typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(RenderTextureDescriptor))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "SetupLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(Vector2Int), "UnityEngine.Rendering.Universal.UniversalLightData", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public bool get_allowDynamicResolution() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool get_allowDynamicResolution_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "InitializeStackedCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public bool get_allowHDR() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool get_allowHDR_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "UpdateFinalStoreActions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32[]", "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "CreateCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ContextContainer", typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", typeof(bool)}, ReturnType = "UnityEngine.Rendering.Universal.UniversalCameraData")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public bool get_allowMSAA() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool get_allowMSAA_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "InitializeAdditionalCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", typeof(bool), typeof(bool), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass0_0", Member = "<DOAspect>b__0", ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public float get_aspect() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static float get_aspect_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "InitializeAdditionalCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", typeof(bool), typeof(bool), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass1_0", Member = "<DOColor>b__0", ReturnType = typeof(Color))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Color get_backgroundColor() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_backgroundColor_Injected(IntPtr _unity_self, out Color ret) { }

	[CalledBy(Type = "UnityEngine.LightAnchor", Member = "GetWorldSpaceAxes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = "UnityEngine.LightAnchor+Axes")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Matrix4x4 get_cameraToWorldMatrix() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_cameraToWorldMatrix_Injected(IntPtr _unity_self, out Matrix4x4 ret) { }

	[CallerCount(Count = 37)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public CameraType get_cameraType() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static CameraType get_cameraType_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "GetCameraClearFlag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = "UnityEngine.Rendering.ClearFlag")]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "CreateRenderGraphCameraRenderTargets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraph", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "OnMainRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraph", typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public CameraClearFlags get_clearFlags() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static CameraClearFlags get_clearFlags_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "IsLensFlareSRPHidden", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.LensFlareComponentSRP", "UnityEngine.Rendering.LensFlareDataSRP"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalSkipCulledSystem", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalSkipCulledSystem", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DecalCulledChunk", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalUpdateCullingGroupSystem", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.DecalUpdateCullingGroupSystem", Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.DecalCachedChunk", "UnityEngine.Rendering.Universal.DecalCulledChunk", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.XRDepthMotionPass", Member = "InitObjectMotionRendererLists", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"PassData&", typeof(CullingResults&), "UnityEngine.Rendering.RenderGraphModule.RenderGraph", typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.EventSystems.PhysicsRaycaster", Member = "get_finalEventMask", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public int get_cullingMask() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int get_cullingMask_Injected(IntPtr _unity_self) { }

	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static Camera get_current() { }

	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[FreeFunction("GetCurrentCameraPPtr")]
	private static Camera get_currentInternal() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr get_currentInternal_Injected() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline+<>c", Member = "<.ctor>b__47_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Camera)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.EventSystems.EventSystem", Member = "RaycastComparer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.RaycastResult", "UnityEngine.EventSystems.RaycastResult"}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.EventSystems.PhysicsRaycaster", Member = "get_depth", ReturnType = typeof(int))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public float get_depth() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static float get_depth_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.MotionVectorRenderPass", Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.MotionVectorRenderPass+PassData", typeof(RendererList)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.XRDepthMotionPass", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraph", "UnityEngine.Rendering.ContextContainer"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public DepthTextureMode get_depthTextureMode() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static DepthTextureMode get_depthTextureMode_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public int get_eventMask() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int get_eventMask_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRLayout", Member = "AddCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.StpUtils", Member = "PopulateStpConfig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.RenderGraphModule.TextureHandle", "UnityEngine.Rendering.RenderGraphModule.TextureHandle", "UnityEngine.Rendering.RenderGraphModule.TextureHandle", typeof(int), "UnityEngine.Rendering.RenderGraphModule.TextureHandle", "UnityEngine.Rendering.RenderGraphModule.TextureHandle", typeof(Texture2D), "Config&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "ComputeOcclusion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), "UnityEngine.Experimental.Rendering.XRPass", typeof(int), typeof(float), typeof(float), typeof(bool), typeof(float), typeof(float), typeof(bool), typeof(Vector3), typeof(Matrix4x4), typeof(CommandBuffer), typeof(bool), typeof(bool), typeof(Texture), typeof(Texture)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "DoLensFlareDataDrivenCommon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), typeof(Rect), "UnityEngine.Experimental.Rendering.XRPass", typeof(int), typeof(float), typeof(float), typeof(bool), typeof(float), typeof(float), typeof(bool), typeof(Vector3), typeof(Matrix4x4), typeof(CommandBuffer), typeof(bool), typeof(bool), typeof(Texture), typeof(Texture), typeof(RenderTargetIdentifier), "System.Func`4<Light, Camera, Vector3, Single>", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareComponentSRP", Member = "celestialProjectedOcclusionRadius", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetPerCameraShaderVariables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(Vector2Int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.ForwardLights", Member = "PreSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRenderingData", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.UniversalLightData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderObjectsPass", Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.RenderObjectsPass+PassData", "UnityEngine.Rendering.RasterCommandBuffer", typeof(RendererList), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Canvas", typeof(Camera), typeof(Vector2), "System.Collections.Generic.IList`1<Graphic>", "System.Collections.Generic.List`1<Graphic>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.EventSystems.PhysicsRaycaster", Member = "ComputeRayAndDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", typeof(Ray&), typeof(Int32&), typeof(Single&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass2_0", Member = "<DOFarClipPlane>b__0", ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "InitializeAdditionalCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", typeof(bool), typeof(bool), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public float get_farClipPlane() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static float get_farClipPlane_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "ComputeOcclusion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), "UnityEngine.Experimental.Rendering.XRPass", typeof(int), typeof(float), typeof(float), typeof(bool), typeof(float), typeof(float), typeof(bool), typeof(Vector3), typeof(Matrix4x4), typeof(CommandBuffer), typeof(bool), typeof(bool), typeof(Texture), typeof(Texture)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "DoLensFlareDataDrivenCommon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), typeof(Rect), "UnityEngine.Experimental.Rendering.XRPass", typeof(int), typeof(float), typeof(float), typeof(bool), typeof(float), typeof(float), typeof(bool), typeof(Vector3), typeof(Matrix4x4), typeof(CommandBuffer), typeof(bool), typeof(bool), typeof(Texture), typeof(Texture), typeof(RenderTargetIdentifier), "System.Func`4<Light, Camera, Vector3, Single>", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "DoPaniniProjection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(CommandBuffer), "UnityEngine.Rendering.RTHandle", "UnityEngine.Rendering.RTHandle"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "CalcViewExtents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "CalcCropExtents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(float)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "RenderPaniniProjection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraph", typeof(Camera), "UnityEngine.Rendering.RenderGraphModule.TextureHandle&", "UnityEngine.Rendering.RenderGraphModule.TextureHandle&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass3_0", Member = "<DOFieldOfView>b__0", ReturnType = typeof(float))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public float get_fieldOfView() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static float get_fieldOfView_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.InputSystem.OnScreen.OnScreenStick", Member = "GetCameraFromCanvas", ReturnType = typeof(Camera))]
	[CalledBy(Type = "UnityEngine.LightAnchor", Member = "GetWorldSpaceAxes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = "UnityEngine.LightAnchor+Axes")]
	[CalledBy(Type = "UnityEngine.LightAnchor", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.LightAnchor", Member = "OnDrawGizmosSelected", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "ComputeOcclusion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), "UnityEngine.Experimental.Rendering.XRPass", typeof(int), typeof(float), typeof(float), typeof(bool), typeof(float), typeof(float), typeof(bool), typeof(Vector3), typeof(Matrix4x4), typeof(CommandBuffer), typeof(bool), typeof(bool), typeof(Texture), typeof(Texture)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "DoLensFlareDataDrivenCommon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), typeof(Rect), "UnityEngine.Experimental.Rendering.XRPass", typeof(int), typeof(float), typeof(float), typeof(bool), typeof(float), typeof(float), typeof(bool), typeof(Vector3), typeof(Matrix4x4), typeof(CommandBuffer), typeof(bool), typeof(bool), typeof(Texture), typeof(Texture), typeof(RenderTargetIdentifier), "System.Func`4<Light, Camera, Vector3, Single>", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.CameraExtensions", Member = "GetVolumeLayerMaskAndTrigger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", typeof(LayerMask&), typeof(Transform&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "get_eventCamera", ReturnType = typeof(Camera))]
	[CalledBy(Type = "UnityEngine.EventSystems.PhysicsRaycaster", Member = "get_eventCamera", ReturnType = typeof(Camera))]
	[CalledBy(Type = "Coffee.UISoftMask.SoftMask", Member = "UpdateMaskTexture", ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("FindMainCamera")]
	public static Camera get_main() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr get_main_Injected() { }

	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRLayout", Member = "AddCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetPerCameraShaderVariables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(Vector2Int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderObjectsPass", Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.RenderObjectsPass+PassData", "UnityEngine.Rendering.RasterCommandBuffer", typeof(RendererList), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass", Member = "SetupKeywordsAndParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionSettings&", "UnityEngine.Rendering.Universal.UniversalCameraData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.StpUtils", Member = "PopulateStpConfig", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.RenderGraphModule.TextureHandle", "UnityEngine.Rendering.RenderGraphModule.TextureHandle", "UnityEngine.Rendering.RenderGraphModule.TextureHandle", typeof(int), "UnityEngine.Rendering.RenderGraphModule.TextureHandle", "UnityEngine.Rendering.RenderGraphModule.TextureHandle", typeof(Texture2D), "Config&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "InitializeAdditionalCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", typeof(bool), typeof(bool), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.ForwardLights", Member = "PreSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRenderingData", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.UniversalLightData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.EventSystems.PhysicsRaycaster", Member = "ComputeRayAndDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", typeof(Ray&), typeof(Int32&), typeof(Single&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass4_0", Member = "<DONearClipPlane>b__0", ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public float get_nearClipPlane() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static float get_nearClipPlane_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "InitializeStackedCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public OpaqueSortMode get_opaqueSortMode() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static OpaqueSortMode get_opaqueSortMode_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.LightAnchor", Member = "GetWorldSpaceAxes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = "UnityEngine.LightAnchor+Axes")]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "WorldToViewport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(bool), typeof(bool), typeof(Matrix4x4), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetPerCameraShaderVariables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(Vector2Int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetPerCameraClippingPlaneProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.UniversalCameraData&", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionPass", Member = "SetupKeywordsAndParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.ScreenSpaceAmbientOcclusionSettings&", "UnityEngine.Rendering.Universal.UniversalCameraData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "InitializeAdditionalCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", typeof(bool), typeof(bool), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.DeferredLights", Member = "ExecuteDeferredPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.UniversalLightData", "UnityEngine.Rendering.Universal.UniversalShadowData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.ForwardLights", Member = "GetViewParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "Unity.Mathematics.float4x4", typeof(Single&), typeof(Single&), "Unity.Mathematics.float4&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.Internal.ForwardLights", Member = "PreSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalRenderingData", "UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Rendering.Universal.UniversalLightData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public bool get_orthographic() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool get_orthographic_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetPerCameraShaderVariables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(Vector2Int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass5_0", Member = "<DOOrthoSize>b__0", ReturnType = typeof(float))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public float get_orthographicSize() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static float get_orthographicSize_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume", Member = "DrawProbeDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Texture)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetPerCameraShaderVariables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(Vector2Int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraData", Member = "get_scaledHeight", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessUtils", Member = "ConfigureDithering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessData", typeof(int), typeof(Camera), typeof(Material)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessUtils", Member = "ConfigureFilmGrain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessData", "UnityEngine.Rendering.Universal.FilmGrain", typeof(Camera), typeof(Material)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "RenderSingleCameraInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData&", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "InitializeStackedCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "SetupFinalPassDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("CameraScripting::GetPixelHeight", HasExplicitThis = True)]
	public int get_pixelHeight() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int get_pixelHeight_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "InitializeStackedCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "InitializeAdditionalCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", typeof(bool), typeof(bool), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.EventSystems.PhysicsRaycaster", Member = "ComputeRayAndDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", typeof(Ray&), typeof(Int32&), typeof(Single&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass6_0", Member = "<DOPixelRect>b__0", ReturnType = typeof(Rect))]
	[CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Rect get_pixelRect() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_pixelRect_Injected(IntPtr _unity_self, out Rect ret) { }

	[CalledBy(Type = "UnityEngine.Rendering.ProbeReferenceVolume", Member = "DrawProbeDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Texture)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "SetPerCameraShaderVariables", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(Vector2Int), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalCameraData", Member = "get_scaledWidth", ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessUtils", Member = "ConfigureDithering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessData", typeof(int), typeof(Camera), typeof(Material)}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessUtils", Member = "ConfigureFilmGrain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessData", "UnityEngine.Rendering.Universal.FilmGrain", typeof(Camera), typeof(Material)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "RenderSingleCameraInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData&", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "InitializeStackedCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "SetupFinalPassDebug", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("CameraScripting::GetPixelWidth", HasExplicitThis = True)]
	public int get_pixelWidth() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int get_pixelWidth_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "WorldToViewport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(bool), typeof(bool), typeof(Matrix4x4), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "WorldToViewportDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3), typeof(bool)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = "UnityEngine.Rendering.XRGraphicsAutomatedTests", Member = "OverrideLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Experimental.Rendering.XRLayout", typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass+<>c", Member = "<LensFlareDataDrivenComputeOcclusion>b__149_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessPass+LensFlarePassData", "UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass+<>c", Member = "<RenderLensFlareDataDriven>b__150_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessPass+LensFlarePassData", "UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "LensFlareDataDrivenComputeOcclusion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData&", typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(bool), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "LensFlareDataDriven", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData&", typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(bool), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "InitializeAdditionalCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", typeof(bool), typeof(bool), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Coffee.UISoftMask.SoftMask", Member = "UpdateMaskTextures", ReturnType = typeof(void))]
	[CalledBy(Type = "Coffee.UISoftMask.SoftMask", Member = "UpdateMaskTexture", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Matrix4x4 get_projectionMatrix() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_projectionMatrix_Injected(IntPtr _unity_self, out Matrix4x4 ret) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "UpdateCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData", "UnityEngine.Experimental.Rendering.XRPass&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "InitializeStackedCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass7_0", Member = "<DORect>b__0", ReturnType = typeof(Rect))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Rect get_rect() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_rect_Injected(IntPtr _unity_self, out Rect ret) { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public SceneViewFilterMode get_sceneViewFilterMode() { }

	[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.EventSystems.PhysicsRaycaster", Member = "ComputeRayAndDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", typeof(Ray&), typeof(Int32&), typeof(Single&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public int get_targetDisplay() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int get_targetDisplay_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRLayout", Member = "AddCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Experimental.Rendering.XRMirrorView", Member = "RenderMirrorView", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Camera), typeof(Material), "UnityEngine.XR.XRDisplaySubsystem"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "SetScaleBiasRt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.UniversalCameraData&", "UnityEngine.Rendering.RTHandle"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.RenderingUtils", Member = "SetScaleBiasRt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "ProcessRenderRequests", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"RequestData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), "RequestData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "RenderSingleCameraInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData&", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "RenderCameraStack", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "CreateCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.ContextContainer", typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", typeof(bool)}, ReturnType = "UnityEngine.Rendering.Universal.UniversalCameraData")]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "InitializeStackedCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "CreateRenderTextureDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.Universal.UniversalCameraData", typeof(bool), "UnityEngine.Rendering.Universal.HDRColorBufferPrecision", typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(RenderTextureDescriptor))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderer", Member = "OnRecordRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraph", typeof(ScriptableRenderContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 3)]
	public RenderTexture get_targetTexture() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static IntPtr get_targetTexture_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "TryGetCullingParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData", typeof(ScriptableCullingParameters&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "RenderSingleCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public bool get_usePhysicalProperties() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool get_usePhysicalProperties_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "WorldToViewport", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(bool), typeof(bool), typeof(Matrix4x4), typeof(Vector3)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = "UnityEngine.Rendering.LensFlareCommonSRP", Member = "WorldToViewportDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3), typeof(bool)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = "UnityEngine.Rendering.XRGraphicsAutomatedTests", Member = "OverrideLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Experimental.Rendering.XRLayout", typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass+<>c", Member = "<LensFlareDataDrivenComputeOcclusion>b__149_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessPass+LensFlarePassData", "UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass+<>c", Member = "<RenderLensFlareDataDriven>b__150_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessPass+LensFlarePassData", "UnityEngine.Rendering.RenderGraphModule.UnsafeGraphContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "LensFlareDataDrivenComputeOcclusion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData&", typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(bool), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "LensFlareDataDriven", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData&", typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(bool), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "InitializeAdditionalCameraData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", typeof(bool), typeof(bool), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Coffee.UISoftMask.SoftMask", Member = "UpdateMaskTextures", ReturnType = typeof(void))]
	[CalledBy(Type = "Coffee.UISoftMask.SoftMask", Member = "UpdateMaskTexture", ReturnType = typeof(void))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Matrix4x4 get_worldToCameraMatrix() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void get_worldToCameraMatrix_Injected(IntPtr _unity_self, out Matrix4x4 ret) { }

	[CalledBy(Type = "UnityEngine.Rendering.VolumeDebugSettings`1", Member = "get_cameras", ReturnType = "System.Collections.Generic.IEnumerable`1<Camera>")]
	[CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NullReferenceException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 11)]
	public static int GetAllCameras(Camera[] cameras) { }

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[FreeFunction("CameraScripting::GetAllCamerasCount")]
	private static int GetAllCamerasCount() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[FreeFunction("CameraScripting::GetAllCameras")]
	private static int GetAllCamerasImpl(out Camera[] cam) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int GetAllCamerasImpl_Injected(out Camera[] cam) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("ScriptableRenderPipeline_Bindings::GetCullingParameters_Internal")]
	[NativeHeader("Runtime/Export/RenderPipeline/ScriptableRenderPipeline.bindings.h")]
	private static bool GetCullingParameters_Internal(Camera camera, bool stereoAware, out ScriptableCullingParameters cullingParameters, int managedCullingParametersSize) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool GetCullingParameters_Internal_Injected(IntPtr camera, bool stereoAware, out ScriptableCullingParameters cullingParameters, int managedCullingParametersSize) { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[NativeConditional("UNITY_EDITOR")]
	private int GetFilterMode() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int GetFilterMode_Injected(IntPtr _unity_self) { }

	[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.InputField", Member = "ScreenToLocal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.EventSystems.PhysicsRaycaster", Member = "ComputeRayAndDistance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", typeof(Ray&), typeof(Int32&), typeof(Single&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.RectTransformUtility", Member = "ScreenPointToWorldPointInRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectTransform), typeof(Vector2), typeof(Camera), typeof(Vector3&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.RectTransformUtility", Member = "ScreenPointToRay", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector2)}, ReturnType = typeof(Ray))]
	[CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Ray ScreenPointToRay(Vector3 pos) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Ray ScreenPointToRay(Vector3 pos, MonoOrStereoscopicEye eye) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private Ray ScreenPointToRay(Vector2 pos, MonoOrStereoscopicEye eye) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void ScreenPointToRay_Injected(IntPtr _unity_self, in Vector2 pos, MonoOrStereoscopicEye eye, out Ray ret) { }

	[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Vector3 ScreenToViewportPoint(Vector3 position) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void ScreenToViewportPoint_Injected(IntPtr _unity_self, in Vector3 position, out Vector3 ret) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Vector3 ScreenToWorldPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	[CalledBy(Type = "Extensions.DraggableFrame", Member = "OnDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.General", Member = "ToWorldPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = "Extensions.General", Member = "GetAbsolutePosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(Vector3))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Vector3 ScreenToWorldPoint(Vector3 position) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void ScreenToWorldPoint_Injected(IntPtr _unity_self, in Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret) { }

	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass0_0", Member = "<DOAspect>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_aspect(float value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_aspect_Injected(IntPtr _unity_self, float value) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.ScriptableRenderer", Member = "GetCameraClearFlag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = "UnityEngine.Rendering.ClearFlag")]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass1_0", Member = "<DOColor>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_backgroundColor(Color value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_backgroundColor_Injected(IntPtr _unity_self, in Color value) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalAdditionalCameraData", Member = "OnValidate", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_clearFlags(CameraClearFlags value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_clearFlags_Injected(IntPtr _unity_self, CameraClearFlags value) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.MotionVectorRenderPass", Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RasterCommandBuffer", "UnityEngine.Rendering.Universal.MotionVectorRenderPass+PassData", typeof(RendererList)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.XRDepthMotionPass", Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.RenderGraphModule.RenderGraph", "UnityEngine.Rendering.ContextContainer"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_depthTextureMode(DepthTextureMode value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_depthTextureMode_Injected(IntPtr _unity_self, DepthTextureMode value) { }

	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass2_0", Member = "<DOFarClipPlane>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_farClipPlane(float value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_farClipPlane_Injected(IntPtr _unity_self, float value) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "TryGetCullingParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData", typeof(ScriptableCullingParameters&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "RenderSingleCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass3_0", Member = "<DOFieldOfView>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_fieldOfView(float value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_fieldOfView_Injected(IntPtr _unity_self, float value) { }

	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass4_0", Member = "<DONearClipPlane>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_nearClipPlane(float value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_nearClipPlane_Injected(IntPtr _unity_self, float value) { }

	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass5_0", Member = "<DOOrthoSize>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_orthographicSize(float value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_orthographicSize_Injected(IntPtr _unity_self, float value) { }

	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass6_0", Member = "<DOPixelRect>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_pixelRect(Rect value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_pixelRect_Injected(IntPtr _unity_self, in Rect value) { }

	[CalledBy(Type = "UnityEngine.InputSystem.PlayerInputManager", Member = "set_splitScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputSystem.PlayerInputManager", Member = "UpdateSplitScreen", ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.ShortcutExtensions+<>c__DisplayClass7_0", Member = "<DORect>b__1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void set_rect(Rect value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_rect_Injected(IntPtr _unity_self, in Rect value) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "ProcessRenderRequests", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"RequestData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(Camera), "RequestData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public void set_targetTexture(RenderTexture value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void set_targetTexture_Injected(IntPtr _unity_self, IntPtr value) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "UpdateCameraStereoMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Experimental.Rendering.XRPass"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetStereoProjectionMatrix(StereoscopicEye eye, Matrix4x4 matrix) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetStereoProjectionMatrix_Injected(IntPtr _unity_self, StereoscopicEye eye, in Matrix4x4 matrix) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "UpdateCameraStereoMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), "UnityEngine.Experimental.Rendering.XRPass"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public void SetStereoViewMatrix(StereoscopicEye eye, Matrix4x4 matrix) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetStereoViewMatrix_Injected(IntPtr _unity_self, StereoscopicEye eye, in Matrix4x4 matrix) { }

	[CalledBy(Type = "UnityEngine.UIElements.BaseRuntimePanel", Member = "Render", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIElementsRuntimeUtility", Member = "RenderOffscreenPanels", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIElementsRuntimeUtility", Member = "RepaintPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BaseRuntimePanel"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIElementsRuntimeUtility", Member = "RenderPanel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BaseRuntimePanel", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIElementsUtility", Member = "DoDispatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.BaseVisualElementPanel"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.RenderChainCommand", Member = "ExecuteNonDrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.DrawParams", typeof(float), typeof(Exception&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 3)]
	[FreeFunction("CameraScripting::SetupCurrent")]
	public static void SetupCurrent(Camera cur) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void SetupCurrent_Injected(IntPtr cur) { }

	[CalledBy(Type = "UnityEngine.Rendering.XRGraphicsAutomatedTests", Member = "OverrideLayout", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Experimental.Rendering.XRLayout", typeof(Camera)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "TryGetCullingParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.UniversalCameraData", typeof(ScriptableCullingParameters&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "RenderSingleCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), "UnityEngine.Rendering.Universal.UniversalCameraData"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public bool TryGetCullingParameters(bool stereoAware, out ScriptableCullingParameters cullingParameters) { }

	[CalledBy(Type = "Extensions.General", Member = "ToCenterOfScreen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Vector3 ViewportToWorldPoint(Vector3 position) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Vector3 ViewportToWorldPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void ViewportToWorldPoint_Injected(IntPtr _unity_self, in Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Vector3 WorldToScreenPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	[CalledBy(Type = "Extensions.DraggableFrame", Member = "OnBeginDrag", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.EventSystems.PointerEventData"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Extensions.DraggableFrame", Member = "CheckForRearrange", ReturnType = typeof(bool))]
	[CalledBy(Type = "Extensions.General", Member = "ToScreenPosition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "Extensions.General", Member = "GetScreenPos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(Vector3))]
	[CalledBy(Type = "UnityEngine.InputSystem.UI.TrackedDeviceRaycaster", Member = "SortedRaycastGraphics", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Canvas", typeof(Ray), "System.Collections.Generic.List`1<RaycastHitData>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Canvas", typeof(Camera), typeof(Vector2), "System.Collections.Generic.IList`1<Graphic>", "System.Collections.Generic.List`1<Graphic>"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.RectTransformUtility", Member = "WorldToScreenPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(Vector3)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public Vector3 WorldToScreenPoint(Vector3 position) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void WorldToScreenPoint_Injected(IntPtr _unity_self, in Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret) { }

}

