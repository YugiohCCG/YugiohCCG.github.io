namespace System.Xml;

internal struct BinXmlSqlMoney
{
	private long data; //Field offset: 0x0

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public BinXmlSqlMoney(int v) { }

	[CallerCount(Count = 26)]
	[DeduplicatedMethod]
	public BinXmlSqlMoney(long v) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(bool), typeof(byte)}, ReturnType = typeof(void))]
	public decimal ToDecimal() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(bool), typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(Decimal), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	public virtual string ToString() { }

}

