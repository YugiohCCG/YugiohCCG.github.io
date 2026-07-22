namespace System.Xml.Schema;

internal sealed class SchemaEntity : IDtdEntityInfo
{
	private XmlQualifiedName qname; //Field offset: 0x10
	private string url; //Field offset: 0x18
	private string pubid; //Field offset: 0x20
	private string text; //Field offset: 0x28
	private XmlQualifiedName ndata; //Field offset: 0x30
	private int lineNumber; //Field offset: 0x38
	private int linePosition; //Field offset: 0x3C
	private bool isParameter; //Field offset: 0x40
	private bool isExternal; //Field offset: 0x41
	private bool parsingInProgress; //Field offset: 0x42
	private bool isDeclaredInExternal; //Field offset: 0x43
	private string baseURI; //Field offset: 0x48
	private string declaredURI; //Field offset: 0x50

	internal string BaseURI
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 30
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	internal bool DeclaredInExternal
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		internal set { } //Length: 4
	}

	internal string DeclaredURI
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		internal get { } //Length: 30
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	internal bool IsExternal
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	internal int Line
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	internal XmlQualifiedName Name
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal XmlQualifiedName NData
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	internal bool ParsingInProgress
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	internal int Pos
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	internal string Pubid
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	private override string System.Xml.IDtdEntityInfo.BaseUriString
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		private get { } //Length: 30
	}

	private override string System.Xml.IDtdEntityInfo.DeclaredUriString
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		private get { } //Length: 30
	}

	private override bool System.Xml.IDtdEntityInfo.IsDeclaredInExternal
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		private get { } //Length: 5
	}

	private override bool System.Xml.IDtdEntityInfo.IsExternal
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		private get { } //Length: 5
	}

	private override bool System.Xml.IDtdEntityInfo.IsParameterEntity
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		private get { } //Length: 5
	}

	private override bool System.Xml.IDtdEntityInfo.IsUnparsedEntity
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlQualifiedName), Member = "get_IsEmpty", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 32
	}

	private override int System.Xml.IDtdEntityInfo.LineNumber
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		private get { } //Length: 4
	}

	private override int System.Xml.IDtdEntityInfo.LinePosition
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		private get { } //Length: 4
	}

	private override string System.Xml.IDtdEntityInfo.Name
	{
		[CallerCount(Count = 6)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private get { } //Length: 27
	}

	private override string System.Xml.IDtdEntityInfo.PublicId
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		private get { } //Length: 5
	}

	private override string System.Xml.IDtdEntityInfo.SystemId
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		private get { } //Length: 5
	}

	private override string System.Xml.IDtdEntityInfo.Text
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		private get { } //Length: 5
	}

	internal string Text
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleGeneralEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(int)}, ReturnType = "System.Xml.XmlTextReaderImpl+EntityType")]
		[CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		internal set { } //Length: 32
	}

	internal string Url
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal set { } //Length: 32
	}

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleGeneralEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(int)}, ReturnType = "System.Xml.XmlTextReaderImpl+EntityType")]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal SchemaEntity(XmlQualifiedName qname, bool isParameter) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal string get_BaseURI() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_DeclaredInExternal() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	internal string get_DeclaredURI() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_IsExternal() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	internal int get_Line() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	internal XmlQualifiedName get_Name() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	internal XmlQualifiedName get_NData() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_ParsingInProgress() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal int get_Pos() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	internal string get_Pubid() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	internal string get_Text() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	internal string get_Url() { }

	[CalledBy(Type = typeof(DtdValidator), Member = "GenEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	internal static bool IsPredefinedEntity(string n) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_BaseURI(string value) { }

	[CallerCount(Count = 0)]
	internal void set_DeclaredInExternal(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_DeclaredURI(string value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_IsExternal(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_Line(int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_NData(XmlQualifiedName value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_ParsingInProgress(bool value) { }

	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	internal void set_Pos(int value) { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_Pubid(string value) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleGeneralEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(int)}, ReturnType = "System.Xml.XmlTextReaderImpl+EntityType")]
	[CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	internal void set_Text(string value) { }

	[CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void set_Url(string value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private override string System.Xml.IDtdEntityInfo.get_BaseUriString() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	private override string System.Xml.IDtdEntityInfo.get_DeclaredUriString() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private override bool System.Xml.IDtdEntityInfo.get_IsDeclaredInExternal() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private override bool System.Xml.IDtdEntityInfo.get_IsExternal() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	private override bool System.Xml.IDtdEntityInfo.get_IsParameterEntity() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlQualifiedName), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private override bool System.Xml.IDtdEntityInfo.get_IsUnparsedEntity() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	private override int System.Xml.IDtdEntityInfo.get_LineNumber() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private override int System.Xml.IDtdEntityInfo.get_LinePosition() { }

	[CallerCount(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override string System.Xml.IDtdEntityInfo.get_Name() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	private override string System.Xml.IDtdEntityInfo.get_PublicId() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	private override string System.Xml.IDtdEntityInfo.get_SystemId() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	private override string System.Xml.IDtdEntityInfo.get_Text() { }

}

