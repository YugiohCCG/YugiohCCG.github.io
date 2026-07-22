namespace UnityEngine.Rendering.Universal;

internal class PostProcessPass : ScriptableRenderPass
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Light, Camera, Vector3, Single> <>9__98_0; //Field offset: 0x8
		public static Func<Light, Camera, Vector3, Single> <>9__98_1; //Field offset: 0x10
		public static BaseRenderFunc<UpdateCameraResolutionPassData, UnsafeGraphContext> <>9__122_0; //Field offset: 0x18
		public static BaseRenderFunc<StopNaNsPassData, RasterGraphContext> <>9__124_0; //Field offset: 0x20
		public static BaseRenderFunc<SMAASetupPassData, RasterGraphContext> <>9__127_0; //Field offset: 0x28
		public static BaseRenderFunc<SMAAPassData, RasterGraphContext> <>9__127_1; //Field offset: 0x30
		public static BaseRenderFunc<SMAAPassData, RasterGraphContext> <>9__127_2; //Field offset: 0x38
		public static BaseRenderFunc<SMAAPassData, RasterGraphContext> <>9__127_3; //Field offset: 0x40
		public static BaseRenderFunc<UberSetupBloomPassData, RasterGraphContext> <>9__129_0; //Field offset: 0x48
		public static BaseRenderFunc<BloomPassData, UnsafeGraphContext> <>9__134_0; //Field offset: 0x50
		public static BaseRenderFunc<DoFGaussianPassData, UnsafeGraphContext> <>9__137_0; //Field offset: 0x58
		public static BaseRenderFunc<DoFBokehPassData, UnsafeGraphContext> <>9__139_0; //Field offset: 0x60
		public static BaseRenderFunc<PaniniProjectionPassData, RasterGraphContext> <>9__141_0; //Field offset: 0x68
		public static BaseRenderFunc<MotionBlurPassData, RasterGraphContext> <>9__147_0; //Field offset: 0x70
		public static BaseRenderFunc<LensFlarePassData, UnsafeGraphContext> <>9__149_0; //Field offset: 0x78
		public static Func<Light, Camera, Vector3, Single> <>9__150_1; //Field offset: 0x80
		public static Func<Light, Camera, Vector3, Single> <>9__150_2; //Field offset: 0x88
		public static BaseRenderFunc<LensFlarePassData, UnsafeGraphContext> <>9__150_0; //Field offset: 0x90
		public static BaseRenderFunc<LensFlareScreenSpacePassData, UnsafeGraphContext> <>9__152_0; //Field offset: 0x98
		public static BaseRenderFunc<PostProcessingFinalSetupPassData, RasterGraphContext> <>9__155_0; //Field offset: 0xA0
		public static BaseRenderFunc<PostProcessingFinalFSRScalePassData, RasterGraphContext> <>9__157_0; //Field offset: 0xA8
		public static BaseRenderFunc<PostProcessingFinalBlitPassData, RasterGraphContext> <>9__160_0; //Field offset: 0xB0
		public static BaseRenderFunc<UberPostPassData, RasterGraphContext> <>9__164_0; //Field offset: 0xB8
		public static BaseRenderFunc<PostFXSetupPassData, RasterGraphContext> <>9__166_0; //Field offset: 0xC0

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PostProcessPass), Member = "GetLensFlareLightAttenuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(Camera), typeof(Vector3)}, ReturnType = typeof(float))]
		internal float <LensFlareDataDriven>b__98_0(Light light, Camera cam, Vector3 wo) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PostProcessPass), Member = "GetLensFlareLightAttenuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(Camera), typeof(Vector3)}, ReturnType = typeof(float))]
		internal float <LensFlareDataDriven>b__98_1(Light light, Camera cam, Vector3 wo) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(UniversalCameraData), Member = "GetProjectionMatrixNoJitter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
		[Calls(Type = typeof(GL), Member = "GetGPUProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(bool)}, ReturnType = typeof(Matrix4x4))]
		[Calls(Type = typeof(UniversalCameraData), Member = "GetViewMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
		[Calls(Type = typeof(XRPass), Member = "get_singlePassEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Camera), Member = "get_projectionMatrix", ReturnType = typeof(Matrix4x4))]
		[Calls(Type = typeof(Camera), Member = "get_worldToCameraMatrix", ReturnType = typeof(Matrix4x4))]
		[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(LensFlareCommonSRP), Member = "ComputeOcclusion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), typeof(XRPass), typeof(int), typeof(float), typeof(float), typeof(bool), typeof(float), typeof(float), typeof(bool), typeof(Vector3), typeof(Matrix4x4), typeof(UnsafeCommandBuffer), typeof(bool), typeof(bool), typeof(Texture), typeof(Texture)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XRPass), Member = "get_viewCount", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		internal void <LensFlareDataDrivenComputeOcclusion>b__149_0(LensFlarePassData data, UnsafeGraphContext ctx) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextureHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(RTHandle))]
		[Calls(Type = typeof(Blitter), Member = "BlitCameraTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(RTHandle), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TextureHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(Texture))]
		[CallsDeduplicatedMethods(Count = 13)]
		[CallsUnknownMethods(Count = 23)]
		internal void <RenderBloomTexture>b__134_0(BloomPassData data, UnsafeGraphContext context) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextureHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(RTHandle))]
		[Calls(Type = typeof(CoreUtils), Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Material), Member = "SetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Material), Member = "SetVectorArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4[])}, ReturnType = typeof(void))]
		[Calls(Type = typeof(PostProcessUtils), Member = "SetSourceSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(RTHandle)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TextureHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(Texture))]
		[Calls(Type = typeof(Blitter), Member = "BlitCameraTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(RTHandle), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 27)]
		[CallsUnknownMethods(Count = 12)]
		internal void <RenderDoFBokeh>b__139_0(DoFBokehPassData data, UnsafeGraphContext context) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextureHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(RTHandle))]
		[Calls(Type = typeof(Material), Member = "SetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CoreUtils), Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(PostProcessUtils), Member = "SetSourceSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(RTHandle)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TextureHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(Texture))]
		[Calls(Type = typeof(Blitter), Member = "BlitCameraTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(RTHandle), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TextureHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(RenderTargetIdentifier))]
		[Calls(Type = typeof(CoreUtils), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier[]), typeof(RTHandle)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(RTHandle), Member = "get_rtHandleProperties", ReturnType = typeof(RTHandleProperties))]
		[Calls(Type = typeof(Blitter), Member = "BlitTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(Vector4), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 29)]
		[CallsUnknownMethods(Count = 19)]
		internal void <RenderDoFGaussian>b__137_0(DoFGaussianPassData data, UnsafeGraphContext context) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextureHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(RTHandle))]
		[Calls(Type = typeof(PostProcessUtils), Member = "SetSourceSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(RTHandle)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CoreUtils), Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(FSRUtils), Member = "SetRcasConstantsLinear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UniversalCameraData), Member = "get_isSceneViewCamera", ReturnType = typeof(bool))]
		[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(RTHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(RenderTargetIdentifier))]
		[Calls(Type = typeof(RTHandle), Member = "get_rtHandleProperties", ReturnType = typeof(RTHandleProperties))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Blitter), Member = "BlitTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(RTHandle), typeof(Vector4), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		internal void <RenderFinalBlit>b__160_0(PostProcessingFinalBlitPassData data, RasterGraphContext context) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextureHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(RTHandle))]
		[Calls(Type = typeof(FSRUtils), Member = "SetEasuConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BaseCommandBuffer), typeof(Vector2), typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CoreUtils), Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(RTHandle), Member = "get_rtHandleProperties", ReturnType = typeof(RTHandleProperties))]
		[Calls(Type = typeof(Blitter), Member = "BlitTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(RTHandle), typeof(Vector4), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <RenderFinalFSRScale>b__157_0(PostProcessingFinalFSRScalePassData data, RasterGraphContext context) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextureHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(RTHandle))]
		[Calls(Type = typeof(PostProcessUtils), Member = "SetSourceSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(RTHandle)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(PostProcessPass), Member = "ScaleViewportAndBlit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(RTHandle), typeof(RTHandle), typeof(UniversalCameraData), typeof(Material), typeof(bool)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <RenderFinalSetup>b__155_0(PostProcessingFinalSetupPassData data, RasterGraphContext context) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(XRPass), Member = "get_singlePassEnabled", ReturnType = typeof(bool))]
		[Calls(Type = typeof(XRPass), Member = "get_viewCount", ReturnType = typeof(int))]
		[Calls(Type = typeof(UniversalCameraData), Member = "GetProjectionMatrixNoJitter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
		[Calls(Type = typeof(GL), Member = "GetGPUProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(bool)}, ReturnType = typeof(Matrix4x4))]
		[Calls(Type = typeof(UniversalCameraData), Member = "GetViewMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
		[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
		[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
		[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
		[Calls(Type = typeof(TextureHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(RenderTargetIdentifier))]
		[Calls(Type = typeof(System.Func`4<System.Object, System.Object, UnityEngine.Vector3, System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(LensFlareCommonSRP), Member = "DoLensFlareDataDrivenCommon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), typeof(Rect), typeof(XRPass), typeof(int), typeof(float), typeof(float), typeof(bool), typeof(float), typeof(float), typeof(bool), typeof(Vector3), typeof(Matrix4x4), typeof(UnsafeCommandBuffer), typeof(bool), typeof(bool), typeof(Texture), typeof(Texture), typeof(RenderTargetIdentifier), typeof(System.Func`4<UnityEngine.Light, UnityEngine.Camera, UnityEngine.Vector3, System.Single>), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Camera), Member = "get_projectionMatrix", ReturnType = typeof(Matrix4x4))]
		[Calls(Type = typeof(Camera), Member = "get_worldToCameraMatrix", ReturnType = typeof(Matrix4x4))]
		[CallsUnknownMethods(Count = 3)]
		internal void <RenderLensFlareDataDriven>b__150_0(LensFlarePassData data, UnsafeGraphContext ctx) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PostProcessPass), Member = "GetLensFlareLightAttenuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(Camera), typeof(Vector3)}, ReturnType = typeof(float))]
		internal float <RenderLensFlareDataDriven>b__150_1(Light light, Camera cam, Vector3 wo) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(PostProcessPass), Member = "GetLensFlareLightAttenuation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(Camera), typeof(Vector3)}, ReturnType = typeof(float))]
		internal float <RenderLensFlareDataDriven>b__150_2(Light light, Camera cam, Vector3 wo) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextureHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(Texture))]
		[Calls(Type = typeof(TextureHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(RTHandle))]
		[Calls(Type = typeof(LensFlareCommonSRP), Member = "DoLensFlareScreenSpaceCommon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), typeof(float), typeof(float), typeof(Color), typeof(Texture), typeof(Texture), typeof(Texture), typeof(Texture), typeof(Texture), typeof(Vector4), typeof(Vector4), typeof(Vector4), typeof(Vector4), typeof(Vector4), typeof(UnsafeCommandBuffer), typeof(RTHandle), typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 17)]
		[CallsUnknownMethods(Count = 1)]
		internal void <RenderLensFlareScreenSpace>b__152_0(LensFlareScreenSpacePassData data, UnsafeGraphContext context) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextureHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(RTHandle))]
		[Calls(Type = typeof(PostProcessPass), Member = "UpdateMotionBlurMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material&), typeof(Camera), typeof(XRPass)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CoreUtils), Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(PostProcessUtils), Member = "SetSourceSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(RTHandle)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(RTHandle), Member = "get_rtHandleProperties", ReturnType = typeof(RTHandleProperties))]
		[Calls(Type = typeof(Blitter), Member = "BlitTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(RTHandle), typeof(Vector4), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <RenderMotionBlur>b__147_0(MotionBlurPassData data, RasterGraphContext context) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextureHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(RTHandle))]
		[Calls(Type = typeof(Material), Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(RTHandle), Member = "get_rtHandleProperties", ReturnType = typeof(RTHandleProperties))]
		[Calls(Type = typeof(Blitter), Member = "BlitTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(RTHandle), typeof(Vector4), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal void <RenderPaniniProjection>b__141_0(PaniniProjectionPassData data, RasterGraphContext context) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GL), Member = "GetGPUProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(bool)}, ReturnType = typeof(Matrix4x4))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal void <RenderPostProcessingRenderGraph>b__166_0(PostFXSetupPassData data, RasterGraphContext context) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Material), Member = "SetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Material), Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 5)]
		[CallsUnknownMethods(Count = 1)]
		internal void <RenderSMAA>b__127_0(SMAASetupPassData data, RasterGraphContext context) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextureHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(RTHandle))]
		[Calls(Type = typeof(RTHandle), Member = "get_rtHandleProperties", ReturnType = typeof(RTHandleProperties))]
		[Calls(Type = typeof(Blitter), Member = "BlitTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(RTHandle), typeof(Vector4), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <RenderSMAA>b__127_1(SMAAPassData data, RasterGraphContext context) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextureHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(RTHandle))]
		[Calls(Type = typeof(RTHandle), Member = "get_rtHandleProperties", ReturnType = typeof(RTHandleProperties))]
		[Calls(Type = typeof(Blitter), Member = "BlitTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(RTHandle), typeof(Vector4), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <RenderSMAA>b__127_2(SMAAPassData data, RasterGraphContext context) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextureHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(RTHandle))]
		[Calls(Type = typeof(TextureHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(Texture))]
		[Calls(Type = typeof(RTHandle), Member = "get_rtHandleProperties", ReturnType = typeof(RTHandleProperties))]
		[Calls(Type = typeof(Blitter), Member = "BlitTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(RTHandle), typeof(Vector4), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal void <RenderSMAA>b__127_3(SMAAPassData data, RasterGraphContext context) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextureHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(RTHandle))]
		[Calls(Type = typeof(RTHandle), Member = "get_rtHandleProperties", ReturnType = typeof(RTHandleProperties))]
		[Calls(Type = typeof(Blitter), Member = "BlitTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(RTHandle), typeof(Vector4), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void <RenderStopNaN>b__124_0(StopNaNsPassData data, RasterGraphContext context) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(TextureHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(RTHandle))]
		[Calls(Type = typeof(TextureHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(Texture))]
		[Calls(Type = typeof(Material), Member = "SetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CoreUtils), Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(PostProcessPass), Member = "ScaleViewportAndBlit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(RTHandle), typeof(RTHandle), typeof(UniversalCameraData), typeof(Material), typeof(bool)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		internal void <RenderUberPost>b__164_0(UberPostPassData data, RasterGraphContext context) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Material), Member = "SetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Material), Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TextureHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureHandle)}, ReturnType = typeof(Texture))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		internal void <UberPostSetupBloomPass>b__129_0(UberSetupBloomPassData data, RasterGraphContext context) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal void <UpdateCameraResolution>b__122_0(UpdateCameraResolutionPassData data, UnsafeGraphContext ctx) { }

	}

	[CompilerGenerated]
	private struct <>c__DisplayClass89_0
	{
		public RTHandle source; //Field offset: 0x0
		public RTHandle destination; //Field offset: 0x8
		public PostProcessPass <>4__this; //Field offset: 0x10
		public int amountOfPassesRemaining; //Field offset: 0x18
		public CommandBuffer cmd; //Field offset: 0x20

	}

	public struct BloomMaterialParams
	{
		internal Vector4 parameters; //Field offset: 0x0
		internal bool highQualityFiltering; //Field offset: 0x10
		internal bool enableAlphaOutput; //Field offset: 0x11

		[CalledBy(Type = typeof(PostProcessPass), Member = "RenderBloomTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal bool Equals(ref BloomMaterialParams other) { }

	}

	private class BloomPassData
	{
		internal int mipCount; //Field offset: 0x10
		internal Material material; //Field offset: 0x18
		internal Material[] upsampleMaterials; //Field offset: 0x20
		internal TextureHandle sourceTexture; //Field offset: 0x28
		internal TextureHandle[] bloomMipUp; //Field offset: 0x38
		internal TextureHandle[] bloomMipDown; //Field offset: 0x40

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public BloomPassData() { }

	}

	private class DoFBokehPassData
	{
		internal Vector4[] bokehKernel; //Field offset: 0x10
		internal int downSample; //Field offset: 0x18
		internal float uvMargin; //Field offset: 0x1C
		internal Vector4 cocParams; //Field offset: 0x20
		internal bool useFastSRGBLinearConversion; //Field offset: 0x30
		internal TextureHandle sourceTexture; //Field offset: 0x34
		internal TextureHandle depthTexture; //Field offset: 0x44
		internal Material material; //Field offset: 0x58
		internal Material materialCoC; //Field offset: 0x60
		internal TextureHandle halfCoCTexture; //Field offset: 0x68
		internal TextureHandle fullCoCTexture; //Field offset: 0x78
		internal TextureHandle pingTexture; //Field offset: 0x88
		internal TextureHandle pongTexture; //Field offset: 0x98
		internal TextureHandle destination; //Field offset: 0xA8

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public DoFBokehPassData() { }

	}

	private class DoFGaussianPassData
	{
		internal int downsample; //Field offset: 0x10
		internal RenderingData renderingData; //Field offset: 0x18
		internal Vector3 cocParams; //Field offset: 0x40
		internal bool highQualitySamplingValue; //Field offset: 0x4C
		internal TextureHandle sourceTexture; //Field offset: 0x50
		internal TextureHandle depthTexture; //Field offset: 0x60
		internal Material material; //Field offset: 0x70
		internal Material materialCoC; //Field offset: 0x78
		internal TextureHandle halfCoCTexture; //Field offset: 0x80
		internal TextureHandle fullCoCTexture; //Field offset: 0x90
		internal TextureHandle pingTexture; //Field offset: 0xA0
		internal TextureHandle pongTexture; //Field offset: 0xB0
		internal RenderTargetIdentifier[] multipleRenderTargets; //Field offset: 0xC0
		internal TextureHandle destination; //Field offset: 0xC8

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public DoFGaussianPassData() { }

	}

	internal struct FinalBlitSettings
	{
		public bool isFxaaEnabled; //Field offset: 0x0
		public bool isFsrEnabled; //Field offset: 0x1
		public bool isTaaSharpeningEnabled; //Field offset: 0x2
		public bool requireHDROutput; //Field offset: 0x3
		public bool resolveToDebugScreen; //Field offset: 0x4
		public bool isAlphaOutputEnabled; //Field offset: 0x5
		public Operation hdrOperations; //Field offset: 0x8

		[CalledBy(Type = typeof(PostProcessPass), Member = "RenderFinalPassRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		public static FinalBlitSettings Create() { }

	}

	private class LensFlarePassData
	{
		internal TextureHandle destinationTexture; //Field offset: 0x10
		internal RenderTextureDescriptor sourceDescriptor; //Field offset: 0x20
		internal UniversalCameraData cameraData; //Field offset: 0x58
		internal Material material; //Field offset: 0x60
		internal Rect viewport; //Field offset: 0x68
		internal float paniniDistance; //Field offset: 0x78
		internal float paniniCropToFit; //Field offset: 0x7C
		internal float width; //Field offset: 0x80
		internal float height; //Field offset: 0x84
		internal bool usePanini; //Field offset: 0x88

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public LensFlarePassData() { }

	}

	private class LensFlareScreenSpacePassData
	{
		internal TextureHandle destinationTexture; //Field offset: 0x10
		internal TextureHandle streakTmpTexture; //Field offset: 0x20
		internal TextureHandle streakTmpTexture2; //Field offset: 0x30
		internal TextureHandle originalBloomTexture; //Field offset: 0x40
		internal TextureHandle screenSpaceLensFlareBloomMipTexture; //Field offset: 0x50
		internal TextureHandle result; //Field offset: 0x60
		internal RenderTextureDescriptor sourceDescriptor; //Field offset: 0x70
		internal Camera camera; //Field offset: 0xA8
		internal Material material; //Field offset: 0xB0
		internal ScreenSpaceLensFlare lensFlareScreenSpace; //Field offset: 0xB8
		internal int downsample; //Field offset: 0xC0

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public LensFlareScreenSpacePassData() { }

	}

	private class MaterialLibrary
	{
		public readonly Material stopNaN; //Field offset: 0x10
		public readonly Material subpixelMorphologicalAntialiasing; //Field offset: 0x18
		public readonly Material gaussianDepthOfField; //Field offset: 0x20
		public readonly Material gaussianDepthOfFieldCoC; //Field offset: 0x28
		public readonly Material bokehDepthOfField; //Field offset: 0x30
		public readonly Material bokehDepthOfFieldCoC; //Field offset: 0x38
		public readonly Material cameraMotionBlur; //Field offset: 0x40
		public readonly Material paniniProjection; //Field offset: 0x48
		public readonly Material bloom; //Field offset: 0x50
		public readonly Material[] bloomUpsample; //Field offset: 0x58
		public readonly Material temporalAntialiasing; //Field offset: 0x60
		public readonly Material scalingSetup; //Field offset: 0x68
		public readonly Material easu; //Field offset: 0x70
		public readonly Material uber; //Field offset: 0x78
		public readonly Material finalPass; //Field offset: 0x80
		public readonly Material lensFlareDataDriven; //Field offset: 0x88
		public readonly Material lensFlareScreenSpace; //Field offset: 0x90

		[CalledBy(Type = typeof(PostProcessPass), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderPassEvent), typeof(PostProcessData), typeof(PostProcessParams&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(MaterialLibrary), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(Material))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 23)]
		public MaterialLibrary(PostProcessData data) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CoreUtils), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		internal void Cleanup() { }

		[CalledBy(Type = typeof(MaterialLibrary), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessData)}, ReturnType = typeof(void))]
		[CallerCount(Count = 17)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Shader), Member = "get_isSupported", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CoreUtils), Member = "CreateEngineMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Shader)}, ReturnType = typeof(Material))]
		[Calls(Type = typeof(Debug), Member = "LogErrorFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		private Material Load(Shader shader) { }

	}

	private class MotionBlurPassData
	{
		internal TextureHandle destinationTexture; //Field offset: 0x10
		internal TextureHandle sourceTexture; //Field offset: 0x20
		internal TextureHandle motionVectors; //Field offset: 0x30
		internal Material material; //Field offset: 0x40
		internal int passIndex; //Field offset: 0x48
		internal Camera camera; //Field offset: 0x50
		internal XRPass xr; //Field offset: 0x58
		internal float intensity; //Field offset: 0x60
		internal float clamp; //Field offset: 0x64
		internal bool enableAlphaOutput; //Field offset: 0x68

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public MotionBlurPassData() { }

	}

	private class PaniniProjectionPassData
	{
		internal TextureHandle destinationTexture; //Field offset: 0x10
		internal TextureHandle sourceTexture; //Field offset: 0x20
		internal RenderTextureDescriptor sourceTextureDesc; //Field offset: 0x30
		internal Material material; //Field offset: 0x68
		internal Vector4 paniniParams; //Field offset: 0x70
		internal bool isPaniniGeneric; //Field offset: 0x80

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public PaniniProjectionPassData() { }

	}

	private class PostFXSetupPassData
	{

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public PostFXSetupPassData() { }

	}

	private class PostProcessingFinalBlitPassData
	{
		internal TextureHandle destinationTexture; //Field offset: 0x10
		internal TextureHandle sourceTexture; //Field offset: 0x20
		internal Material material; //Field offset: 0x30
		internal UniversalCameraData cameraData; //Field offset: 0x38
		internal FinalBlitSettings settings; //Field offset: 0x40

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public PostProcessingFinalBlitPassData() { }

	}

	private class PostProcessingFinalFSRScalePassData
	{
		internal TextureHandle destinationTexture; //Field offset: 0x10
		internal TextureHandle sourceTexture; //Field offset: 0x20
		internal Material material; //Field offset: 0x30
		internal bool enableAlphaOutput; //Field offset: 0x38

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public PostProcessingFinalFSRScalePassData() { }

	}

	private class PostProcessingFinalSetupPassData
	{
		internal TextureHandle destinationTexture; //Field offset: 0x10
		internal TextureHandle sourceTexture; //Field offset: 0x20
		internal Material material; //Field offset: 0x30
		internal UniversalCameraData cameraData; //Field offset: 0x38

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public PostProcessingFinalSetupPassData() { }

	}

	private static class ShaderConstants
	{
		public static readonly int _TempTarget; //Field offset: 0x0
		public static readonly int _TempTarget2; //Field offset: 0x4
		public static readonly int _StencilRef; //Field offset: 0x8
		public static readonly int _StencilMask; //Field offset: 0xC
		public static readonly int _FullCoCTexture; //Field offset: 0x10
		public static readonly int _HalfCoCTexture; //Field offset: 0x14
		public static readonly int _DofTexture; //Field offset: 0x18
		public static readonly int _CoCParams; //Field offset: 0x1C
		public static readonly int _BokehKernel; //Field offset: 0x20
		public static readonly int _BokehConstants; //Field offset: 0x24
		public static readonly int _PongTexture; //Field offset: 0x28
		public static readonly int _PingTexture; //Field offset: 0x2C
		public static readonly int _Metrics; //Field offset: 0x30
		public static readonly int _AreaTexture; //Field offset: 0x34
		public static readonly int _SearchTexture; //Field offset: 0x38
		public static readonly int _EdgeTexture; //Field offset: 0x3C
		public static readonly int _BlendTexture; //Field offset: 0x40
		public static readonly int _ColorTexture; //Field offset: 0x44
		public static readonly int _Params; //Field offset: 0x48
		public static readonly int _SourceTexLowMip; //Field offset: 0x4C
		public static readonly int _Bloom_Params; //Field offset: 0x50
		public static readonly int _Bloom_Texture; //Field offset: 0x54
		public static readonly int _LensDirt_Texture; //Field offset: 0x58
		public static readonly int _LensDirt_Params; //Field offset: 0x5C
		public static readonly int _LensDirt_Intensity; //Field offset: 0x60
		public static readonly int _Distortion_Params1; //Field offset: 0x64
		public static readonly int _Distortion_Params2; //Field offset: 0x68
		public static readonly int _Chroma_Params; //Field offset: 0x6C
		public static readonly int _Vignette_Params1; //Field offset: 0x70
		public static readonly int _Vignette_Params2; //Field offset: 0x74
		public static readonly int _Vignette_ParamsXR; //Field offset: 0x78
		public static readonly int _Lut_Params; //Field offset: 0x7C
		public static readonly int _UserLut_Params; //Field offset: 0x80
		public static readonly int _InternalLut; //Field offset: 0x84
		public static readonly int _UserLut; //Field offset: 0x88
		public static readonly int _DownSampleScaleFactor; //Field offset: 0x8C
		public static readonly int _FlareOcclusionRemapTex; //Field offset: 0x90
		public static readonly int _FlareOcclusionTex; //Field offset: 0x94
		public static readonly int _FlareOcclusionIndex; //Field offset: 0x98
		public static readonly int _FlareTex; //Field offset: 0x9C
		public static readonly int _FlareColorValue; //Field offset: 0xA0
		public static readonly int _FlareData0; //Field offset: 0xA4
		public static readonly int _FlareData1; //Field offset: 0xA8
		public static readonly int _FlareData2; //Field offset: 0xAC
		public static readonly int _FlareData3; //Field offset: 0xB0
		public static readonly int _FlareData4; //Field offset: 0xB4
		public static readonly int _FlareData5; //Field offset: 0xB8
		public static readonly int _FullscreenProjMat; //Field offset: 0xBC
		public static Int32[] _BloomMipUp; //Field offset: 0xC0
		public static Int32[] _BloomMipDown; //Field offset: 0xC8

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		private static ShaderConstants() { }

	}

	private class SMAAPassData
	{
		internal TextureHandle destinationTexture; //Field offset: 0x10
		internal TextureHandle sourceTexture; //Field offset: 0x20
		internal TextureHandle depthStencilTexture; //Field offset: 0x30
		internal TextureHandle blendTexture; //Field offset: 0x40
		internal Material material; //Field offset: 0x50

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public SMAAPassData() { }

	}

	private class SMAASetupPassData
	{
		internal Vector4 metrics; //Field offset: 0x10
		internal Texture2D areaTexture; //Field offset: 0x20
		internal Texture2D searchTexture; //Field offset: 0x28
		internal float stencilRef; //Field offset: 0x30
		internal float stencilMask; //Field offset: 0x34
		internal AntialiasingQuality antialiasingQuality; //Field offset: 0x38
		internal Material material; //Field offset: 0x40

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public SMAASetupPassData() { }

	}

	private class StopNaNsPassData
	{
		internal TextureHandle stopNaNTarget; //Field offset: 0x10
		internal TextureHandle sourceTexture; //Field offset: 0x20
		internal Material stopNaN; //Field offset: 0x30

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public StopNaNsPassData() { }

	}

	private class UberPostPassData
	{
		internal TextureHandle destinationTexture; //Field offset: 0x10
		internal TextureHandle sourceTexture; //Field offset: 0x20
		internal TextureHandle lutTexture; //Field offset: 0x30
		internal Vector4 lutParams; //Field offset: 0x40
		internal TextureHandle userLutTexture; //Field offset: 0x50
		internal Vector4 userLutParams; //Field offset: 0x60
		internal Material material; //Field offset: 0x70
		internal UniversalCameraData cameraData; //Field offset: 0x78
		internal TonemappingMode toneMappingMode; //Field offset: 0x80
		internal bool isHdrGrading; //Field offset: 0x84
		internal bool isBackbuffer; //Field offset: 0x85
		internal bool enableAlphaOutput; //Field offset: 0x86
		internal bool hasFinalPass; //Field offset: 0x87

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public UberPostPassData() { }

	}

	private class UberSetupBloomPassData
	{
		internal Vector4 bloomParams; //Field offset: 0x10
		internal Vector4 dirtScaleOffset; //Field offset: 0x20
		internal float dirtIntensity; //Field offset: 0x30
		internal Texture dirtTexture; //Field offset: 0x38
		internal bool highQualityFilteringValue; //Field offset: 0x40
		internal TextureHandle bloomTexture; //Field offset: 0x44
		internal Material uberMaterial; //Field offset: 0x58

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public UberSetupBloomPassData() { }

	}

	private class UpdateCameraResolutionPassData
	{
		internal Vector2Int newCameraTargetSize; //Field offset: 0x10

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public UpdateCameraResolutionPassData() { }

	}

	private const string _UpscaledColorTargetName = "_CameraColorUpscaledSTP"; //Field offset: 0x0
	private static readonly ProfilingSampler m_ProfilingRenderPostProcessing; //Field offset: 0x0
	private const string _TemporalAATargetName = "_TemporalAATarget"; //Field offset: 0x0
	private const int k_GaussianDoFPassComputeCoc = 0; //Field offset: 0x0
	private const int k_GaussianDoFPassDownscalePrefilter = 1; //Field offset: 0x0
	private const int k_GaussianDoFPassBlurH = 2; //Field offset: 0x0
	private const int k_GaussianDoFPassBlurV = 3; //Field offset: 0x0
	private const int k_GaussianDoFPassComposite = 4; //Field offset: 0x0
	private const int k_BokehDoFPassComputeCoc = 0; //Field offset: 0x0
	private const string k_RenderFinalPostProcessingTag = "Blit Final PostProcessing"; //Field offset: 0x0
	private const int k_BokehDoFPassDownscalePrefilter = 1; //Field offset: 0x0
	private const int k_BokehDoFPassPostFilter = 3; //Field offset: 0x0
	private const int k_BokehDoFPassComposite = 4; //Field offset: 0x0
	private const int k_MaxPyramidSize = 16; //Field offset: 0x0
	private const int k_BokehDoFPassBlur = 2; //Field offset: 0x0
	private const string k_RenderPostProcessingTag = "Blit PostProcessing Effects"; //Field offset: 0x0
	private static readonly ProfilingSampler m_ProfilingRenderFinalPostProcessing; //Field offset: 0x8
	internal static readonly int k_ShaderPropertyId_ViewProjM; //Field offset: 0x10
	internal static readonly int k_ShaderPropertyId_PrevViewProjM; //Field offset: 0x14
	internal static readonly int k_ShaderPropertyId_ViewProjMStereo; //Field offset: 0x18
	internal static readonly int k_ShaderPropertyId_PrevViewProjMStereo; //Field offset: 0x1C
	private static readonly int s_CameraDepthTextureID; //Field offset: 0x20
	private RenderTextureDescriptor m_Descriptor; //Field offset: 0xB8
	private RTHandle m_Source; //Field offset: 0xF0
	private RTHandle m_Destination; //Field offset: 0xF8
	private RTHandle m_Depth; //Field offset: 0x100
	private RTHandle m_InternalLut; //Field offset: 0x108
	private RTHandle m_MotionVectors; //Field offset: 0x110
	private RTHandle m_FullCoCTexture; //Field offset: 0x118
	private RTHandle m_HalfCoCTexture; //Field offset: 0x120
	private RTHandle m_PingTexture; //Field offset: 0x128
	private RTHandle m_PongTexture; //Field offset: 0x130
	private RTHandle[] m_BloomMipDown; //Field offset: 0x138
	private RTHandle[] m_BloomMipUp; //Field offset: 0x140
	private TextureHandle[] _BloomMipUp; //Field offset: 0x148
	private TextureHandle[] _BloomMipDown; //Field offset: 0x150
	private RTHandle m_BlendTexture; //Field offset: 0x158
	private RTHandle m_EdgeColorTexture; //Field offset: 0x160
	private RTHandle m_EdgeStencilTexture; //Field offset: 0x168
	private RTHandle m_TempTarget; //Field offset: 0x170
	private RTHandle m_TempTarget2; //Field offset: 0x178
	private RTHandle m_StreakTmpTexture; //Field offset: 0x180
	private RTHandle m_StreakTmpTexture2; //Field offset: 0x188
	private RTHandle m_ScreenSpaceLensFlareResult; //Field offset: 0x190
	private RTHandle m_UserLut; //Field offset: 0x198
	private MaterialLibrary m_Materials; //Field offset: 0x1A0
	private PostProcessData m_Data; //Field offset: 0x1A8
	private DepthOfField m_DepthOfField; //Field offset: 0x1B0
	private MotionBlur m_MotionBlur; //Field offset: 0x1B8
	private ScreenSpaceLensFlare m_LensFlareScreenSpace; //Field offset: 0x1C0
	private PaniniProjection m_PaniniProjection; //Field offset: 0x1C8
	private Bloom m_Bloom; //Field offset: 0x1D0
	private LensDistortion m_LensDistortion; //Field offset: 0x1D8
	private ChromaticAberration m_ChromaticAberration; //Field offset: 0x1E0
	private Vignette m_Vignette; //Field offset: 0x1E8
	private ColorLookup m_ColorLookup; //Field offset: 0x1F0
	private ColorAdjustments m_ColorAdjustments; //Field offset: 0x1F8
	private Tonemapping m_Tonemapping; //Field offset: 0x200
	private FilmGrain m_FilmGrain; //Field offset: 0x208
	private readonly GraphicsFormat m_DefaultColorFormat; //Field offset: 0x210
	private bool m_DefaultColorFormatIsAlpha; //Field offset: 0x214
	private readonly GraphicsFormat m_SMAAEdgeFormat; //Field offset: 0x218
	private readonly GraphicsFormat m_GaussianCoCFormat; //Field offset: 0x21C
	private int m_DitheringTextureIndex; //Field offset: 0x220
	private RenderTargetIdentifier[] m_MRT2; //Field offset: 0x228
	private Vector4[] m_BokehKernel; //Field offset: 0x230
	private int m_BokehHash; //Field offset: 0x238
	private float m_BokehMaxRadius; //Field offset: 0x23C
	private float m_BokehRCPAspect; //Field offset: 0x240
	private bool m_IsFinalPass; //Field offset: 0x244
	private bool m_HasFinalPass; //Field offset: 0x245
	private bool m_EnableColorEncodingIfNeeded; //Field offset: 0x246
	private bool m_UseFastSRGBLinearConversion; //Field offset: 0x247
	private bool m_SupportScreenSpaceLensFlare; //Field offset: 0x248
	private bool m_SupportDataDrivenLensFlare; //Field offset: 0x249
	private bool m_ResolveToScreen; //Field offset: 0x24A
	private bool m_UseSwapBuffer; //Field offset: 0x24B
	private RTHandle m_ScalingSetupTarget; //Field offset: 0x250
	private RTHandle m_UpscaledTarget; //Field offset: 0x258
	private Material m_BlitMaterial; //Field offset: 0x260
	private BloomMaterialParams m_BloomParamsPrev; //Field offset: 0x268

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProfilingSampler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	private static PostProcessPass() { }

	[CalledBy(Type = typeof(PostProcessPasses), Member = "Recreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessData), typeof(PostProcessParams&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "ToLowerInvariant", ReturnType = typeof(string))]
	[Calls(Type = typeof(SystemInfo), Member = "get_graphicsDeviceVendor", ReturnType = typeof(string))]
	[Calls(Type = typeof(SystemInfo), Member = "IsFormatSupported", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat), typeof(GraphicsFormatUsage)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(QualitySettings), Member = "get_activeColorSpace", ReturnType = typeof(ColorSpace))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "HasAlphaChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsFloatFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsHalfFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RTHandles), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier), typeof(string)}, ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(MaterialLibrary), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "set_profilingSampler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProfilingSampler)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ProfilingSampler), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 20)]
	public PostProcessPass(RenderPassEvent evt, PostProcessData data, ref PostProcessParams postProcessParams) { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(PostProcessPass), Member = "GetCompatibleDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(GraphicsFormat)}, ReturnType = typeof(RenderTextureDescriptor))]
	[Calls(Type = typeof(RenderingUtils), Member = "ReAllocateHandleIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle&), typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	private RTHandle <Render>g__GetDestination|89_1(ref <>c__DisplayClass89_0 unnamed_param_0) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private RTHandle <Render>g__GetSource|89_0(ref <>c__DisplayClass89_0 unnamed_param_0) { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(ScriptableRenderer), Member = "get_cameraColorTargetHandle", ReturnType = typeof(RTHandle))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	[CompilerGenerated]
	private void <Render>g__Swap|89_2(ref ScriptableRenderer r, ref <>c__DisplayClass89_0 unnamed_param_1) { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderBloomTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderPostProcessingRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Math), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public int CalcBloomMipCount(Bloom bloom, Vector2Int bloomResolution) { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderBloomTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderPostProcessingRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public Vector2Int CalcBloomResolution(Bloom bloom) { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "DoPaniniProjection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(CommandBuffer), typeof(RTHandle), typeof(RTHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderPaniniProjection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(Camera), typeof(TextureHandle&), typeof(TextureHandle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Camera), Member = "get_fieldOfView", ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private Vector2 CalcCropExtents(Camera camera, float d) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Camera), Member = "get_fieldOfView", ReturnType = typeof(float))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private Vector2 CalcViewExtents(Camera camera) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public bool CanRunOnTile() { }

	[CalledBy(Type = typeof(PostProcessPasses), Member = "Recreate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessData), typeof(PostProcessParams&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPasses), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CoreUtils), Member = "Destroy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsInvalidInstructions]
	public void Cleanup() { }

	[CalledBy(Type = typeof(PostProcessPasses), Member = "ReleaseRenderTargets", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RTHandle), Member = "Release", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public void Dispose() { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "DoDepthOfField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraData&), typeof(CommandBuffer), typeof(RTHandle), typeof(RTHandle), typeof(Rect)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CoreUtils), Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessPass), Member = "PrepareBokehKernel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalVectorArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessPass), Member = "GetCompatibleDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(GraphicsFormat)}, ReturnType = typeof(RenderTextureDescriptor))]
	[Calls(Type = typeof(RenderingUtils), Member = "ReAllocateHandleIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle&), typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PostProcessUtils), Member = "SetSourceSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Blitter), Member = "BlitCameraTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(RTHandle), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void DoBokehDepthOfField(CommandBuffer cmd, RTHandle source, RTHandle destination, Rect pixelRect, bool enableAlphaOutput) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraData), Member = "get_isAlphaOutputEnabled", ReturnType = typeof(Boolean&))]
	[Calls(Type = typeof(PostProcessPass), Member = "DoBokehDepthOfField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(RTHandle), typeof(Rect), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessPass), Member = "DoGaussianDepthOfField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(RTHandle), typeof(Rect), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void DoDepthOfField(ref CameraData cameraData, CommandBuffer cmd, RTHandle source, RTHandle destination, Rect pixelRect) { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "DoDepthOfField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraData&), typeof(CommandBuffer), typeof(RTHandle), typeof(RTHandle), typeof(Rect)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RTHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(Blitter), Member = "BlitTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(Vector4), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTHandle), Member = "get_rtHandleProperties", ReturnType = typeof(RTHandleProperties))]
	[Calls(Type = typeof(CoreUtils), Member = "SetRenderTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderTargetIdentifier[]), typeof(RTHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Blitter), Member = "BlitCameraTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(RTHandle), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessUtils), Member = "SetSourceSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderingUtils), Member = "ReAllocateHandleIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle&), typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PostProcessPass), Member = "GetCompatibleDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(GraphicsFormat)}, ReturnType = typeof(RenderTextureDescriptor))]
	[Calls(Type = typeof(Material), Member = "SetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CoreUtils), Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	private void DoGaussianDepthOfField(CommandBuffer cmd, RTHandle source, RTHandle destination, Rect pixelRect, bool enableAlphaOutput) { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PostProcessPass), Member = "GetCompatibleDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(GraphicsFormat)}, ReturnType = typeof(RenderTextureDescriptor))]
	[Calls(Type = typeof(ScreenSpaceLensFlare), Member = "IsStreaksActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderingUtils), Member = "ReAllocateHandleIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle&), typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RTHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(Texture))]
	[Calls(Type = typeof(LensFlareCommonSRP), Member = "DoLensFlareScreenSpaceCommon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), typeof(float), typeof(float), typeof(Color), typeof(Texture), typeof(Texture), typeof(Texture), typeof(Texture), typeof(Texture), typeof(Vector4), typeof(Vector4), typeof(Vector4), typeof(Vector4), typeof(Vector4), typeof(CommandBuffer), typeof(RTHandle), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void DoLensFlareScreenSpace(Camera camera, CommandBuffer cmd, RenderTargetIdentifier source, RTHandle originalBloomTexture, RTHandle screenSpaceLensFlareBloomMipTexture) { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CameraData), Member = "get_camera", ReturnType = typeof(Camera&))]
	[Calls(Type = typeof(CameraData), Member = "get_xr", ReturnType = typeof(XRPass))]
	[Calls(Type = typeof(PostProcessPass), Member = "UpdateMotionBlurMatrices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material&), typeof(Camera), typeof(XRPass)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(Texture))]
	[Calls(Type = typeof(Material), Member = "SetTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Texture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessUtils), Member = "SetSourceSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CameraData), Member = "get_isAlphaOutputEnabled", ReturnType = typeof(Boolean&))]
	[Calls(Type = typeof(CoreUtils), Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Blitter), Member = "BlitCameraTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(RTHandle), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private void DoMotionBlur(CommandBuffer cmd, RTHandle source, RTHandle destination, RTHandle motionVectors, ref CameraData cameraData) { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Camera), Member = "get_fieldOfView", ReturnType = typeof(float))]
	[Calls(Type = typeof(PostProcessPass), Member = "CalcCropExtents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(float)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(Material), Member = "SetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Blitter), Member = "BlitCameraTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(RTHandle), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void DoPaniniProjection(Camera camera, CommandBuffer cmd, RTHandle source, RTHandle destination) { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CameraData), Member = "get_cameraTargetDescriptor", ReturnType = typeof(RenderTextureDescriptor&))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetDepthStencilFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(PostProcessPass), Member = "GetCompatibleDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(GraphicsFormat)}, ReturnType = typeof(RenderTextureDescriptor))]
	[Calls(Type = typeof(RenderingUtils), Member = "ReAllocateHandleIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle&), typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RTHandle), Member = "get_rtHandleProperties", ReturnType = typeof(RTHandleProperties))]
	[Calls(Type = typeof(Material), Member = "SetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CameraData), Member = "get_antialiasingQuality", ReturnType = typeof(AntialiasingQuality&))]
	[Calls(Type = typeof(Material), Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderingUtils), Member = "Blit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(Rect), typeof(RTHandle), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(RTHandle), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(ClearFlag), typeof(Color), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Blitter), Member = "BlitCameraTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(RTHandle), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	private void DoSubpixelMorphologicalAntialiasing(ref CameraData cameraData, CommandBuffer cmd, RTHandle source, RTHandle destination) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VolumeManager), Member = "get_instance", ReturnType = typeof(VolumeManager))]
	[Calls(Type = typeof(VolumeStack), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(PostProcessingData), Member = "get_useFastSRGBLinearConversion", ReturnType = typeof(Boolean&))]
	[Calls(Type = typeof(PostProcessingData), Member = "get_supportScreenSpaceLensFlare", ReturnType = typeof(Boolean&))]
	[Calls(Type = typeof(PostProcessingData), Member = "get_supportDataDrivenLensFlare", ReturnType = typeof(Boolean&))]
	[Calls(Type = typeof(RenderingData), Member = "get_commandBuffer", ReturnType = typeof(CommandBuffer&))]
	[Calls(Type = typeof(PostProcessPass), Member = "RenderFinalPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 15)]
	[ContainsUnimplementedInstructions]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "CreateAfterPostProcessTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderTextureDescriptor)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_graphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(void))]
	internal static RenderTextureDescriptor GetCompatibleDescriptor(RenderTextureDescriptor desc, int width, int height, GraphicsFormat format, GraphicsFormat depthStencilFormat = 0) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessPass), Member = "GetCompatibleDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(GraphicsFormat)}, ReturnType = typeof(RenderTextureDescriptor))]
	[CallsDeduplicatedMethods(Count = 1)]
	private RenderTextureDescriptor GetCompatibleDescriptor() { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "GetCompatibleDescriptor", ReturnType = typeof(RenderTextureDescriptor))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "DoSubpixelMorphologicalAntialiasing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraData&), typeof(CommandBuffer), typeof(RTHandle), typeof(RTHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "DoGaussianDepthOfField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(RTHandle), typeof(Rect), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "DoBokehDepthOfField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(RTHandle), typeof(Rect), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "DoLensFlareScreenSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RTHandle), typeof(RTHandle)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "SetupBloom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(Material), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderBloomTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "<Render>g__GetDestination|89_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<>c__DisplayClass89_0&)}, ReturnType = typeof(RTHandle))]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_graphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(void))]
	private RenderTextureDescriptor GetCompatibleDescriptor(int width, int height, GraphicsFormat format, GraphicsFormat depthStencilFormat = 0) { }

	[CalledBy(Type = typeof(<>c), Member = "<LensFlareDataDriven>b__98_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(Camera), typeof(Vector3)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(<>c), Member = "<LensFlareDataDriven>b__98_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(Camera), typeof(Vector3)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(<>c), Member = "<RenderLensFlareDataDriven>b__150_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(Camera), typeof(Vector3)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(<>c), Member = "<RenderLensFlareDataDriven>b__150_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Light), typeof(Camera), typeof(Vector3)}, ReturnType = typeof(float))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Light), Member = "get_type", ReturnType = typeof(LightType))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_forward", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(LensFlareCommonSRP), Member = "ShapeAttenuationDirLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Light), Member = "get_spotAngle", ReturnType = typeof(float))]
	[Calls(Type = typeof(Light), Member = "get_innerSpotAngle", ReturnType = typeof(float))]
	[Calls(Type = typeof(LensFlareCommonSRP), Member = "ShapeAttenuationSpotConeLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Vector3), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static float GetLensFlareLightAttenuation(Light light, Camera cam, Vector3 wo) { }

	[CallerCount(Count = 0)]
	private static float GetMaxBokehRadiusInPixels(float viewportHeight) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "HasAlphaChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
	private bool IsAlphaFormat(GraphicsFormat format) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsHalfFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "IsFloatFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(bool))]
	private bool IsHDRFormat(GraphicsFormat format) { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "get_singlePassEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "get_viewCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(UniversalCameraData), Member = "GetProjectionMatrixNoJitter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(GL), Member = "GetGPUProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(bool)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(UniversalCameraData), Member = "GetViewMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(System.Func`4<System.Object, System.Object, UnityEngine.Vector3, System.Single>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LensFlareCommonSRP), Member = "DoLensFlareDataDrivenCommon", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), typeof(Rect), typeof(XRPass), typeof(int), typeof(float), typeof(float), typeof(bool), typeof(float), typeof(float), typeof(bool), typeof(Vector3), typeof(Matrix4x4), typeof(CommandBuffer), typeof(bool), typeof(bool), typeof(Texture), typeof(Texture), typeof(RenderTargetIdentifier), typeof(System.Func`4<UnityEngine.Light, UnityEngine.Camera, UnityEngine.Vector3, System.Single>), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Camera), Member = "get_projectionMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Camera), Member = "get_worldToCameraMatrix", ReturnType = typeof(Matrix4x4))]
	[CallsUnknownMethods(Count = 3)]
	private void LensFlareDataDriven(ref UniversalCameraData cameraData, CommandBuffer cmd, RenderTargetIdentifier source, bool usePanini, float paniniDistance, float paniniCropToFit) { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LensFlareCommonSRP), Member = "ComputeOcclusion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(Camera), typeof(XRPass), typeof(int), typeof(float), typeof(float), typeof(bool), typeof(float), typeof(float), typeof(bool), typeof(Vector3), typeof(Matrix4x4), typeof(CommandBuffer), typeof(bool), typeof(bool), typeof(Texture), typeof(Texture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Transform), Member = "get_position", ReturnType = typeof(Vector3))]
	[Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Matrix4x4), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(Matrix4x4)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Camera), Member = "get_worldToCameraMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(Camera), Member = "get_projectionMatrix", ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(XRPass), Member = "get_singlePassEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalCameraData), Member = "GetViewMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(GL), Member = "GetGPUProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(bool)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(UniversalCameraData), Member = "GetProjectionMatrixNoJitter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(LensFlareCommonSRP), Member = "IsOcclusionRTCompatible", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "get_viewCount", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private void LensFlareDataDrivenComputeOcclusion(ref UniversalCameraData cameraData, CommandBuffer cmd, RenderTargetIdentifier source, bool usePanini, float paniniDistance, float paniniCropToFit) { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderPostProcessingRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LensFlareCommonSRP), Member = "IsOcclusionRTCompatible", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderGraph), Member = "AddUnsafePass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IUnsafeRenderGraphBuilder))]
	[Calls(Type = typeof(RenderGraph), Member = "ImportTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_cameraDepthTexture", ReturnType = typeof(TextureHandle))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 33)]
	private void LensFlareDataDrivenComputeOcclusion(RenderGraph renderGraph, UniversalResourceData resourceData, UniversalCameraData cameraData) { }

	[CallerCount(Count = 0)]
	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	public virtual void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData) { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "DoBokehDepthOfField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(RTHandle), typeof(Rect), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderDoFBokeh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalResourceData), typeof(UniversalCameraData), typeof(TextureHandle&), typeof(TextureHandle&), typeof(Material&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	[ContainsUnimplementedInstructions]
	private void PrepareBokehKernel(float maxRadius, float rcpAspect) { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RTHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(PostProcessPass), Member = "LensFlareDataDriven", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData&), typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(bool), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessPass), Member = "SetupLensDistortion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessPass), Member = "SetupChromaticAberration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessPass), Member = "SetupVignette", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(XRPass)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessPass), Member = "SetupColorGrading", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&), typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FilmGrain), Member = "IsActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessUtils), Member = "ConfigureFilmGrain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessData), typeof(FilmGrain), typeof(int), typeof(int), typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessUtils), Member = "ConfigureDithering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessData), typeof(int), typeof(int), typeof(int), typeof(Material)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_requireSrgbConversion", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_isHDROutputActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_hdrDisplayInformation", ReturnType = typeof(HDRDisplayInformation))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_hdrDisplayColorGamut", ReturnType = typeof(ColorGamut))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_rendersOverlayUI", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PostProcessPass), Member = "SetupHDROutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HDRDisplayInformation), typeof(ColorGamut), typeof(Material), typeof(Operation), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CoreUtils), Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "GetActiveDebugHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(DebugHandler))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuiltinRenderTextureType)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTHandleStaticHelpers), Member = "SetRTHandleStaticWrapper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderingUtils), Member = "FinalBlit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(UniversalCameraData), typeof(RTHandle), typeof(RTHandle), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessPass), Member = "LensFlareDataDrivenComputeOcclusion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData&), typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(bool), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessPass), Member = "DoLensFlareScreenSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(CommandBuffer), typeof(RenderTargetIdentifier), typeof(RTHandle), typeof(RTHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessPass), Member = "SetupBloom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(Material), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture), Member = "get_filterMode", ReturnType = typeof(FilterMode))]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_isSceneViewCamera", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DepthOfField), Member = "IsActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(LensFlareCommonSRP), Member = "get_Instance", ReturnType = typeof(LensFlareCommonSRP))]
	[Calls(Type = typeof(LensFlareCommonSRP), Member = "IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalCameraData), Member = "IsTemporalAAEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalCameraData), Member = "IsTemporalAARequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TemporalAA), Member = "ValidateAndWarn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "get_cameraColorTargetHandle", ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(GL), Member = "GetGPUProjectionMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4), typeof(bool)}, ReturnType = typeof(Matrix4x4))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessPass), Member = "<Render>g__GetDestination|89_1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(<>c__DisplayClass89_0&)}, ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(Blitter), Member = "BlitCameraTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(RTHandle), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessPass), Member = "<Render>g__Swap|89_2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderer&), typeof(<>c__DisplayClass89_0&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessPass), Member = "DoSubpixelMorphologicalAntialiasing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CameraData&), typeof(CommandBuffer), typeof(RTHandle), typeof(RTHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CameraData), Member = "get_isAlphaOutputEnabled", ReturnType = typeof(Boolean&))]
	[Calls(Type = typeof(PostProcessPass), Member = "DoBokehDepthOfField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(RTHandle), typeof(Rect), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessPass), Member = "DoGaussianDepthOfField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(RTHandle), typeof(Rect), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TemporalAA), Member = "ExecutePass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Material), typeof(CameraData&), typeof(RTHandle), typeof(RTHandle), typeof(RenderTexture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessPass), Member = "DoMotionBlur", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(RTHandle), typeof(RTHandle), typeof(CameraData&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessPass), Member = "DoPaniniProjection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(CommandBuffer), typeof(RTHandle), typeof(RTHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "ConfigureCameraTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle), typeof(RTHandle)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 71)]
	[CallsUnknownMethods(Count = 92)]
	[ContainsUnimplementedInstructions]
	private void Render(CommandBuffer cmd, ref RenderingData renderingData) { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderPostProcessingRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextureHandle), Member = "GetDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(TextureDesc))]
	[Calls(Type = typeof(PostProcessPass), Member = "CalcBloomResolution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bloom)}, ReturnType = typeof(Vector2Int))]
	[Calls(Type = typeof(PostProcessPass), Member = "CalcBloomMipCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bloom), typeof(Vector2Int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Mathf), Member = "GammaToLinearSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(BloomMaterialParams), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BloomMaterialParams&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "HasProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "SetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CoreUtils), Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessPass), Member = "GetCompatibleDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(GraphicsFormat)}, ReturnType = typeof(RenderTextureDescriptor))]
	[Calls(Type = typeof(UniversalRenderer), Member = "CreateRenderGraphTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderTextureDescriptor), typeof(string), typeof(bool), typeof(FilterMode), typeof(TextureWrapMode)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(RenderGraph), Member = "AddUnsafePass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IUnsafeRenderGraphBuilder))]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 70)]
	public void RenderBloomTexture(RenderGraph renderGraph, in TextureHandle source, out TextureHandle destination, bool enableAlphaOutput) { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderPostProcessingRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_graphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderer), Member = "CreateRenderGraphTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderTextureDescriptor), typeof(string), typeof(bool), typeof(FilterMode), typeof(TextureWrapMode)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(CoreUtils), Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessPass), Member = "RenderDoFBokeh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalResourceData), typeof(UniversalCameraData), typeof(TextureHandle&), typeof(TextureHandle&), typeof(Material&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessPass), Member = "RenderDoFGaussian", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalResourceData), typeof(UniversalCameraData), typeof(TextureHandle&), typeof(TextureHandle), typeof(Material&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public void RenderDoF(RenderGraph renderGraph, UniversalResourceData resourceData, UniversalCameraData cameraData, in TextureHandle source, out TextureHandle destination) { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderDoF", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalResourceData), typeof(UniversalCameraData), typeof(TextureHandle&), typeof(TextureHandle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_graphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderer), Member = "CreateRenderGraphTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderTextureDescriptor), typeof(string), typeof(bool), typeof(FilterMode), typeof(TextureWrapMode)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(RenderGraph), Member = "AddUnsafePass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(string), typeof(int)}, ReturnType = typeof(IUnsafeRenderGraphBuilder))]
	[Calls(Type = typeof(PostProcessPass), Member = "PrepareBokehKernel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_cameraDepthTexture", ReturnType = typeof(TextureHandle))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 47)]
	[ContainsUnimplementedInstructions]
	public void RenderDoFBokeh(RenderGraph renderGraph, UniversalResourceData resourceData, UniversalCameraData cameraData, in TextureHandle source, in TextureHandle destination, ref Material dofMaterial) { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderDoF", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalResourceData), typeof(UniversalCameraData), typeof(TextureHandle&), typeof(TextureHandle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_graphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderer), Member = "CreateRenderGraphTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderTextureDescriptor), typeof(string), typeof(bool), typeof(FilterMode), typeof(TextureWrapMode)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(RenderGraph), Member = "AddUnsafePass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(string), typeof(int)}, ReturnType = typeof(IUnsafeRenderGraphBuilder))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_cameraDepthTexture", ReturnType = typeof(TextureHandle))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 46)]
	public void RenderDoFGaussian(RenderGraph renderGraph, UniversalResourceData resourceData, UniversalCameraData cameraData, in TextureHandle source, TextureHandle destination, ref Material dofMaterial) { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderFinalPassRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderGraph), Member = "AddRasterRenderPass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IRasterRenderGraphBuilder))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_rendersOverlayUI", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "get_supportsFoveatedRendering", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 32)]
	public void RenderFinalBlit(RenderGraph renderGraph, UniversalCameraData cameraData, in TextureHandle source, in TextureHandle overlayUITexture, in TextureHandle postProcessingTarget, ref FinalBlitSettings settings) { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderFinalPassRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderGraph), Member = "AddRasterRenderPass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IRasterRenderGraphBuilder))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 20)]
	public void RenderFinalFSRScale(RenderGraph renderGraph, in TextureHandle source, in TextureHandle destination, bool enableAlphaOutput) { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ScriptableRenderContext), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_rendersOverlayUI", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RTHandleStaticHelpers), Member = "SetRTHandleStaticWrapper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderingUtils), Member = "GetCameraTargetIdentifier", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderingData&)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(FSRUtils), Member = "SetRcasConstantsLinear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FSRUtils), Member = "SetEasuConstants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(Vector2), typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Blitter), Member = "BlitCameraTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(RTHandle), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderingUtils), Member = "ReAllocateHandleIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle&), typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_graphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "MakeUnormRenderTextureGraphicsFormat", ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(UniversalCameraData), Member = "IsTemporalAAEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "GetActiveDebugHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(DebugHandler))]
	[Calls(Type = typeof(CoreUtils), Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessPass), Member = "SetupHDROutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HDRDisplayInformation), typeof(ColorGamut), typeof(Material), typeof(Operation), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_hdrDisplayColorGamut", ReturnType = typeof(ColorGamut))]
	[Calls(Type = typeof(RenderingUtils), Member = "FinalBlit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(UniversalCameraData), typeof(RTHandle), typeof(RTHandle), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_hdrDisplayInformation", ReturnType = typeof(HDRDisplayInformation))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_isHDROutputActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CameraData), Member = "get_requireSrgbConversion", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PostProcessUtils), Member = "ConfigureDithering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessData), typeof(int), typeof(int), typeof(int), typeof(Material)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(PostProcessUtils), Member = "ConfigureFilmGrain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessData), typeof(FilmGrain), typeof(int), typeof(int), typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FilmGrain), Member = "IsActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CameraData), Member = "get_universalCameraData", ReturnType = typeof(UniversalCameraData))]
	[Calls(Type = typeof(PostProcessUtils), Member = "SetSourceSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ScriptableRenderer), Member = "get_cameraColorTargetHandle", ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(ScriptableRenderer), Member = "ConfigureCameraTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle), typeof(RTHandle)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void RenderFinalPass(CommandBuffer cmd, ref RenderingData renderingData) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnAfterRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_hdrDisplayInformation", ReturnType = typeof(HDRDisplayInformation))]
	[Calls(Type = typeof(PostProcessPass), Member = "RenderFinalSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalCameraData), typeof(TextureHandle&), typeof(TextureHandle&), typeof(FinalBlitSettings&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderer), Member = "CreateRenderGraphTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderTextureDescriptor), typeof(string), typeof(bool), typeof(FilterMode), typeof(TextureWrapMode)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_graphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "MakeUnormRenderTextureGraphicsFormat", ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(UniversalCameraData), Member = "IsSTPEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalCameraData), Member = "IsTemporalAAEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "GetActiveDebugHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(DebugHandler))]
	[Calls(Type = typeof(PostProcessPass), Member = "SetupHDROutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HDRDisplayInformation), typeof(ColorGamut), typeof(Material), typeof(Operation), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_rendersOverlayUI", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_hdrDisplayColorGamut", ReturnType = typeof(ColorGamut))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_isHDROutputActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CoreUtils), Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_requireSrgbConversion", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PostProcessUtils), Member = "ConfigureDithering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessData), typeof(int), typeof(int), typeof(int), typeof(Material)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(PostProcessUtils), Member = "ConfigureFilmGrain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessData), typeof(FilmGrain), typeof(int), typeof(int), typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FilmGrain), Member = "IsActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(FinalBlitSettings), Member = "Create", ReturnType = typeof(FinalBlitSettings))]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(VolumeStack), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(VolumeManager), Member = "get_instance", ReturnType = typeof(VolumeManager))]
	[Calls(Type = typeof(PostProcessPass), Member = "RenderFinalFSRScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessPass), Member = "RenderFinalBlit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalCameraData), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(FinalBlitSettings&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public void RenderFinalPassRenderGraph(RenderGraph renderGraph, ContextContainer frameData, in TextureHandle source, in TextureHandle overlayUITexture, in TextureHandle postProcessingTarget, bool enableColorEncodingIfNeeded) { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderFinalPassRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderGraph), Member = "AddRasterRenderPass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IRasterRenderGraphBuilder))]
	[Calls(Type = typeof(CoreUtils), Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_hdrDisplayInformation", ReturnType = typeof(HDRDisplayInformation))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_hdrDisplayColorGamut", ReturnType = typeof(ColorGamut))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_rendersOverlayUI", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PostProcessPass), Member = "SetupHDROutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HDRDisplayInformation), typeof(ColorGamut), typeof(Material), typeof(Operation), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 25)]
	public void RenderFinalSetup(RenderGraph renderGraph, UniversalCameraData cameraData, in TextureHandle source, in TextureHandle destination, ref FinalBlitSettings settings) { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderPostProcessingRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderGraph), Member = "AddUnsafePass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IUnsafeRenderGraphBuilder))]
	[Calls(Type = typeof(LensFlareCommonSRP), Member = "IsOcclusionRTCompatible", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_cameraDepthTexture", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(RenderGraph), Member = "ImportTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(TextureHandle))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 38)]
	public void RenderLensFlareDataDriven(RenderGraph renderGraph, UniversalResourceData resourceData, UniversalCameraData cameraData, in TextureHandle destination) { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderPostProcessingRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_graphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderer), Member = "CreateRenderGraphTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderTextureDescriptor), typeof(string), typeof(bool), typeof(FilterMode), typeof(TextureWrapMode)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(RenderGraph), Member = "AddUnsafePass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IUnsafeRenderGraphBuilder))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 36)]
	[ContainsUnimplementedInstructions]
	public TextureHandle RenderLensFlareScreenSpace(RenderGraph renderGraph, Camera camera, in TextureHandle destination, TextureHandle originalBloomTexture, TextureHandle screenSpaceLensFlareBloomMipTexture, bool enableXR, bool sameInputOutputTex) { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderPostProcessingRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_graphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderer), Member = "CreateRenderGraphTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderTextureDescriptor), typeof(string), typeof(bool), typeof(FilterMode), typeof(TextureWrapMode)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_motionVectorColor", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_cameraDepthTexture", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(RenderGraph), Member = "AddRasterRenderPass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IRasterRenderGraphBuilder))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 37)]
	public void RenderMotionBlur(RenderGraph renderGraph, UniversalResourceData resourceData, UniversalCameraData cameraData, in TextureHandle source, out TextureHandle destination) { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderPostProcessingRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_graphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderer), Member = "CreateRenderGraphTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderTextureDescriptor), typeof(string), typeof(bool), typeof(FilterMode), typeof(TextureWrapMode)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(Camera), Member = "get_fieldOfView", ReturnType = typeof(float))]
	[Calls(Type = typeof(PostProcessPass), Member = "CalcCropExtents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(float)}, ReturnType = typeof(Vector2))]
	[Calls(Type = typeof(RenderGraph), Member = "AddRasterRenderPass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IRasterRenderGraphBuilder))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 23)]
	[ContainsUnimplementedInstructions]
	public void RenderPaniniProjection(RenderGraph renderGraph, Camera camera, in TextureHandle source, out TextureHandle destination) { }

	[CalledBy(Type = typeof(UniversalRenderer), Member = "OnAfterRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PostProcessPass), Member = "RenderSTP", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalResourceData), typeof(UniversalCameraData), typeof(TextureHandle&), typeof(TextureHandle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessPass), Member = "RenderBloomTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessPass), Member = "CalcBloomResolution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bloom)}, ReturnType = typeof(Vector2Int))]
	[Calls(Type = typeof(PostProcessPass), Member = "CalcBloomMipCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Bloom), typeof(Vector2Int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PostProcessPass), Member = "RenderLensFlareScreenSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(Camera), typeof(TextureHandle&), typeof(TextureHandle), typeof(TextureHandle), typeof(bool), typeof(bool)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(PostProcessPass), Member = "UberPostSetupBloomPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(TextureHandle&), typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessPass), Member = "LensFlareDataDrivenComputeOcclusion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalResourceData), typeof(UniversalCameraData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessPass), Member = "RenderLensFlareDataDriven", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalResourceData), typeof(UniversalCameraData), typeof(TextureHandle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessPass), Member = "SetupLensDistortion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessPass), Member = "SetupChromaticAberration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessPass), Member = "SetupVignette", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(XRPass)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FilmGrain), Member = "IsActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessUtils), Member = "ConfigureFilmGrain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessData), typeof(FilmGrain), typeof(int), typeof(int), typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessUtils), Member = "ConfigureDithering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessData), typeof(int), typeof(int), typeof(int), typeof(Material)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_requireSrgbConversion", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CoreUtils), Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_isHDROutputActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_hdrDisplayInformation", ReturnType = typeof(HDRDisplayInformation))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_hdrDisplayColorGamut", ReturnType = typeof(ColorGamut))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_rendersOverlayUI", ReturnType = typeof(bool))]
	[Calls(Type = typeof(PostProcessPass), Member = "SetupHDROutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HDRDisplayInformation), typeof(ColorGamut), typeof(Material), typeof(Operation), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessPass), Member = "RenderPaniniProjection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(Camera), typeof(TextureHandle&), typeof(TextureHandle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessPass), Member = "RenderMotionBlur", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalResourceData), typeof(UniversalCameraData), typeof(TextureHandle&), typeof(TextureHandle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(TemporalAA), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(Material), typeof(UniversalCameraData), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Time), Member = "get_frameCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(VolumeManager), Member = "get_instance", ReturnType = typeof(VolumeManager))]
	[Calls(Type = typeof(VolumeStack), Member = "GetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_useMipMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_autoGenerateMips", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_isSceneViewCamera", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(DepthOfField), Member = "IsActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(LensFlareCommonSRP), Member = "get_Instance", ReturnType = typeof(LensFlareCommonSRP))]
	[Calls(Type = typeof(LensFlareCommonSRP), Member = "IsEmpty", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(ScriptableRenderPass), Member = "GetActiveDebugHandler", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData)}, ReturnType = typeof(DebugHandler))]
	[Calls(Type = typeof(PostProcessPass), Member = "RenderUberPost", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(UniversalCameraData), typeof(UniversalPostProcessingData), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalCameraData), Member = "IsTemporalAAEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalCameraData), Member = "IsSTPRequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalCameraData), Member = "IsTemporalAARequested", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TemporalAA), Member = "ValidateAndWarn", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UniversalCameraData), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RenderGraph), Member = "AddRasterRenderPass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IRasterRenderGraphBuilder))]
	[Calls(Type = typeof(PostProcessPass), Member = "RenderStopNaN", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderTextureDescriptor), typeof(TextureHandle&), typeof(TextureHandle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessPass), Member = "RenderSMAA", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalResourceData), typeof(AntialiasingQuality), typeof(TextureHandle&), typeof(TextureHandle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessPass), Member = "RenderDoF", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalResourceData), typeof(UniversalCameraData), typeof(TextureHandle&), typeof(TextureHandle&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_graphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderer), Member = "CreateRenderGraphTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderTextureDescriptor), typeof(string), typeof(bool), typeof(FilterMode), typeof(TextureWrapMode)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_motionVectorColor", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 26)]
	[ContainsUnimplementedInstructions]
	public void RenderPostProcessingRenderGraph(RenderGraph renderGraph, ContextContainer frameData, in TextureHandle activeCameraColorTexture, in TextureHandle lutTexture, in TextureHandle overlayUITexture, in TextureHandle postProcessingTarget, bool hasFinalPass, bool resolveToDebugScreen, bool enableColorEndingIfNeeded) { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderPostProcessingRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_graphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderer), Member = "CreateRenderGraphTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderTextureDescriptor), typeof(string), typeof(bool), typeof(FilterMode), typeof(TextureWrapMode)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(GraphicsFormatUtility), Member = "GetDepthStencilFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(GraphicsFormat))]
	[Calls(Type = typeof(RenderGraph), Member = "AddRasterRenderPass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IRasterRenderGraphBuilder))]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallsUnknownMethods(Count = 80)]
	public void RenderSMAA(RenderGraph renderGraph, UniversalResourceData resourceData, AntialiasingQuality antialiasingQuality, in TextureHandle source, out TextureHandle SMAATarget) { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderPostProcessingRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_graphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderer), Member = "CreateRenderGraphTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderTextureDescriptor), typeof(string), typeof(bool), typeof(FilterMode), typeof(TextureWrapMode)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(RenderGraph), Member = "AddRasterRenderPass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IRasterRenderGraphBuilder))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 17)]
	public void RenderStopNaN(RenderGraph renderGraph, RenderTextureDescriptor cameraTargetDescriptor, in TextureHandle activeCameraColor, out TextureHandle stopNaNTarget) { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderPostProcessingRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_cameraDepthTexture", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_motionVectorColor", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_graphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_enableRandomWrite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_sRGB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderer), Member = "CreateRenderGraphTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderTextureDescriptor), typeof(string), typeof(bool), typeof(FilterMode), typeof(TextureWrapMode)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(Time), Member = "get_frameCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(StpUtils), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalResourceData), typeof(UniversalCameraData), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(TextureHandle), typeof(Texture2D)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessPass), Member = "UpdateCameraResolution", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalCameraData), typeof(Vector2Int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void RenderSTP(RenderGraph renderGraph, UniversalResourceData resourceData, UniversalCameraData cameraData, ref TextureHandle source, out TextureHandle destination) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_graphicsFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GraphicsFormat)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UniversalRenderer), Member = "CreateRenderGraphTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(RenderTextureDescriptor), typeof(string), typeof(bool), typeof(FilterMode), typeof(TextureWrapMode)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_motionVectorColor", ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(TemporalAA), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(Material), typeof(UniversalCameraData), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void RenderTemporalAA(RenderGraph renderGraph, UniversalResourceData resourceData, UniversalCameraData cameraData, ref TextureHandle source, out TextureHandle destination) { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderPostProcessingRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PostProcessPass), Member = "TryGetCachedUserLutTextureHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(TextureHandle))]
	[Calls(Type = typeof(ColorLookup), Member = "IsActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(RenderGraph), Member = "AddRasterRenderPass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IRasterRenderGraphBuilder))]
	[Calls(Type = typeof(ContextContainer), Member = "Get", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_xrUniversal", ReturnType = typeof(XRPassUniversal))]
	[Calls(Type = typeof(UniversalResourceData), Member = "get_isActiveTargetBackBuffer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "get_supportsFoveatedRendering", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 52)]
	[ContainsUnimplementedInstructions]
	public void RenderUberPost(RenderGraph renderGraph, ContextContainer frameData, UniversalCameraData cameraData, UniversalPostProcessingData postProcessingData, in TextureHandle sourceTexture, in TextureHandle destTexture, in TextureHandle lutTexture, in TextureHandle overlayUITexture, bool requireHDROutput, bool enableAlphaOutput, bool resolveToDebugScreen, bool hasFinalPass) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UniversalCameraData), Member = "get_isHDROutputActive", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool RequireHDROutput(UniversalCameraData cameraData) { }

	[CallerCount(Count = 0)]
	private bool RequireSRGBConversionBlitToBackBuffer(bool requireSrgbConversion) { }

	[CalledBy(Type = typeof(<>c), Member = "<RenderFinalSetup>b__155_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessingFinalSetupPassData), typeof(RasterGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(<>c), Member = "<RenderUberPost>b__164_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UberPostPassData), typeof(RasterGraphContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderingUtils), Member = "GetFinalBlitScaleBias", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle), typeof(RTHandle), typeof(UniversalCameraData)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(RenderTargetIdentifier), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuiltinRenderTextureType)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Blitter), Member = "BlitTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RasterCommandBuffer), typeof(RTHandle), typeof(Vector4), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static void ScaleViewportAndBlit(RasterCommandBuffer cmd, RTHandle sourceTextureHdl, RTHandle dest, UniversalCameraData cameraData, Material material, bool hasFinalPass) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_useMipMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RenderTextureDescriptor), Member = "set_autoGenerateMips", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public void Setup(in RenderTextureDescriptor baseDescriptor, in RTHandle source, bool resolveToScreen, in RTHandle depth, in RTHandle internalLut, in RTHandle motionVectors, bool hasFinalPass, bool enableColorEncoding) { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Blitter), Member = "BlitCameraTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(RTHandle), typeof(RenderBufferLoadAction), typeof(RenderBufferStoreAction), typeof(Material), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Texture2D), Member = "get_blackTexture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ColorUtils), Member = "Luminance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color&)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RenderTargetIdentifier)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(RTHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(RenderTargetIdentifier))]
	[Calls(Type = typeof(RenderingUtils), Member = "ReAllocateHandleIfNeeded", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle&), typeof(RenderTextureDescriptor&), typeof(FilterMode), typeof(TextureWrapMode), typeof(int), typeof(float), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(PostProcessPass), Member = "GetCompatibleDescriptor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(GraphicsFormat), typeof(GraphicsFormat)}, ReturnType = typeof(RenderTextureDescriptor))]
	[Calls(Type = typeof(CoreUtils), Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "SetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mathf), Member = "GammaToLinearSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Math), Member = "Log", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(Material), Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	private void SetupBloom(CommandBuffer cmd, RTHandle source, Material uberMaterial, bool enableAlphaOutput) { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderPostProcessingRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Material), Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private void SetupChromaticAberration(Material material) { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PostProcessingData), Member = "get_gradingMode", ReturnType = typeof(ColorGradingMode&))]
	[Calls(Type = typeof(PostProcessingData), Member = "get_lutSize", ReturnType = typeof(Int32&))]
	[Calls(Type = typeof(RTHandle), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(Texture))]
	[Calls(Type = typeof(Material), Member = "SetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ColorLookup), Member = "IsActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 2)]
	private void SetupColorGrading(CommandBuffer cmd, ref RenderingData renderingData, Material material) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessUtils), Member = "ConfigureDithering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessData), typeof(int), typeof(int), typeof(int), typeof(Material)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	private void SetupDithering(UniversalCameraData cameraData, Material material) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public void SetupFinalPass(in RTHandle source, bool useSwapBuffer = false, bool enableColorEncoding = true) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FilmGrain), Member = "IsActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(PostProcessUtils), Member = "ConfigureFilmGrain", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PostProcessData), typeof(FilmGrain), typeof(int), typeof(int), typeof(Material)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void SetupGrain(UniversalCameraData cameraData, Material material) { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderFinalPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderFinalSetup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalCameraData), typeof(TextureHandle&), typeof(TextureHandle&), typeof(FinalBlitSettings&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderFinalPassRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderPostProcessingRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UniversalRenderPipeline), Member = "GetHDROutputLuminanceParameters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(HDRDisplayInformation), typeof(ColorGamut), typeof(Tonemapping), typeof(Vector4&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "SetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HDROutputUtils), Member = "ConfigureHDROutput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(ColorGamut), typeof(Operation)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CoreUtils), Member = "SetKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void SetupHDROutput(HDRDisplayInformation hdrDisplayInformation, ColorGamut hdrDisplayColorGamut, Material material, Operation hdrOperations, bool rendersOverlayUI) { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderPostProcessingRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Material), Member = "SetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LensDistortion), Member = "IsActive", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "EnableKeyword", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	private void SetupLensDistortion(Material material, bool isSceneView) { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "Render", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RenderingData&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderPostProcessingRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "get_singlePassEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "ApplyXRViewCenterOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(Material), Member = "SetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	private void SetupVignette(Material material, XRPass xrPass) { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderUberPost", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(UniversalCameraData), typeof(UniversalPostProcessingData), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(RTHandle), Member = "Release", ReturnType = typeof(void))]
	[Calls(Type = typeof(RTHandles), Member = "Alloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture)}, ReturnType = typeof(RTHandle))]
	[Calls(Type = typeof(RenderGraph), Member = "ImportTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RTHandle)}, ReturnType = typeof(TextureHandle))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private TextureHandle TryGetCachedUserLutTextureHandle(RenderGraph renderGraph) { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderPostProcessingRenderGraph", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(ContextContainer), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(TextureHandle&), typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderGraph), Member = "AddRasterRenderPass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(ProfilingSampler), typeof(string), typeof(int)}, ReturnType = typeof(IRasterRenderGraphBuilder))]
	[Calls(Type = typeof(Mathf), Member = "GammaToLinearSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(ColorUtils), Member = "Luminance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Color&)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Texture2D), Member = "get_blackTexture", ReturnType = typeof(Texture2D))]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 34)]
	public void UberPostSetupBloomPass(RenderGraph rendergraph, in TextureHandle bloomTexture, Material uberMaterial) { }

	[CalledBy(Type = typeof(PostProcessPass), Member = "RenderSTP", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph), typeof(UniversalResourceData), typeof(UniversalCameraData), typeof(TextureHandle&), typeof(TextureHandle&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderGraph), Member = "AddUnsafePass", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"PassData"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "PassData&", typeof(string), typeof(int)}, ReturnType = typeof(IUnsafeRenderGraphBuilder))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	private void UpdateCameraResolution(RenderGraph renderGraph, UniversalCameraData cameraData, Vector2Int newCameraTargetSize) { }

	[CalledBy(Type = typeof(<>c), Member = "<RenderMotionBlur>b__147_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MotionBlurPassData), typeof(RasterGraphContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PostProcessPass), Member = "DoMotionBlur", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(RTHandle), typeof(RTHandle), typeof(RTHandle), typeof(CameraData&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Component), Member = "TryGetComponent", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "get_enabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XRPass), Member = "get_singlePassEnabled", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "SetMatrixArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Matrix4x4[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "SetMatrix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal static void UpdateMotionBlurMatrices(ref Material material, Camera camera, XRPass xr) { }

}

