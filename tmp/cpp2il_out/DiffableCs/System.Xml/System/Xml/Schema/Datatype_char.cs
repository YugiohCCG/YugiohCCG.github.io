namespace System.Xml.Schema;

internal class Datatype_char : Datatype_anySimpleType
{
	private static readonly Type atomicValueType; //Field offset: 0x0
	private static readonly Type listValueType; //Field offset: 0x8

	internal virtual Type ListValueType
	{
		[CallerCount(Count = 0)]
		internal get { } //Length: 79
	}

	internal virtual RestrictionFlags ValidRestrictionFlags
	{
		[CallerCount(Count = 182)]
		[DeduplicatedMethod]
		internal get { } //Length: 3
	}

	public virtual Type ValueType
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 78
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsUnknownMethods(Count = 2)]
	private static Datatype_char() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Datatype_char() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(char), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 2)]
	internal virtual int Compare(object value1, object value2) { }

	[CallerCount(Count = 0)]
	internal virtual Type get_ListValueType() { }

	[CallerCount(Count = 182)]
	[DeduplicatedMethod]
	internal virtual RestrictionFlags get_ValidRestrictionFlags() { }

	[CallerCount(Count = 0)]
	public virtual Type get_ValueType() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlConvert), Member = "ToChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	public virtual object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlConvert), Member = "TryToChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Char&)}, ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

