namespace UnityEngine.Rendering.Universal;

[AttributeUsage(AttributeTargets::Class (4))]
public class DisallowMultipleRendererFeature : Attribute
{
	[CompilerGenerated]
	private string <customTitle>k__BackingField; //Field offset: 0x10

	public private string customTitle
	{
		[CallerCount(Count = 106)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	[CallerCount(Count = 27)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public DisallowMultipleRendererFeature(string customTitle = null) { }

	[CallerCount(Count = 106)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public string get_customTitle() { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_customTitle(string value) { }

}

