namespace Mono.Xml;

internal class SmallXmlParser
{
	private class AttrListImpl : IAttrList
	{
		private List<String> attrNames; //Field offset: 0x10
		private List<String> attrValues; //Field offset: 0x18

		public override int Length
		{
			[CallerCount(Count = 0)]
			[CallsUnknownMethods(Count = 1)]
			 get { } //Length: 60
		}

		public override String[] Names
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
			[CallsUnknownMethods(Count = 1)]
			 get { } //Length: 68
		}

		public override String[] Values
		{
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
			[CallsUnknownMethods(Count = 1)]
			 get { } //Length: 68
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		public AttrListImpl() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		internal void Add(string name, string value) { }

		[CalledBy(Type = typeof(SmallXmlParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader), typeof(IContentHandler)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(SmallXmlParser), Member = "Cleanup", ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		internal void Clear() { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public override int get_Length() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
		[CallsUnknownMethods(Count = 1)]
		public override String[] get_Names() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
		[CallsUnknownMethods(Count = 1)]
		public override String[] get_Values() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public override string GetName(int i) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public override string GetValue(int i) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		public override string GetValue(string name) { }

	}

	internal interface IAttrList
	{

		public int Length
		{
			 get { } //Length: 0
		}

		public String[] Names
		{
			 get { } //Length: 0
		}

		public String[] Values
		{
			 get { } //Length: 0
		}

		public int get_Length() { }

		public String[] get_Names() { }

		public String[] get_Values() { }

		public string GetName(int i) { }

		public string GetValue(int i) { }

		public string GetValue(string name) { }

	}

	internal interface IContentHandler
	{

		public void OnChars(string text) { }

		public void OnEndElement(string name) { }

		public void OnEndParsing(SmallXmlParser parser) { }

		public void OnIgnorableWhitespace(string text) { }

		public void OnProcessingInstruction(string name, string text) { }

		public void OnStartElement(string name, IAttrList attrs) { }

		public void OnStartParsing(SmallXmlParser parser) { }

	}

	private IContentHandler handler; //Field offset: 0x10
	private TextReader reader; //Field offset: 0x18
	private Stack elementNames; //Field offset: 0x20
	private Stack xmlSpaces; //Field offset: 0x28
	private string xmlSpace; //Field offset: 0x30
	private StringBuilder buffer; //Field offset: 0x38
	private Char[] nameBuffer; //Field offset: 0x40
	private bool isWhitespace; //Field offset: 0x48
	private AttrListImpl attributes; //Field offset: 0x50
	private int line; //Field offset: 0x58
	private int column; //Field offset: 0x5C
	private bool resetColumn; //Field offset: 0x60

	[CalledBy(Type = typeof(RemotingConfiguration), Member = "LoadDefaultDelayedChannels", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Stack), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	public SmallXmlParser() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AttrListImpl), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	private void Cleanup() { }

	[CalledBy(Type = typeof(SmallXmlParser), Member = "UnexpectedEndError", ReturnType = typeof(Exception))]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "SkipWhitespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "Expect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader), typeof(IContentHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadContent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadReference", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AttrListImpl)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadComment", ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SystemException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	private Exception Error(string msg) { }

	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadContent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadReference", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AttrListImpl)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadComment", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SmallXmlParser), Member = "Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(SmallXmlParser), Member = "UnexpectedEndError", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public void Expect(int c) { }

	[CalledBy(Type = typeof(SmallXmlParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader), typeof(IContentHandler)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadContent", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private void HandleBufferedContent() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	private void HandleWhitespaces() { }

	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadName", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(char), Member = "GetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(UnicodeCategory))]
	[CallsUnknownMethods(Count = 1)]
	private bool IsNameChar(char c, bool start) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private bool IsWhitespace(int c) { }

	[CalledBy(Type = typeof(SecurityParser), Member = "LoadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeyPairPersistence), Member = "Load", ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(KeyPairPersistence), Member = "FromXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RemotingConfiguration), Member = "LoadDefaultDelayedChannels", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(SmallXmlParser), Member = "ReadContent", ReturnType = typeof(void))]
	[Calls(Type = typeof(SmallXmlParser), Member = "HandleBufferedContent", ReturnType = typeof(void))]
	[Calls(Type = typeof(AttrListImpl), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SmallXmlParser), Member = "Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 13)]
	public void Parse(TextReader input, IContentHandler handler) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	private int Peek() { }

	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadName", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private int Read() { }

	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadContent", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SmallXmlParser), Member = "SkipWhitespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SmallXmlParser), Member = "ReadName", ReturnType = typeof(string))]
	[Calls(Type = typeof(SmallXmlParser), Member = "Expect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SmallXmlParser), Member = "ReadUntil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SmallXmlParser), Member = "Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 8)]
	private void ReadAttribute(AttrListImpl a) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(SmallXmlParser), Member = "UnexpectedEndError", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void ReadCDATASection() { }

	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadReference", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	private int ReadCharacterReference() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SmallXmlParser), Member = "ReadReference", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private void ReadCharacters() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SmallXmlParser), Member = "Expect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SmallXmlParser), Member = "Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void ReadComment() { }

	[CalledBy(Type = typeof(SmallXmlParser), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader), typeof(IContentHandler)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SmallXmlParser), Member = "UnexpectedEndError", ReturnType = typeof(Exception))]
	[Calls(Type = typeof(SmallXmlParser), Member = "Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SmallXmlParser), Member = "ReadAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AttrListImpl)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SmallXmlParser), Member = "ReadUntil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SmallXmlParser), Member = "SkipWhitespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SmallXmlParser), Member = "HandleBufferedContent", ReturnType = typeof(void))]
	[Calls(Type = typeof(SmallXmlParser), Member = "Expect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(SmallXmlParser), Member = "ReadName", ReturnType = typeof(string))]
	[Calls(Type = typeof(SmallXmlParser), Member = "ReadReference", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 38)]
	[CallsUnknownMethods(Count = 28)]
	public void ReadContent() { }

	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadContent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadReference", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AttrListImpl)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(SmallXmlParser), Member = "IsNameChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SmallXmlParser), Member = "Read", ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[]), typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SmallXmlParser), Member = "Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	public string ReadName() { }

	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadUntil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadContent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadCharacters", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(SmallXmlParser), Member = "ReadName", ReturnType = typeof(string))]
	[Calls(Type = typeof(SmallXmlParser), Member = "Expect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(SmallXmlParser), Member = "ReadCharacterReference", ReturnType = typeof(int))]
	[Calls(Type = typeof(SmallXmlParser), Member = "Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 4)]
	private void ReadReference() { }

	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadContent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AttrListImpl)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(SmallXmlParser), Member = "ReadReference", ReturnType = typeof(void))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SmallXmlParser), Member = "UnexpectedEndError", ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	private string ReadUntil(char until, bool handleReferences) { }

	[CalledBy(Type = typeof(SmallXmlParser), Member = "SkipWhitespaces", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadContent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AttrListImpl)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(SmallXmlParser), Member = "Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public void SkipWhitespaces(bool expected) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SmallXmlParser), Member = "SkipWhitespaces", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	public void SkipWhitespaces() { }

	[CalledBy(Type = typeof(SmallXmlParser), Member = "Expect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadUntil", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(bool)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadContent", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SmallXmlParser), Member = "ReadCDATASection", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "Join", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(SmallXmlParser), Member = "Error", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Exception))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private Exception UnexpectedEndError() { }

}

