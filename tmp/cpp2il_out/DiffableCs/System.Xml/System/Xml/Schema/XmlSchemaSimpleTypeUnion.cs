namespace System.Xml.Schema;

public class XmlSchemaSimpleTypeUnion : XmlSchemaSimpleTypeContent
{
	private XmlSchemaObjectCollection baseTypes; //Field offset: 0x50
	private XmlQualifiedName[] memberTypes; //Field offset: 0x58
	private XmlSchemaSimpleType[] baseMemberTypes; //Field offset: 0x60

	[XmlIgnore]
	public XmlSchemaSimpleType[] BaseMemberTypes
	{
		[CallerCount(Count = 84)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	public XmlSchemaObjectCollection BaseTypes
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[XmlAttribute("memberTypes")]
	public XmlQualifiedName[] MemberTypes
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CalledBy(Type = typeof(XsdBuilder), Member = "InitSimpleTypeUnion", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public XmlSchemaSimpleTypeUnion() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlQualifiedName), Member = "Clone", ReturnType = typeof(XmlQualifiedName))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	internal virtual XmlSchemaObject Clone() { }

	[CallerCount(Count = 84)]
	[DeduplicatedMethod]
	public XmlSchemaSimpleType[] get_BaseMemberTypes() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	public XmlSchemaObjectCollection get_BaseTypes() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public XmlQualifiedName[] get_MemberTypes() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_MemberTypes(XmlQualifiedName[] value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void SetBaseMemberTypes(XmlSchemaSimpleType[] baseMemberTypes) { }

}

