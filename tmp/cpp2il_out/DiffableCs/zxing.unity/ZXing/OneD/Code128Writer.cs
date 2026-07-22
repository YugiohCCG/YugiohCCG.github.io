namespace ZXing.OneD;

public sealed class Code128Writer : OneDimensionalCodeWriter
{
	private const int CODE_START_B = 104; //Field offset: 0x0
	private const int CODE_START_C = 105; //Field offset: 0x0
	private const int CODE_CODE_B = 100; //Field offset: 0x0
	private const int CODE_CODE_C = 99; //Field offset: 0x0
	private const int CODE_STOP = 106; //Field offset: 0x0
	private const char ESCAPE_FNC_1 = '\uF1'; //Field offset: 0x0
	private const char ESCAPE_FNC_2 = '\uF2'; //Field offset: 0x0
	private const char ESCAPE_FNC_3 = '\uF3'; //Field offset: 0x0
	private const char ESCAPE_FNC_4 = '\uF4'; //Field offset: 0x0
	private const int CODE_FNC_1 = 102; //Field offset: 0x0
	private const int CODE_FNC_2 = 97; //Field offset: 0x0
	private const int CODE_FNC_3 = 96; //Field offset: 0x0
	private const int CODE_FNC_4_B = 100; //Field offset: 0x0
	private bool forceCodesetB; //Field offset: 0x10

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public Code128Writer() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OneDimensionalCodeWriter), Member = "encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(BarcodeFormat), typeof(int), typeof(int), typeof(System.Collections.Generic.IDictionary`2<ZXing.EncodeHintType, System.Object>)}, ReturnType = typeof(BitMatrix))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	public virtual BitMatrix encode(string contents, BarcodeFormat format, int width, int height, IDictionary<EncodeHintType, Object> hints) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(int), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(OneDimensionalCodeWriter), Member = "appendPattern", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Boolean[]), typeof(int), typeof(Int32[]), typeof(bool)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 17)]
	[ContainsUnimplementedInstructions]
	public virtual Boolean[] encode(string contents) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static bool isDigits(string value, int start, int length) { }

}

