namespace System;

[NonVersionable]
public struct Guid : IFormattable, IComparable, IComparable<Guid>, IEquatable<Guid>, ISpanFormattable
{
	private enum GuidParseThrowStyle
	{
		None = 0,
		All = 1,
		AllButOverflow = 2,
	}

	private struct GuidResult
	{
		internal Guid _parsedGuid; //Field offset: 0x0
		internal GuidParseThrowStyle _throwStyle; //Field offset: 0x10
		private ParseFailureKind _failure; //Field offset: 0x14
		private string _failureMessageID; //Field offset: 0x18
		private object _failureMessageFormatArgument; //Field offset: 0x20
		private string _failureArgumentName; //Field offset: 0x28
		private Exception _innerException; //Field offset: 0x30

		[CalledBy(Type = typeof(GuidResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Guid+ParseFailureKind", typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GuidResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Guid+ParseFailureKind", typeof(string), typeof(object)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(GuidResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Guid+ParseFailureKind", typeof(string), typeof(object), typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Guid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Guid), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Guid))]
		[CalledBy(Type = typeof(Guid), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(Guid))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 4)]
		internal Exception GetGuidParseException() { }

		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		internal void Init(GuidParseThrowStyle canThrow) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal void SetFailure(Exception nativeException) { }

		[CalledBy(Type = typeof(Guid), Member = "TryParseGuid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), "System.Guid+GuidStyles", typeof(GuidResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Guid), Member = "TryParseGuidWithHexPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(GuidResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Guid), Member = "TryParseGuidWithNoStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(GuidResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Guid), Member = "TryParseGuidWithDashes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(GuidResult&)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Guid), Member = "StringToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(Int32&), typeof(int), typeof(int), typeof(Int32&), typeof(GuidResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(GuidResult), Member = "GetGuidParseException", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 6)]
		internal void SetFailure(ParseFailureKind failure, string failureMessageID) { }

		[CalledBy(Type = typeof(Guid), Member = "TryParseGuidWithHexPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(GuidResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(GuidResult), Member = "GetGuidParseException", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 6)]
		internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument) { }

		[CalledBy(Type = typeof(Guid), Member = "TryParseGuid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), "System.Guid+GuidStyles", typeof(GuidResult&)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(GuidResult), Member = "GetGuidParseException", ReturnType = typeof(Exception))]
		[CallsUnknownMethods(Count = 6)]
		internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument, string failureArgumentName, Exception innerException) { }

	}

	[Flags]
	private enum GuidStyles
	{
		None = 0,
		AllowParenthesis = 1,
		AllowBraces = 2,
		AllowDashes = 4,
		AllowHexPrefix = 8,
		RequireParenthesis = 16,
		RequireBraces = 32,
		RequireDashes = 64,
		RequireHexPrefix = 128,
		HexFormat = 160,
		NumberFormat = 0,
		DigitFormat = 64,
		BraceFormat = 96,
		ParenthesisFormat = 80,
		Any = 15,
	}

	private enum ParseFailureKind
	{
		None = 0,
		ArgumentNull = 1,
		Format = 2,
		FormatWithParameter = 3,
		NativeException = 4,
		FormatWithInnerException = 5,
	}

	public static readonly Guid Empty; //Field offset: 0x0
	private int _a; //Field offset: 0x0
	private short _b; //Field offset: 0x4
	private short _c; //Field offset: 0x6
	private byte _d; //Field offset: 0x8
	private byte _e; //Field offset: 0x9
	private byte _f; //Field offset: 0xA
	private byte _g; //Field offset: 0xB
	private byte _h; //Field offset: 0xC
	private byte _i; //Field offset: 0xD
	private byte _j; //Field offset: 0xE
	private byte _k; //Field offset: 0xF

	[CalledBy(Type = "Newtonsoft.Json.Bson.BsonDataReader", Member = "ReadType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Bson.BsonType"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(KeyPairPersistence), Member = "get_ContainerName", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(RuntimeModule), Member = "GetModuleVersionId", ReturnType = typeof(Guid))]
	[CalledBy(Type = typeof(StackTrace), Member = "GetAotId", ReturnType = typeof(string))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "TryConvertInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(CultureInfo), typeof(Type), typeof(Object&)}, ReturnType = "Newtonsoft.Json.Utilities.ConvertUtils+ConvertResult")]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = typeof(Guid))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JToken", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Linq.JToken"}, ReturnType = "System.Nullable`1<Guid>")]
	[CalledBy(Type = "Newtonsoft.Json.Bson.BsonReader", Member = "ReadType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.Bson.BsonType"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.SqlTypes.SqlGuid", Member = "get_Value", ReturnType = typeof(Guid))]
	[CalledBy(Type = "System.Data.SqlTypes.SqlGuid", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Data.SqlTypes.SqlGuid", Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = "System.Data.SqlTypes.SqlGuid", Member = "System.Xml.Serialization.IXmlSerializable.WriteXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.XmlWriter"}, ReturnType = typeof(void))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Byte>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public Guid(Byte[] b) { }

	[CalledBy(Type = typeof(Guid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 7)]
	public Guid(ReadOnlySpan<Byte> b) { }

	[CalledBy(Type = typeof(ArrayPoolEventSource), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ArrayPoolEventSource), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Linq.Expressions.SymbolDocumentInfo", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	public Guid(int a, short b, short c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k) { }

	[CallerCount(Count = 43)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(Guid), Member = "TryParseGuid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(GuidStyles), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GuidResult), Member = "GetGuidParseException", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 6)]
	public Guid(string g) { }

	[CallerCount(Count = 0)]
	public override int CompareTo(Guid value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public override int CompareTo(object value) { }

	[CalledBy(Type = typeof(Guid), Member = "TryParseGuidWithHexPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(char), Member = "IsWhiteSpace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(ReadOnlySpan`1), Member = "CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private static ReadOnlySpan<Char> EatAllWhitespace(ReadOnlySpan<Char> str) { }

	[CalledBy(Type = "System.Xml.Schema.Datatype_uuid", Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object o) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(Guid g) { }

	[CalledBy(Type = "UnityEngine.UIElements.VisualTreeAsset", Member = "GetNextUxmlAssetId", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Data.SqlTypes.SqlGuid", Member = "GetHashCode", ReturnType = typeof(int))]
	[CalledBy(Type = "System.Numerics.Hashing.HashHelpers", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	private int GetResult(uint me, uint them) { }

	[CallerCount(Count = 0)]
	private static int HexsToChars(Char* guidChars, int a, int b) { }

	[CallerCount(Count = 0)]
	private static int HexsToCharsHexOutput(Char* guidChars, int a, int b) { }

	[CallerCount(Count = 0)]
	private static char HexToChar(int a) { }

	[CalledBy(Type = typeof(Guid), Member = "TryParseGuidWithHexPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(char), Member = "ToLowerInvariant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static bool IsHexPrefix(ReadOnlySpan<Char> str, int i) { }

	[CallerCount(Count = 40)]
	[Calls(Type = typeof(Interop), Member = "GetRandomBytes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte*), typeof(int)}, ReturnType = typeof(void))]
	public static Guid NewGuid() { }

	[CallerCount(Count = 15)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Equality(Guid a, Guid b) { }

	[CalledBy(Type = "UnityEngine.InputSystem.InputBinding", Member = "Matches", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.InputSystem.InputBinding&", "UnityEngine.InputSystem.InputBinding+MatchOptions"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool op_Inequality(Guid a, Guid b) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Guid), Member = "TryParseGuid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(GuidStyles), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GuidResult), Member = "GetGuidParseException", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 2)]
	public static Guid Parse(ReadOnlySpan<Char> input) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(Guid), Member = "TryParseGuid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(GuidStyles), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GuidResult), Member = "GetGuidParseException", ReturnType = typeof(Exception))]
	[CallsUnknownMethods(Count = 6)]
	public static Guid Parse(string input) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Guid), Member = "StringToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(Int32&), typeof(int), typeof(int), typeof(Int32&), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	private static bool StringToInt(ReadOnlySpan<Char> str, int requiredLength, int flags, out int result, ref GuidResult parseResult) { }

	[CalledBy(Type = typeof(Guid), Member = "TryParseGuidWithHexPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Guid), Member = "TryParseGuidWithNoStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Guid), Member = "TryParseGuidWithDashes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Guid), Member = "StringToShort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(int), typeof(int), typeof(Int16&), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Guid), Member = "StringToShort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(Int32&), typeof(int), typeof(int), typeof(Int16&), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Guid), Member = "StringToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(int), typeof(int), typeof(Int32&), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(ParseNumbers), Member = "StringToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(GuidResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	private static bool StringToInt(ReadOnlySpan<Char> str, ref int parsePos, int requiredLength, int flags, out int result, ref GuidResult parseResult) { }

	[CalledBy(Type = typeof(Guid), Member = "TryParseGuidWithNoStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Guid), Member = "TryParseGuidWithDashes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ParseNumbers), Member = "StringToLong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(long))]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	private static bool StringToLong(ReadOnlySpan<Char> str, ref int parsePos, int flags, out long result, ref GuidResult parseResult) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Guid), Member = "StringToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(Int32&), typeof(int), typeof(int), typeof(Int32&), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	private static bool StringToShort(ReadOnlySpan<Char> str, int requiredLength, int flags, out short result, ref GuidResult parseResult) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Guid), Member = "StringToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(Int32&), typeof(int), typeof(int), typeof(Int32&), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	private static bool StringToShort(ReadOnlySpan<Char> str, ref int parsePos, int requiredLength, int flags, out short result, ref GuidResult parseResult) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Guid), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(bool))]
	private override bool System.ISpanFormattable.TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format, IFormatProvider provider) { }

	[CalledBy(Type = "Newtonsoft.Json.Bson.BsonDataWriter", Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Manager.DiscordController", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.JsonReader", Member = "ReadAsBytes", ReturnType = "System.Byte[]")]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "TryConvertInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(CultureInfo), typeof(Type), typeof(Object&)}, ReturnType = "Newtonsoft.Json.Utilities.ConvertUtils+ConvertResult")]
	[CalledBy(Type = "Newtonsoft.Json.Bson.BsonWriter", Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.SqlTypes.SqlGuid", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.SqlTypes.SqlGuid", Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid)}, ReturnType = "System.Data.SqlTypes.SqlGuid")]
	[CalledBy(Type = "System.Data.SqlTypes.SqlGuid", Member = "System.Xml.Serialization.IXmlSerializable.ReadXml", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.XmlReader"}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Guid), Member = "WriteByteHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Byte>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public Byte[] ToByteArray() { }

	[CallerCount(Count = 34)]
	[ContainsInvalidInstructions]
	public virtual string ToString() { }

	[CalledBy(Type = typeof(StackTrace), Member = "GetAotId", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(StackTrace), Member = "AddFrames", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder), typeof(bool), typeof(Boolean&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(PathInternal), Member = "GetIsCaseSensitive", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.PlayerConnectionInternal", Member = "UnityEngine.IPlayerEditorConnectionNative.SendMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid), "System.Byte[]", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.PlayerConnectionInternal", Member = "UnityEngine.IPlayerEditorConnectionNative.TrySendMessage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid), "System.Byte[]", typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.PlayerConnectionInternal", Member = "UnityEngine.IPlayerEditorConnectionNative.RegisterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.PlayerConnectionInternal", Member = "UnityEngine.IPlayerEditorConnectionNative.UnregisterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Schema.JsonSchema", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.IO.PathInternal", Member = "GetIsCaseSensitive", ReturnType = typeof(bool))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Guid), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	public string ToString(string format) { }

	[CalledBy(Type = typeof(Guid), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Newtonsoft.Json.JsonConvert", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Newtonsoft.Json.JsonConvert", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid), typeof(char)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Newtonsoft.Json.JsonConvert", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextWriter+<DoWriteValueAsync>d__78", Member = "MoveNext", ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextWriter", Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Guid)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(string), Member = "FastAllocateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(Guid), Member = "TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public override string ToString(string format, IFormatProvider provider) { }

	[CalledBy(Type = typeof(Guid), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(Guid), Member = "System.ISpanFormattable.TryFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<System.Char>), typeof(Int32&), typeof(System.ReadOnlySpan`1<System.Char>), typeof(IFormatProvider)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(FormatException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	public bool TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format = null) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Guid), Member = "TryParseGuid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(GuidStyles), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	public static bool TryParse(ReadOnlySpan<Char> input, out Guid result) { }

	[CalledBy(Type = "UnityEngine.InputSystem.InputActionAsset", Member = "FindActionMap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = "UnityEngine.InputSystem.InputActionMap")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(Guid), Member = "TryParseGuid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(GuidStyles), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	public static bool TryParse(string input, out Guid result) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Guid), Member = "TryParseGuid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(GuidStyles), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public static bool TryParseExact(ReadOnlySpan<Char> input, ReadOnlySpan<Char> format, out Guid result) { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "TryConvertGuid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Guid&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(Guid), Member = "TryParseGuid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(GuidStyles), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[ContainsUnimplementedInstructions]
	public static bool TryParseExact(string input, string format, out Guid result) { }

	[CalledBy(Type = typeof(Guid), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Guid), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Guid))]
	[CalledBy(Type = typeof(Guid), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(Guid))]
	[CalledBy(Type = typeof(Guid), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Guid&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Guid), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(Guid&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Guid), Member = "TryParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(Guid&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(Guid), Member = "TryParseExact", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.ReadOnlySpan`1<System.Char>), typeof(Guid&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(MemoryExtensions), Member = "Trim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
	[Calls(Type = typeof(GuidResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Guid), Member = "TryParseGuidWithNoStyle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Guid), Member = "TryParseGuidWithHexPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Guid), Member = "TryParseGuidWithDashes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GuidResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string), typeof(object), typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private static bool TryParseGuid(ReadOnlySpan<Char> guidString, GuidStyles flags, ref GuidResult result) { }

	[CalledBy(Type = typeof(Guid), Member = "TryParseGuid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(GuidStyles), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(GuidResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Guid), Member = "StringToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(Int32&), typeof(int), typeof(int), typeof(Int32&), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Guid), Member = "StringToLong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(Int32&), typeof(int), typeof(Int64&), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	private static bool TryParseGuidWithDashes(ReadOnlySpan<Char> guidString, ref GuidResult result) { }

	[CalledBy(Type = typeof(Guid), Member = "TryParseGuid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(GuidStyles), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Guid), Member = "EatAllWhitespace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>)}, ReturnType = typeof(System.ReadOnlySpan`1<System.Char>))]
	[Calls(Type = typeof(Guid), Member = "IsHexPrefix", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(Guid), Member = "StringToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(Int32&), typeof(int), typeof(int), typeof(Int32&), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(char), Member = "ToLowerInvariant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(GuidResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(GuidResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 15)]
	private static bool TryParseGuidWithHexPrefix(ReadOnlySpan<Char> guidString, ref GuidResult result) { }

	[CalledBy(Type = typeof(Guid), Member = "TryParseGuid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(GuidStyles), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(char), Member = "ToUpperInvariant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(Guid), Member = "StringToInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(Int32&), typeof(int), typeof(int), typeof(Int32&), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Guid), Member = "StringToLong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(Int32&), typeof(int), typeof(Int64&), typeof(GuidResult&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(GuidResult), Member = "SetFailure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParseFailureKind), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	private static bool TryParseGuidWithNoStyle(ReadOnlySpan<Char> guidString, ref GuidResult result) { }

	[CalledBy(Type = typeof(Guid), Member = "ToByteArray", ReturnType = typeof(Byte[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
	[Calls(Type = typeof(SpanHelpers), Member = "IndexOf", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T&", "T", typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SpanHelpers), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Char&), typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(SpanHelpers), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte&), typeof(byte), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NumberBuffer), Member = "set_sign", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(ValueStringBuilder), Member = "AppendSlow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	private void WriteByteHelper(Span<Byte> destination) { }

}

