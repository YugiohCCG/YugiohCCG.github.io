namespace System.Xml;

internal class DocumentXPathNodeIterator_ElemChildren : DocumentXPathNodeIterator_ElemDescendants
{
	protected string localNameAtom; //Field offset: 0x28
	protected string nsAtom; //Field offset: 0x30

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DocumentXPathNodeIterator_ElemDescendants), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DocumentXPathNavigator)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal DocumentXPathNodeIterator_ElemChildren(DocumentXPathNavigator nav, string localNameAtom, string nsAtom) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DocumentXPathNodeIterator_ElemDescendants), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DocumentXPathNodeIterator_ElemDescendants)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	internal DocumentXPathNodeIterator_ElemChildren(DocumentXPathNodeIterator_ElemChildren other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DocumentXPathNodeIterator_ElemDescendants), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DocumentXPathNodeIterator_ElemDescendants)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public virtual XPathNodeIterator Clone() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual bool Match(XmlNode node) { }

}

