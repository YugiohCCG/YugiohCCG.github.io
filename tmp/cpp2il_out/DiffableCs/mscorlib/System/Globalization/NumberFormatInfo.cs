namespace System.Globalization;

[ComVisible(True)]
public sealed class NumberFormatInfo : ICloneable, IFormatProvider
{
	private static NumberFormatInfo invariantInfo; //Field offset: 0x0
	private const NumberStyles InvalidNumberStyles = -1024; //Field offset: 0x0
	internal Int32[] numberGroupSizes; //Field offset: 0x10
	internal Int32[] currencyGroupSizes; //Field offset: 0x18
	internal Int32[] percentGroupSizes; //Field offset: 0x20
	internal string positiveSign; //Field offset: 0x28
	internal string negativeSign; //Field offset: 0x30
	internal string numberDecimalSeparator; //Field offset: 0x38
	internal string numberGroupSeparator; //Field offset: 0x40
	internal string currencyGroupSeparator; //Field offset: 0x48
	internal string currencyDecimalSeparator; //Field offset: 0x50
	internal string currencySymbol; //Field offset: 0x58
	internal string ansiCurrencySymbol; //Field offset: 0x60
	internal string nanSymbol; //Field offset: 0x68
	internal string positiveInfinitySymbol; //Field offset: 0x70
	internal string negativeInfinitySymbol; //Field offset: 0x78
	internal string percentDecimalSeparator; //Field offset: 0x80
	internal string percentGroupSeparator; //Field offset: 0x88
	internal string percentSymbol; //Field offset: 0x90
	internal string perMilleSymbol; //Field offset: 0x98
	[OptionalField(VersionAdded = 2)]
	internal String[] nativeDigits; //Field offset: 0xA0
	[OptionalField(VersionAdded = 1)]
	internal int m_dataItem; //Field offset: 0xA8
	internal int numberDecimalDigits; //Field offset: 0xAC
	internal int currencyDecimalDigits; //Field offset: 0xB0
	internal int currencyPositivePattern; //Field offset: 0xB4
	internal int currencyNegativePattern; //Field offset: 0xB8
	internal int numberNegativePattern; //Field offset: 0xBC
	internal int percentPositivePattern; //Field offset: 0xC0
	internal int percentNegativePattern; //Field offset: 0xC4
	internal int percentDecimalDigits; //Field offset: 0xC8
	[OptionalField(VersionAdded = 2)]
	internal int digitSubstitution; //Field offset: 0xCC
	internal bool isReadOnly; //Field offset: 0xD0
	[OptionalField(VersionAdded = 1)]
	internal bool m_useUserOverride; //Field offset: 0xD1
	[OptionalField(VersionAdded = 2)]
	internal bool m_isInvariant; //Field offset: 0xD2
	[OptionalField(VersionAdded = 1)]
	internal bool validForParseAsNumber; //Field offset: 0xD3
	[OptionalField(VersionAdded = 1)]
	internal bool validForParseAsCurrency; //Field offset: 0xD4

	public int CurrencyDecimalDigits
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public string CurrencyDecimalSeparator
	{
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string CurrencyGroupSeparator
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 254
	}

	public Int32[] CurrencyGroupSizes
	{
		[CalledBy(Type = "System.Globalization.FormatProvider+Number", Member = "FormatCurrency", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Text.ValueStringBuilder&", "NumberBuffer&", typeof(int), typeof(int), typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 119
	}

	public int CurrencyNegativePattern
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public int CurrencyPositivePattern
	{
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public string CurrencySymbol
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public static NumberFormatInfo CurrentInfo
	{
		[CallerCount(Count = 24)]
		[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[Calls(Type = typeof(Thread), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 251
	}

	public static NumberFormatInfo InvariantInfo
	{
		[CallerCount(Count = 136)]
		[Calls(Type = typeof(NumberFormatInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureData)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 6)]
		 get { } //Length: 278
	}

	public bool IsReadOnly
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public string NaNSymbol
	{
		[CallerCount(Count = 22)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CalledBy(Type = typeof(CultureData), Member = "GetNFIValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 10)]
		 set { } //Length: 233
	}

	public string NegativeInfinitySymbol
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string NegativeSign
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public int NumberDecimalDigits
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public string NumberDecimalSeparator
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string NumberGroupSeparator
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public Int32[] NumberGroupSizes
	{
		[CalledBy(Type = "System.Globalization.FormatProvider+Number", Member = "NumberToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Text.ValueStringBuilder&", "NumberBuffer&", typeof(char), typeof(int), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Globalization.FormatProvider+Number", Member = "FormatNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Text.ValueStringBuilder&", "NumberBuffer&", typeof(int), typeof(int), typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
		[CalledBy(Type = "System.Globalization.FormatProvider+Number", Member = "NumberToStringFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Text.ValueStringBuilder&", "NumberBuffer&", "System.ReadOnlySpan`1<Char>", typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 119
	}

	public int NumberNegativePattern
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public int PercentDecimalDigits
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public string PercentDecimalSeparator
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public string PercentGroupSeparator
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public Int32[] PercentGroupSizes
	{
		[CalledBy(Type = "System.Globalization.FormatProvider+Number", Member = "FormatPercent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Text.ValueStringBuilder&", "NumberBuffer&", typeof(int), typeof(int), typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 119
	}

	public int PercentNegativePattern
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public int PercentPositivePattern
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public string PercentSymbol
	{
		[CallerCount(Count = 57)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public string PerMilleSymbol
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public string PositiveInfinitySymbol
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string PositiveSign
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NumberFormatInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureData)}, ReturnType = typeof(void))]
	public NumberFormatInfo() { }

	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_FullTimeSpanPositivePattern", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(DateTimeFormatInfo), Member = "get_FullTimeSpanNegativePattern", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(NumberFormatInfo), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
	[CalledBy(Type = typeof(CultureInfo), Member = "get_NumberFormat", ReturnType = typeof(NumberFormatInfo))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CultureData), Member = "GetNFIValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureData), Member = "get_IsInvariantCulture", ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 30)]
	internal NumberFormatInfo(CultureData cultureData) { }

	[CalledBy(Type = typeof(CultureInfo), Member = "Clone", ReturnType = typeof(object))]
	[CalledBy(Type = typeof(CultureInfo), Member = "ConstructInvariant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override object Clone() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_CurrencyDecimalDigits() { }

	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	public string get_CurrencyDecimalSeparator() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public string get_CurrencyGroupSeparator() { }

	[CalledBy(Type = "System.Globalization.FormatProvider+Number", Member = "FormatCurrency", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Text.ValueStringBuilder&", "NumberBuffer&", typeof(int), typeof(int), typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Int32[] get_CurrencyGroupSizes() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_CurrencyNegativePattern() { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public int get_CurrencyPositivePattern() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public string get_CurrencySymbol() { }

	[CallerCount(Count = 24)]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[Calls(Type = typeof(Thread), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static NumberFormatInfo get_CurrentInfo() { }

	[CallerCount(Count = 136)]
	[Calls(Type = typeof(NumberFormatInfo), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CultureData)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public static NumberFormatInfo get_InvariantInfo() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_IsReadOnly() { }

	[CallerCount(Count = 22)]
	[DeduplicatedMethod]
	public string get_NaNSymbol() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public string get_NegativeInfinitySymbol() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public string get_NegativeSign() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public int get_NumberDecimalDigits() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	public string get_NumberDecimalSeparator() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public string get_NumberGroupSeparator() { }

	[CalledBy(Type = "System.Globalization.FormatProvider+Number", Member = "NumberToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Text.ValueStringBuilder&", "NumberBuffer&", typeof(char), typeof(int), typeof(NumberFormatInfo), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Globalization.FormatProvider+Number", Member = "FormatNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Text.ValueStringBuilder&", "NumberBuffer&", typeof(int), typeof(int), typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Globalization.FormatProvider+Number", Member = "NumberToStringFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Text.ValueStringBuilder&", "NumberBuffer&", "System.ReadOnlySpan`1<Char>", typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Int32[] get_NumberGroupSizes() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_NumberNegativePattern() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_PercentDecimalDigits() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public string get_PercentDecimalSeparator() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public string get_PercentGroupSeparator() { }

	[CalledBy(Type = "System.Globalization.FormatProvider+Number", Member = "FormatPercent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Text.ValueStringBuilder&", "NumberBuffer&", typeof(int), typeof(int), typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public Int32[] get_PercentGroupSizes() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_PercentNegativePattern() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public int get_PercentPositivePattern() { }

	[CallerCount(Count = 57)]
	[DeduplicatedMethod]
	public string get_PercentSymbol() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public string get_PerMilleSymbol() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public string get_PositiveInfinitySymbol() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public string get_PositiveSign() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override object GetFormat(Type formatType) { }

	[CallerCount(Count = 59)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
	[Calls(Type = typeof(Thread), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	public static NumberFormatInfo GetInstance(IFormatProvider formatProvider) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	[OnDeserialized]
	private void OnDeserialized(StreamingContext ctx) { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	[OnDeserializing]
	private void OnDeserializing(StreamingContext ctx) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[OnSerializing]
	private void OnSerializing(StreamingContext ctx) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public static NumberFormatInfo ReadOnly(NumberFormatInfo nfi) { }

	[CalledBy(Type = typeof(CultureData), Member = "GetNFIValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberFormatInfo)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	public void set_NaNSymbol(string value) { }

	[CalledBy(Type = typeof(double), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(double))]
	[CalledBy(Type = typeof(double), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Double&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(float), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(float), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Single&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Decimal), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = typeof(Decimal), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Decimal&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	internal static void ValidateParseStyleFloatingPoint(NumberStyles style) { }

	[CallerCount(Count = 20)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	internal static void ValidateParseStyleInteger(NumberStyles style) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void VerifyWritable() { }

}

