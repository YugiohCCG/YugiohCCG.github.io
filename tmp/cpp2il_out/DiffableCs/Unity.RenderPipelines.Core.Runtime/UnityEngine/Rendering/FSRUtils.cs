namespace UnityEngine.Rendering;

public static class FSRUtils
{
	private static class ShaderConstants
	{
		public static readonly int _FsrEasuConstants0; //Field offset: 0x0
		public static readonly int _FsrEasuConstants1; //Field offset: 0x4
		public static readonly int _FsrEasuConstants2; //Field offset: 0x8
		public static readonly int _FsrEasuConstants3; //Field offset: 0xC
		public static readonly int _FsrRcasConstants; //Field offset: 0x10

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		private static ShaderConstants() { }

	}

	internal const float kMaxSharpnessStops = 2.5; //Field offset: 0x0
	public const float kDefaultSharpnessStops = 0.2; //Field offset: 0x0
	public const float kDefaultSharpnessLinear = 0.92; //Field offset: 0x0

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipeline", Member = "ResolveUpscalingFilterSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(float), "UnityEngine.Rendering.Universal.UpscalingFilterSelection", typeof(bool)}, ReturnType = "UnityEngine.Rendering.Universal.ImageUpscalingFilter")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool IsSupported() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "RenderFinalPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void SetEasuConstants(CommandBuffer cmd, Vector2 inputViewportSizeInPixels, Vector2 inputImageSizeInPixels, Vector2 outputImageSizeInPixels) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass+<>c", Member = "<RenderFinalFSRScale>b__157_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessPass+PostProcessingFinalFSRScalePassData", typeof(RasterGraphContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static void SetEasuConstants(BaseCommandBuffer cmd, Vector2 inputViewportSizeInPixels, Vector2 inputImageSizeInPixels, Vector2 outputImageSizeInPixels) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mathf), Member = "FloatToHalf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static void SetRcasConstants(CommandBuffer cmd, float sharpnessStops = 0.2) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass", Member = "RenderFinalPass", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), "UnityEngine.Rendering.Universal.RenderingData&"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Mathf), Member = "FloatToHalf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static void SetRcasConstantsLinear(CommandBuffer cmd, float sharpnessLinear = 0.92) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.PostProcessPass+<>c", Member = "<RenderFinalBlit>b__160_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.Universal.PostProcessPass+PostProcessingFinalBlitPassData", typeof(RasterGraphContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Mathf), Member = "FloatToHalf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(ushort))]
	[Calls(Type = typeof(CommandBuffer), Member = "SetGlobalVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public static void SetRcasConstantsLinear(RasterCommandBuffer cmd, float sharpnessLinear = 0.92) { }

}

