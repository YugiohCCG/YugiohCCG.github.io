namespace UnityEngine.UIElements;

[AttributeUsage(AttributeTargets::Class (4), Inherited = False)]
public class UxmlElementAttribute : Attribute
{
	public readonly string name; //Field offset: 0x10
	public LibraryVisibility visibility; //Field offset: 0x18
	internal readonly Type[] supportedChildTypes; //Field offset: 0x20

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public UxmlElementAttribute(string uxmlName) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public UxmlElementAttribute(string uxmlName, Type[] supportedTypes) { }

}

