namespace System.Xml.Schema;

internal class CompiledIdentityConstraint
{
	internal enum ConstraintRole
	{
		Unique = 0,
		Key = 1,
		Keyref = 2,
	}

	public static readonly CompiledIdentityConstraint Empty; //Field offset: 0x0
	internal XmlQualifiedName name; //Field offset: 0x10
	private ConstraintRole role; //Field offset: 0x18
	private Asttree selector; //Field offset: 0x20
	private Asttree[] fields; //Field offset: 0x28
	internal XmlQualifiedName refer; //Field offset: 0x30

	public Asttree[] Fields
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public ConstraintRole Role
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public Asttree Selector
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static CompiledIdentityConstraint() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private CompiledIdentityConstraint() { }

	[CalledBy(Type = typeof(SchemaCollectionCompiler), Member = "CompileIdentityConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaIdentityConstraint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Compiler), Member = "CompileIdentityConstraint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaIdentityConstraint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Asttree), Member = "CompileXPath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(XmlNamespaceManager)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Asttree), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(XmlNamespaceManager)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlSchemaException), Member = "SetSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaObject)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 31)]
	public CompiledIdentityConstraint(XmlSchemaIdentityConstraint constraint, XmlNamespaceManager nsmgr) { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public Asttree[] get_Fields() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public ConstraintRole get_Role() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public Asttree get_Selector() { }

}

