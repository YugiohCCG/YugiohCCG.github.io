namespace System;

[IsReadOnly]
public struct short : IComparable, IConvertible, IFormattable, IComparable<Int16>, IEquatable<Int16>, ISpanFormattable
{
	private readonly short m_value; //Field offset: 0x0

	[CalledBy(Type = "System.Xml.Schema.Datatype_short", Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public override int CompareTo(object value) { }

	[CalledBy(Type = "System.Data.Common.Int16Storage", Member = "CompareValueTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	public override int CompareTo(short value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 15)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[NonVersionable]
	public override bool Equals(short obj) { }

	[CalledBy(Type = typeof(Vector`1), Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ShortEnumEqualityComparer`1), Member = "GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Data.SqlTypes.SqlInt16", Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = "System.Drawing.Color", Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 13)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override TypeCode GetTypeCode() { }

	[CalledBy(Type = typeof(short), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(short))]
	[CalledBy(Type = typeof(short), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(short))]
	[CalledBy(Type = typeof(short), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(short))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Number), Member = "ParseInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 13)]
	[ContainsUnimplementedInstructions]
	private static short Parse(ReadOnlySpan<Char> s, NumberStyles style, NumberFormatInfo info) { }

	[CalledBy(Type = typeof(Convert), Member = "ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(short))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(short))]
	[CalledBy(Type = "System.ComponentModel.Int16Converter", Member = "FromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberFormatInfo)}, ReturnType = typeof(object))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberStyles)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(short), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(short))]
	public static short Parse(string s, NumberStyles style, IFormatProvider provider) { }

	[CalledBy(Type = "Scenes.Deck.DeckEdit", Member = "OnApplyButton", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(short), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(short))]
	public static short Parse(string s) { }

	[CalledBy(Type = typeof(PrimitiveArray), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(short), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(short))]
	public static short Parse(string s, IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private override bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(byte))]
	private override byte System.IConvertible.ToByte(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(char))]
	private override char System.IConvertible.ToChar(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private override DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(Decimal))]
	private override decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(double))]
	private override double System.IConvertible.ToDouble(IFormatProvider provider) { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	private override short System.IConvertible.ToInt16(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(int))]
	private override int System.IConvertible.ToInt32(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(long))]
	private override long System.IConvertible.ToInt64(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(sbyte))]
	private override sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(float))]
	private override float System.IConvertible.ToSingle(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "DefaultToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IConvertible), typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	private override object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(ushort))]
	private override ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(uint))]
	private override uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(ulong))]
	private override ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	[CalledBy(Type = "System.Xml.XmlConvert", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.ComponentModel.Int16Converter", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(NumberFormatInfo)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Newtonsoft.Json.JsonConvert", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Newtonsoft.Json.JsonConvert", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(Number), Member = "FormatUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Number), Member = "FormatInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	public override string ToString(string format, IFormatProvider provider) { }

	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.PrimitiveValue", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Data.SqlTypes.SqlInt16", Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Number), Member = "FormatInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override string ToString(IFormatProvider provider) { }

	[CalledBy(Type = "HostSettings", Member = "SetHostRules", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Data.GameSettings", typeof(int), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Card.Template", Member = "RefreshGenesys", ReturnType = typeof(void))]
	[CalledBy(Type = "Unity.Properties.TypeConversion+PrimitiveConverters+<>c", Member = "<RegisterStringConverters>b__13_7", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int16&)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Number), Member = "FormatInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual string ToString() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Number), Member = "TryFormatUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Number), Member = "TryFormatInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public override bool TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format = null, IFormatProvider provider = null) { }

	[CalledBy(Type = "HostSettings", Member = "GetGameSettings", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Data.GameSettings&", typeof(UInt32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "HostSettings", Member = "ParseFilters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Enumerator.DuelRules&", typeof(Int32&), typeof(Int16&), typeof(Byte&), typeof(Byte&), typeof(Byte&), typeof(Byte&), typeof(UInt32&), "Enumerator.DuelMode&", typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.BanlistManager", Member = "ReadBanlistFile", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.ConverterGroups+<>c", Member = "<RegisterInt16Converters>b__18_11", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String&)}, ReturnType = typeof(short))]
	[CalledBy(Type = "Unity.Properties.TypeConversion+PrimitiveConverters+<>c", Member = "<RegisterStringConverters>b__13_6", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String&)}, ReturnType = typeof(short))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(Number), Member = "TryParseInt32IntegerStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(Int32&), typeof(Boolean&)}, ReturnType = typeof(bool))]
	public static bool TryParse(string s, out short result) { }

	[CalledBy(Type = "System.Xml.XmlConvert", Member = "TryToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Int16&)}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberStyles)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(short), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(Int16&)}, ReturnType = typeof(bool))]
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out short result) { }

	[CalledBy(Type = typeof(short), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Int16&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Number), Member = "TryParseInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(Int32&)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	private static bool TryParse(ReadOnlySpan<Char> s, NumberStyles style, NumberFormatInfo info, out short result) { }

}

