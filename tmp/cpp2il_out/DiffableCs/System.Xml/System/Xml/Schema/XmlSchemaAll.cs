namespace System.Xml.Schema;

public class XmlSchemaAll : XmlSchemaGroupBase
{
	private XmlSchemaObjectCollection items; //Field offset: 0x78

	internal virtual bool IsEmpty
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlSchemaParticle), Member = "get_IsEmpty", ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		internal get { } //Length: 60
	}

	[XmlElement("element", typeof(XmlSchemaElement))]
	public virtual XmlSchemaObjectCollection Items
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CannonicalizeGroupRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaGroupRef), typeof(bool), typeof(bool)}, ReturnType = typeof(XmlSchemaParticle))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CannonicalizeAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAll), typeof(bool), typeof(bool)}, ReturnType = typeof(XmlSchemaParticle))]
	[CalledBy(Type = typeof(Compiler), Member = "CannonicalizeGroupRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaGroupRef), typeof(bool)}, ReturnType = typeof(XmlSchemaParticle))]
	[CalledBy(Type = typeof(Compiler), Member = "CannonicalizeAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAll), typeof(bool)}, ReturnType = typeof(XmlSchemaParticle))]
	[CalledBy(Type = typeof(Compiler), Member = "IsElementFromGroupBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement), typeof(XmlSchemaGroupBase)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "InitAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CollectionBase), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaParticle), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public XmlSchemaAll() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaParticle), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal virtual bool get_IsEmpty() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public virtual XmlSchemaObjectCollection get_Items() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal virtual void SetItems(XmlSchemaObjectCollection newItems) { }

}

