namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(2)]
internal class XDeclarationWrapper : XObjectWrapper, IXmlDeclaration, IXmlNode
{
	[CompilerGenerated]
	[Nullable(1)]
	private readonly XDeclaration <Declaration>k__BackingField; //Field offset: 0x18

	[Nullable(1)]
	internal XDeclaration Declaration
	{
		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[NullableContext(1)]
		internal get { } //Length: 5
	}

	public override string Encoding
	{
		[CallerCount(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 27
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		 set { } //Length: 35
	}

	public virtual XmlNodeType NodeType
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public override string Standalone
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 27
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 35
	}

	public override string Version
	{
		[CallerCount(Count = 21)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 27
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[NullableContext(1)]
	public XDeclarationWrapper(XDeclaration declaration) { }

	[CallerCount(Count = 31)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[NullableContext(1)]
	internal XDeclaration get_Declaration() { }

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override string get_Encoding() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual XmlNodeType get_NodeType() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override string get_Standalone() { }

	[CallerCount(Count = 21)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public override string get_Version() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public override void set_Encoding(string value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public override void set_Standalone(string value) { }

}

