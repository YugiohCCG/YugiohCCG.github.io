namespace Spine.Unity;

public class SpineAtlasRegion : PropertyAttribute
{
	public string atlasAssetField; //Field offset: 0x18

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public SpineAtlasRegion(string atlasAssetField = "") { }

}

