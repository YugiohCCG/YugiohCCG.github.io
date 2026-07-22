namespace System.Xml;

public class XmlNamedNodeMap : IEnumerable
{
	[DefaultMember("Item")]
	public struct SmallXmlNodeList
	{
		private class SingleObjectEnumerator : IEnumerator
		{
			private object loneValue; //Field offset: 0x10
			private int position; //Field offset: 0x18

			public override object Current
			{
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
				[CallsUnknownMethods(Count = 3)]
				 get { } //Length: 85
			}

			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			public SingleObjectEnumerator(object value) { }

			[CallerCount(Count = 0)]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
			[CallsUnknownMethods(Count = 3)]
			public override object get_Current() { }

			[CallerCount(Count = 0)]
			public override bool MoveNext() { }

			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			public override void Reset() { }

		}

		private object field; //Field offset: 0x0

		public int Count
		{
			[CalledBy(Type = typeof(XmlAttributeCollection), Member = "get_ItemOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlAttribute))]
			[CalledBy(Type = typeof(XmlAttributeCollection), Member = "get_ItemOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XmlAttribute))]
			[CalledBy(Type = typeof(XmlAttributeCollection), Member = "FindNodeOffsetNS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(int))]
			[CalledBy(Type = typeof(XmlAttributeCollection), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(XmlAttribute))]
			[CalledBy(Type = typeof(XmlAttributeCollection), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(XmlAttribute))]
			[CalledBy(Type = typeof(XmlAttributeCollection), Member = "Detach", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(XmlNamedNodeMap), Member = "get_Count", ReturnType = typeof(int))]
			[CallerCount(Count = 10)]
			[CallsDeduplicatedMethods(Count = 1)]
			 get { } //Length: 128
		}

		public object Item
		{
			[CalledBy(Type = typeof(XmlAttributeCollection), Member = "get_ItemOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XmlAttribute))]
			[CalledBy(Type = typeof(XmlNamedNodeMap), Member = "RemoveNodeAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XmlNode))]
			[CalledBy(Type = typeof(XmlNamedNodeMap), Member = "FindNodeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
			[CalledBy(Type = typeof(XmlNamedNodeMap), Member = "FindNodeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
			[CalledBy(Type = typeof(XmlNamedNodeMap), Member = "SetNamedItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
			[CalledBy(Type = typeof(XmlNamedNodeMap), Member = "GetNamedItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlNode))]
			[CalledBy(Type = typeof(XmlAttributeCollection), Member = "Detach", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(XmlAttributeCollection), Member = "RemoveDuplicateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(int))]
			[CalledBy(Type = typeof(XmlAttributeCollection), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(XmlAttributeCollection), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(XmlAttribute))]
			[CalledBy(Type = typeof(XmlAttributeCollection), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(XmlAttribute))]
			[CalledBy(Type = typeof(XmlAttributeCollection), Member = "FindNodeOffsetNS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(int))]
			[CalledBy(Type = typeof(XmlAttributeCollection), Member = "get_ItemOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XmlAttribute))]
			[CalledBy(Type = typeof(XmlAttributeCollection), Member = "get_ItemOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlAttribute))]
			[CalledBy(Type = typeof(XmlAttributeCollection), Member = "AddNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
			[CallerCount(Count = 16)]
			[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 8)]
			 get { } //Length: 285
		}

		[CalledBy(Type = typeof(SmallXmlNodeList), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlNamedNodeMap), Member = "AddNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
		[CalledBy(Type = typeof(XmlNamedNodeMap), Member = "AddNodeForLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlDocument)}, ReturnType = typeof(XmlNode))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 2)]
		public void Add(object value) { }

		[CalledBy(Type = typeof(XmlAttributeCollection), Member = "get_ItemOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlAttribute))]
		[CalledBy(Type = typeof(XmlAttributeCollection), Member = "get_ItemOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XmlAttribute))]
		[CalledBy(Type = typeof(XmlAttributeCollection), Member = "FindNodeOffsetNS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(XmlAttributeCollection), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(XmlAttribute))]
		[CalledBy(Type = typeof(XmlAttributeCollection), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(XmlAttribute))]
		[CalledBy(Type = typeof(XmlAttributeCollection), Member = "Detach", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlNamedNodeMap), Member = "get_Count", ReturnType = typeof(int))]
		[CallerCount(Count = 10)]
		[CallsDeduplicatedMethods(Count = 1)]
		public int get_Count() { }

		[CalledBy(Type = typeof(XmlAttributeCollection), Member = "get_ItemOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XmlAttribute))]
		[CalledBy(Type = typeof(XmlAttributeCollection), Member = "AddNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
		[CalledBy(Type = typeof(XmlAttributeCollection), Member = "get_ItemOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlAttribute))]
		[CalledBy(Type = typeof(XmlAttributeCollection), Member = "get_ItemOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(XmlAttribute))]
		[CalledBy(Type = typeof(XmlAttributeCollection), Member = "FindNodeOffsetNS", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(XmlAttributeCollection), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(XmlAttribute))]
		[CalledBy(Type = typeof(XmlAttributeCollection), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlAttributeCollection), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(XmlAttribute))]
		[CalledBy(Type = typeof(XmlAttributeCollection), Member = "Detach", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlNamedNodeMap), Member = "GetNamedItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlNode))]
		[CalledBy(Type = typeof(XmlNamedNodeMap), Member = "SetNamedItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
		[CalledBy(Type = typeof(XmlNamedNodeMap), Member = "FindNodeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(XmlNamedNodeMap), Member = "FindNodeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(XmlNamedNodeMap), Member = "RemoveNodeAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XmlNode))]
		[CalledBy(Type = typeof(XmlAttributeCollection), Member = "RemoveDuplicateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(int))]
		[CallerCount(Count = 16)]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		public object get_Item(int index) { }

		[CalledBy(Type = typeof(XmlNamedNodeMap), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		public IEnumerator GetEnumerator() { }

		[CalledBy(Type = typeof(XmlNamedNodeMap), Member = "InsertNodeAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(SmallXmlNodeList), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		[CallsUnknownMethods(Count = 10)]
		public void Insert(int index, object value) { }

		[CalledBy(Type = typeof(XmlNamedNodeMap), Member = "RemoveNodeAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XmlNode))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 9)]
		public void RemoveAt(int index) { }

	}

	internal XmlNode parent; //Field offset: 0x10
	internal SmallXmlNodeList nodes; //Field offset: 0x18

	public override int Count
	{
		[CalledBy(Type = typeof(XmlAttributeCollection), Member = "System.Collections.ICollection.get_Count", ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(SmallXmlNodeList), Member = "get_Count", ReturnType = typeof(int))]
		 get { } //Length: 11
	}

	[CallerCount(Count = 98)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal XmlNamedNodeMap(XmlNode parent) { }

	[CalledBy(Type = typeof(XmlAttributeCollection), Member = "SetNamedItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlAttributeCollection), Member = "AddNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlAttributeCollection), Member = "InternalAppendAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(XmlAttribute))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SmallXmlNodeList), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	internal override XmlNode AddNode(XmlNode node) { }

	[CalledBy(Type = typeof(XmlAttributeCollection), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(XmlAttribute))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlDocument), Member = "GetInsertEventArgsForLoad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(XmlNode)}, ReturnType = typeof(XmlNodeChangedEventArgs))]
	[Calls(Type = typeof(SmallXmlNodeList), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	internal override XmlNode AddNodeForLoad(XmlNode node, XmlDocument doc) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SmallXmlNodeList), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	internal int FindNodeOffset(string name) { }

	[CalledBy(Type = typeof(XmlAttributeCollection), Member = "SetNamedItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlAttributeCollection), Member = "AddNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlAttributeCollection), Member = "RemoveDuplicateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SmallXmlNodeList), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	internal int FindNodeOffset(string localName, string namespaceURI) { }

	[CalledBy(Type = typeof(XmlAttributeCollection), Member = "System.Collections.ICollection.get_Count", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SmallXmlNodeList), Member = "get_Count", ReturnType = typeof(int))]
	public override int get_Count() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SmallXmlNodeList), Member = "GetEnumerator", ReturnType = typeof(IEnumerator))]
	public override IEnumerator GetEnumerator() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SmallXmlNodeList), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public override XmlNode GetNamedItem(string name) { }

	[CalledBy(Type = typeof(XmlAttributeCollection), Member = "InsertNodeAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SmallXmlNodeList), Member = "Insert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	internal override XmlNode InsertNodeAt(int i, XmlNode node) { }

	[CalledBy(Type = typeof(XmlAttributeCollection), Member = "SetNamedItem", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlAttributeCollection), Member = "AddNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlAttributeCollection), Member = "RemoveNodeAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlAttributeCollection), Member = "RemoveDuplicateAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SmallXmlNodeList), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(SmallXmlNodeList), Member = "RemoveAt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	internal override XmlNode RemoveNodeAt(int i) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	internal XmlNode ReplaceNodeAt(int i, XmlNode node) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SmallXmlNodeList), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 2)]
	public override XmlNode SetNamedItem(XmlNode node) { }

}

