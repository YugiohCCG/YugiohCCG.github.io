namespace System.Xml;

internal class DocumentXPathNodeIterator_ElemChildren_NoLocalName : DocumentXPathNodeIterator_ElemDescendants
{
	private string nsAtom; //Field offset: 0x28

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DocumentXPathNodeIterator_ElemDescendants), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DocumentXPathNavigator)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal DocumentXPathNodeIterator_ElemChildren_NoLocalName(DocumentXPathNavigator nav, string nsAtom) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DocumentXPathNodeIterator_ElemDescendants), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DocumentXPathNodeIterator_ElemDescendants)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal DocumentXPathNodeIterator_ElemChildren_NoLocalName(DocumentXPathNodeIterator_ElemChildren_NoLocalName other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DocumentXPathNodeIterator_ElemDescendants), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DocumentXPathNodeIterator_ElemDescendants)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public virtual XPathNodeIterator Clone() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual bool Match(XmlNode node) { }

}

