namespace UnityEngine.UI;

public class FontData : ISerializationCallbackReceiver
{
	[FormerlySerializedAs("font")]
	[SerializeField]
	private Font m_Font; //Field offset: 0x10
	[FormerlySerializedAs("fontSize")]
	[SerializeField]
	private int m_FontSize; //Field offset: 0x18
	[FormerlySerializedAs("fontStyle")]
	[SerializeField]
	private FontStyle m_FontStyle; //Field offset: 0x1C
	[SerializeField]
	private bool m_BestFit; //Field offset: 0x20
	[SerializeField]
	private int m_MinSize; //Field offset: 0x24
	[SerializeField]
	private int m_MaxSize; //Field offset: 0x28
	[FormerlySerializedAs("alignment")]
	[SerializeField]
	private TextAnchor m_Alignment; //Field offset: 0x2C
	[SerializeField]
	private bool m_AlignByGeometry; //Field offset: 0x30
	[FormerlySerializedAs("richText")]
	[SerializeField]
	private bool m_RichText; //Field offset: 0x31
	[SerializeField]
	private HorizontalWrapMode m_HorizontalOverflow; //Field offset: 0x34
	[SerializeField]
	private VerticalWrapMode m_VerticalOverflow; //Field offset: 0x38
	[SerializeField]
	private float m_LineSpacing; //Field offset: 0x3C

	public bool alignByGeometry
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public TextAnchor alignment
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public bool bestFit
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public static FontData defaultFontData
	{
		[CalledBy(Type = typeof(Text), Member = ".ctor", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 123
	}

	public Font font
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public int fontSize
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public FontStyle fontStyle
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public HorizontalWrapMode horizontalOverflow
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public float lineSpacing
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public int maxSize
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public int minSize
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public bool richText
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public VerticalWrapMode verticalOverflow
	{
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public FontData() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public bool get_alignByGeometry() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public TextAnchor get_alignment() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_bestFit() { }

	[CalledBy(Type = typeof(Text), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static FontData get_defaultFontData() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public Font get_font() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public int get_fontSize() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public FontStyle get_fontStyle() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public HorizontalWrapMode get_horizontalOverflow() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_lineSpacing() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public int get_maxSize() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public int get_minSize() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public bool get_richText() { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public VerticalWrapMode get_verticalOverflow() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_alignByGeometry(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_alignment(TextAnchor value) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public void set_bestFit(bool value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_font(Font value) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public void set_fontSize(int value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_fontStyle(FontStyle value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_horizontalOverflow(HorizontalWrapMode value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_lineSpacing(float value) { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public void set_maxSize(int value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_minSize(int value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_richText(bool value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_verticalOverflow(VerticalWrapMode value) { }

	[CallerCount(Count = 0)]
	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	[CallerCount(Count = 13327)]
	[DeduplicatedMethod]
	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

}

