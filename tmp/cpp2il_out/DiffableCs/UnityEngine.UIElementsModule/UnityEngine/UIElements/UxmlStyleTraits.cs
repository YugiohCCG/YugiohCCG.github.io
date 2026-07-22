namespace UnityEngine.UIElements;

[Obsolete("UxmlStyleTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
public class UxmlStyleTraits : UxmlTraits
{
	private UxmlStringAttributeDescription m_Name; //Field offset: 0x18
	private UxmlStringAttributeDescription m_Path; //Field offset: 0x20
	private UxmlStringAttributeDescription m_Src; //Field offset: 0x28

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UxmlStringAttributeDescription), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public UxmlStyleTraits() { }

}

