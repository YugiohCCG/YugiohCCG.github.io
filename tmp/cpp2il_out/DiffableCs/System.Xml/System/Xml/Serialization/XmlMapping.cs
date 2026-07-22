namespace System.Xml.Serialization;

public abstract class XmlMapping
{
	private ObjectMap map; //Field offset: 0x10
	private ArrayList relatedMaps; //Field offset: 0x18
	private SerializationFormat format; //Field offset: 0x20
	private SerializationSource source; //Field offset: 0x28
	internal string _elementName; //Field offset: 0x30
	internal string _namespace; //Field offset: 0x38
	private string key; //Field offset: 0x40

	public string ElementName
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	internal SerializationFormat Format
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	public string Namespace
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	internal ObjectMap ObjectMap
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	internal ArrayList RelatedMaps
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	internal SerializationSource Source
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	[CalledBy(Type = typeof(XmlTypeMapping), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(TypeData), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSerializableMapping), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlRootAttribute), typeof(string), typeof(string), typeof(TypeData), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal XmlMapping(string elementName, string ns) { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public string get_ElementName() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	internal SerializationFormat get_Format() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	public string get_Namespace() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	internal ObjectMap get_ObjectMap() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	internal ArrayList get_RelatedMaps() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	internal SerializationSource get_Source() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	internal void set_Format(SerializationFormat value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_ObjectMap(ObjectMap value) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_RelatedMaps(ArrayList value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void SetKey(string key) { }

}

