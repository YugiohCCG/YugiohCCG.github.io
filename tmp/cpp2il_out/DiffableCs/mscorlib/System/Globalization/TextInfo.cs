namespace System.Globalization;

[ComVisible(True)]
public class TextInfo : ICloneable, IDeserializationCallback
{
	internal static TextInfo s_Invariant; //Field offset: 0x0
	[OptionalField(VersionAdded = 2)]
	private bool m_isReadOnly; //Field offset: 0x10
	[OptionalField(VersionAdded = 3)]
	private string m_cultureName; //Field offset: 0x18
	private CultureData m_cultureData; //Field offset: 0x20
	private string m_textInfoName; //Field offset: 0x28
	private Nullable<Boolean> m_IsAsciiCasingSameAsInvariant; //Field offset: 0x30
	[OptionalField(VersionAdded = 2)]
	private string customCultureName; //Field offset: 0x38
	[OptionalField(VersionAdded = 1)]
	internal bool m_useUserOverride; //Field offset: 0x40
	[OptionalField(VersionAdded = 1)]
	internal int m_win32LangID; //Field offset: 0x44

	[ComVisible(False)]
	public string CultureName
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	internal static TextInfo Invariant
	{
		[CalledBy(Type = typeof(CultureInfo), Member = "ConstructInvariant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CultureData), Member = "get_Invariant", ReturnType = typeof(CultureData))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 8)]
		internal get { } //Length: 258
	}

	private bool IsAsciiCasingSameAsInvariant
	{
		[CalledBy(Type = typeof(TextInfo), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
		[CalledBy(Type = typeof(TextInfo), Member = "ToUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
		[CalledBy(Type = typeof(TextInfo), Member = "ToLowerInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		private get { } //Length: 219
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	internal TextInfo() { }

	[CalledBy(Type = typeof(CultureInfo), Member = "get_TextInfo", ReturnType = typeof(TextInfo))]
	[CalledBy(Type = typeof(CultureInfo), Member = "CreateTextInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(TextInfo))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	internal TextInfo(CultureData cultureData) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[CallsUnknownMethods(Count = 1)]
	private static int AddNonLetter(ref StringBuilder result, ref string input, int inputIndex, int charLen) { }

	[CalledBy(Type = typeof(TextInfo), Member = "ToTitleCase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(StringBuilder))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private int AddTitlecaseLetter(ref StringBuilder result, ref string input, int inputIndex, int charLen) { }

	[CalledBy(Type = typeof(MemoryExtensions), Member = "ToUpperInvariant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.Span`1<System.Char>)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	internal void ChangeCase(ReadOnlySpan<Char> source, Span<Char> destination, bool toUpper) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[ComVisible(False)]
	public override object Clone() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public string get_CultureName() { }

	[CalledBy(Type = typeof(CultureInfo), Member = "ConstructInvariant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CultureData), Member = "get_Invariant", ReturnType = typeof(CultureData))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	internal static TextInfo get_Invariant() { }

	[CalledBy(Type = typeof(TextInfo), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[CalledBy(Type = typeof(TextInfo), Member = "ToUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[CalledBy(Type = typeof(TextInfo), Member = "ToLowerInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	private bool get_IsAsciiCasingSameAsInvariant() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static bool IsAscii(char c) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static bool IsLetterCategory(UnicodeCategory uc) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static bool IsWordSeparator(UnicodeCategory category) { }

	[CalledBy(Type = typeof(TextInfo), Member = "OnDeserialized", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StreamingContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextInfo), Member = "System.Runtime.Serialization.IDeserializationCallback.OnDeserialization", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CultureInfo), Member = "GetCultureInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(CultureInfo), Member = "GetCultureInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(CultureInfo))]
	[CallsUnknownMethods(Count = 4)]
	private void OnDeserialized() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextInfo), Member = "OnDeserialized", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	[OnDeserialized]
	private void OnDeserialized(StreamingContext ctx) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[OnDeserializing]
	private void OnDeserializing(StreamingContext ctx) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CultureInfo), Member = "GetCultureInfo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(CultureInfo))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[OnSerializing]
	private void OnSerializing(StreamingContext ctx) { }

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SemaphoreSlim), Member = "Release", ReturnType = typeof(int))]
	[Calls(Type = typeof(Math), Member = "ThrowAbsOverflow", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	internal void SetReadOnlyState(bool readOnly) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextInfo), Member = "OnDeserialized", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextInfo), Member = "get_IsAsciiCasingSameAsInvariant", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextInfo), Member = "ToLowerInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	public override char ToLower(char c) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "FastAllocateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public override string ToLower(string str) { }

	[CallerCount(Count = 0)]
	private static char ToLowerAsciiInvariant(char c) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "FastAllocateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private string ToLowerInternal(string str) { }

	[CalledBy(Type = typeof(TextInfo), Member = "ToLower", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CultureData), Member = "get_IsInvariantCulture", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextInfo), Member = "get_IsAsciiCasingSameAsInvariant", ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	private char ToLowerInternal(char c) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public virtual string ToString() { }

	[CalledBy(Type = "UnityEngine.InputSystem.Controls.KeyControl", Member = "RefreshConfiguration", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CharUnicodeInfo), Member = "InternalGetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(Int32&)}, ReturnType = typeof(UnicodeCategory))]
	[Calls(Type = typeof(char), Member = "CheckLetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnicodeCategory)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextInfo), Member = "AddTitlecaseLetter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StringBuilder&), typeof(String&), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(StringBuilder))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 5)]
	[ContainsUnimplementedInstructions]
	public string ToTitleCase(string str) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "FastAllocateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public override string ToUpper(string str) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextInfo), Member = "get_IsAsciiCasingSameAsInvariant", ReturnType = typeof(bool))]
	[Calls(Type = typeof(TextInfo), Member = "ToUpperInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	public override char ToUpper(char c) { }

	[CallerCount(Count = 0)]
	internal static char ToUpperAsciiInvariant(char c) { }

	[CalledBy(Type = typeof(MemoryExtensions), Member = "ToUpperInvariant", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(System.Span`1<System.Char>)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	internal void ToUpperAsciiInvariant(ReadOnlySpan<Char> source, Span<Char> destination) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "FastAllocateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(RuntimeHelpers), Member = "get_OffsetToStringData", ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private string ToUpperInternal(string str) { }

	[CalledBy(Type = typeof(TextInfo), Member = "ToUpper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(char))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CultureData), Member = "get_IsInvariantCulture", ReturnType = typeof(bool))]
	[ContainsInvalidInstructions]
	private char ToUpperInternal(char c) { }

}

