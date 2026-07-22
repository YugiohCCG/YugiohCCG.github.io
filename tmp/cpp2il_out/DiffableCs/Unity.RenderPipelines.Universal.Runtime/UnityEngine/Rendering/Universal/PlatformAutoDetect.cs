namespace UnityEngine.Rendering.Universal;

internal static class PlatformAutoDetect
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GraphicsSettings), Member = "HasShaderDefine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuiltinShaderDefine)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
		[Calls(Type = typeof(SystemInfo), Member = "get_graphicsDeviceName", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal PlatformDetectionCache <.cctor>b__14_0() { }

	}

	private sealed class PlatformDetectionCache
	{
		public readonly bool isXRMobile; //Field offset: 0x10
		public readonly bool isShaderAPIMobileDefined; //Field offset: 0x11
		public readonly bool isSwitch; //Field offset: 0x12
		public readonly bool isSwitch2; //Field offset: 0x13
		public readonly bool isRunningOnPowerVRGPU; //Field offset: 0x14

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GraphicsSettings), Member = "HasShaderDefine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BuiltinShaderDefine)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
		[Calls(Type = typeof(SystemInfo), Member = "get_graphicsDeviceName", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Contains", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		public PlatformDetectionCache() { }

	}

	private static readonly Lazy<PlatformDetectionCache> platformCache; //Field offset: 0x0

	internal static bool isRunningOnPowerVRGPU
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Lazy`1<System.Object>), Member = "get_Value", ReturnType = typeof(object))]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 121
	}

	internal static bool isShaderAPIMobileDefined
	{
		[CalledBy(Type = typeof(DecalRendererFeature), Member = "GetTechnique", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(DecalTechnique))]
		[CalledBy(Type = typeof(DecalRendererFeature), Member = "IsAutomaticDBuffer", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "get_maxVisibleAdditionalLights", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(PlatformAutoDetect), Member = "ShAutoDetect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShEvalMode)}, ReturnType = typeof(ShEvalMode))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(System.Lazy`1<System.Object>), Member = "get_Value", ReturnType = typeof(object))]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 121
	}

	internal static bool isSwitch
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Lazy`1<System.Object>), Member = "get_Value", ReturnType = typeof(object))]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 121
	}

	internal static bool isSwitch2
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Lazy`1<System.Object>), Member = "get_Value", ReturnType = typeof(object))]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 121
	}

	internal static bool isXRMobile
	{
		[CalledBy(Type = typeof(ScriptableRenderer), Member = "BeginRenderGraphXRRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(System.Lazy`1<System.Object>), Member = "get_Value", ReturnType = typeof(object))]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 121
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Lazy`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<System.Object>), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static PlatformAutoDetect() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Lazy`1<System.Object>), Member = "get_Value", ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 1)]
	internal static bool get_isRunningOnPowerVRGPU() { }

	[CalledBy(Type = typeof(DecalRendererFeature), Member = "GetTechnique", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool), typeof(bool)}, ReturnType = typeof(DecalTechnique))]
	[CalledBy(Type = typeof(DecalRendererFeature), Member = "IsAutomaticDBuffer", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UniversalRenderPipeline), Member = "get_maxVisibleAdditionalLights", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(PlatformAutoDetect), Member = "ShAutoDetect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ShEvalMode)}, ReturnType = typeof(ShEvalMode))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(System.Lazy`1<System.Object>), Member = "get_Value", ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 1)]
	internal static bool get_isShaderAPIMobileDefined() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Lazy`1<System.Object>), Member = "get_Value", ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 1)]
	internal static bool get_isSwitch() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Lazy`1<System.Object>), Member = "get_Value", ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 1)]
	internal static bool get_isSwitch2() { }

	[CalledBy(Type = typeof(ScriptableRenderer), Member = "BeginRenderGraphXRRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderGraph)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Lazy`1<System.Object>), Member = "get_Value", ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 1)]
	internal static bool get_isXRMobile() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Lazy`1<System.Object>), Member = "get_Value", ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 1)]
	internal static void Initialize() { }

	[CalledBy(Type = typeof(ForwardLights), Member = "SetupLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeCommandBuffer), typeof(UniversalRenderingData), typeof(UniversalCameraData), typeof(UniversalLightData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Lazy`1<System.Object>), Member = "get_Value", ReturnType = typeof(object))]
	[Calls(Type = typeof(PlatformAutoDetect), Member = "get_isShaderAPIMobileDefined", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	internal static ShEvalMode ShAutoDetect(ShEvalMode mode) { }

}

