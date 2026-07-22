namespace System.Xml.Schema;

public abstract class XmlSchemaFacet : XmlSchemaAnnotated
{
	private string value; //Field offset: 0x50
	private bool isFixed; //Field offset: 0x58
	private FacetType facetType; //Field offset: 0x5C

	internal FacetType FacetType
	{
		[CallerCount(Count = 26)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	[DefaultValue(False)]
	[XmlAttribute("fixed")]
	public override bool IsFixed
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		 set { } //Length: 159
	}

	[XmlAttribute("value")]
	public string Value
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected XmlSchemaFacet() { }

	[CallerCount(Count = 26)]
	[DeduplicatedMethod]
	internal FacetType get_FacetType() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override bool get_IsFixed() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	public string get_Value() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal void set_FacetType(FacetType value) { }

	[CallerCount(Count = 0)]
	public override void set_IsFixed(bool value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_Value(string value) { }

}

