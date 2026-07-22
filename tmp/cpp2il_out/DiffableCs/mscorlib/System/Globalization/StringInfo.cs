namespace System.Globalization;

[ComVisible(True)]
public class StringInfo
{
	[OptionalField(VersionAdded = 2)]
	private string m_str; //Field offset: 0x10
	private Int32[] m_indexes; //Field offset: 0x18

	private Int32[] Indexes
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StringInfo), Member = "ParseCombiningCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Int32[]))]
		[CallsUnknownMethods(Count = 2)]
		private get { } //Length: 72
	}

	public int LengthInTextElements
	{
		[CalledBy(Type = "UnityEngine.TextEditingUtilities", Member = "ReplaceSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(StringInfo), Member = "ParseCombiningCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Int32[]))]
		[CallsUnknownMethods(Count = 2)]
		 get { } //Length: 90
	}

	public string String
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		 set { } //Length: 161
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public StringInfo() { }

	[CalledBy(Type = "UnityEngine.TextEditingUtilities", Member = "ReplaceSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public StringInfo(string value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	[ComVisible(False)]
	public virtual bool Equals(object value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringInfo), Member = "ParseCombiningCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Int32[]))]
	[CallsUnknownMethods(Count = 2)]
	private Int32[] get_Indexes() { }

	[CalledBy(Type = "UnityEngine.TextEditingUtilities", Member = "ReplaceSelection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StringInfo), Member = "ParseCombiningCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Int32[]))]
	[CallsUnknownMethods(Count = 2)]
	public int get_LengthInTextElements() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public string get_String() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CharUnicodeInfo), Member = "InternalGetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(Int32&)}, ReturnType = typeof(UnicodeCategory))]
	[Calls(Type = typeof(CharUnicodeInfo), Member = "IsCombiningCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnicodeCategory)}, ReturnType = typeof(bool))]
	internal static int GetCurrentTextElementLen(string str, int index, int len, ref UnicodeCategory ucCurrent, ref int currentCharCount) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ComVisible(False)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[OnDeserialized]
	private void OnDeserialized(StreamingContext ctx) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[OnDeserializing]
	private void OnDeserializing(StreamingContext ctx) { }

	[CalledBy(Type = typeof(StringInfo), Member = "get_Indexes", ReturnType = typeof(Int32[]))]
	[CalledBy(Type = typeof(StringInfo), Member = "get_LengthInTextElements", ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CharUnicodeInfo), Member = "InternalGetUnicodeCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(Int32&)}, ReturnType = typeof(UnicodeCategory))]
	[Calls(Type = typeof(CharUnicodeInfo), Member = "IsCombiningCategory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnicodeCategory)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	public static Int32[] ParseCombiningCharacters(string str) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public void set_String(string value) { }

}

