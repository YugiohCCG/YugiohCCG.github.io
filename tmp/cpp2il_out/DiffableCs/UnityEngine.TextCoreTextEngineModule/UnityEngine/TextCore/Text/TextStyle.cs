namespace UnityEngine.TextCore.Text;

public class TextStyle
{
	internal static TextStyle k_NormalStyle; //Field offset: 0x0
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
	[SerializeField]
	internal UInt32[] m_OpeningTagUnicodeArray; //Field offset: 0x40
	[SerializeField]
	internal UInt32[] m_ClosingTagUnicodeArray; //Field offset: 0x48

	public int hashCode
	{
		[CallerCount(Count = 42)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public UInt32[] styleClosingTagArray
	{
		[CallerCount(Count = 35)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public UInt32[] styleOpeningTagArray
	{
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextUtilities), Member = "GetHashCodeCaseInSensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(TextStyle), Member = "RefreshStyle", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	internal TextStyle(string styleName, string styleOpeningDefinition, string styleClosingDefinition) { }

	[CallerCount(Count = 42)]
	[DeduplicatedMethod]
	public int get_hashCode() { }

	[CallerCount(Count = 35)]
	[DeduplicatedMethod]
	public UInt32[] get_styleClosingTagArray() { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public UInt32[] get_styleOpeningTagArray() { }

	[CalledBy(Type = typeof(TextStyle), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextStyleSheet), Member = "LoadStyleDictionaryInternal", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(TextUtilities), Member = "GetHashCodeCaseInSensitive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(char))]
	[CallsUnknownMethods(Count = 6)]
	public void RefreshStyle() { }

}

