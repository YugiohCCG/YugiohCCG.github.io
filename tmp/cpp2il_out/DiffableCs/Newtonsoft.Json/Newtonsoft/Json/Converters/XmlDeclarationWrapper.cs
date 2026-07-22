namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(2)]
internal class XmlDeclarationWrapper : XmlNodeWrapper, IXmlDeclaration, IXmlNode
{
	[Nullable(1)]
	private readonly XmlDeclaration _declaration; //Field offset: 0x28

	public override string Encoding
	{
		[CallerCount(Count = 17)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 27
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlDeclaration), Member = "set_Encoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 30
	}

	public override string Standalone
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 27
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(XmlDeclaration), Member = "set_Standalone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 30
	}

	public override string Version
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 27
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[NullableContext(1)]
	public XmlDeclarationWrapper(XmlDeclaration declaration) { }

	[CallerCount(Count = 17)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override string get_Encoding() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override string get_Standalone() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public override string get_Version() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlDeclaration), Member = "set_Encoding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void set_Encoding(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlDeclaration), Member = "set_Standalone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public override void set_Standalone(string value) { }

}

