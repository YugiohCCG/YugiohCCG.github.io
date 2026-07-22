namespace TMPro;

internal struct CharacterElement
{
	private uint m_Unicode; //Field offset: 0x0
	private TMP_TextElement m_TextElement; //Field offset: 0x8

	public uint Unicode
	{
		[CallerCount(Count = 173)]
		[DeduplicatedMethod]
		 get { } //Length: 3
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		 set { } //Length: 3
	}

	[CalledBy(Type = typeof(TextProcessingElement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_TextElement), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public CharacterElement(TMP_TextElement textElement) { }

	[CallerCount(Count = 173)]
	[DeduplicatedMethod]
	public uint get_Unicode() { }

	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	public void set_Unicode(uint value) { }

}

