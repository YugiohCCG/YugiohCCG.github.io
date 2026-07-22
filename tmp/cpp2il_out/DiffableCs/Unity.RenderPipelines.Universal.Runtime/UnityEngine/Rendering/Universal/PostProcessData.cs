namespace UnityEngine.Rendering.Universal;

public class PostProcessData : ScriptableObject
{
	[CategoryInfo(Name = "R: Default PostProcess Shaders", Order = 1000)]
	[ElementInfo(Order = 0)]
	[HideInInspector]
	[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
	internal sealed class ShaderResources : IRenderPipelineResources, IRenderPipelineGraphicsSettings
	{
		[ResourcePath("Shaders/PostProcessing/StopNaN.shader", SearchType::ProjectPath (0))]
		public Shader stopNanPS; //Field offset: 0x10
		[ResourcePath("Shaders/PostProcessing/SubpixelMorphologicalAntialiasing.shader", SearchType::ProjectPath (0))]
		public Shader subpixelMorphologicalAntialiasingPS; //Field offset: 0x18
		[ResourcePath("Shaders/PostProcessing/GaussianDepthOfField.shader", SearchType::ProjectPath (0))]
		public Shader gaussianDepthOfFieldPS; //Field offset: 0x20
		[ResourcePath("Shaders/PostProcessing/BokehDepthOfField.shader", SearchType::ProjectPath (0))]
		public Shader bokehDepthOfFieldPS; //Field offset: 0x28
		[ResourcePath("Shaders/PostProcessing/CameraMotionBlur.shader", SearchType::ProjectPath (0))]
		public Shader cameraMotionBlurPS; //Field offset: 0x30
		[ResourcePath("Shaders/PostProcessing/PaniniProjection.shader", SearchType::ProjectPath (0))]
		public Shader paniniProjectionPS; //Field offset: 0x38
		[ResourcePath("Shaders/PostProcessing/LutBuilderLdr.shader", SearchType::ProjectPath (0))]
		public Shader lutBuilderLdrPS; //Field offset: 0x40
		[ResourcePath("Shaders/PostProcessing/LutBuilderHdr.shader", SearchType::ProjectPath (0))]
		public Shader lutBuilderHdrPS; //Field offset: 0x48
		[ResourcePath("Shaders/PostProcessing/Bloom.shader", SearchType::ProjectPath (0))]
		public Shader bloomPS; //Field offset: 0x50
		[ResourcePath("Shaders/PostProcessing/TemporalAA.shader", SearchType::ProjectPath (0))]
		public Shader temporalAntialiasingPS; //Field offset: 0x58
		[ResourcePath("Shaders/PostProcessing/LensFlareDataDriven.shader", SearchType::ProjectPath (0))]
		public Shader LensFlareDataDrivenPS; //Field offset: 0x60
		[ResourcePath("Shaders/PostProcessing/LensFlareScreenSpace.shader", SearchType::ProjectPath (0))]
		public Shader LensFlareScreenSpacePS; //Field offset: 0x68
		[ResourcePath("Shaders/PostProcessing/ScalingSetup.shader", SearchType::ProjectPath (0))]
		public Shader scalingSetupPS; //Field offset: 0x70
		[ResourcePath("Shaders/PostProcessing/EdgeAdaptiveSpatialUpsampling.shader", SearchType::ProjectPath (0))]
		public Shader easuPS; //Field offset: 0x78
		[ResourcePath("Shaders/PostProcessing/UberPost.shader", SearchType::ProjectPath (0))]
		public Shader uberPostPS; //Field offset: 0x80
		[ResourcePath("Shaders/PostProcessing/FinalPost.shader", SearchType::ProjectPath (0))]
		public Shader finalPostPassPS; //Field offset: 0x88
		[HideInInspector]
		[SerializeField]
		private int m_ShaderResourcesVersion; //Field offset: 0x90

		public override bool isAvailableInPlayerBuild
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public override int version
		{
			[CallerCount(Count = 33)]
			[DeduplicatedMethod]
			 get { } //Length: 7
		}

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public ShaderResources() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public override bool get_isAvailableInPlayerBuild() { }

		[CallerCount(Count = 33)]
		[DeduplicatedMethod]
		public override int get_version() { }

	}

	[CategoryInfo(Name = "R: Default PostProcess Textures", Order = 1000)]
	[ElementInfo(Order = 0)]
	[HideInInspector]
	[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
	internal sealed class TextureResources : IRenderPipelineResources, IRenderPipelineGraphicsSettings
	{
		[ResourceFormattedPaths("Textures/BlueNoise16/L/LDR_LLL1_{0}.png", 0, 32, SearchType::ProjectPath (0))]
		public Texture2D[] blueNoise16LTex; //Field offset: 0x10
		[ResourcePaths(new IL2CPP_TYPE_STRING[] {"Textures/FilmGrain/Thin01.png", "Textures/FilmGrain/Thin02.png", "Textures/FilmGrain/Medium01.png", "Textures/FilmGrain/Medium02.png", "Textures/FilmGrain/Medium03.png", "Textures/FilmGrain/Medium04.png", "Textures/FilmGrain/Medium05.png", "Textures/FilmGrain/Medium06.png", "Textures/FilmGrain/Large01.png", "Textures/FilmGrain/Large02.png"}, SearchType::ProjectPath (0))]
		public Texture2D[] filmGrainTex; //Field offset: 0x18
		[ResourcePath("Textures/SMAA/AreaTex.tga", SearchType::ProjectPath (0))]
		public Texture2D smaaAreaTex; //Field offset: 0x20
		[ResourcePath("Textures/SMAA/SearchTex.tga", SearchType::ProjectPath (0))]
		public Texture2D smaaSearchTex; //Field offset: 0x28
		[HideInInspector]
		[SerializeField]
		private int m_TexturesResourcesVersion; //Field offset: 0x30

		public override bool isAvailableInPlayerBuild
		{
			[CallerCount(Count = 271)]
			[DeduplicatedMethod]
			 get { } //Length: 3
		}

		public override int version
		{
			[CallerCount(Count = 3)]
			[DeduplicatedMethod]
			 get { } //Length: 4
		}

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public TextureResources() { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public override bool get_isAvailableInPlayerBuild() { }

		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		public override int get_version() { }

	}

	public ShaderResources shaders; //Field offset: 0x18
	public TextureResources textures; //Field offset: 0x20

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public PostProcessData() { }

}

