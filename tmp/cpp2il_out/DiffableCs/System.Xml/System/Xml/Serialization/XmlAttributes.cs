namespace System.Xml.Serialization;

public class XmlAttributes
{
	private XmlAnyAttributeAttribute xmlAnyAttribute; //Field offset: 0x10
	private XmlAnyElementAttributes xmlAnyElements; //Field offset: 0x18
	private XmlArrayAttribute xmlArray; //Field offset: 0x20
	private XmlArrayItemAttributes xmlArrayItems; //Field offset: 0x28
	private XmlAttributeAttribute xmlAttribute; //Field offset: 0x30
	private XmlChoiceIdentifierAttribute xmlChoiceIdentifier; //Field offset: 0x38
	private object xmlDefaultValue; //Field offset: 0x40
	private XmlElementAttributes xmlElements; //Field offset: 0x48
	private XmlEnumAttribute xmlEnum; //Field offset: 0x50
	private bool xmlIgnore; //Field offset: 0x58
	private bool xmlns; //Field offset: 0x59
	private XmlRootAttribute xmlRoot; //Field offset: 0x60
	private XmlTextAttribute xmlText; //Field offset: 0x68
	private XmlTypeAttribute xmlType; //Field offset: 0x70

	internal Nullable<Int32> Order
	{
		[CalledBy(Type = typeof(XmlAttributes), Member = "get_SortableOrder", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportClassMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string), typeof(bool)}, ReturnType = typeof(XmlTypeMapping))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(XmlAnyElementAttributes), Member = "get_Order", ReturnType = typeof(int))]
		[Calls(Type = typeof(XmlElementAttributes), Member = "get_Order", ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 176
	}

	internal int SortableOrder
	{
		[CalledBy(Type = "System.Xml.Serialization.XmlReflectionImporter+<>c", Member = "<ImportClassMapping>b__28_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReflectionMember), typeof(XmlReflectionMember)}, ReturnType = typeof(int))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(XmlAttributes), Member = "get_Order", ReturnType = typeof(System.Nullable`1<System.Int32>))]
		[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
		internal get { } //Length: 126
	}

	public XmlAnyAttributeAttribute XmlAnyAttribute
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public XmlAnyElementAttributes XmlAnyElements
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public XmlArrayAttribute XmlArray
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public XmlArrayItemAttributes XmlArrayItems
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public XmlAttributeAttribute XmlAttribute
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public XmlChoiceIdentifierAttribute XmlChoiceIdentifier
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public object XmlDefaultValue
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public XmlElementAttributes XmlElements
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 254
	}

	public bool XmlIgnore
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public bool Xmlns
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public XmlRootAttribute XmlRoot
	{
		[CallerCount(Count = 84)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public XmlTextAttribute XmlText
	{
		[CallerCount(Count = 22)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public XmlTypeAttribute XmlType
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = "System.Xml.Serialization.XmlReflectionImporter+<>c", Member = "<ImportClassMapping>b__28_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReflectionMember), typeof(XmlReflectionMember)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportClassMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string), typeof(bool)}, ReturnType = typeof(XmlTypeMapping))]
	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportListMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string), typeof(XmlAttributes), typeof(int)}, ReturnType = typeof(XmlTypeMapping))]
	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "CreateMapMember", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(XmlReflectionMember), typeof(string)}, ReturnType = typeof(XmlTypeMapMember))]
	[CalledBy(Type = typeof(XmlReflectionMember), Member = "get_XmlAttributes", ReturnType = typeof(XmlAttributes))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public XmlAttributes() { }

	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "CreateTypeMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string), typeof(string)}, ReturnType = typeof(XmlTypeMapping))]
	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportClassMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string), typeof(bool)}, ReturnType = typeof(XmlTypeMapping))]
	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "GetTypeNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportXmlNodeMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string)}, ReturnType = typeof(XmlTypeMapping))]
	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportPrimitiveMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string)}, ReturnType = typeof(XmlTypeMapping))]
	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportEnumMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string)}, ReturnType = typeof(XmlTypeMapping))]
	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportXmlSerializableMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string)}, ReturnType = typeof(XmlTypeMapping))]
	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "GetReflectionMembers", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(System.Collections.Generic.List`1<System.Xml.Serialization.XmlReflectionMember>))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlAnyElementAttributes), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlAnyElementAttribute)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlArrayItemAttributes), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlArrayItemAttribute)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlElementAttributes), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlElementAttribute)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CollectionBase), Member = "Clear", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 37)]
	public XmlAttributes(ICustomAttributeProvider provider) { }

	[CalledBy(Type = typeof(XmlAttributeOverrides), Member = "AddKeyHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlCustomFormatter), Member = "ToXmlString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(TypeTranslator), Member = "GetTypeData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(TypeData))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(KeyHelper), Member = "AddField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(Type)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(KeyHelper), Member = "AddField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlElementAttributes), Member = "AddKeyHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextAttribute), Member = "AddKeyHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlArrayItemAttributes), Member = "AddKeyHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(KeyHelper), Member = "AddField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(KeyHelper), Member = "AddField", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(XmlTypeAttribute), Member = "AddKeyHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	internal void AddKeyHash(StringBuilder sb) { }

	[CalledBy(Type = typeof(XmlAttributes), Member = "get_SortableOrder", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlReflectionImporter), Member = "ImportClassMapping", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TypeData), typeof(XmlRootAttribute), typeof(string), typeof(bool)}, ReturnType = typeof(XmlTypeMapping))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlAnyElementAttributes), Member = "get_Order", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlElementAttributes), Member = "get_Order", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	internal Nullable<Int32> get_Order() { }

	[CalledBy(Type = "System.Xml.Serialization.XmlReflectionImporter+<>c", Member = "<ImportClassMapping>b__28_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReflectionMember), typeof(XmlReflectionMember)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlAttributes), Member = "get_Order", ReturnType = typeof(System.Nullable`1<System.Int32>))]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	internal int get_SortableOrder() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public XmlAnyAttributeAttribute get_XmlAnyAttribute() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public XmlAnyElementAttributes get_XmlAnyElements() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public XmlArrayAttribute get_XmlArray() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public XmlArrayItemAttributes get_XmlArrayItems() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public XmlAttributeAttribute get_XmlAttribute() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	public XmlChoiceIdentifierAttribute get_XmlChoiceIdentifier() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public object get_XmlDefaultValue() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public XmlElementAttributes get_XmlElements() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_XmlIgnore() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_Xmlns() { }

	[CallerCount(Count = 84)]
	[DeduplicatedMethod]
	public XmlRootAttribute get_XmlRoot() { }

	[CallerCount(Count = 22)]
	[DeduplicatedMethod]
	public XmlTextAttribute get_XmlText() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public XmlTypeAttribute get_XmlType() { }

}

