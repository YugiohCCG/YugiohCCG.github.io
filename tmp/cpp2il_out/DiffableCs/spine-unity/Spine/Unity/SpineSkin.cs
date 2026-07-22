namespace Spine.Unity;

public class SpineSkin : SpineAttributeBase
{
	public bool defaultAsEmptyString; //Field offset: 0x30

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public SpineSkin(string startsWith = "", string dataField = "", bool includeNone = true, bool fallbackToTextField = false, bool defaultAsEmptyString = false) { }

}

