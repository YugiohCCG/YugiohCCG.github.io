namespace System.Web.Util;

public class HttpEncoder
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal HttpEncoder <.cctor>b__13_0() { }

	}

	private static Char[] hexChars; //Field offset: 0x0
	private static object entitiesLock; //Field offset: 0x8
	private static Lazy<HttpEncoder> defaultEncoder; //Field offset: 0x10
	private static Lazy<HttpEncoder> currentEncoderLazy; //Field offset: 0x18
	private static HttpEncoder currentEncoder; //Field offset: 0x20

	public static HttpEncoder Current
	{
		[CalledBy(Type = typeof(HttpUtility), Member = "UrlEncode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Encoding)}, ReturnType = typeof(string))]
		[CalledBy(Type = typeof(HttpUtility), Member = "UrlEncodeToBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(Byte[]))]
		[CalledBy(Type = typeof(HttpUtility), Member = "UrlPathEncode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(System.Lazy`1<System.Object>), Member = "get_Value", ReturnType = typeof(object))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 228
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "ToCharArray", ReturnType = typeof(Char[]))]
	[Calls(Type = typeof(System.Lazy`1<System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Func`1<System.Object>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	private static HttpEncoder() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public HttpEncoder() { }

	[CalledBy(Type = typeof(HttpUtility), Member = "UrlEncode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Encoding)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(HttpUtility), Member = "UrlEncodeToBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(Byte[]))]
	[CalledBy(Type = typeof(HttpUtility), Member = "UrlPathEncode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(System.Lazy`1<System.Object>), Member = "get_Value", ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 2)]
	public static HttpEncoder get_Current() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Lazy`1<System.Object>), Member = "get_Value", ReturnType = typeof(object))]
	[CallsUnknownMethods(Count = 1)]
	private static HttpEncoder GetCustomEncoderFromConfig() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal static bool NotEncoded(char c) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(HttpEncoder), Member = "UrlEncodeToBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(Byte[]))]
	protected private override Byte[] UrlEncode(Byte[] bytes, int offset, int count) { }

	[CalledBy(Type = typeof(HttpEncoder), Member = "UrlEncodeToBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal static void UrlEncodeChar(char c, Stream result, bool isUnicode) { }

	[CalledBy(Type = typeof(HttpEncoder), Member = "UrlEncode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(HttpEncoder), Member = "UrlEncodeChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(Stream), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	internal static Byte[] UrlEncodeToBytes(Byte[] bytes, int offset, int count) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(HttpEncoder), Member = "UrlPathEncodeChar", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(Stream)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected private override string UrlPathEncode(string value) { }

	[CalledBy(Type = typeof(HttpEncoder), Member = "UrlPathEncode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 2)]
	internal static void UrlPathEncodeChar(char c, Stream result) { }

}

