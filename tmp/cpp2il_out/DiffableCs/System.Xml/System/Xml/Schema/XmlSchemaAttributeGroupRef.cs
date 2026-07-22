namespace System.Xml.Schema;

public class XmlSchemaAttributeGroupRef : XmlSchemaAnnotated
{
	private XmlQualifiedName refName; //Field offset: 0x50

	[XmlAttribute("ref")]
	public XmlQualifiedName RefName
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(XmlSchemaComplexType), Member = "CloneAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectCollection)}, ReturnType = typeof(XmlSchemaObjectCollection))]
		[CalledBy(Type = typeof(XsdBuilder), Member = "BuildAttributeGroupRef_Ref", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(XmlQualifiedName), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 160
	}

	[CalledBy(Type = typeof(XsdBuilder), Member = "InitAttributeGroupRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public XmlSchemaAttributeGroupRef() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	public XmlQualifiedName get_RefName() { }

	[CalledBy(Type = typeof(XmlSchemaComplexType), Member = "CloneAttributes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObjectCollection)}, ReturnType = typeof(XmlSchemaObjectCollection))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildAttributeGroupRef_Ref", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlQualifiedName), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public void set_RefName(XmlQualifiedName value) { }

}

