namespace System.Xml;

internal class XmlTextReaderImpl : XmlReader, IXmlLineInfo, IXmlNamespaceResolver
{
	private class DtdDefaultAttributeInfoToNodeDataComparer : IComparer<Object>
	{
		private static IComparer<Object> s_instance; //Field offset: 0x0

		internal static IComparer<Object> Instance
		{
			[CallerCount(Count = 0)]
			internal get { } //Length: 78
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static DtdDefaultAttributeInfoToNodeDataComparer() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public DtdDefaultAttributeInfoToNodeDataComparer() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 14)]
		[ContainsUnimplementedInstructions]
		public override int Compare(object x, object y) { }

		[CallerCount(Count = 0)]
		internal static IComparer<Object> get_Instance() { }

	}

	public class DtdParserProxy : IDtdParserAdapterV1, IDtdParserAdapterWithValidation, IDtdParserAdapter
	{
		private XmlTextReaderImpl reader; //Field offset: 0x10

		private override Uri System.Xml.IDtdParserAdapter.BaseUri
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(XmlTextReaderImpl), Member = "get_DtdParserProxy_BaseUri", ReturnType = typeof(Uri))]
			[CallsUnknownMethods(Count = 1)]
			private get { } //Length: 29
		}

		private override int System.Xml.IDtdParserAdapter.CurrentPosition
		{
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			private get { } //Length: 29
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			private set { } //Length: 30
		}

		private override int System.Xml.IDtdParserAdapter.EntityStackLength
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(XmlTextReaderImpl), Member = "get_DtdParserProxy_EntityStackLength", ReturnType = typeof(int))]
			[CallsUnknownMethods(Count = 1)]
			private get { } //Length: 29
		}

		private override bool System.Xml.IDtdParserAdapter.IsEntityEolNormalized
		{
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			private get { } //Length: 29
		}

		private override bool System.Xml.IDtdParserAdapter.IsEof
		{
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			private get { } //Length: 29
		}

		private override int System.Xml.IDtdParserAdapter.LineNo
		{
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			private get { } //Length: 29
		}

		private override int System.Xml.IDtdParserAdapter.LineStartPosition
		{
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			private get { } //Length: 29
		}

		private override IXmlNamespaceResolver System.Xml.IDtdParserAdapter.NamespaceResolver
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			private get { } //Length: 30
		}

		private override XmlNameTable System.Xml.IDtdParserAdapter.NameTable
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			private get { } //Length: 30
		}

		private override Char[] System.Xml.IDtdParserAdapter.ParsingBuffer
		{
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			private get { } //Length: 29
		}

		private override int System.Xml.IDtdParserAdapter.ParsingBufferLength
		{
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			private get { } //Length: 29
		}

		private override bool System.Xml.IDtdParserAdapterV1.Namespaces
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			private get { } //Length: 30
		}

		private override bool System.Xml.IDtdParserAdapterV1.Normalization
		{
			[CallerCount(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			[DeduplicatedMethod]
			private get { } //Length: 30
		}

		private override bool System.Xml.IDtdParserAdapterV1.V1CompatibilityMode
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			private get { } //Length: 30
		}

		private override bool System.Xml.IDtdParserAdapterWithValidation.DtdValidation
		{
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			private get { } //Length: 29
		}

		private override IValidationEventHandling System.Xml.IDtdParserAdapterWithValidation.ValidationEventHandling
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			private get { } //Length: 30
		}

		[CallerCount(Count = 98)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal DtdParserProxy(XmlTextReaderImpl reader) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlTextReaderImpl), Member = "get_DtdParserProxy_BaseUri", ReturnType = typeof(Uri))]
		[CallsUnknownMethods(Count = 1)]
		private override Uri System.Xml.IDtdParserAdapter.get_BaseUri() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private override int System.Xml.IDtdParserAdapter.get_CurrentPosition() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlTextReaderImpl), Member = "get_DtdParserProxy_EntityStackLength", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		private override int System.Xml.IDtdParserAdapter.get_EntityStackLength() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private override bool System.Xml.IDtdParserAdapter.get_IsEntityEolNormalized() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private override bool System.Xml.IDtdParserAdapter.get_IsEof() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private override int System.Xml.IDtdParserAdapter.get_LineNo() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private override int System.Xml.IDtdParserAdapter.get_LineStartPosition() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private override IXmlNamespaceResolver System.Xml.IDtdParserAdapter.get_NamespaceResolver() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private override XmlNameTable System.Xml.IDtdParserAdapter.get_NameTable() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private override Char[] System.Xml.IDtdParserAdapter.get_ParsingBuffer() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private override int System.Xml.IDtdParserAdapter.get_ParsingBufferLength() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private override void System.Xml.IDtdParserAdapter.OnNewLine(int pos) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_OnPublicId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(LineInfo), typeof(LineInfo)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private override void System.Xml.IDtdParserAdapter.OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_OnSystemId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(LineInfo), typeof(LineInfo)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private override void System.Xml.IDtdParserAdapter.OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_ParseComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private override void System.Xml.IDtdParserAdapter.ParseComment(StringBuilder sb) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_ParseNamedCharRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(StringBuilder)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		private override int System.Xml.IDtdParserAdapter.ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_ParseNumericCharRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		private override int System.Xml.IDtdParserAdapter.ParseNumericCharRef(StringBuilder internalSubsetBuilder) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_ParsePI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private override void System.Xml.IDtdParserAdapter.ParsePI(StringBuilder sb) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_PopEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdEntityInfo&), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		private override bool System.Xml.IDtdParserAdapter.PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_PushEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdEntityInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		private override bool System.Xml.IDtdParserAdapter.PushEntity(IDtdEntityInfo entity, out int entityId) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_PushExternalSubset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		private override bool System.Xml.IDtdParserAdapter.PushExternalSubset(string systemId, string publicId) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_PushInternalDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private override void System.Xml.IDtdParserAdapter.PushInternalDtd(string baseUri, string internalDtd) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_ReadData", ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 1)]
		private override int System.Xml.IDtdParserAdapter.ReadData() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private override void System.Xml.IDtdParserAdapter.set_CurrentPosition(int value) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		private override void System.Xml.IDtdParserAdapter.Throw(Exception e) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private override bool System.Xml.IDtdParserAdapterV1.get_Namespaces() { }

		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		private override bool System.Xml.IDtdParserAdapterV1.get_Normalization() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private override bool System.Xml.IDtdParserAdapterV1.get_V1CompatibilityMode() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private override bool System.Xml.IDtdParserAdapterWithValidation.get_DtdValidation() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		private override IValidationEventHandling System.Xml.IDtdParserAdapterWithValidation.get_ValidationEventHandling() { }

	}

	private enum EntityExpandType
	{
		All = 0,
		OnlyGeneral = 1,
		OnlyCharacter = 2,
	}

	private enum EntityType
	{
		CharacterDec = 0,
		CharacterHex = 1,
		CharacterNamed = 2,
		Expanded = 3,
		Skipped = 4,
		FakeExpanded = 5,
		Unexpanded = 6,
		ExpandedInAttribute = 7,
	}

	private enum IncrementalReadState
	{
		Text = 0,
		StartTag = 1,
		PI = 2,
		CDATA = 3,
		Comment = 4,
		Attributes = 5,
		AttributeValue = 6,
		ReadData = 7,
		EndElement = 8,
		End = 9,
		ReadValueChunk_OnCachedValue = 10,
		ReadValueChunk_OnPartialValue = 11,
		ReadContentAsBinary_OnCachedValue = 12,
		ReadContentAsBinary_OnPartialValue = 13,
		ReadContentAsBinary_End = 14,
	}

	private enum InitInputType
	{
		UriString = 0,
		Stream = 1,
		TextReader = 2,
		Invalid = 3,
	}

	private class LaterInitParam
	{
		public bool useAsync; //Field offset: 0x10
		public Stream inputStream; //Field offset: 0x18
		public Byte[] inputBytes; //Field offset: 0x20
		public int inputByteCount; //Field offset: 0x28
		public Uri inputbaseUri; //Field offset: 0x30
		public string inputUriStr; //Field offset: 0x38
		public XmlResolver inputUriResolver; //Field offset: 0x40
		public XmlParserContext inputContext; //Field offset: 0x48
		public TextReader inputTextReader; //Field offset: 0x50
		public InitInputType initType; //Field offset: 0x58

		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Byte[]), typeof(int), typeof(XmlReaderSettings), typeof(Uri), typeof(string), typeof(XmlParserContext), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader), typeof(XmlReaderSettings), typeof(string), typeof(XmlParserContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		public LaterInitParam() { }

	}

	private class NodeData : IComparable
	{
		private static NodeData s_None; //Field offset: 0x0
		internal XmlNodeType type; //Field offset: 0x10
		internal string localName; //Field offset: 0x18
		internal string prefix; //Field offset: 0x20
		internal string ns; //Field offset: 0x28
		internal string nameWPrefix; //Field offset: 0x30
		private string value; //Field offset: 0x38
		private Char[] chars; //Field offset: 0x40
		private int valueStartPos; //Field offset: 0x48
		private int valueLength; //Field offset: 0x4C
		internal LineInfo lineInfo; //Field offset: 0x50
		internal LineInfo lineInfo2; //Field offset: 0x58
		internal char quoteChar; //Field offset: 0x60
		internal int depth; //Field offset: 0x64
		private bool isEmptyOrDefault; //Field offset: 0x68
		internal int entityId; //Field offset: 0x6C
		internal bool xmlContextPushed; //Field offset: 0x70
		internal NodeData nextAttrValueChunk; //Field offset: 0x78
		internal object schemaType; //Field offset: 0x80
		internal object typedValue; //Field offset: 0x88

		internal bool IsDefaultAttribute
		{
			[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_IsDefault", ReturnType = typeof(bool))]
			[CallerCount(Count = 1)]
			internal get { } //Length: 14
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			internal set { } //Length: 4
		}

		internal bool IsEmptyElement
		{
			[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_IsEmptyElement", ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Skip", ReturnType = typeof(void))]
			[CallerCount(Count = 2)]
			internal get { } //Length: 14
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			internal set { } //Length: 4
		}

		internal int LineNo
		{
			[CallerCount(Count = 7)]
			[DeduplicatedMethod]
			internal get { } //Length: 4
		}

		internal int LinePos
		{
			[CallerCount(Count = 14)]
			[DeduplicatedMethod]
			internal get { } //Length: 4
		}

		internal static NodeData None
		{
			[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Close", ReturnType = typeof(void))]
			[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(NodeData), Member = "ClearName", ReturnType = typeof(void))]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 8)]
			internal get { } //Length: 303
		}

		internal string StringValue
		{
			[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Value", ReturnType = typeof(string))]
			[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "GetAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
			[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "GetAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
			[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "GetAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
			[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ReadAttributeValue", ReturnType = typeof(bool))]
			[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributesAndNormalize", ReturnType = typeof(void))]
			[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OnDefaultNamespaceDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OnNamespaceDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OnXmlReservedAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(void))]
			[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishOtherValueIterator", ReturnType = typeof(void))]
			[CallerCount(Count = 14)]
			[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
			[CallsUnknownMethods(Count = 1)]
			internal get { } //Length: 80
		}

		internal bool ValueBuffered
		{
			[CallerCount(Count = 0)]
			[ContainsUnimplementedInstructions]
			internal get { } //Length: 9
		}

		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlResolver), typeof(XmlReaderSettings), typeof(XmlParserContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char), typeof(NodeData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(NodeData))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AllocNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(NodeData))]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(NodeData), Member = "ClearName", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		internal NodeData() { }

		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OnEof", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(NodeData), Member = "ClearName", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		internal void Clear(XmlNodeType type) { }

		[CalledBy(Type = typeof(NodeData), Member = "get_None", ReturnType = typeof(NodeData))]
		[CalledBy(Type = typeof(NodeData), Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NodeData), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NodeData), Member = "SetValueNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(NodeData), Member = "SetValueNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 4)]
		internal void ClearName() { }

		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ReadValueChunk", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(string), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		internal int CopyTo(int valueOffset, Char[] buffer, int offset, int length) { }

		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_ParseComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishPartialValue", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
		[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
		[CallsUnknownMethods(Count = 1)]
		internal void CopyTo(int valueOffset, StringBuilder sb) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal string CreateNameWPrefix(XmlNameTable nt) { }

		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_IsDefault", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		internal bool get_IsDefaultAttribute() { }

		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_IsEmptyElement", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Skip", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		internal bool get_IsEmptyElement() { }

		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		internal int get_LineNo() { }

		[CallerCount(Count = 14)]
		[DeduplicatedMethod]
		internal int get_LinePos() { }

		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Close", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(NodeData), Member = "ClearName", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		internal static NodeData get_None() { }

		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Value", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "GetAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "GetAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "GetAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ReadAttributeValue", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributesAndNormalize", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OnDefaultNamespaceDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OnNamespaceDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OnXmlReservedAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishOtherValueIterator", ReturnType = typeof(void))]
		[CallerCount(Count = 14)]
		[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		internal string get_StringValue() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal bool get_ValueBuffered() { }

		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Name", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnclosedElements", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributesAndNormalize", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowTagMismatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AttributeDuplCheck", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "IncrementalRead", ReturnType = typeof(int))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "GetIndexOfAttributeWithPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal string GetNameWPrefix(XmlNameTable nt) { }

		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		internal void OnBufferInvalidated() { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal void set_IsDefaultAttribute(bool value) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal void set_IsEmptyElement(bool value) { }

		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlResolver), typeof(XmlReaderSettings), typeof(XmlParserContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueChunk", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OnEof", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDoctypeDecl", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseCDataOrComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseComment", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParsePI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseEntityReference", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseRootLevelWhitespace", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseText", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElement", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_ParseComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
		[CallerCount(Count = 17)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal void SetLineInfo(int lineNo, int linePos) { }

		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal void SetLineInfo2(int lineNo, int linePos) { }

		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElement", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDtd", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(NodeData))]
		[CallerCount(Count = 4)]
		[CallsUnknownMethods(Count = 5)]
		internal void SetNamedNode(XmlNodeType type, string localName, string prefix, string nameWPrefix) { }

		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_OnSystemId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(LineInfo), typeof(LineInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_OnPublicId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(LineInfo), typeof(LineInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElement", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char), typeof(NodeData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseEntityReference", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SetupEndEntityNodeInContent", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParsePI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddAttributeNoChecks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(NodeData))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueChunk", ReturnType = typeof(bool))]
		[CallerCount(Count = 11)]
		[CallsUnknownMethods(Count = 5)]
		internal void SetNamedNode(XmlNodeType type, string localName) { }

		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Value", ReturnType = typeof(string))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ReadValueChunk", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_OnSystemId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(LineInfo), typeof(LineInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_OnPublicId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(LineInfo), typeof(LineInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char), typeof(NodeData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishPartialValue", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishOtherValueIterator", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParsePI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDtd", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SkipDtd", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributeDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdDefaultAttributeInfo), typeof(bool), typeof(NodeData[])}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(NodeData))]
		[CallerCount(Count = 16)]
		[CallsUnknownMethods(Count = 1)]
		internal void SetValue(string value) { }

		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ReadValueChunk", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParsePI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 2)]
		internal void SetValue(Char[] chars, int startPos, int len) { }

		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_ParseComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseText", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseComment", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseCDataOrComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(NodeData), Member = "ClearName", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 2)]
		internal void SetValueNode(XmlNodeType type, Char[] chars, int startPos, int len) { }

		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ReadAttributeValue", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_ParseComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char), typeof(NodeData)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseText", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseRootLevelWhitespace", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseComment", ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseCDataOrComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueChunk", ReturnType = typeof(bool))]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(NodeData), Member = "ClearName", ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void SetValueNode(XmlNodeType type, string value) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 2)]
		private override int System.IComparable.CompareTo(object obj) { }

		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributesAndNormalize", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(XmlTextReaderImpl), Member = "StripSpaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(XmlTextReaderImpl), Member = "StripSpaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(Int32&)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void TrimSpacesInValue() { }

	}

	private class NoNamespaceManager : XmlNamespaceManager
	{

		public virtual string DefaultNamespace
		{
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			 get { } //Length: 18
		}

		[CallerCount(Count = 162)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public NoNamespaceManager() { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public virtual void AddNamespace(string prefix, string uri) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public virtual string get_DefaultNamespace() { }

		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		public virtual IEnumerator GetEnumerator() { }

		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		public virtual IDictionary<String, String> GetNamespacesInScope(XmlNamespaceScope scope) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public virtual string LookupNamespace(string prefix) { }

		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		public virtual string LookupPrefix(string uri) { }

		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		public virtual bool PopScope() { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public virtual void PushScope() { }

		[CallerCount(Count = 13327)]
		[DeduplicatedMethod]
		public virtual void RemoveNamespace(string prefix, string uri) { }

	}

	public sealed class OnDefaultAttributeUseDelegate : MulticastDelegate
	{

		[CallerCount(Count = 290)]
		[CallsUnknownMethods(Count = 7)]
		[DeduplicatedMethod]
		public OnDefaultAttributeUseDelegate(object object, IntPtr method) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public override void Invoke(IDtdDefaultAttributeInfo defaultAttribute, XmlTextReaderImpl coreReader) { }

	}

	private enum ParsingFunction
	{
		ElementContent = 0,
		NoData = 1,
		OpenUrl = 2,
		SwitchToInteractive = 3,
		SwitchToInteractiveXmlDecl = 4,
		DocumentContent = 5,
		MoveToElementContent = 6,
		PopElementContext = 7,
		PopEmptyElementContext = 8,
		ResetAttributesRootLevel = 9,
		Error = 10,
		Eof = 11,
		ReaderClosed = 12,
		EntityReference = 13,
		InIncrementalRead = 14,
		FragmentAttribute = 15,
		ReportEndEntity = 16,
		AfterResolveEntityInContent = 17,
		AfterResolveEmptyEntityInContent = 18,
		XmlDeclarationFragment = 19,
		GoToEof = 20,
		PartialTextValue = 21,
		InReadAttributeValue = 22,
		InReadValueChunk = 23,
		InReadContentAsBinary = 24,
		InReadElementContentAsBinary = 25,
	}

	private enum ParsingMode
	{
		Full = 0,
		SkipNode = 1,
		SkipContent = 2,
	}

	private struct ParsingState
	{
		internal Char[] chars; //Field offset: 0x0
		internal int charPos; //Field offset: 0x8
		internal int charsUsed; //Field offset: 0xC
		internal Encoding encoding; //Field offset: 0x10
		internal bool appendMode; //Field offset: 0x18
		internal Stream stream; //Field offset: 0x20
		internal Decoder decoder; //Field offset: 0x28
		internal Byte[] bytes; //Field offset: 0x30
		internal int bytePos; //Field offset: 0x38
		internal int bytesUsed; //Field offset: 0x3C
		internal TextReader textReader; //Field offset: 0x40
		internal int lineNo; //Field offset: 0x48
		internal int lineStartPos; //Field offset: 0x4C
		internal string baseUriStr; //Field offset: 0x50
		internal Uri baseUri; //Field offset: 0x58
		internal bool isEof; //Field offset: 0x60
		internal bool isStreamEof; //Field offset: 0x61
		internal IDtdEntityInfo entity; //Field offset: 0x68
		internal int entityId; //Field offset: 0x70
		internal bool eolNormalized; //Field offset: 0x74
		internal bool entityResolvedManually; //Field offset: 0x75

		internal int LineNo
		{
			[CallerCount(Count = 26)]
			[DeduplicatedMethod]
			internal get { } //Length: 4
		}

		internal int LinePos
		{
			[CallerCount(Count = 33)]
			internal get { } //Length: 7
		}

		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushParsingState", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		internal void Clear() { }

		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Close", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PopParsingState", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		internal void Close(bool closeInput) { }

		[CallerCount(Count = 26)]
		[DeduplicatedMethod]
		internal int get_LineNo() { }

		[CallerCount(Count = 33)]
		internal int get_LinePos() { }

	}

	private class XmlContext
	{
		internal XmlSpace xmlSpace; //Field offset: 0x10
		internal string xmlLang; //Field offset: 0x18
		internal string defaultNamespace; //Field offset: 0x20
		internal XmlContext previousContext; //Field offset: 0x28

		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlResolver), typeof(XmlReaderSettings), typeof(XmlParserContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		internal XmlContext() { }

		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushXmlContext", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 4)]
		internal XmlContext(XmlContext previousContext) { }

	}

	private readonly bool useAsync; //Field offset: 0x10
	private LaterInitParam laterInitParam; //Field offset: 0x18
	private XmlCharType xmlCharType; //Field offset: 0x20
	private ParsingState ps; //Field offset: 0x28
	private ParsingFunction parsingFunction; //Field offset: 0xA0
	private ParsingFunction nextParsingFunction; //Field offset: 0xA4
	private ParsingFunction nextNextParsingFunction; //Field offset: 0xA8
	private NodeData[] nodes; //Field offset: 0xB0
	private NodeData curNode; //Field offset: 0xB8
	private int index; //Field offset: 0xC0
	private int curAttrIndex; //Field offset: 0xC4
	private int attrCount; //Field offset: 0xC8
	private int attrHashtable; //Field offset: 0xCC
	private int attrDuplWalkCount; //Field offset: 0xD0
	private bool attrNeedNamespaceLookup; //Field offset: 0xD4
	private bool fullAttrCleanup; //Field offset: 0xD5
	private NodeData[] attrDuplSortingArray; //Field offset: 0xD8
	private XmlNameTable nameTable; //Field offset: 0xE0
	private bool nameTableFromSettings; //Field offset: 0xE8
	private XmlResolver xmlResolver; //Field offset: 0xF0
	private string url; //Field offset: 0xF8
	private bool normalize; //Field offset: 0x100
	private bool supportNamespaces; //Field offset: 0x101
	private WhitespaceHandling whitespaceHandling; //Field offset: 0x104
	private DtdProcessing dtdProcessing; //Field offset: 0x108
	private EntityHandling entityHandling; //Field offset: 0x10C
	private bool ignorePIs; //Field offset: 0x110
	private bool ignoreComments; //Field offset: 0x111
	private bool checkCharacters; //Field offset: 0x112
	private int lineNumberOffset; //Field offset: 0x114
	private int linePositionOffset; //Field offset: 0x118
	private bool closeInput; //Field offset: 0x11C
	private long maxCharactersInDocument; //Field offset: 0x120
	private long maxCharactersFromEntities; //Field offset: 0x128
	private bool v1Compat; //Field offset: 0x130
	private XmlNamespaceManager namespaceManager; //Field offset: 0x138
	private string lastPrefix; //Field offset: 0x140
	private XmlContext xmlContext; //Field offset: 0x148
	private ParsingState[] parsingStatesStack; //Field offset: 0x150
	private int parsingStatesStackTop; //Field offset: 0x158
	private string reportedBaseUri; //Field offset: 0x160
	private Encoding reportedEncoding; //Field offset: 0x168
	private IDtdInfo dtdInfo; //Field offset: 0x170
	private XmlNodeType fragmentType; //Field offset: 0x178
	private XmlParserContext fragmentParserContext; //Field offset: 0x180
	private bool fragment; //Field offset: 0x188
	private IncrementalReadDecoder incReadDecoder; //Field offset: 0x190
	private IncrementalReadState incReadState; //Field offset: 0x198
	private LineInfo incReadLineInfo; //Field offset: 0x19C
	private int incReadDepth; //Field offset: 0x1A4
	private int incReadLeftStartPos; //Field offset: 0x1A8
	private int incReadLeftEndPos; //Field offset: 0x1AC
	private int attributeValueBaseEntityId; //Field offset: 0x1B0
	private bool emptyEntityInAttributeResolved; //Field offset: 0x1B4
	private IValidationEventHandling validationEventHandling; //Field offset: 0x1B8
	private OnDefaultAttributeUseDelegate onDefaultAttributeUse; //Field offset: 0x1C0
	private bool validatingReaderCompatFlag; //Field offset: 0x1C8
	private bool addDefaultAttributesAndNormalize; //Field offset: 0x1C9
	private StringBuilder stringBuilder; //Field offset: 0x1D0
	private bool rootElementParsed; //Field offset: 0x1D8
	private bool standalone; //Field offset: 0x1D9
	private int nextEntityId; //Field offset: 0x1DC
	private ParsingMode parsingMode; //Field offset: 0x1E0
	private ReadState readState; //Field offset: 0x1E4
	private IDtdEntityInfo lastEntity; //Field offset: 0x1E8
	private bool afterResetState; //Field offset: 0x1F0
	private int documentStartBytePos; //Field offset: 0x1F4
	private int readValueOffset; //Field offset: 0x1F8
	private long charactersInDocument; //Field offset: 0x200
	private long charactersFromEntities; //Field offset: 0x208
	private Dictionary<IDtdEntityInfo, IDtdEntityInfo> currentEntities; //Field offset: 0x210
	private bool disableUndeclaredEntityCheck; //Field offset: 0x218
	private XmlReader outerReader; //Field offset: 0x220
	private bool xmlResolverIsSet; //Field offset: 0x228
	private string Xml; //Field offset: 0x230
	private string XmlNs; //Field offset: 0x238
	private Task<Tuple`4<Int32, Int32, Int32, Boolean>> parseText_dummyTask; //Field offset: 0x240

	public virtual int AttributeCount
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public virtual string BaseURI
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public virtual bool CanReadValueChunk
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public virtual bool CanResolveEntity
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	public virtual int Depth
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 29
	}

	internal bool DisableUndeclaredEntityCheck
	{
		[CallerCount(Count = 0)]
		internal set { } //Length: 7
	}

	internal virtual IDtdInfo DtdInfo
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	internal Uri DtdParserProxy_BaseUri
	{
		[CalledBy(Type = typeof(DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.get_BaseUri", ReturnType = typeof(Uri))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal get { } //Length: 190
	}

	internal int DtdParserProxy_CurrentPosition
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	internal bool DtdParserProxy_DtdValidation
	{
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		internal get { } //Length: 12
	}

	internal int DtdParserProxy_EntityStackLength
	{
		[CalledBy(Type = typeof(DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.get_EntityStackLength", ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		internal get { } //Length: 9
	}

	internal bool DtdParserProxy_IsEntityEolNormalized
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	internal bool DtdParserProxy_IsEof
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	internal int DtdParserProxy_LineNo
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	internal int DtdParserProxy_LineStartPosition
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	internal IXmlNamespaceResolver DtdParserProxy_NamespaceResolver
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	internal bool DtdParserProxy_Namespaces
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	internal XmlNameTable DtdParserProxy_NameTable
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	internal bool DtdParserProxy_Normalization
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	internal Char[] DtdParserProxy_ParsingBuffer
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	internal int DtdParserProxy_ParsingBufferLength
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	internal bool DtdParserProxy_V1CompatibilityMode
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	internal IValidationEventHandling DtdParserProxy_ValidationEventHandling
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	private bool DtdValidation
	{
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		private get { } //Length: 12
	}

	internal EntityHandling EntityHandling
	{
		[CalledBy(Type = typeof(XmlTextReader), Member = "set_EntityHandling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EntityHandling)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		internal set { } //Length: 133
	}

	public virtual bool EOF
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 11
	}

	internal XmlNodeType FragmentType
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 7
	}

	private bool InAttributeValueIterator
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 23
	}

	private bool InEntity
	{
		[CallerCount(Count = 0)]
		private get { } //Length: 12
	}

	internal object InternalSchemaType
	{
		[CalledBy(Type = typeof(XmlValidatingReaderImpl), Member = "ProcessCoreReaderEvent", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlValidatingReaderImpl), Member = "set_SchemaTypeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		internal set { } //Length: 41
	}

	internal object InternalTypedValue
	{
		[CalledBy(Type = typeof(XmlValidatingReaderImpl), Member = "get_TypedValueObject", ReturnType = typeof(object))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 33
		[CalledBy(Type = typeof(XmlValidatingReaderImpl), Member = "ProcessCoreReaderEvent", ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlValidatingReaderImpl), Member = "set_TypedValueObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		internal set { } //Length: 44
	}

	public virtual bool IsDefault
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NodeData), Member = "get_IsDefaultAttribute", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 32
	}

	public virtual bool IsEmptyElement
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NodeData), Member = "get_IsEmptyElement", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 32
	}

	private bool IsResolverNull
	{
		[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleGeneralEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(int)}, ReturnType = typeof(EntityType))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		private get { } //Length: 60
	}

	internal bool IsResolverSet
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 8
	}

	public override int LineNumber
	{
		[CalledBy(Type = typeof(XmlTextReader), Member = "get_LineNumber", ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 32
	}

	public override int LinePosition
	{
		[CalledBy(Type = typeof(XmlTextReader), Member = "get_LinePosition", ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 32
	}

	public virtual string LocalName
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 30
	}

	public virtual string Name
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NodeData), Member = "GetNameWPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 43
	}

	internal virtual XmlNamespaceManager NamespaceManager
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	internal bool Namespaces
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CalledBy(Type = typeof(XmlLoader), Member = "ParseDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocumentType), typeof(bool), typeof(XmlResolver)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlLoader), Member = "CreateInnerXmlReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNodeType), typeof(XmlParserContext), typeof(XmlDocument)}, ReturnType = typeof(XmlReader))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(XmlNamespaceManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 8)]
		internal set { } //Length: 582
	}

	public virtual string NamespaceURI
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 30
	}

	public virtual XmlNameTable NameTable
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public virtual XmlNodeType NodeType
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 29
	}

	internal bool Normalization
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
		[CalledBy(Type = typeof(XmlTextReader), Member = "set_Normalization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 5)]
		internal set { } //Length: 205
	}

	internal OnDefaultAttributeUseDelegate OnDefaultAttributeUse
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 19
	}

	internal XmlReader OuterReader
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 19
	}

	public virtual string Prefix
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 30
	}

	public virtual char QuoteChar
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 46
	}

	public virtual ReadState ReadState
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 7
	}

	public virtual XmlReaderSettings Settings
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlReaderSettings), Member = "set_IgnoreWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlReaderSettings), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlReaderSettings), Member = "set_NameTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlReaderSettings), Member = "set_ConformanceLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConformanceLevel)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlReaderSettings), Member = "set_CheckCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlReaderSettings), Member = "set_LineNumberOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlReaderSettings), Member = "set_LinePositionOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlReaderSettings), Member = "set_XmlResolver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlResolver)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlReaderSettings), Member = "set_IgnoreProcessingInstructions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlReaderSettings), Member = "set_IgnoreComments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlReaderSettings), Member = "set_DtdProcessing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DtdProcessing)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlReaderSettings), Member = "set_MaxCharactersInDocument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlReaderSettings), Member = "set_MaxCharactersFromEntities", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlReaderSettings), Member = "EnableLegacyXmlSettings", ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 387
	}

	internal bool StandAlone
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 8
	}

	internal bool V1Compat
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal get { } //Length: 8
	}

	internal IValidationEventHandling ValidationEventHandling
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		internal set { } //Length: 19
	}

	public virtual string Value
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NodeData), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishPartialValue", ReturnType = typeof(void))]
		[Calls(Type = typeof(NodeData), Member = "get_StringValue", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 329
	}

	internal WhitespaceHandling WhitespaceHandling
	{
		[CalledBy(Type = typeof(XmlTextReader), Member = "set_WhitespaceHandling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WhitespaceHandling)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		internal set { } //Length: 217
	}

	public virtual string XmlLang
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 30
	}

	internal XmlResolver XmlResolver
	{
		[CalledBy(Type = typeof(XmlTextReader), Member = "set_XmlResolver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlResolver)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlLoader), Member = "ParseDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocumentType), typeof(bool), typeof(XmlResolver)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlLoader), Member = "CreateInnerXmlReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNodeType), typeof(XmlParserContext), typeof(XmlDocument)}, ReturnType = typeof(XmlReader))]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 5)]
		internal set { } //Length: 172
	}

	public virtual XmlSpace XmlSpace
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 29
	}

	internal bool XmlValidatingReaderCompatibilityMode
	{
		[CalledBy(Type = typeof(XmlTextReader), Member = "set_XmlValidatingReaderCompatibilityMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlValidatingReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(ValidationEventHandler), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(XmlLoader), Member = "CreateInnerXmlReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNodeType), typeof(XmlParserContext), typeof(XmlDocument)}, ReturnType = typeof(XmlReader))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Preprocessor), Member = "GetBuildInSchema", ReturnType = typeof(XmlSchema))]
		[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 3)]
		internal set { } //Length: 622
	}

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Stream), typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader), typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextReader), typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNodeType), typeof(XmlParserContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlParserContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(XmlCharType), Member = "get_Instance", ReturnType = typeof(XmlCharType))]
	[Calls(Type = typeof(Task), Member = "FromResult", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "EnableLegacyXmlSettings", ReturnType = typeof(bool))]
	[Calls(Type = typeof(NodeData), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlContext), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 19)]
	internal XmlTextReaderImpl(XmlNameTable nt) { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ImplReadXmlText", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlResolver), typeof(XmlReaderSettings), typeof(XmlParserContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoding), Member = "get_Unicode", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "InitStringInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Encoding), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal XmlTextReaderImpl(string xmlFragment, XmlParserContext context, XmlReaderSettings settings) { }

	[CalledBy(Type = typeof(XmlReader), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlReaderSettings), typeof(string)}, ReturnType = typeof(XmlReader))]
	[CalledBy(Type = typeof(XmlReader), Member = "CreateSqlReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(XmlReaderSettings), typeof(XmlParserContext)}, ReturnType = typeof(XmlReader))]
	[CalledBy(Type = typeof(XmlReaderSettings), Member = "CreateReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Uri), typeof(string), typeof(XmlParserContext)}, ReturnType = typeof(XmlReader))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlResolver), typeof(XmlReaderSettings), typeof(XmlParserContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(LaterInitParam), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishInitStream", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	internal XmlTextReaderImpl(Stream stream, Byte[] bytes, int byteCount, XmlReaderSettings settings, Uri baseUri, string baseUriStr, XmlParserContext context, bool closeInput) { }

	[CalledBy(Type = typeof(XmlLoader), Member = "ParseXmlDeclarationValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(String&), typeof(String&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoding), Member = "get_Unicode", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "InitStringInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Encoding), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "InitFragmentReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(XmlParserContext), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NameTable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal XmlTextReaderImpl(string xmlFragment, XmlParserContext context) { }

	[CalledBy(Type = typeof(XmlLoader), Member = "ParseDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocumentType), typeof(bool), typeof(XmlResolver)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlLoader), Member = "CreateInnerXmlReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNodeType), typeof(XmlParserContext), typeof(XmlDocument)}, ReturnType = typeof(XmlReader))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NameTable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoding), Member = "get_Unicode", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "InitStringInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Encoding), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "InitFragmentReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(XmlParserContext), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal XmlTextReaderImpl(string xmlFragment, XmlNodeType fragType, XmlParserContext context) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlNamespaceManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "InitTextReaderInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Uri), typeof(TextReader)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal XmlTextReaderImpl(string url, TextReader input, XmlNameTable nt) { }

	[CalledBy(Type = typeof(XmlReader), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader), typeof(XmlReaderSettings), typeof(string)}, ReturnType = typeof(XmlReader))]
	[CalledBy(Type = typeof(XmlReaderSettings), Member = "CreateReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader), typeof(string), typeof(XmlParserContext)}, ReturnType = typeof(XmlReader))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlResolver), typeof(XmlReaderSettings), typeof(XmlParserContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(LaterInitParam), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishInitTextReader", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	internal XmlTextReaderImpl(TextReader input, XmlReaderSettings settings, string baseUriStr, XmlParserContext context) { }

	[CalledBy(Type = typeof(XmlTextReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NameTable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlNamespaceManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "InitTextReaderInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Uri), typeof(TextReader)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal XmlTextReaderImpl(TextReader input) { }

	[CalledBy(Type = typeof(XmlTextReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Stream), typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlNamespaceManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "InitStreamInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(Stream), typeof(Byte[]), typeof(int), typeof(Encoding)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal XmlTextReaderImpl(string url, Stream input, XmlNameTable nt) { }

	[CalledBy(Type = typeof(XmlTextReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NameTable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlNamespaceManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "InitStreamInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(Stream), typeof(Byte[]), typeof(int), typeof(Encoding)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal XmlTextReaderImpl(Stream input) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Byte[]), typeof(int), typeof(XmlReaderSettings), typeof(Uri), typeof(string), typeof(XmlParserContext), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader), typeof(XmlReaderSettings), typeof(string), typeof(XmlParserContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlParserContext), typeof(XmlReaderSettings)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "SetupFromParserContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlParserContext), typeof(XmlReaderSettings)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlCharType), Member = "get_Instance", ReturnType = typeof(XmlCharType))]
	[Calls(Type = typeof(Task), Member = "FromResult", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(System.Threading.Tasks.Task`1<System.Object>))]
	[Calls(Type = typeof(XmlContext), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(NameTable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlNamespaceManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
	[Calls(Type = typeof(NodeData), Member = "SetLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 21)]
	[ContainsUnimplementedInstructions]
	private XmlTextReaderImpl(XmlResolver resolver, XmlReaderSettings settings, XmlParserContext context) { }

	[CalledBy(Type = typeof(XmlTextReader), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader), typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlNamespaceManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "InitTextReaderInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Uri), typeof(TextReader)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	internal XmlTextReaderImpl(TextReader input, XmlNameTable nt) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(NodeData))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributeDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdDefaultAttributeInfo), typeof(bool), typeof(NodeData[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(NodeData))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "AddNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(NodeData))]
	[Calls(Type = typeof(NodeData), Member = "SetNamedNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private NodeData AddAttribute(string localName, string prefix, string nameWPrefix) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlConvert), Member = "StrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(NodeData))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private NodeData AddAttribute(int endNamePos, int colonPos) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	private void AddAttributeChunkToList(NodeData attr, NodeData chunk, ref NodeData lastChunk) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "AddNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(NodeData))]
	[Calls(Type = typeof(NodeData), Member = "SetNamedNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private NodeData AddAttributeNoChecks(string name, int attrDepth) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributesAndNormalize", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "BinarySearch", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", "T", "System.Collections.Generic.IComparer`1<T>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(NodeData))]
	[Calls(Type = typeof(NodeData), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "OnXmlReservedAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "OnNamespaceDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "OnDefaultNamespaceDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 17)]
	private bool AddDefaultAttributeDtd(IDtdDefaultAttributeInfo defAttrInfo, bool definedInDtd, NodeData[] nameSortedNodeData) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributeNonDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(NodeData))]
	[Calls(Type = typeof(NodeData), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "OnXmlReservedAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "OnNamespaceDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "OnDefaultNamespaceDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	private NodeData AddDefaultAttributeInternal(string localName, string ns, string prefix, string value, int lineNo, int linePos, int valueLineNo, int valueLinePos, bool isXmlAttribute) { }

	[CalledBy(Type = typeof(XmlValidatingReaderImpl), Member = "AddDefaultAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SchemaAttDef)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SchemaDeclBase), Member = "get_Prefix", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(NodeData))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	internal bool AddDefaultAttributeNonDtd(SchemaAttDef attrDef) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NodeData), Member = "get_StringValue", ReturnType = typeof(string))]
	[Calls(Type = typeof(NodeData), Member = "TrimSpacesInValue", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NodeData), Member = "GetNameWPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSeverityType), typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Sort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object[]), typeof(System.Collections.Generic.IComparer`1<System.Object>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributeDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdDefaultAttributeInfo), typeof(bool), typeof(NodeData[])}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "AttributeNamespaceLookup", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 24)]
	private void AddDefaultAttributesAndNormalize() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OnDefaultNamespaceDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OnNamespaceDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 13)]
	private void AddNamespace(string prefix, string uri, NodeData attr) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ReadAttributeValue", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_ParseComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_OnSystemId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(LineInfo), typeof(LineInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_OnPublicId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(LineInfo), typeof(LineInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddAttributeNoChecks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(NodeData))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(NodeData))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueChunk", ReturnType = typeof(bool))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	private NodeData AddNode(int nodeIndex, int nodeDepth) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	private NodeData AllocNode(int nodeIndex, int nodeDepth) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Sort", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "GetNameWPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 15)]
	private void AttributeDuplCheck() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributesAndNormalize", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "LookupNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	private void AttributeNamespaceLookup() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	internal static void BlockCopy(Byte[] src, int srcOffset, Byte[] dst, int dstOffset, int count) { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[DeduplicatedMethod]
	internal static void BlockCopyChars(Char[] src, int srcOffset, Char[] dst, int dstOffset, int count) { }

	[CalledBy(Type = typeof(XmlValidatingReaderImpl), Member = "ProcessCoreReaderEvent", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void ChangeCurrentNodeType(XmlNodeType newNodeType) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(UTF8Encoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowWithoutLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private Encoding CheckEncoding(string newEncodingName) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "PopParsingState", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParsingState), Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "get_None", ReturnType = typeof(NodeData))]
	[CallsUnknownMethods(Count = 4)]
	internal void Close(bool closeInput) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "PopParsingState", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParsingState), Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "get_None", ReturnType = typeof(NodeData))]
	[CallsUnknownMethods(Count = 4)]
	public virtual void Close() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "InitStreamInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(Stream), typeof(Byte[]), typeof(int), typeof(Encoding)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Encoding), Member = "get_BigEndianUnicode", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(Ucs4Encoding), Member = "get_UCS4_3412", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(Encoding), Member = "get_Unicode", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(Ucs4Encoding), Member = "get_UCS4_Littleendian", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(UTF8Encoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Ucs4Encoding), Member = "get_UCS4_Bigendian", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(Ucs4Encoding), Member = "get_UCS4_2143", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private Encoding DetectEncoding() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	internal void DtdParserProxy_OnNewLine(int pos) { }

	[CalledBy(Type = typeof(DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.OnPublicId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(LineInfo), typeof(LineInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "AddNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(NodeData))]
	[Calls(Type = typeof(NodeData), Member = "SetNamedNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void DtdParserProxy_OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo) { }

	[CalledBy(Type = typeof(DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.OnSystemId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(LineInfo), typeof(LineInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "AddNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(NodeData))]
	[Calls(Type = typeof(NodeData), Member = "SetNamedNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void DtdParserProxy_OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo) { }

	[CalledBy(Type = typeof(DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.ParseComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "AddNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(NodeData))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseCDataOrComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
	[Calls(Type = typeof(NodeData), Member = "SetLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(NodeData), Member = "SetValueNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "SetValueNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "SendValidationEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSeverityType), typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 15)]
	internal void DtdParserProxy_ParseComment(StringBuilder sb) { }

	[CalledBy(Type = typeof(DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.ParseNamedCharRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(StringBuilder)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseNamedCharRefInline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(StringBuilder)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	internal int DtdParserProxy_ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	[CalledBy(Type = typeof(DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.ParseNumericCharRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseNumericCharRefInline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(StringBuilder), typeof(Int32&), typeof(EntityType&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	internal int DtdParserProxy_ParseNumericCharRef(StringBuilder internalSubsetBuilder) { }

	[CalledBy(Type = typeof(DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.ParsePI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParsePI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(bool))]
	internal void DtdParserProxy_ParsePI(StringBuilder sb) { }

	[CalledBy(Type = typeof(DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.PopEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdEntityInfo&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "PopEntity", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal bool DtdParserProxy_PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId) { }

	[CalledBy(Type = typeof(DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.PushEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdEntityInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "PushInternalEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdEntityInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "PushExternalEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdEntityInfo)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal bool DtdParserProxy_PushEntity(IDtdEntityInfo entity, out int entityId) { }

	[CalledBy(Type = typeof(DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.PushExternalSubset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "PushExternalEntityOrSubset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Uri), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "EatWhitespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	internal bool DtdParserProxy_PushExternalSubset(string systemId, string publicId) { }

	[CalledBy(Type = typeof(DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.PushInternalDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "PushParsingState", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "RegisterConsumedCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoding), Member = "get_Unicode", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "InitStringInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Encoding), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal void DtdParserProxy_PushInternalDtd(string baseUri, string internalDtd) { }

	[CalledBy(Type = typeof(DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.ReadData", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	internal int DtdParserProxy_ReadData() { }

	[CalledBy(Type = typeof(DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	internal void DtdParserProxy_Throw(Exception e) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_PushExternalSubset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseRootLevelWhitespace", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParsePI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDoctypeDecl", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SkipDtd", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushExternalEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdEntityInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "IncrementalRead", ReturnType = typeof(int))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private int EatWhitespaces(StringBuilder sb) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "LookupNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	private void ElementNamespaceLookup() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "MoveToAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "MoveToAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "MoveToFirstAttribute", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "MoveToNextAttribute", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "MoveToElement", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Skip", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishReadContentAsBinary", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "SkipPartialTextValue", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "PopEntity", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void FinishAttributeValueIterator() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Skip", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "IncrementalRead", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void FinishIncrementalRead() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishInitTextReader", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishInitStream", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishInitUriString", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void FinishInit() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Byte[]), typeof(int), typeof(XmlReaderSettings), typeof(Uri), typeof(string), typeof(XmlParserContext), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishInit", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "InitStreamInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(Stream), typeof(Byte[]), typeof(int), typeof(Encoding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlParserContext), Member = "get_HasDtdInfo", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ProcessDtdFromParserContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlParserContext)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void FinishInitStream() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader), typeof(XmlReaderSettings), typeof(string), typeof(XmlParserContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishInit", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "InitTextReaderInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Uri), typeof(TextReader)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlParserContext), Member = "get_HasDtdInfo", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ProcessDtdFromParserContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlParserContext)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void FinishInitTextReader() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishInit", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Task), Member = "Wait", ReturnType = typeof(void))]
	[Calls(Type = typeof(Task`1), Member = "get_Result", ReturnType = "TResult")]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "InitStreamInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(Stream), typeof(Byte[]), typeof(int), typeof(Encoding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlParserContext), Member = "get_HasDtdInfo", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ProcessDtdFromParserContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlParserContext)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 17)]
	private void FinishInitUriString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NodeData), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishPartialValue", ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "get_StringValue", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	private void FinishOtherValueIterator() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Value", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishOtherValueIterator", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(NodeData), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(StringBuilder)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(NodeData), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void FinishPartialValue() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Skip", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ReadAttributeValue", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishAttributeValueIterator", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishReadElementContentAsBinary", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "SkipPartialTextValue", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void FinishReadContentAsBinary() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Skip", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishReadContentAsBinary", ReturnType = typeof(void))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void FinishReadElementContentAsBinary() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "SkipPartialTextValue", ReturnType = typeof(void))]
	private void FinishReadValueChunk() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private void FullAttributeCleanup() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual int get_AttributeCount() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual string get_BaseURI() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public virtual bool get_CanReadValueChunk() { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public virtual bool get_CanResolveEntity() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual int get_Depth() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal virtual IDtdInfo get_DtdInfo() { }

	[CalledBy(Type = typeof(DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.get_BaseUri", ReturnType = typeof(Uri))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal Uri get_DtdParserProxy_BaseUri() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	internal int get_DtdParserProxy_CurrentPosition() { }

	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal bool get_DtdParserProxy_DtdValidation() { }

	[CalledBy(Type = typeof(DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.get_EntityStackLength", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	internal int get_DtdParserProxy_EntityStackLength() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	internal bool get_DtdParserProxy_IsEntityEolNormalized() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	internal bool get_DtdParserProxy_IsEof() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	internal int get_DtdParserProxy_LineNo() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	internal int get_DtdParserProxy_LineStartPosition() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal IXmlNamespaceResolver get_DtdParserProxy_NamespaceResolver() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_DtdParserProxy_Namespaces() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal XmlNameTable get_DtdParserProxy_NameTable() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_DtdParserProxy_Normalization() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	internal Char[] get_DtdParserProxy_ParsingBuffer() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	internal int get_DtdParserProxy_ParsingBufferLength() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_DtdParserProxy_V1CompatibilityMode() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal IValidationEventHandling get_DtdParserProxy_ValidationEventHandling() { }

	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	private bool get_DtdValidation() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public virtual bool get_EOF() { }

	[CallerCount(Count = 0)]
	internal XmlNodeType get_FragmentType() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private bool get_InAttributeValueIterator() { }

	[CallerCount(Count = 0)]
	private bool get_InEntity() { }

	[CalledBy(Type = typeof(XmlValidatingReaderImpl), Member = "get_TypedValueObject", ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal object get_InternalTypedValue() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NodeData), Member = "get_IsDefaultAttribute", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool get_IsDefault() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NodeData), Member = "get_IsEmptyElement", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool get_IsEmptyElement() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleGeneralEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(int)}, ReturnType = typeof(EntityType))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private bool get_IsResolverNull() { }

	[CallerCount(Count = 0)]
	internal bool get_IsResolverSet() { }

	[CalledBy(Type = typeof(XmlTextReader), Member = "get_LineNumber", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override int get_LineNumber() { }

	[CalledBy(Type = typeof(XmlTextReader), Member = "get_LinePosition", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public override int get_LinePosition() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string get_LocalName() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NodeData), Member = "GetNameWPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public virtual string get_Name() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal virtual XmlNamespaceManager get_NamespaceManager() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_Namespaces() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string get_NamespaceURI() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual XmlNameTable get_NameTable() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual XmlNodeType get_NodeType() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_Normalization() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string get_Prefix() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual char get_QuoteChar() { }

	[CallerCount(Count = 0)]
	public virtual ReadState get_ReadState() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlReaderSettings), Member = "EnableLegacyXmlSettings", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_MaxCharactersFromEntities", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_MaxCharactersInDocument", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_DtdProcessing", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DtdProcessing)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_IgnoreComments", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_IgnoreProcessingInstructions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_XmlResolver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlResolver)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_LineNumberOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_CheckCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_ConformanceLevel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ConformanceLevel)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_NameTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_IgnoreWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlReaderSettings), Member = "set_LinePositionOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual XmlReaderSettings get_Settings() { }

	[CallerCount(Count = 0)]
	internal bool get_StandAlone() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal bool get_V1Compat() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NodeData), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishPartialValue", ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "get_StringValue", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public virtual string get_Value() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string get_XmlLang() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public virtual XmlSpace get_XmlSpace() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NodeData), Member = "get_StringValue", ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public virtual string GetAttribute(int i) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NodeData), Member = "get_StringValue", ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public virtual string GetAttribute(string localName, string namespaceURI) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "GetIndexOfAttributeWithPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "GetIndexOfAttributeWithoutPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NodeData), Member = "get_StringValue", ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	public virtual string GetAttribute(string name) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "InvalidCharRecovery", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private int GetChars(int maxCharsCount) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "GetAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "MoveToAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private int GetIndexOfAttributeWithoutPrefix(string name) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "GetAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "MoveToAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NodeData), Member = "GetNameWPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private int GetIndexOfAttributeWithPrefix(string name) { }

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal IDictionary<String, String> GetNamespacesInScope(XmlNamespaceScope scope) { }

	[CalledBy(Type = typeof(XmlValidatingReaderImpl), Member = "GetResolver", ReturnType = typeof(XmlResolver))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal XmlResolver GetResolver() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private XmlResolver GetTempResolver() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseText", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private XmlNodeType GetTextNodeType(int orChars) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private XmlNodeType GetWhitespaceType() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElementContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char), typeof(NodeData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "PopEntity", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	private bool HandleEntityEnd(bool checkEntityNesting) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char), typeof(NodeData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueChunk", ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseNamedCharRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(StringBuilder)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "HandleGeneralEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(int)}, ReturnType = typeof(EntityType))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseNumericCharRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(StringBuilder), typeof(EntityType&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	private EntityType HandleEntityReference(bool isInAttributeValue, EntityExpandType expandType, out int charRefEndPos) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ResolveEntity", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(EntityExpandType), typeof(Int32&)}, ReturnType = typeof(EntityType))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlParserContext), Member = "get_HasDtdInfo", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseDtdFromParserContext", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaEntity), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SchemaEntity), Member = "set_Text", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "PushInternalEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdEntityInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "get_IsResolverNull", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "PushExternalEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdEntityInfo)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	private EntityType HandleGeneralEntityReference(string name, bool isInAttributeValue, bool pushFakeEntityIfNullResolver, int entityStartLinePos) { }

	[CallerCount(Count = 23)]
	[DeduplicatedMethod]
	public override bool HasLineInfo() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishIncrementalRead", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParsePIValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseCDataOrComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[Calls(Type = typeof(ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlConvert), Member = "StrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NodeData), Member = "GetNameWPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlCharType), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "EatWhitespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnclosedElements", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	private int IncrementalRead() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNodeType), typeof(XmlParserContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlParserContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlNamespaceManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	private void InitFragmentReader(XmlNodeType fragmentType, XmlParserContext parserContext, bool allowXmlDeclFragment) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "InitStreamInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(Stream), typeof(Encoding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Stream), typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishInitUriString", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishInitStream", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "InitStreamInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream), typeof(Encoding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "InitStreamInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Stream), typeof(Encoding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "InitStreamInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Stream), typeof(Encoding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OpenUrl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OpenAndPush", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(XmlReader), Member = "CalcBufferSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Stream)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "DetectEncoding", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "SetupEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	[ContainsUnimplementedInstructions]
	private void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, Byte[] bytes, int byteCount, Encoding encoding) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "InitStreamInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(Stream), typeof(Byte[]), typeof(int), typeof(Encoding)}, ReturnType = typeof(void))]
	private void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, Encoding encoding) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "InitStreamInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(Stream), typeof(Byte[]), typeof(int), typeof(Encoding)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void InitStreamInput(Uri baseUri, Stream stream, Encoding encoding) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "InitStreamInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(Stream), typeof(Byte[]), typeof(int), typeof(Encoding)}, ReturnType = typeof(void))]
	private void InitStreamInput(string baseUriStr, Stream stream, Encoding encoding) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "InitStreamInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(Stream), typeof(Byte[]), typeof(int), typeof(Encoding)}, ReturnType = typeof(void))]
	private void InitStreamInput(Stream stream, Encoding encoding) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNodeType), typeof(XmlParserContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlParserContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlParserContext), typeof(XmlReaderSettings)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_PushInternalDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushExternalEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdEntityInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushInternalEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdEntityInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	private void InitStringInput(string baseUriStr, Encoding originalEncoding, string str) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "InitTextReaderInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Uri), typeof(TextReader)}, ReturnType = typeof(void))]
	private void InitTextReaderInput(string baseUriStr, TextReader input) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader), typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextReader), typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishInitTextReader", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "InitTextReaderInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextReader)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OpenAndPush", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Encoding), Member = "get_Unicode", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	private void InitTextReaderInput(string baseUriStr, Uri baseUri, TextReader input) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "GetChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void InvalidCharRecovery(ref int bytesCount, out int charsCount) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ElementNamespaceLookup", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AttributeNamespaceLookup", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private string LookupNamespace(NodeData node) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual string LookupNamespace(string prefix) { }

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal string LookupPrefix(string namespaceName) { }

	[CalledBy(Type = typeof(XmlTextReader), Member = "ReadString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	internal void MoveOffEntityReference() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishAttributeValueIterator", ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public virtual void MoveToAttribute(int i) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "GetIndexOfAttributeWithPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "GetIndexOfAttributeWithoutPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishAttributeValueIterator", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public virtual bool MoveToAttribute(string name) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishAttributeValueIterator", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public virtual bool MoveToElement() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishAttributeValueIterator", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public virtual bool MoveToFirstAttribute() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishAttributeValueIterator", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	public virtual bool MoveToNextAttribute() { }

	[CallerCount(Count = 0)]
	[ContainsInvalidInstructions]
	private bool MoveToNextContentNode(bool moveIfOnContentNode) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributeDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdDefaultAttributeInfo), typeof(bool), typeof(NodeData[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(NodeData))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NodeData), Member = "get_StringValue", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "PushXmlContext", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "AddNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(NodeData)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void OnDefaultNamespaceDecl(NodeData attr) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElementContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseFragmentAttribute", ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(NodeData), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
	[Calls(Type = typeof(NodeData), Member = "SetLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private void OnEof() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributeDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdDefaultAttributeInfo), typeof(bool), typeof(NodeData[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(NodeData))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NodeData), Member = "get_StringValue", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "AddNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(NodeData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void OnNamespaceDecl(NodeData attr) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	private void OnNewLine(int pos) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributeDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdDefaultAttributeInfo), typeof(bool), typeof(NodeData[])}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributeInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(string), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(NodeData))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "PushXmlContext", ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "get_StringValue", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlConvert), Member = "TrimString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void OnXmlReservedAttribute(NodeData attr) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushExternalEntityOrSubset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Uri), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "PushParsingState", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "InitStreamInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(Stream), typeof(Byte[]), typeof(int), typeof(Encoding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "InitTextReaderInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Uri), typeof(TextReader)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	private bool OpenAndPush(Uri uri) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Uri), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "InitStreamInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(Stream), typeof(Byte[]), typeof(int), typeof(Encoding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "SetErrorState", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowWithoutLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 10)]
	private void OpenUrl() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void OpenUrlDelegate(object xmlResolver) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElement", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowExpectingWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnclosedElements", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "AttributeDuplCheck", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "AttributeNamespaceLookup", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ElementNamespaceLookup", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributesAndNormalize", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "OnDefaultNamespaceDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "OnNamespaceDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "OnXmlReservedAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char), typeof(NodeData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "SetLineInfo2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "EatWhitespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NodeData), Member = "SetLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "AddAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(NodeData))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void ParseAttributes() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ReadAttributeValue", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowInvalidChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "SetValueNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "SetNamedNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseEntityName", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "PopEntity", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlCharType), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "HandleEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(EntityExpandType), typeof(Int32&)}, ReturnType = typeof(EntityType))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(XmlCharType), Member = "IsLowSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlCharType), Member = "IsHighSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NodeData), Member = "SetLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "AddNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(NodeData))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	private bool ParseAttributeValueChunk() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseFragmentAttribute", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowInvalidChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "HandleEntityEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseEntityName", ReturnType = typeof(string))]
	[Calls(Type = typeof(NodeData), Member = "SetValueNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NodeData), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "HandleEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(EntityExpandType), typeof(Int32&)}, ReturnType = typeof(EntityType))]
	[Calls(Type = typeof(XmlCharType), Member = "IsLowSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlCharType), Member = "IsHighSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
	[Calls(Type = typeof(NodeData), Member = "SetNamedNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 22)]
	private void ParseAttributeValueSlow(int curPos, char quoteChar, NodeData attr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseCDataOrComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType)}, ReturnType = typeof(void))]
	private void ParseCData() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElementContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseCData", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseCDataOrComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
	[Calls(Type = typeof(NodeData), Member = "SetLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(NodeData), Member = "SetValueNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "SetValueNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void ParseCDataOrComment(XmlNodeType type) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_ParseComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseComment", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseCDataOrComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "IncrementalRead", ReturnType = typeof(int))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlCharType), Member = "IsHighSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlCharType), Member = "IsLowSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowInvalidChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private bool ParseCDataOrComment(XmlNodeType type, out int outStartPos, out int outEndPos) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseNamedCharRefInline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(StringBuilder)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseNumericCharRefInline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(StringBuilder), typeof(Int32&), typeof(EntityType&)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	private int ParseCharRefInline(int startPos, out int charCount, out EntityType entityType) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElementContent", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseCDataOrComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
	[Calls(Type = typeof(NodeData), Member = "SetLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(NodeData), Member = "SetValueNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "SetValueNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool ParseComment() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlConvert), Member = "StrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlCharType), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "EatWhitespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "SkipDtd", ReturnType = typeof(void))]
	[Calls(Type = typeof(ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
	[Calls(Type = typeof(NodeData), Member = "SetLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseDtd", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowWithoutLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowExpectingWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	private bool ParseDoctypeDecl() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowWithoutLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "OnEof", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseElement", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseCDataOrComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlConvert), Member = "StrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseUnexpectedToken", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseEntityReference", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParsePI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseComment", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "SetupEndEntityNodeInContent", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "HandleEntityEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseDoctypeDecl", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "HandleEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(EntityExpandType), typeof(Int32&)}, ReturnType = typeof(EntityType))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseRootLevelWhitespace", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseText", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private bool ParseDocumentContent() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDoctypeDecl", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DtdParser), Member = "Create", ReturnType = typeof(IDtdParser))]
	[Calls(Type = typeof(NodeData), Member = "SetNamedNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	private void ParseDtd() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ProcessDtdFromParserContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlParserContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleGeneralEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(int)}, ReturnType = typeof(EntityType))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DtdParser), Member = "Create", ReturnType = typeof(IDtdParser))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private void ParseDtdFromParserContext() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElementContent", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ElementNamespaceLookup", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[Calls(Type = typeof(NodeData), Member = "SetNamedNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "SetNamedNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlConvert), Member = "StrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NodeData), Member = "SetLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributesAndNormalize", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private void ParseElement() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnclosedElements", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseEndElement", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseElement", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "OnEof", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseUnexpectedToken", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseCDataOrComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParsePI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "SetupEndEntityNodeInContent", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "HandleEntityEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseComment", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlConvert), Member = "StrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseText", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private bool ParseElementContent() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElementContent", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlConvert), Member = "StrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlCharType), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnclosedElements", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowTagMismatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void ParseEndElement() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char), typeof(NodeData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseEntityReference", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueChunk", ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private string ParseEntityName() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseText", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
	[Calls(Type = typeof(NodeData), Member = "SetLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseEntityName", ReturnType = typeof(string))]
	[Calls(Type = typeof(NodeData), Member = "SetNamedNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private void ParseEntityReference() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char), typeof(NodeData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "OnEof", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private bool ParseFragmentAttribute() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	private int ParseName() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(EntityExpandType), typeof(Int32&)}, ReturnType = typeof(EntityType))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseNamedCharRefInline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(StringBuilder)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	private int ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_ParseNamedCharRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(StringBuilder)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseCharRefInline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&), typeof(EntityType&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseNamedCharRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(StringBuilder)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 2)]
	private int ParseNamedCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(EntityExpandType), typeof(Int32&)}, ReturnType = typeof(EntityType))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseNumericCharRefInline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(StringBuilder), typeof(Int32&), typeof(EntityType&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	private int ParseNumericCharRef(bool expand, StringBuilder internalSubsetBuilder, out EntityType entityType) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_ParseNumericCharRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseCharRefInline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Int32&), typeof(EntityType&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseNumericCharRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(StringBuilder), typeof(EntityType&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlCharType), Member = "SplitSurrogateChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Char&), typeof(Char&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlCharType), Member = "IsHighSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlCharType), Member = "IsLowSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(XmlCharType), Member = "IsCharData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 43)]
	[ContainsUnimplementedInstructions]
	private int ParseNumericCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder, out int charCount, out EntityType entityType) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_ParsePI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElementContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParsePI", ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(NodeData), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "EatWhitespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[Calls(Type = typeof(NodeData), Member = "SetNamedNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(string), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(StringComparison)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NodeData), Member = "SetLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParsePIValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private bool ParsePI(StringBuilder piInDtdStringBuilder) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParsePI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(bool))]
	private bool ParsePI() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParsePI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "IncrementalRead", ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlCharType), Member = "IsHighSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlCharType), Member = "IsLowSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowInvalidChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private bool ParsePIValue(out int outStartPos, out int outEndPos) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "IncrementalRead", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseName", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SkipDtd", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseEntityName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(EntityExpandType), typeof(Int32&)}, ReturnType = typeof(EntityType))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParsePI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private int ParseQName(bool isQName, int startOffset, out int colonPos) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowTagMismatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	private int ParseQName(out int colonPos) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
	[Calls(Type = typeof(NodeData), Member = "SetLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "EatWhitespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ZeroEndingStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NodeData), Member = "SetValueNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlCharType), Member = "IsCharData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowInvalidChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private bool ParseRootLevelWhitespace() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElementContent", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
	[Calls(Type = typeof(NodeData), Member = "SetLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "GetTextNodeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(XmlNodeType))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "SetValueNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "SetValueNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseEntityReference", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "SetupEndEntityNodeInContent", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private bool ParseText() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ReadValueChunk", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseText", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishPartialValue", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SkipPartialTextValue", ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(XmlCharType), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "HandleEntityEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlCharType), Member = "IsLowSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlCharType), Member = "IsHighSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "HandleEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(EntityExpandType), typeof(Int32&)}, ReturnType = typeof(EntityType))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseNumericCharRefInline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(StringBuilder), typeof(Int32&), typeof(EntityType&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseNamedCharRefInline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(StringBuilder)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowInvalidChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private bool ParseText(out int startPos, out int endPos, ref int outOrChars) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseUnexpectedToken", ReturnType = typeof(string))]
	private string ParseUnexpectedToken(int pos) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElementContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowExpectingWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(XmlCharType), Member = "IsNCNameSingleChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	private string ParseUnexpectedToken() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_PushExternalSubset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushExternalEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdEntityInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclarationFragment", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(NodeData), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "UnDecodeChars", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "SetupEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "CheckEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "SwitchEncodingToUTF8", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(NodeData), Member = "SetLineInfo2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "AddAttributeNoChecks", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(NodeData))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "EatWhitespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "SetNamedNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "SetLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlCharType), Member = "IsNameSingleChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlConvert), Member = "StrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[Calls(Type = typeof(NodeData), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 13)]
	private bool ParseXmlDeclaration(bool isTextDecl) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void ParseXmlDeclarationFragment() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void PopElementContext() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_PopEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdEntityInfo&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishAttributeValueIterator", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleEntityEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueChunk", ReturnType = typeof(bool))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "PopParsingState", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void PopEntity() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Close", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PopEntity", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(ParsingState), Member = "Close", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void PopParsingState() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void PopXmlContext() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishInitUriString", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishInitStream", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishInitTextReader", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseDtdFromParserContext", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowWithoutLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	private void ProcessDtdFromParserContext(XmlParserContext context) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_PushEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdEntityInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleGeneralEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(int)}, ReturnType = typeof(EntityType))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "PushExternalEntityOrSubset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Uri), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "RegisterEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdEntityInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "EatWhitespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "PushParsingState", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "InitStringInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Encoding), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "RegisterConsumedCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(bool)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private bool PushExternalEntity(IDtdEntityInfo entity) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_PushExternalSubset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushExternalEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdEntityInfo)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "OpenAndPush", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowWithoutLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 22)]
	private void PushExternalEntityOrSubset(string publicId, string systemId, Uri baseUri, string entityName) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_PushEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdEntityInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleGeneralEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(int)}, ReturnType = typeof(EntityType))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "PushParsingState", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "InitStringInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Encoding), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "RegisterEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdEntityInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "RegisterConsumedCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(bool)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	private void PushInternalEntity(IDtdEntityInfo entity) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_PushInternalDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OpenAndPush", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushExternalEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdEntityInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushInternalEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdEntityInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParsingState), Member = "Clear", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private void PushParsingState() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OnDefaultNamespaceDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OnXmlReservedAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlContext)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void PushXmlContext() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowWithoutLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "OnEof", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclarationFragment", ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "SetLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
	[Calls(Type = typeof(NodeData), Member = "SetValueNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "SetupEndEntityNodeInContent", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char), typeof(NodeData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishIncrementalRead", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseEntityReference", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseElementContent", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishReadElementContentAsBinary", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "PopEntity", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "SkipPartialTextValue", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishReadContentAsBinary", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "PopElementContext", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "AddNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(NodeData))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ResetAttributes", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "OpenUrl", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishInitUriString", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishInitStream", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishInitTextReader", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 18)]
	public virtual bool Read() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueChunk", ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "SkipPartialTextValue", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishReadContentAsBinary", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "AddNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(NodeData))]
	[Calls(Type = typeof(NodeData), Member = "get_StringValue", ReturnType = typeof(string))]
	[Calls(Type = typeof(NodeData), Member = "SetValueNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 14)]
	public virtual bool ReadAttributeValue() { }

	[CallerCount(Count = 37)]
	[Calls(Type = typeof(NodeData), Member = "OnBufferInvalidated", ReturnType = typeof(void))]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "RegisterConsumedCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "GetChars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	private int ReadData() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	private bool ReadDataInName(ref int pos) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlReader), Member = "ReadString", ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public virtual string ReadString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlReader), Member = "HasValueInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NodeData), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NodeData), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlCharType), Member = "IsHighSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(NodeData), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 28)]
	public virtual int ReadValueChunk(Char[] buffer, int index, int count) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_PushInternalDtd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushExternalEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdEntityInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushInternalEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdEntityInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowWithoutLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	private void RegisterConsumedCharacters(long characters, bool inEntityReference) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushExternalEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdEntityInfo)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushInternalEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdEntityInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Dictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 12)]
	private void RegisterEntity(IDtdEntityInfo entity) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private void ResetAttributes() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "HandleGeneralEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(int)}, ReturnType = typeof(EntityType))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 14)]
	public virtual void ResolveEntity() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(NodeData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "IncrementalRead", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclarationFragment", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void ReThrow(Exception e, int lineNo, int linePos) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void SendValidationEvent(XmlSeverityType severity, XmlSchemaException exception) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_ParseComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributesAndNormalize", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void SendValidationEvent(XmlSeverityType severity, string code, string arg, int lineNo, int linePos) { }

	[CallerCount(Count = 0)]
	internal void set_DisableUndeclaredEntityCheck(bool value) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	internal void set_DtdParserProxy_CurrentPosition(int value) { }

	[CalledBy(Type = typeof(XmlTextReader), Member = "set_EntityHandling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(EntityHandling)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	internal void set_EntityHandling(EntityHandling value) { }

	[CalledBy(Type = typeof(XmlValidatingReaderImpl), Member = "ProcessCoreReaderEvent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlValidatingReaderImpl), Member = "set_SchemaTypeObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal void set_InternalSchemaType(object value) { }

	[CalledBy(Type = typeof(XmlValidatingReaderImpl), Member = "ProcessCoreReaderEvent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlValidatingReaderImpl), Member = "set_TypedValueObject", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	internal void set_InternalTypedValue(object value) { }

	[CalledBy(Type = typeof(XmlLoader), Member = "ParseDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocumentType), typeof(bool), typeof(XmlResolver)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlLoader), Member = "CreateInnerXmlReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNodeType), typeof(XmlParserContext), typeof(XmlDocument)}, ReturnType = typeof(XmlReader))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlNamespaceManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	internal void set_Namespaces(bool value) { }

	[CalledBy(Type = typeof(XmlTextReader), Member = "set_Normalization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	internal void set_Normalization(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_OnDefaultAttributeUse(OnDefaultAttributeUseDelegate value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_OuterReader(XmlReader value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal void set_ValidationEventHandling(IValidationEventHandling value) { }

	[CalledBy(Type = typeof(XmlTextReader), Member = "set_WhitespaceHandling", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(WhitespaceHandling)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	internal void set_WhitespaceHandling(WhitespaceHandling value) { }

	[CalledBy(Type = typeof(XmlTextReader), Member = "set_XmlResolver", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlResolver)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlLoader), Member = "ParseDocumentType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlDocumentType), typeof(bool), typeof(XmlResolver)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlLoader), Member = "CreateInnerXmlReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNodeType), typeof(XmlParserContext), typeof(XmlDocument)}, ReturnType = typeof(XmlReader))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	internal void set_XmlResolver(XmlResolver value) { }

	[CalledBy(Type = typeof(XmlTextReader), Member = "set_XmlValidatingReaderCompatibilityMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlValidatingReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlReader), typeof(ValidationEventHandler), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlLoader), Member = "CreateInnerXmlReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNodeType), typeof(XmlParserContext), typeof(XmlDocument)}, ReturnType = typeof(XmlReader))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Preprocessor), Member = "GetBuildInSchema", ReturnType = typeof(XmlSchema))]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 3)]
	internal void set_XmlValidatingReaderCompatibilityMode(bool value) { }

	[CalledBy(Type = typeof(XmlValidatingReaderImpl), Member = "Read", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlValidatingReaderImpl), Member = "ParseDtdFromParserContext", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlLoader), Member = "CreateInnerXmlReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(XmlNodeType), typeof(XmlParserContext), typeof(XmlDocument)}, ReturnType = typeof(XmlReader))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	internal void SetDtdInfo(IDtdInfo newDtdInfo) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OpenUrl", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	private void SetErrorState() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "InitStreamInput", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(string), typeof(Stream), typeof(Byte[]), typeof(int), typeof(Encoding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SwitchEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UTF16Decoder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	private void SetupEncoding(Encoding encoding) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private void SetupEndEntityNodeInAttribute() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElementContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseText", ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(NodeData), Member = "SetNamedNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void SetupEndEntityNodeInContent() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlResolver), typeof(XmlReaderSettings), typeof(XmlParserContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NameTable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlNamespaceManager), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 14)]
	[ContainsUnimplementedInstructions]
	private void SetupFromParserContext(XmlParserContext context, XmlReaderSettings settings) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	private void ShiftBuffer(int sourcePos, int destPos, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishAttributeValueIterator", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishIncrementalRead", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishReadElementContentAsBinary", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishReadContentAsBinary", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "SkipPartialTextValue", ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "get_IsEmptyElement", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public virtual void Skip() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDoctypeDecl", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "EatWhitespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlConvert), Member = "StrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "SkipPublicOrSystemIdLiteral", ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "SkipUntil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowExpectingWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void SkipDtd() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Skip", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ReadAttributeValue", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishAttributeValueIterator", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishReadValueChunk", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishReadContentAsBinary", ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	private void SkipPartialTextValue() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SkipDtd", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsInvalidInstructions]
	private void SkipPublicOrSystemIdLiteral() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SkipDtd", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlCharType), Member = "IsHighSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlCharType), Member = "IsLowSurrogate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowInvalidChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void SkipUntil(char stopChar, bool recognizeLiterals) { }

	[CalledBy(Type = typeof(NodeData), Member = "TrimSpacesInValue", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	internal static void StripSpaces(Char[] value, int index, ref int len) { }

	[CalledBy(Type = typeof(NodeData), Member = "TrimSpacesInValue", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal static string StripSpaces(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "SetupEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Encoding)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private void SwitchEncoding(Encoding newEncoding) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UTF8Encoding), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[ContainsInvalidInstructions]
	private void SwitchEncodingToUTF8() { }

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override IDictionary<String, String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	private override string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private override string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Throw(string res, String[] args, Exception innerException) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ReThrow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowWithoutLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowWithoutLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowWithoutLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushExternalEntityOrSubset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Uri), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "SetErrorState", ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "SetLineInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private void Throw(Exception e) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowTagMismatch", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParsePI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Throw(string res, String[] args) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "CheckEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Encoding))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseNumericCharRefInline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(StringBuilder), typeof(Int32&), typeof(EntityType&)}, ReturnType = typeof(int))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	private void Throw(string res, string arg, Exception innerException) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushExternalEntityOrSubset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Uri), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDoctypeDecl", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseCDataOrComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishReadElementContentAsBinary", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParsePI", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DetectEncoding", ReturnType = typeof(Encoding))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "InitFragmentReader", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(XmlParserContext), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "CheckEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Encoding))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Throw(string res, string arg) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnclosedElements", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParsePIValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowExpectingWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	private void Throw(int pos, string res, string arg) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OnNamespaceDecl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(EntityExpandType), typeof(Int32&)}, ReturnType = typeof(EntityType))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(NodeData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	private void Throw(string res, int lineNo, int linePos) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowInvalidChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char), typeof(NodeData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseNumericCharRefInline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(StringBuilder), typeof(Int32&), typeof(EntityType&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueChunk", ReturnType = typeof(bool))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	private void Throw(int pos, string res, String[] args) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AttributeDuplCheck", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OnXmlReservedAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleGeneralEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(bool), typeof(int)}, ReturnType = typeof(EntityType))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "LookupNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NodeData)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddNamespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(NodeData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "RegisterEntity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IDtdEntityInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	private void Throw(string res, string arg, int lineNo, int linePos) { }

	[CallerCount(Count = 38)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	private void Throw(string res) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "InvalidCharRecovery", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnclosedElements", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseCDataOrComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDoctypeDecl", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseNumericCharRefInline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(bool), typeof(StringBuilder), typeof(Int32&), typeof(EntityType&)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowExpectingWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	private void Throw(int pos, string res) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDoctypeDecl", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SkipDtd", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseUnexpectedToken", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	private void ThrowExpectingWhitespace(int pos) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(char), typeof(NodeData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseRootLevelWhitespace", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParsePIValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseCDataOrComment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNodeType), typeof(Int32&), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SkipUntil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueChunk", ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	private void ThrowInvalidChar(Char[] data, int length, int invCharPos) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseEndElement", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NodeData), Member = "GetNameWPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(int), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 14)]
	private void ThrowTagMismatch(NodeData startTag) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElementContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseEndElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "IncrementalRead", ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NodeData), Member = "GetNameWPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlNameTable)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	private void ThrowUnclosedElements() { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SkipPublicOrSystemIdLiteral", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseUnexpectedToken", ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	private void ThrowUnexpectedToken(string expectedToken1, string expectedToken2) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElementContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	private void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDoctypeDecl", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SkipDtd", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "IncrementalRead", ReturnType = typeof(int))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	private void ThrowUnexpectedToken(string expectedToken1) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElementContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseEndElement", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleEntityReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(EntityExpandType), typeof(Int32&)}, ReturnType = typeof(EntityType))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	private void ThrowUnexpectedToken(int pos, string expectedToken) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushExternalEntityOrSubset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Uri), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[]), typeof(Exception), typeof(int), typeof(int), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	private void ThrowWithoutLineInfo(string res, String[] args, Exception innerException) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OpenUrl", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "RegisterConsumedCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	private void ThrowWithoutLineInfo(string res, string arg) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ProcessDtdFromParserContext", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlParserContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "CheckEncoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Encoding))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDoctypeDecl", ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Exception)}, ReturnType = typeof(void))]
	private void ThrowWithoutLineInfo(string res) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void UnDecodeChars() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Remove", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private void UnregisterEntity() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri), typeof(Uri)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private bool UriEqual(Uri uri1, string uri1Str, string uri2Str, XmlResolver resolver) { }

	[CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseRootLevelWhitespace", ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	private bool ZeroEndingStream(int pos) { }

}

