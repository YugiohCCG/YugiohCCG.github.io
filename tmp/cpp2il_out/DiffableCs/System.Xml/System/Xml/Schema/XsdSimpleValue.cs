namespace System.Xml.Schema;

internal class XsdSimpleValue
{
	private XmlSchemaSimpleType xmlType; //Field offset: 0x10
	private object typedValue; //Field offset: 0x18

	public object TypedValue
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public XmlSchemaSimpleType XmlType
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 40)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public XsdSimpleValue(XmlSchemaSimpleType st, object value) { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public object get_TypedValue() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public XmlSchemaSimpleType get_XmlType() { }

}

