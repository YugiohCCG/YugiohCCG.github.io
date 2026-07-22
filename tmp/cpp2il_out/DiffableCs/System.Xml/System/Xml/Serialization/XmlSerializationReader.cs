namespace System.Xml.Serialization;

[MonoTODO]
public abstract class XmlSerializationReader : XmlSerializationGeneratedCode
{
	internal class CollectionFixup
	{
		private XmlSerializationCollectionFixupCallback callback; //Field offset: 0x10
		private object collection; //Field offset: 0x18
		private object collectionItems; //Field offset: 0x20
		private string id; //Field offset: 0x28

		public XmlSerializationCollectionFixupCallback Callback
		{
			[CallerCount(Count = 106)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		public object Collection
		{
			[CallerCount(Count = 31)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		public internal object CollectionItems
		{
			[CallerCount(Count = 12)]
			[DeduplicatedMethod]
			 get { } //Length: 5
			[CallerCount(Count = 10)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			internal set { } //Length: 13
		}

		internal object Id
		{
			[CallerCount(Count = 15)]
			[DeduplicatedMethod]
			internal get { } //Length: 5
		}

		[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		internal CollectionFixup(object collection, XmlSerializationCollectionFixupCallback callback, string id) { }

		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		public XmlSerializationCollectionFixupCallback get_Callback() { }

		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		public object get_Collection() { }

		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		public object get_CollectionItems() { }

		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		internal object get_Id() { }

		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal void set_CollectionItems(object value) { }

	}

	private class CollectionItemFixup
	{
		private Array list; //Field offset: 0x10
		private int index; //Field offset: 0x18
		private string id; //Field offset: 0x20

		public Array Collection
		{
			[CallerCount(Count = 106)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		public string Id
		{
			[CallerCount(Count = 12)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		public int Index
		{
			[CallerCount(Count = 7)]
			[DeduplicatedMethod]
			 get { } //Length: 4
		}

		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		public CollectionItemFixup(Array list, int index, string id) { }

		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		public Array get_Collection() { }

		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		public string get_Id() { }

		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		public int get_Index() { }

	}

	internal class Fixup
	{
		private object source; //Field offset: 0x10
		private String[] ids; //Field offset: 0x18
		private XmlSerializationFixupCallback callback; //Field offset: 0x20

		public XmlSerializationFixupCallback Callback
		{
			[CallerCount(Count = 12)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		public String[] Ids
		{
			[CallerCount(Count = 31)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		public object Source
		{
			[CallerCount(Count = 106)]
			[DeduplicatedMethod]
			 get { } //Length: 5
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		public Fixup(object o, XmlSerializationFixupCallback callback, int count) { }

		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		public XmlSerializationFixupCallback get_Callback() { }

		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		public String[] get_Ids() { }

		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		public object get_Source() { }

	}

	private class WriteCallbackInfo
	{
		public Type Type; //Field offset: 0x10
		public string TypeName; //Field offset: 0x18
		public string TypeNs; //Field offset: 0x20
		public XmlSerializationReadCallback Callback; //Field offset: 0x28

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public WriteCallbackInfo() { }

	}

	private XmlDocument document; //Field offset: 0x10
	private XmlReader reader; //Field offset: 0x18
	private ArrayList fixups; //Field offset: 0x20
	private Hashtable collFixups; //Field offset: 0x28
	private ArrayList collItemFixups; //Field offset: 0x30
	private Hashtable typesCallbacks; //Field offset: 0x38
	private ArrayList noIDTargets; //Field offset: 0x40
	private Hashtable targets; //Field offset: 0x48
	private Hashtable delayedListFixups; //Field offset: 0x50
	private XmlSerializer eventSource; //Field offset: 0x58
	private int delayedFixupId; //Field offset: 0x60
	private Hashtable referencedObjects; //Field offset: 0x68
	private int readCount; //Field offset: 0x70
	private int whileIterationCount; //Field offset: 0x74
	private string w3SchemaNS; //Field offset: 0x78
	private string w3InstanceNS; //Field offset: 0x80
	private string w3InstanceNS2000; //Field offset: 0x88
	private string w3InstanceNS1999; //Field offset: 0x90
	private string soapNS; //Field offset: 0x98
	private string wsdlNS; //Field offset: 0xA0
	private string nullX; //Field offset: 0xA8
	private string nil; //Field offset: 0xB0
	private string typeX; //Field offset: 0xB8
	private string arrayType; //Field offset: 0xC0
	private XmlQualifiedName arrayQName; //Field offset: 0xC8

	protected XmlDocument Document
	{
		[CalledBy(Type = typeof(XmlSerializationReader), Member = "ReadNull", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlSerializationReader), Member = "ReadTypedPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(bool)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(XmlSerializationReader), Member = "ReadXmlNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(XmlNode))]
		[CalledBy(Type = typeof(XmlSerializationReader), Member = "UnknownNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSerializationReader), Member = "UnknownNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadRoot", ReturnType = typeof(object))]
		[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadEncodedObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadAttributeMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ProcessUnknownAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ProcessUnknownElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadXmlNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(bool)}, ReturnType = typeof(object))]
		[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadXmlSerializableElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(bool)}, ReturnType = typeof(object))]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(XmlDocument), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 152
	}

	protected XmlReader Reader
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected XmlSerializationReader() { }

	[CalledBy(Type = typeof(XmlSerializationReader), Member = "ReadList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void AddFixup(CollectionItemFixup fixup) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	protected void AddFixup(Fixup fixup) { }

	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	protected void AddFixup(CollectionFixup fixup) { }

	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "InitCallbacks", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	protected void AddReadCallback(string name, string ns, Type type, XmlSerializationReadCallback read) { }

	[CalledBy(Type = typeof(XmlSerializationReader), Member = "ReadReferencedElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	protected void AddTarget(string id, object o) { }

	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadListElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(bool), typeof(object), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "AddListValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(Object&), typeof(int), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "CopyEnumerableList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	protected Exception CreateReadOnlyCollectionException(string name) { }

	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "GetEnumValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(string)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	protected Exception CreateUnknownConstantException(string value, Type enumType) { }

	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadRoot", ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadEncodedObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadXmlSerializableElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(bool)}, ReturnType = typeof(object))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(XmlSerializationReader), Member = "CurrentTag", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	protected Exception CreateUnknownNodeException() { }

	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadClassInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(bool), typeof(bool)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSerializationReader), Member = "CurrentTag", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 8)]
	protected Exception CreateUnknownTypeException(XmlQualifiedName type) { }

	[CalledBy(Type = typeof(XmlSerializationReader), Member = "CreateUnknownNodeException", ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(XmlSerializationReader), Member = "CreateUnknownTypeException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsInvalidInstructions]
	private string CurrentTag() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(int)}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	protected Array EnsureArrayIndex(Array a, int index, Type elementType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	private ArrayList EnsureArrayList(ArrayList list) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	private Hashtable EnsureHashtable(Hashtable hash) { }

	[CalledBy(Type = typeof(XmlSerializationReader), Member = "ReadNull", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSerializationReader), Member = "ReadTypedPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSerializationReader), Member = "ReadXmlNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(XmlNode))]
	[CalledBy(Type = typeof(XmlSerializationReader), Member = "UnknownNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationReader), Member = "UnknownNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadRoot", ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadEncodedObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadAttributeMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ProcessUnknownAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ProcessUnknownElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadXmlNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadXmlSerializableElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(bool)}, ReturnType = typeof(object))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(XmlDocument), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	protected XmlDocument get_Document() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	protected XmlReader get_Reader() { }

	[CalledBy(Type = typeof(XmlSerializationReader), Member = "ReadReferencedElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSerializationReader), Member = "ReadList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSerializationReader), Member = "ReadReferencingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(String&)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private WriteCallbackInfo GetCallbackInfo(XmlQualifiedName qname) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	protected bool GetNullAttr() { }

	[CalledBy(Type = typeof(XmlSerializationReader), Member = "ReadReferencedElements", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationReader), Member = "ReadReferencingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(String&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "FixupMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	protected object GetTarget(string id) { }

	[CalledBy(Type = typeof(XmlSerializationReader), Member = "ReadReferencedElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSerializationReader), Member = "ReadReferencingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(String&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSerializationReader), Member = "ReadTypedPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadClassInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(bool), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadPrimitiveElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(bool)}, ReturnType = typeof(object))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	protected XmlQualifiedName GetXsiType() { }

	protected abstract void InitCallbacks() { }

	[CalledBy(Type = typeof(XmlSerializer), Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSerializer), Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallsUnknownMethods(Count = 14)]
	internal void Initialize(XmlReader reader, XmlSerializer eventSource) { }

	protected abstract void InitIDs() { }

	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadAttributeMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected bool IsXmlnsAttribute(string name) { }

	[CalledBy(Type = typeof(XmlSerializationReader), Member = "ReadNull", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ProcessUnknownElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ProcessUnknownAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadEncodedObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadXmlSerializableElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSerializationReader), Member = "UnknownNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationReader), Member = "UnknownNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializationReader), Member = "ReadTypedPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadRoot", ReturnType = typeof(object))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(XmlTextReader), Member = "get_LineNumber", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReader), Member = "get_LinePosition", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlAttributeEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute), typeof(int), typeof(int), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlElementEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(int), typeof(int), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlNodeEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(int), typeof(int), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 13)]
	private void OnUnknownNode(XmlNode node, object o, string qnames) { }

	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadAttributeMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TypeTranslator), Member = "ParseArrayType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	protected void ParseWsdlArrayType(XmlAttribute attr) { }

	[CalledBy(Type = typeof(XmlSerializationReader), Member = "ReadNullableQualifiedName", ReturnType = typeof(XmlQualifiedName))]
	[CalledBy(Type = typeof(XmlSerializationReader), Member = "ReadTypedPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadObjectElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapElementInfo)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadPrimitiveValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapElementInfo)}, ReturnType = typeof(object))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(XmlSerializationReader), Member = "ToXmlQualifiedName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlQualifiedName))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	protected XmlQualifiedName ReadElementQualifiedName() { }

	[CalledBy(Type = typeof(XmlSerializationReader), Member = "ReadNull", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlMembersMapping)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadClassInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(bool), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadListElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(bool), typeof(object), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadEnumElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(bool)}, ReturnType = typeof(object))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	protected void ReadEndElement() { }

	[CalledBy(Type = typeof(XmlSerializationReader), Member = "ReadReferencedElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSerializationReader), Member = "ReadReferencingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(String&)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "ReadReferencingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(String&)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Array), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(int)}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TypeTranslator), Member = "GetPrimitiveTypeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TypeData))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "GetCallbackInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(WriteCallbackInfo))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(int), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "AddFixup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollectionItemFixup)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "ToXmlQualifiedName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(Array), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	private bool ReadList(out object resultList) { }

	[CalledBy(Type = typeof(XmlSerializationReader), Member = "ReadNullableQualifiedName", ReturnType = typeof(XmlQualifiedName))]
	[CalledBy(Type = typeof(XmlSerializationReader), Member = "ReadNullableString", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlSerializationReader), Member = "ReadReferencingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(String&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSerializationReader), Member = "ReadSerializable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IXmlSerializable)}, ReturnType = typeof(IXmlSerializable))]
	[CalledBy(Type = typeof(XmlSerializationReader), Member = "ReadTypedPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadClassInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(bool), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadObjectElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapElementInfo)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadPrimitiveValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapElementInfo)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadListElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(bool), typeof(object), typeof(bool)}, ReturnType = typeof(object))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(XmlSerializationReader), Member = "get_Document", ReturnType = typeof(XmlDocument))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "OnUnknownNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "ReadEndElement", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	protected bool ReadNull() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSerializationReader), Member = "ReadNull", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "ReadElementQualifiedName", ReturnType = typeof(XmlQualifiedName))]
	protected XmlQualifiedName ReadNullableQualifiedName() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSerializationReader), Member = "ReadNull", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected string ReadNullableString() { }

	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadRoot", ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadEncodedObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlMembersMapping)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlSerializationReader), Member = "ReadReferencedElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected object ReadReferencedElement() { }

	[CalledBy(Type = typeof(XmlSerializationReader), Member = "ReadReferencedElement", ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSerializationReader), Member = "ReadReferencedElements", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlSerializationReader), Member = "GetXsiType", ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "GetCallbackInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(WriteCallbackInfo))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "ReadTypedPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "ReadList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "AddTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	protected object ReadReferencedElement(string name, string ns) { }

	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadRoot", ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadEncodedObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlMembersMapping)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlSerializationReader), Member = "ReadReferencedElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Array), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "UnreferencedObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 27)]
	[CallsUnknownMethods(Count = 62)]
	[ContainsUnimplementedInstructions]
	protected void ReadReferencedElements() { }

	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlSerializationReader), Member = "ReadReferencingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(String&)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected object ReadReferencingElement(out string fixupReference) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSerializationReader), Member = "ReadReferencingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(String&)}, ReturnType = typeof(object))]
	protected object ReadReferencingElement(string name, string ns, out string fixupReference) { }

	[CalledBy(Type = typeof(XmlSerializationReader), Member = "ReadList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSerializationReader), Member = "ReadReferencingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSerializationReader), Member = "ReadReferencingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(String&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlSerializationReader), Member = "ReadList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "ReadTypedPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(bool)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "GetCallbackInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(WriteCallbackInfo))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "GetXsiType", ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "ReadNull", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 7)]
	protected object ReadReferencingElement(string name, string ns, bool elementCanBeType, out string fixupReference) { }

	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadObjectElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapElementInfo)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadXmlSerializableElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(bool)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlSerializationReader), Member = "ReadNull", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	protected IXmlSerializable ReadSerializable(IXmlSerializable serializable) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSerializationReader), Member = "ReadTypedPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(bool)}, ReturnType = typeof(object))]
	protected object ReadTypedPrimitive(XmlQualifiedName type) { }

	[CalledBy(Type = typeof(XmlSerializationReader), Member = "ReadReferencedElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSerializationReader), Member = "ReadReferencingElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(bool), typeof(String&)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSerializationReader), Member = "ReadTypedPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadClassInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(bool), typeof(bool)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadPrimitiveElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlTypeMapping), typeof(bool)}, ReturnType = typeof(object))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(XmlSerializationReader), Member = "OnUnknownNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "get_Document", ReturnType = typeof(XmlDocument))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "ReadElementQualifiedName", ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "ReadNull", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TypeTranslator), Member = "FindPrimitiveTypeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TypeData))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "GetXsiType", ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlCustomFormatter), Member = "FromXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(string)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallsUnknownMethods(Count = 36)]
	private object ReadTypedPrimitive(XmlQualifiedName qname, bool reportUnknown) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlDocument), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	protected XmlDocument ReadXmlDocument(bool wrapped) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSerializationReader), Member = "get_Document", ReturnType = typeof(XmlDocument))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected XmlNode ReadXmlNode(bool wrapped) { }

	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ClassMap), typeof(object), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(int)}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	protected Array ShrinkArray(Array a, int length, Type elementType, bool isNullable) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private bool TargetReady(string id) { }

	[CalledBy(Type = typeof(XmlSerializationReader), Member = "ReadElementQualifiedName", ReturnType = typeof(XmlQualifiedName))]
	[CalledBy(Type = typeof(XmlSerializationReader), Member = "ReadList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlSerializationReaderInterpreter), Member = "GetValueFromXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TypeData), typeof(XmlTypeMapping)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlConvert), Member = "DecodeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 6)]
	protected XmlQualifiedName ToXmlQualifiedName(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextReader), Member = "get_LineNumber", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReader), Member = "get_LinePosition", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlAttributeEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttribute), typeof(int), typeof(int), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	protected void UnknownAttribute(object o, XmlAttribute attr, string qnames) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextReader), Member = "get_LineNumber", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReader), Member = "get_LinePosition", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlElementEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElement), typeof(int), typeof(int), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	protected void UnknownElement(object o, XmlElement elem, string qnames) { }

	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlSerializationReader), Member = "get_Document", ReturnType = typeof(XmlDocument))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "OnUnknownNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	protected void UnknownNode(object o) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSerializationReader), Member = "get_Document", ReturnType = typeof(XmlDocument))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "OnUnknownNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNode), typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected void UnknownNode(object o, string qnames) { }

	[CalledBy(Type = typeof(XmlSerializationReader), Member = "ReadReferencedElements", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnreferencedObjectEventArgs), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	protected void UnreferencedObject(string id, object o) { }

}

