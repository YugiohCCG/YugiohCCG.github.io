namespace System.Xml;

internal sealed class DocumentXPathNodeIterator_AllElemChildren_AndSelf : DocumentXPathNodeIterator_AllElemChildren
{

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DocumentXPathNodeIterator_ElemDescendants), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DocumentXPathNavigator)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	internal DocumentXPathNodeIterator_AllElemChildren_AndSelf(DocumentXPathNavigator nav) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DocumentXPathNodeIterator_ElemDescendants), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DocumentXPathNodeIterator_ElemDescendants)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	internal DocumentXPathNodeIterator_AllElemChildren_AndSelf(DocumentXPathNodeIterator_AllElemChildren_AndSelf other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DocumentXPathNodeIterator_ElemDescendants), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DocumentXPathNodeIterator_ElemDescendants)}, ReturnType = typeof(void))]
	public virtual XPathNodeIterator Clone() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DocumentXPathNodeIterator_ElemDescendants), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	public virtual bool MoveNext() { }

}

