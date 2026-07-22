namespace System.Xml.Schema;

public class XmlSchemaGroup : XmlSchemaAnnotated
{
	private string name; //Field offset: 0x50
	private XmlSchemaGroupBase particle; //Field offset: 0x58
	private XmlSchemaParticle canonicalParticle; //Field offset: 0x60
	private XmlQualifiedName qname; //Field offset: 0x68
	private XmlSchemaGroup redefined; //Field offset: 0x70
	private int selfReferenceCount; //Field offset: 0x78

	[XmlIgnore]
	internal XmlSchemaParticle CanonicalParticle
	{
		[CallerCount(Count = 84)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	[XmlAttribute("name")]
	public string Name
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[XmlIgnore]
	internal virtual string NameAttribute
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	[XmlElement("choice", typeof(XmlSchemaChoice))]
	[XmlElement("all", typeof(XmlSchemaAll))]
	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	public XmlSchemaGroupBase Particle
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[XmlIgnore]
	public XmlQualifiedName QualifiedName
	{
		[CallerCount(Count = 22)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[XmlIgnore]
	internal XmlSchemaGroup Redefined
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	[XmlIgnore]
	internal int SelfReferenceCount
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	[CalledBy(Type = typeof(XsdBuilder), Member = "InitGroup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public XmlSchemaGroup() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaGroup), Member = "Clone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchema)}, ReturnType = typeof(XmlSchemaObject))]
	internal virtual XmlSchemaObject Clone() { }

	[CalledBy(Type = typeof(XmlSchema), Member = "DeepClone", ReturnType = typeof(XmlSchema))]
	[CalledBy(Type = typeof(XmlSchemaGroup), Member = "Clone", ReturnType = typeof(XmlSchemaObject))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlSchemaComplexType), Member = "HasParticleRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle), typeof(XmlSchema)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlSchemaComplexType), Member = "CloneParticle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaParticle), typeof(XmlSchema)}, ReturnType = typeof(XmlSchemaParticle))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	[CallerCount(Count = 84)]
	[DeduplicatedMethod]
	internal XmlSchemaParticle get_CanonicalParticle() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	public string get_Name() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	internal virtual string get_NameAttribute() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public XmlSchemaGroupBase get_Particle() { }

	[CallerCount(Count = 22)]
	[DeduplicatedMethod]
	public XmlQualifiedName get_QualifiedName() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	internal XmlSchemaGroup get_Redefined() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal int get_SelfReferenceCount() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_CanonicalParticle(XmlSchemaParticle value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Name(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual void set_NameAttribute(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Particle(XmlSchemaGroupBase value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_Redefined(XmlSchemaGroup value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_SelfReferenceCount(int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void SetQualifiedName(XmlQualifiedName value) { }

}

