namespace UnityEngine;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UnityWebRequestWWWModule"})]
internal class WWWTranscoder
{
	private static Byte[] ucHexChars; //Field offset: 0x0
	private static Byte[] lcHexChars; //Field offset: 0x8
	private static byte urlEscapeChar; //Field offset: 0x10
	private static Byte[] urlSpace; //Field offset: 0x18
	private static Byte[] dataSpace; //Field offset: 0x20
	private static Byte[] urlForbidden; //Field offset: 0x28
	private static byte qpEscapeChar; //Field offset: 0x30
	private static Byte[] qpSpace; //Field offset: 0x38
	private static Byte[] qpForbidden; //Field offset: 0x40

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
	private static WWWTranscoder() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void Byte2Hex(byte b, Byte[] hexChars, out byte byte0, out byte byte1) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool ByteArrayContains(Byte[] array, byte b) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool ByteSubArrayEquals(Byte[] array, int index, Byte[] comperand) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WWWTranscoder), Member = "Encode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(byte), typeof(Byte[]), typeof(Byte[]), typeof(bool)}, ReturnType = typeof(Byte[]))]
	[Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static string DataEncode(string toEncode, Encoding e) { }

	[CalledBy(Type = typeof(WebRequestUtils), Member = "URLDecode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(WWWTranscoder), Member = "URLDecode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(WWWTranscoder), Member = "Hex2Byte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int)}, ReturnType = typeof(byte))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 13)]
	[ContainsUnimplementedInstructions]
	public static Byte[] Decode(Byte[] input, byte escapeChar, Byte[] space) { }

	[CalledBy(Type = typeof(WWWTranscoder), Member = "DataEncode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Encoding)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(UnityWebRequest), Member = "SetupPostWwwForm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityWebRequest), typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 23)]
	public static Byte[] Encode(Byte[] input, byte escapeChar, Byte[] space, Byte[] forbidden, bool uppercase) { }

	[CalledBy(Type = typeof(WWWTranscoder), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(byte), typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static byte Hex2Byte(Byte[] b, int offset) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WWWTranscoder), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(byte), typeof(Byte[])}, ReturnType = typeof(Byte[]))]
	public static Byte[] URLDecode(Byte[] toEncode) { }

}

