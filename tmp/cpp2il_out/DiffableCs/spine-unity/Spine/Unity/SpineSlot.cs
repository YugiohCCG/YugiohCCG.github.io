namespace Spine.Unity;

public class SpineSlot : SpineAttributeBase
{
	public bool containsBoundingBoxes; //Field offset: 0x30

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public SpineSlot(string startsWith = "", string dataField = "", bool containsBoundingBoxes = false, bool includeNone = true, bool fallbackToTextField = false) { }

}

