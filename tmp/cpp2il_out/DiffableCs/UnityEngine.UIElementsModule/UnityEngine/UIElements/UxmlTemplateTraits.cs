namespace UnityEngine.UIElements;

[Obsolete("UxmlTemplateTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
public class UxmlTemplateTraits : UxmlTraits
{
	private UxmlStringAttributeDescription m_Name; //Field offset: 0x18
	private UxmlStringAttributeDescription m_Path; //Field offset: 0x20
	private UxmlStringAttributeDescription m_Src; //Field offset: 0x28

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UxmlStringAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public UxmlTemplateTraits() { }

}

