namespace System.Xml.Schema;

public class XmlSchemaComplexContent : XmlSchemaContentModel
{
	private XmlSchemaContent content; //Field offset: 0x50
	private bool isMixed; //Field offset: 0x58
	private bool hasMixedAttribute; //Field offset: 0x59

	[XmlElement("restriction", typeof(XmlSchemaComplexContentRestriction))]
	[XmlElement("extension", typeof(XmlSchemaComplexContentExtension))]
	public virtual XmlSchemaContent Content
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
	internal bool HasMixedAttribute
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	[XmlAttribute("mixed")]
	public bool IsMixed
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "PreprocessComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XsdBuilder), Member = "BuildComplexContent_Mixed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		 set { } //Length: 8
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public XmlSchemaComplexContent() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	public virtual XmlSchemaContent get_Content() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_HasMixedAttribute() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_IsMixed() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual void set_Content(XmlSchemaContent value) { }

	[CalledBy(Type = typeof(Preprocessor), Member = "PreprocessComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SchemaCollectionPreprocessor), Member = "PreprocessComplexType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaComplexType), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XsdBuilder), Member = "BuildComplexContent_Mixed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XsdBuilder), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	public void set_IsMixed(bool value) { }

}

