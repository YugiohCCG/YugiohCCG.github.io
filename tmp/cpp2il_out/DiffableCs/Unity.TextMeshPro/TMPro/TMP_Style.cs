namespace TMPro;

public class TMP_Style
{
	internal static TMP_Style k_NormalStyle; //Field offset: 0x0
	[SerializeField]
	private string m_Name; //Field offset: 0x10
	[SerializeField]
	private int m_HashCode; //Field offset: 0x18
	[SerializeField]
	private string m_OpeningDefinition; //Field offset: 0x20
	[SerializeField]
	private string m_ClosingDefinition; //Field offset: 0x28
	[SerializeField]
	private UInt32[] m_OpeningTagArray; //Field offset: 0x30
	[SerializeField]
	private UInt32[] m_ClosingTagArray; //Field offset: 0x38

	public int hashCode
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		 set { } //Length: 9
	}

	public string name
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 62
	}

	public static TMP_Style NormalStyle
	{
		[CalledBy(Type = typeof(TMP_Text), Member = "get_textStyle", ReturnType = typeof(TMP_Style))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(TMP_Style), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 214
	}

	public string styleClosingDefinition
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public UInt32[] styleClosingTagArray
	{
		[CallerCount(Count = 38)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public string styleOpeningDefinition
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public UInt32[] styleOpeningTagArray
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = typeof(TMP_Style), Member = "get_NormalStyle", ReturnType = typeof(TMP_Style))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_TextParsingUtilities), Member = "GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TMP_Style), Member = "RefreshStyle", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal TMP_Style(string styleName, string styleOpeningDefinition, string styleClosingDefinition) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public int get_hashCode() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public string get_name() { }

	[CalledBy(Type = typeof(TMP_Text), Member = "get_textStyle", ReturnType = typeof(TMP_Style))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TMP_Style), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public static TMP_Style get_NormalStyle() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public string get_styleClosingDefinition() { }

	[CallerCount(Count = 38)]
	[DeduplicatedMethod]
	public UInt32[] get_styleClosingTagArray() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public string get_styleOpeningDefinition() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public UInt32[] get_styleOpeningTagArray() { }

	[CalledBy(Type = typeof(TMP_Style), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_StyleSheet), Member = "LoadStyleDictionaryInternal", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TMP_TextParsingUtilities), Member = "GetHashCode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 4)]
	public void RefreshStyle() { }

	[CallerCount(Count = 0)]
	public void set_hashCode(int value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public void set_name(string value) { }

}

