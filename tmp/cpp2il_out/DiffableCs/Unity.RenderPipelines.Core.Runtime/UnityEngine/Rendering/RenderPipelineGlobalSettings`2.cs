namespace UnityEngine.Rendering;

public abstract class RenderPipelineGlobalSettings : RenderPipelineGlobalSettings
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<TGlobalRenderPipelineSettings, TRenderPipeline> <>9; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		[DeduplicatedMethod]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GraphicsSettings), Member = "GetSettingsForRenderPipeline", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(RenderPipelineGlobalSettings))]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		internal TGlobalRenderPipelineSettings <.cctor>b__5_0() { }

	}

	private static Lazy<TGlobalRenderPipelineSettings> s_Instance; //Field offset: 0x0

	public static TGlobalRenderPipelineSettings instance
	{
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(System.Lazy`1<System.Object>), Member = "get_Value", ReturnType = typeof(object))]
		[CallsUnknownMethods(Count = 6)]
		[DeduplicatedMethod]
		 get { } //Length: 198
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Lazy`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<System.Object>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	[DeduplicatedMethod]
	private static RenderPipelineGlobalSettings`2() { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.UniversalRenderPipelineGlobalSettings", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(RenderPipelineGlobalSettings), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	protected RenderPipelineGlobalSettings`2() { }

	[CallerCount(Count = 9)]
	[Calls(Type = typeof(System.Lazy`1<System.Object>), Member = "get_Value", ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 6)]
	[DeduplicatedMethod]
	public static TGlobalRenderPipelineSettings get_instance() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public override void Reset() { }

}

