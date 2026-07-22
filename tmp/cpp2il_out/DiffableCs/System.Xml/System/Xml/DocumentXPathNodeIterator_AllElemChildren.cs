namespace System.Xml;

internal class DocumentXPathNodeIterator_AllElemChildren : DocumentXPathNodeIterator_ElemDescendants
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DocumentXPathNodeIterator_ElemDescendants), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DocumentXPathNavigator)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	internal DocumentXPathNodeIterator_AllElemChildren(DocumentXPathNavigator nav) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DocumentXPathNodeIterator_ElemDescendants), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DocumentXPathNodeIterator_ElemDescendants)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	internal DocumentXPathNodeIterator_AllElemChildren(DocumentXPathNodeIterator_AllElemChildren other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DocumentXPathNodeIterator_ElemDescendants), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DocumentXPathNodeIterator_ElemDescendants)}, ReturnType = typeof(void))]
	public virtual XPathNodeIterator Clone() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	protected virtual bool Match(XmlNode node) { }

}

