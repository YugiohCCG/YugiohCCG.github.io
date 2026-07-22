namespace System.Xml.Serialization;

public class XmlSerializer
{
	public class SerializerData
	{
		public MethodInfo ReaderMethod; //Field offset: 0x10
		public Type WriterType; //Field offset: 0x18
		public MethodInfo WriterMethod; //Field offset: 0x20
		public XmlSerializerImplementation Implementation; //Field offset: 0x28

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		public XmlSerializationWriter CreateWriter() { }

	}

	private static int generationThreshold; //Field offset: 0x0
	private static bool backgroundGeneration; //Field offset: 0x4
	private static bool deleteTempFiles; //Field offset: 0x5
	private static bool generatorFallback; //Field offset: 0x6
	private static Hashtable serializerTypes; //Field offset: 0x8
	private bool customSerializer; //Field offset: 0x10
	private XmlMapping typeMapping; //Field offset: 0x18
	private SerializerData serializerData; //Field offset: 0x20
	private UnreferencedObjectEventHandler onUnreferencedObject; //Field offset: 0x28
	private XmlAttributeEventHandler onUnknownAttribute; //Field offset: 0x30
	private XmlElementEventHandler onUnknownElement; //Field offset: 0x38
	private XmlNodeEventHandler onUnknownNode; //Field offset: 0x40

	internal XmlMapping Mapping
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static XmlSerializer() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlReflectionImporter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAttributeOverrides), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReflectionImporter), Member = "IncludeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReflectionImporter), Member = "ImportTypeMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(XmlRootAttribute), typeof(string)}, ReturnType = typeof(XmlTypeMapping))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public XmlSerializer(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	protected override XmlSerializationReader CreateReader() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSerializationReaderInterpreter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlMapping)}, ReturnType = typeof(void))]
	private XmlSerializationReader CreateReader(XmlMapping typeMapping) { }

	[CalledBy(Type = typeof(XmlSerializer), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(object), typeof(XmlSerializerNamespaces)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Activator), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private XmlSerializationWriter CreateWriter(XmlMapping typeMapping) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	protected override XmlSerializationWriter CreateWriter() { }

	[CalledBy(Type = "System.Data.Common.ObjectStorage", Member = "ConvertXmlToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Data.Common.SqlUdtStorage", Member = "ConvertXmlToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlTextReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReader), Member = "set_Normalization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReader), Member = "set_WhitespaceHandling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WhitespaceHandling)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationReaderInterpreter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlMapping)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlSerializer)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public object Deserialize(TextReader textReader) { }

	[CalledBy(Type = "System.Data.Common.ObjectStorage", Member = "ConvertXmlToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlRootAttribute)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Data.Common.SqlUdtStorage", Member = "ConvertXmlToObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlRootAttribute)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlSerializationReaderInterpreter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlMapping)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationReader), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlSerializer)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public object Deserialize(XmlReader xmlReader) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSerializationReaderInterpreter), Member = "ReadRoot", ReturnType = typeof(object))]
	[Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 20)]
	protected override object Deserialize(XmlSerializationReader reader) { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	internal XmlMapping get_Mapping() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal override void OnUnknownAttribute(XmlAttributeEventArgs e) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal override void OnUnknownElement(XmlElementEventArgs e) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal override void OnUnknownNode(XmlNodeEventArgs e) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal override void OnUnreferencedObject(UnreferencedObjectEventArgs e) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSerializationWriterInterpreter), Member = "WriteRoot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MethodBase), Member = "Invoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object[])}, ReturnType = typeof(object))]
	[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 16)]
	protected override void Serialize(object o, XmlSerializationWriter writer) { }

	[CalledBy(Type = "System.Data.Common.ObjectStorage", Member = "ConvertObjectToXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Data.Common.SqlUdtStorage", Member = "ConvertObjectToXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlTextWriter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextWriter), Member = "set_Formatting", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Formatting)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializer), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(object), typeof(XmlSerializerNamespaces)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public void Serialize(TextWriter textWriter, object o) { }

	[CalledBy(Type = "System.Data.Common.ObjectStorage", Member = "ConvertObjectToXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XmlWriter), typeof(XmlRootAttribute)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.Common.SqlUdtStorage", Member = "ConvertObjectToXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(XmlWriter), typeof(XmlRootAttribute)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlSerializer), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(object), typeof(XmlSerializerNamespaces)}, ReturnType = typeof(void))]
	public void Serialize(XmlWriter xmlWriter, object o) { }

	[CalledBy(Type = typeof(XmlSerializer), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextWriter), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializer), Member = "Serialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlSerializer), Member = "CreateWriter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlMapping)}, ReturnType = typeof(XmlSerializationWriter))]
	[Calls(Type = typeof(XmlSerializerNamespaces), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlSerializerNamespaces), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSerializationWriter), Member = "Initialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlWriter), typeof(XmlSerializerNamespaces)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 13)]
	public void Serialize(XmlWriter xmlWriter, object o, XmlSerializerNamespaces namespaces) { }

}

