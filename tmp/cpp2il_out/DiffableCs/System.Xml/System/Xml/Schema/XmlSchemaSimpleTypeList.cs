namespace System.Xml.Schema;

public class XmlSchemaSimpleTypeList : XmlSchemaSimpleTypeContent
{
	private XmlQualifiedName itemTypeName; //Field offset: 0x50
	private XmlSchemaSimpleType itemType; //Field offset: 0x58
	private XmlSchemaSimpleType baseItemType; //Field offset: 0x60

	[XmlIgnore]
	public XmlSchemaSimpleType BaseItemType
	{
		[CallerCount(Count = 84)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	public XmlSchemaSimpleType ItemType
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[XmlAttribute("itemType")]
	public XmlQualifiedName ItemTypeName
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(XsdBuilder), Member = "BuildSimpleTypeList_ItemType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(XmlQualifiedName), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 160
	}

	[CalledBy(Type = typeof(DatatypeImplementation), Member = "FinishBuiltinType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaSimpleType), typeof(XmlSchemaSimpleType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "InitSimpleTypeList", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public XmlSchemaSimpleTypeList() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlQualifiedName), Member = "Clone", ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(XmlQualifiedName), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal virtual XmlSchemaObject Clone() { }

	[CallerCount(Count = 84)]
	[DeduplicatedMethod]
	public XmlSchemaSimpleType get_BaseItemType() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public XmlSchemaSimpleType get_ItemType() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	public XmlQualifiedName get_ItemTypeName() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_BaseItemType(XmlSchemaSimpleType value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_ItemType(XmlSchemaSimpleType value) { }

	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildSimpleTypeList_ItemType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlQualifiedName), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public void set_ItemTypeName(XmlQualifiedName value) { }

}

