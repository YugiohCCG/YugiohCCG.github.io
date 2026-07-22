namespace System.Xml.Schema;

public sealed class XmlSchemaCollectionEnumerator : IEnumerator
{
	private IDictionaryEnumerator enumerator; //Field offset: 0x10

	public XmlSchema Current
	{
		[CalledBy(Type = typeof(XmlSchemaCollection), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSchemaCollectionEnumerator), Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 133
	}

	internal XmlSchemaCollectionNode CurrentNode
	{
		[CalledBy(Type = typeof(AutoValidator), Member = "DetectValidationType", ReturnType = typeof(ValidationType))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		internal get { } //Length: 123
	}

	private override object System.Collections.IEnumerator.Current
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlSchemaCollectionEnumerator), Member = "get_Current", ReturnType = typeof(XmlSchema))]
		private get { } //Length: 7
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal XmlSchemaCollectionEnumerator(Hashtable collection) { }

	[CalledBy(Type = typeof(XmlSchemaCollection), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaCollectionEnumerator), Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public XmlSchema get_Current() { }

	[CalledBy(Type = typeof(AutoValidator), Member = "DetectValidationType", ReturnType = typeof(ValidationType))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal XmlSchemaCollectionNode get_CurrentNode() { }

	[CalledBy(Type = typeof(AutoValidator), Member = "DetectValidationType", ReturnType = typeof(ValidationType))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public bool MoveNext() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaCollectionEnumerator), Member = "get_Current", ReturnType = typeof(XmlSchema))]
	private override object System.Collections.IEnumerator.get_Current() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private override bool System.Collections.IEnumerator.MoveNext() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private override void System.Collections.IEnumerator.Reset() { }

}

