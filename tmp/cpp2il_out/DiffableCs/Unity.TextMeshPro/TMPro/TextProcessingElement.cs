namespace TMPro;

[DebuggerDisplay("{DebuggerDisplay()}")]
internal struct TextProcessingElement
{
	private TextProcessingElementType m_ElementType; //Field offset: 0x0
	private int m_StartIndex; //Field offset: 0x4
	private int m_Length; //Field offset: 0x8
	private CharacterElement m_CharacterElement; //Field offset: 0x10
	private MarkupElement m_MarkupElement; //Field offset: 0x20

	public CharacterElement CharacterElement
	{
		[CallerCount(Count = 17)]
		[DeduplicatedMethod]
		 get { } //Length: 11
	}

	public TextProcessingElementType ElementType
	{
		[CallerCount(Count = 173)]
		[DeduplicatedMethod]
		 get { } //Length: 3
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		 set { } //Length: 3
	}

	public int Length
	{
		[CallerCount(Count = 28)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public MarkupElement MarkupElement
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		 set { } //Length: 15
	}

	public int StartIndex
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public static TextProcessingElement Undefined
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 20
	}

	[CallerCount(Count = 0)]
	public TextProcessingElement(TextProcessingElementType elementType, int startIndex, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CharacterElement), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TMP_TextElement)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	public TextProcessingElement(TMP_TextElement textElement, int startIndex, int length) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public TextProcessingElement(CharacterElement characterElement, int startIndex, int length) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public TextProcessingElement(MarkupElement markupElement) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	private string DebuggerDisplay() { }

	[CallerCount(Count = 17)]
	[DeduplicatedMethod]
	public CharacterElement get_CharacterElement() { }

	[CallerCount(Count = 173)]
	[DeduplicatedMethod]
	public TextProcessingElementType get_ElementType() { }

	[CallerCount(Count = 28)]
	[DeduplicatedMethod]
	public int get_Length() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public MarkupElement get_MarkupElement() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public int get_StartIndex() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static TextProcessingElement get_Undefined() { }

	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	public void set_ElementType(TextProcessingElementType value) { }

	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	public void set_Length(int value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void set_MarkupElement(MarkupElement value) { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public void set_StartIndex(int value) { }

}

