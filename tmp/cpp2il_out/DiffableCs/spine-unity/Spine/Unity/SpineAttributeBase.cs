namespace Spine.Unity;

[AttributeUsage(AttributeTargets::Field (256), Inherited = True, AllowMultiple = False)]
public abstract class SpineAttributeBase : PropertyAttribute
{
	public string dataField; //Field offset: 0x18
	public string startsWith; //Field offset: 0x20
	public bool includeNone; //Field offset: 0x28
	public bool fallbackToTextField; //Field offset: 0x29

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	protected SpineAttributeBase() { }

}

