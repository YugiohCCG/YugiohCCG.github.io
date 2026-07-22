namespace System.Xml.Schema;

internal class XmlUntypedConverter : XmlListConverter
{
	public static readonly XmlValueConverter Untyped; //Field offset: 0x0
	public static readonly XmlValueConverter UntypedList; //Field offset: 0x8
	private bool allowListToList; //Field offset: 0x30

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlUntypedConverter), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlUntypedConverter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlUntypedConverter), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlBaseConverter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlBaseConverter), typeof(Type)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private static XmlUntypedConverter() { }

	[CalledBy(Type = typeof(XmlUntypedConverter), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(XmlBaseConverter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType)}, ReturnType = typeof(void))]
	protected XmlUntypedConverter() { }

	[CalledBy(Type = typeof(XmlUntypedConverter), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(XmlBaseConverter), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlBaseConverter), typeof(Type)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	protected XmlUntypedConverter(XmlUntypedConverter atomicConverter, bool allowListToList) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlListConverter), Member = "ChangeListType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlUntypedConverter), Member = "SupportsType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlBaseConverter), Member = "CreateInvalidClrMappingException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(Exception))]
	[Calls(Type = typeof(XmlBaseConverter), Member = "get_XmlTypeName", ReturnType = typeof(string))]
	[Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 29)]
	protected virtual object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlUntypedConverter), Member = "ChangeTypeWildcardSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public virtual object ChangeType(double value, Type destinationType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlUntypedConverter), Member = "ChangeTypeWildcardSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlBaseConverter), Member = "DateTimeToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public virtual object ChangeType(DateTime value, Type destinationType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlUntypedConverter), Member = "ChangeTypeWildcardSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public virtual object ChangeType(bool value, Type destinationType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlUntypedConverter), Member = "ChangeTypeWildcardSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public virtual object ChangeType(int value, Type destinationType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlUntypedConverter), Member = "ChangeTypeWildcardSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public virtual object ChangeType(long value, Type destinationType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlConvert), Member = "ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(XmlBaseConverter), Member = "Int32ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(XmlBaseConverter), Member = "StringToBase64Binary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(XmlBaseConverter), Member = "UntypedAtomicToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(XmlBaseConverter), Member = "UntypedAtomicToDateTimeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTimeOffset))]
	[Calls(Type = typeof(XmlConvert), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(XmlBaseConverter), Member = "Int32ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(short))]
	[Calls(Type = typeof(XmlBaseConverter), Member = "Int32ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(sbyte))]
	[Calls(Type = typeof(XmlConvert), Member = "ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(XmlBaseConverter), Member = "StringToDuration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(XmlBaseConverter), Member = "Int32ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ushort))]
	[Calls(Type = typeof(XmlConvert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlBaseConverter), Member = "Int64ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(XmlConvert), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(XmlBaseConverter), Member = "DecimalToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(XmlConvert), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(XmlConvert), Member = "ToUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Uri))]
	[Calls(Type = typeof(XmlAtomicValue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlBaseConverter), Member = "StringToQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(XmlUntypedConverter), Member = "ChangeTypeWildcardSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CallsDeduplicatedMethods(Count = 23)]
	[CallsUnknownMethods(Count = 8)]
	public virtual object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlAtomicValue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlBaseConverter), Member = "StringToQName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(XmlQualifiedName))]
	[Calls(Type = typeof(XmlConvert), Member = "ToUri", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Uri))]
	[Calls(Type = typeof(XmlBaseConverter), Member = "DecimalToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(ulong))]
	[Calls(Type = typeof(XmlBaseConverter), Member = "Int64ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(XmlBaseConverter), Member = "Int32ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ushort))]
	[Calls(Type = typeof(XmlBaseConverter), Member = "StringToDuration", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(TimeSpan))]
	[Calls(Type = typeof(XmlConvert), Member = "ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(XmlBaseConverter), Member = "Int32ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(sbyte))]
	[Calls(Type = typeof(XmlConvert), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(XmlBaseConverter), Member = "Int32ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(short))]
	[Calls(Type = typeof(XmlConvert), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(XmlConvert), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(XmlBaseConverter), Member = "UntypedAtomicToDateTimeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTimeOffset))]
	[Calls(Type = typeof(XmlBaseConverter), Member = "UntypedAtomicToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(XmlBaseConverter), Member = "StringToBase64Binary", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(XmlBaseConverter), Member = "Int32ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(byte))]
	[Calls(Type = typeof(XmlConvert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(XmlConvert), Member = "ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 52)]
	[CallsUnknownMethods(Count = 31)]
	public virtual object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlUntypedConverter), Member = "ChangeTypeWildcardSource", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public virtual object ChangeType(decimal value, Type destinationType) { }

	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(DateTime))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToDateTimeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(DateTimeOffset))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(double))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(string))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(XmlAtomicValue), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlSchemaType), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	[CalledBy(Type = typeof(XmlUntypedConverter), Member = "ChangeListType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 18)]
	private bool SupportsType(Type clrType) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlConvert), Member = "ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public virtual bool ToBoolean(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlUntypedConverter), Member = "ChangeTypeWildcardDestination", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlConvert), Member = "ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public virtual bool ToBoolean(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlUntypedConverter), Member = "ChangeTypeWildcardDestination", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlBaseConverter), Member = "UntypedAtomicToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public virtual DateTime ToDateTime(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlBaseConverter), Member = "UntypedAtomicToDateTime", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTime))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public virtual DateTime ToDateTime(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlUntypedConverter), Member = "ChangeTypeWildcardDestination", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlBaseConverter), Member = "UntypedAtomicToDateTimeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTimeOffset))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public virtual DateTimeOffset ToDateTimeOffset(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlBaseConverter), Member = "UntypedAtomicToDateTimeOffset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(DateTimeOffset))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public virtual DateTimeOffset ToDateTimeOffset(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlUntypedConverter), Member = "ChangeTypeWildcardDestination", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlConvert), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public virtual decimal ToDecimal(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlConvert), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Decimal))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public virtual decimal ToDecimal(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlUntypedConverter), Member = "ChangeTypeWildcardDestination", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlConvert), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public virtual double ToDouble(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlConvert), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public virtual double ToDouble(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlUntypedConverter), Member = "ChangeTypeWildcardDestination", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlConvert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public virtual int ToInt32(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlConvert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public virtual int ToInt32(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlConvert), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public virtual long ToInt64(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlUntypedConverter), Member = "ChangeTypeWildcardDestination", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlConvert), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public virtual long ToInt64(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlUntypedConverter), Member = "ChangeTypeWildcardDestination", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlConvert), Member = "ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public virtual float ToSingle(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlConvert), Member = "ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public virtual float ToSingle(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlBaseConverter), Member = "DateTimeOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(string))]
	public virtual string ToString(DateTimeOffset value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(string))]
	public virtual string ToString(float value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(string))]
	public virtual string ToString(long value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	public virtual string ToString(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(string))]
	public virtual string ToString(double value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(string))]
	public virtual string ToString(decimal value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	public virtual string ToString(bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlBaseConverter), Member = "Base64BinaryToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlBaseConverter), Member = "DateTimeToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlBaseConverter), Member = "DateTimeOffsetToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTimeOffset)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlBaseConverter), Member = "DurationToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TimeSpan)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlBaseConverter), Member = "AnyUriToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Uri)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlBaseConverter), Member = "QNameToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XmlQualifiedName), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(XmlUntypedConverter), Member = "ChangeTypeWildcardDestination", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), typeof(IXmlNamespaceResolver)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(XmlBaseConverter), Member = "IsDerivedFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(Type)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
	[Calls(Type = typeof(XmlConvert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallsUnknownMethods(Count = 27)]
	public virtual string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XmlBaseConverter), Member = "DateTimeToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DateTime)}, ReturnType = typeof(string))]
	public virtual string ToString(DateTime value) { }

}

