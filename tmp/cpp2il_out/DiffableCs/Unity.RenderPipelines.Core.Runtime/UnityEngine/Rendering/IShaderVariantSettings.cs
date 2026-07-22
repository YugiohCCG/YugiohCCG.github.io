namespace UnityEngine.Rendering;

[Obsolete("Use GraphicsSettings.GetRenderPipelineSettings<ShaderStrippingSetting>(). #from(23.3)")]
public interface IShaderVariantSettings
{

	public bool exportShaderVariants
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public ShaderVariantLogLevel shaderVariantLogLevel
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool stripDebugVariants
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		 set { } //Length: 3
	}

	public bool get_exportShaderVariants() { }

	public ShaderVariantLogLevel get_shaderVariantLogLevel() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public bool get_stripDebugVariants() { }

	public void set_exportShaderVariants(bool value) { }

	public void set_shaderVariantLogLevel(ShaderVariantLogLevel value) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	public void set_stripDebugVariants(bool value) { }

}

