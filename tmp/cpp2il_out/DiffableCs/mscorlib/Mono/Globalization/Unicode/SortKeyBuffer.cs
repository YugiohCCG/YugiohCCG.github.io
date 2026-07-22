namespace Mono.Globalization.Unicode;

internal class SortKeyBuffer
{
	private Byte[] l1b; //Field offset: 0x10
	private Byte[] l2b; //Field offset: 0x18
	private Byte[] l3b; //Field offset: 0x20
	private Byte[] l4sb; //Field offset: 0x28
	private Byte[] l4tb; //Field offset: 0x30
	private Byte[] l4kb; //Field offset: 0x38
	private Byte[] l4wb; //Field offset: 0x40
	private Byte[] l5b; //Field offset: 0x48
	private string source; //Field offset: 0x50
	private int l1; //Field offset: 0x58
	private int l2; //Field offset: 0x5C
	private int l3; //Field offset: 0x60
	private int l4s; //Field offset: 0x64
	private int l4t; //Field offset: 0x68
	private int l4k; //Field offset: 0x6C
	private int l4w; //Field offset: 0x70
	private int l5; //Field offset: 0x74
	private int lcid; //Field offset: 0x78
	private CompareOptions options; //Field offset: 0x7C
	private bool processLevel2; //Field offset: 0x80
	private bool frenchSort; //Field offset: 0x81
	private bool frenchSorted; //Field offset: 0x82

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public SortKeyBuffer(int lcid) { }

	[CalledBy(Type = typeof(SimpleCollator), Member = "FillSortKeyRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "Mono.Globalization.Unicode.SimpleCollator+ExtenderType", typeof(SortKeyBuffer), typeof(CompareOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SortKeyBuffer), Member = "AppendCJKExtension", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SortKeyBuffer), Member = "AppendKana", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(bool), typeof(byte), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SortKeyBuffer), Member = "AppendNormal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte), typeof(byte)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SortKeyBuffer), Member = "AppendLevel5", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte)}, ReturnType = typeof(void))]
	[CallerCount(Count = 33)]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	private void AppendBufferPrimitive(byte value, ref Byte[] buf, ref int bidx) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SortKeyBuffer), Member = "AppendBufferPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(Byte[]&), typeof(Int32&)}, ReturnType = typeof(void))]
	internal void AppendCJKExtension(byte lv1msb, byte lv1lsb) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SortKeyBuffer), Member = "AppendNormal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte), typeof(byte)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SortKeyBuffer), Member = "AppendBufferPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(Byte[]&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	internal void AppendKana(byte category, byte lv1, byte lv2, byte lv3, bool isSmallKana, byte markType, bool isKatakana, bool isHalfWidth) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SortKeyBuffer), Member = "AppendBufferPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(Byte[]&), typeof(Int32&)}, ReturnType = typeof(void))]
	private void AppendLevel5(byte category, byte lv1) { }

	[CalledBy(Type = typeof(SimpleCollator), Member = "GetSortKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(SortKeyBuffer), typeof(CompareOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "FillSortKeyRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "Mono.Globalization.Unicode.SimpleCollator+ExtenderType", typeof(SortKeyBuffer), typeof(CompareOptions)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "FillSurrogateSortKeyRaw", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(SortKeyBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(SortKeyBuffer), Member = "AppendKana", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(byte), typeof(byte), typeof(byte), typeof(bool), typeof(byte), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(SortKeyBuffer), Member = "AppendBufferPrimitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte), typeof(Byte[]&), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	internal void AppendNormal(byte category, byte lv1, byte lv2, byte lv3) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private int GetOptimizedLength(Byte[] data, int len, byte defaultValue) { }

	[CalledBy(Type = typeof(SimpleCollator), Member = "GetSortKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CompareOptions)}, ReturnType = typeof(SortKey))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "GetSortKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(CompareOptions)}, ReturnType = typeof(SortKey))]
	[CalledBy(Type = typeof(SortKeyBuffer), Member = "GetResultAndReset", ReturnType = typeof(SortKey))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Reverse", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SortKey), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(string), typeof(Byte[]), typeof(CompareOptions), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	public SortKey GetResult() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SortKeyBuffer), Member = "GetResult", ReturnType = typeof(SortKey))]
	public SortKey GetResultAndReset() { }

	[CalledBy(Type = typeof(SimpleCollator), Member = "GetSortKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(CompareOptions)}, ReturnType = typeof(SortKey))]
	[CalledBy(Type = typeof(SimpleCollator), Member = "GetSortKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(CompareOptions)}, ReturnType = typeof(SortKey))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	internal void Initialize(CompareOptions options, int lcid, string s, bool frenchSort) { }

	[CallerCount(Count = 0)]
	public void Reset() { }

}

