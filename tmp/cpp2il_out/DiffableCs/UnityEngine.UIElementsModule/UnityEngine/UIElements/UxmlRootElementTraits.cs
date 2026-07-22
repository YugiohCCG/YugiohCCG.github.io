namespace UnityEngine.UIElements;

[Obsolete("UxmlRootElementTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
public class UxmlRootElementTraits : UxmlTraits
{
	protected UxmlStringAttributeDescription m_Name; //Field offset: 0x18
	private UxmlStringAttributeDescription m_Class; //Field offset: 0x20

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UxmlStringAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public UxmlRootElementTraits() { }

}

