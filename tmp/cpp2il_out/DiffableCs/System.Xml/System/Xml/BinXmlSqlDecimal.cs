namespace System.Xml;

internal struct BinXmlSqlDecimal
{
	private static readonly byte NUMERIC_MAX_PRECISION; //Field offset: 0x0
	private static readonly byte MaxPrecision; //Field offset: 0x1
	private static readonly byte MaxScale; //Field offset: 0x2
	private static readonly int x_cNumeMax; //Field offset: 0x4
	private static readonly long x_lInt32Base; //Field offset: 0x8
	private static readonly ulong x_ulInt32Base; //Field offset: 0x10
	private static readonly ulong x_ulInt32BaseForMod; //Field offset: 0x18
	internal static readonly ulong x_llMax; //Field offset: 0x20
	private static readonly double DUINT_BASE; //Field offset: 0x28
	private static readonly double DUINT_BASE2; //Field offset: 0x30
	private static readonly double DUINT_BASE3; //Field offset: 0x38
	private static readonly UInt32[] x_rgulShiftBase; //Field offset: 0x40
	private static readonly Byte[] rgCLenFromPrec; //Field offset: 0x48
	internal byte m_bLen; //Field offset: 0x0
	internal byte m_bPrec; //Field offset: 0x1
	internal byte m_bScale; //Field offset: 0x2
	internal byte m_bSign; //Field offset: 0x3
	internal uint m_data1; //Field offset: 0x4
	internal uint m_data2; //Field offset: 0x8
	internal uint m_data3; //Field offset: 0xC
	internal uint m_data4; //Field offset: 0x10

	public bool IsPositive
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static BinXmlSqlDecimal() { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ValueAsDecimal", ReturnType = typeof(Decimal))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BinXmlSqlDecimal), Member = "TrimTrailingZeros", ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String[])}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	public BinXmlSqlDecimal(Byte[] data, int offset, bool trim) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private static char ChFromDigit(uint uiDigit) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool get_IsPositive() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private static void MpDiv1(UInt32[] rgulU, ref int ciulU, uint iulD, out uint iulR) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private static void MpNormalize(UInt32[] rgulU, ref int ciulU) { }

	[CalledBy(Type = typeof(XmlSqlBinaryReader), Member = "ValueAsDecimal", ReturnType = typeof(Decimal))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int), typeof(bool), typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	public decimal ToDecimal() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public virtual string ToString() { }

	[CalledBy(Type = typeof(BinXmlSqlDecimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private void TrimTrailingZeros() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	private static uint UIntFromByteArray(Byte[] data, int offset) { }

}

