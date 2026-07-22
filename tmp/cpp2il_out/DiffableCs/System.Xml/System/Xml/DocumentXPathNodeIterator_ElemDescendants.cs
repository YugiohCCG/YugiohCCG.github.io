namespace System.Xml;

internal abstract class DocumentXPathNodeIterator_ElemDescendants : XPathNodeIterator
{
	private DocumentXPathNavigator nav; //Field offset: 0x18
	private int level; //Field offset: 0x20
	private int position; //Field offset: 0x24

	public virtual XPathNavigator Current
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public virtual int CurrentPosition
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "SelectDescendants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool)}, ReturnType = typeof(XPathNodeIterator))]
	[CalledBy(Type = typeof(DocumentXPathNavigator), Member = "SelectDescendants", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XPathNodeType), typeof(bool)}, ReturnType = typeof(XPathNodeIterator))]
	[CalledBy(Type = typeof(DocumentXPathNodeIterator_AllElemChildren), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DocumentXPathNavigator)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DocumentXPathNodeIterator_AllElemChildren_AndSelf), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DocumentXPathNavigator)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DocumentXPathNodeIterator_ElemChildren_NoLocalName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DocumentXPathNavigator), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DocumentXPathNodeIterator_ElemChildren_AndSelf_NoLocalName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DocumentXPathNavigator), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DocumentXPathNodeIterator_ElemChildren), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DocumentXPathNavigator), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DocumentXPathNodeIterator_ElemChildren_AndSelf), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DocumentXPathNavigator), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	internal DocumentXPathNodeIterator_ElemDescendants(DocumentXPathNavigator nav) { }

	[CalledBy(Type = typeof(DocumentXPathNodeIterator_AllElemChildren), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DocumentXPathNodeIterator_AllElemChildren)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DocumentXPathNodeIterator_AllElemChildren), Member = "Clone", ReturnType = typeof(XPathNodeIterator))]
	[CalledBy(Type = typeof(DocumentXPathNodeIterator_AllElemChildren_AndSelf), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DocumentXPathNodeIterator_AllElemChildren_AndSelf)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DocumentXPathNodeIterator_AllElemChildren_AndSelf), Member = "Clone", ReturnType = typeof(XPathNodeIterator))]
	[CalledBy(Type = typeof(DocumentXPathNodeIterator_ElemChildren_NoLocalName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DocumentXPathNodeIterator_ElemChildren_NoLocalName)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DocumentXPathNodeIterator_ElemChildren_NoLocalName), Member = "Clone", ReturnType = typeof(XPathNodeIterator))]
	[CalledBy(Type = typeof(DocumentXPathNodeIterator_ElemChildren_AndSelf_NoLocalName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DocumentXPathNodeIterator_ElemChildren_AndSelf_NoLocalName)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DocumentXPathNodeIterator_ElemChildren_AndSelf_NoLocalName), Member = "Clone", ReturnType = typeof(XPathNodeIterator))]
	[CalledBy(Type = typeof(DocumentXPathNodeIterator_ElemChildren), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DocumentXPathNodeIterator_ElemChildren)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DocumentXPathNodeIterator_ElemChildren), Member = "Clone", ReturnType = typeof(XPathNodeIterator))]
	[CalledBy(Type = typeof(DocumentXPathNodeIterator_ElemChildren_AndSelf), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DocumentXPathNodeIterator_ElemChildren_AndSelf)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DocumentXPathNodeIterator_ElemChildren_AndSelf), Member = "Clone", ReturnType = typeof(XPathNodeIterator))]
	[CallerCount(Count = 12)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	internal DocumentXPathNodeIterator_ElemDescendants(DocumentXPathNodeIterator_ElemDescendants other) { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public virtual XPathNavigator get_Current() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public virtual int get_CurrentPosition() { }

	protected abstract bool Match(XmlNode node) { }

	[CalledBy(Type = typeof(DocumentXPathNodeIterator_AllElemChildren_AndSelf), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DocumentXPathNodeIterator_ElemChildren_AndSelf_NoLocalName), Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(DocumentXPathNodeIterator_ElemChildren_AndSelf), Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	public virtual bool MoveNext() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected void SetPosition(int pos) { }

}

