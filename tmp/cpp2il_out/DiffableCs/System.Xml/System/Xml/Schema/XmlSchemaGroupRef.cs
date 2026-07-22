namespace System.Xml.Schema;

public class XmlSchemaGroupRef : XmlSchemaParticle
{
	private XmlQualifiedName refName; //Field offset: 0x78
	private XmlSchemaGroupBase particle; //Field offset: 0x80
	private XmlSchemaGroup refined; //Field offset: 0x88

	[XmlIgnore]
	public XmlSchemaGroupBase Particle
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	[XmlIgnore]
	internal XmlSchemaGroup Redefined
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 19
	}

	[XmlAttribute("ref")]
	public XmlQualifiedName RefName
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(XsdBuilder), Member = "BuildGroupRef_Ref", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(XmlQualifiedName), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 160
	}

	[CalledBy(Type = typeof(XsdBuilder), Member = "InitGroupRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlSchemaParticle), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public XmlSchemaGroupRef() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public XmlSchemaGroupBase get_Particle() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal XmlSchemaGroup get_Redefined() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public XmlQualifiedName get_RefName() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_Redefined(XmlSchemaGroup value) { }

	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildGroupRef_Ref", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlQualifiedName), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	public void set_RefName(XmlQualifiedName value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void SetParticle(XmlSchemaGroupBase value) { }

}

