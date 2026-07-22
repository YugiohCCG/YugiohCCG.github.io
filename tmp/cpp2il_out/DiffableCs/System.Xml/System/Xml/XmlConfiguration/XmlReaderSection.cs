namespace System.Xml.XmlConfiguration;

[EditorBrowsable(EditorBrowsableState::Never (1))]
public sealed class XmlReaderSection
{

	internal static bool CollapseWhiteSpaceIntoEmptyString
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		internal get { } //Length: 3
	}

	internal static bool ProhibitDefaultUrlResolver
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		internal get { } //Length: 3
	}

	[CalledBy(Type = typeof(Parser), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaType), typeof(XmlNameTable), typeof(SchemaNames), typeof(ValidationEventHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XdrBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(XmlNamespaceManager), typeof(SchemaInfo), typeof(string), typeof(XmlNameTable), typeof(SchemaNames), typeof(ValidationEventHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaCollection), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlSchemaValidator), Member = "Init", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal static XmlResolver CreateDefaultResolver() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	internal static bool get_CollapseWhiteSpaceIntoEmptyString() { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	internal static bool get_ProhibitDefaultUrlResolver() { }

}

