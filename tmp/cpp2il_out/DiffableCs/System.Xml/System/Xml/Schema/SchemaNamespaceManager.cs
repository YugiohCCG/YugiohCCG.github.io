namespace System.Xml.Schema;

internal class SchemaNamespaceManager : XmlNamespaceManager
{
	private XmlSchemaObject node; //Field offset: 0x50

	[CalledBy(Type = typeof(FacetsChecker), Member = "ConstructRestriction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DatatypeImplementation), typeof(XmlSchemaObjectCollection), typeof(XmlNameTable)}, ReturnType = typeof(RestrictionFacets))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaAttribute)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileIdentityConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaIdentityConstraint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaElement)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public SchemaNamespaceManager(XmlSchemaObject node) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaObject), Member = "get_Namespaces", ReturnType = typeof(XmlSerializerNamespaces))]
	[Calls(Type = typeof(XmlSerializerNamespaces), Member = "get_Namespaces", ReturnType = typeof(Hashtable))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public virtual string LookupNamespace(string prefix) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlSchemaObject), Member = "get_Namespaces", ReturnType = typeof(XmlSerializerNamespaces))]
	[Calls(Type = typeof(XmlSerializerNamespaces), Member = "get_Namespaces", ReturnType = typeof(Hashtable))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 13)]
	public virtual string LookupPrefix(string ns) { }

}

