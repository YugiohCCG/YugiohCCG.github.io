namespace UnityEngine.UI;

public struct ColorBlock : IEquatable<ColorBlock>
{
	public static ColorBlock defaultColorBlock; //Field offset: 0x0
	[FormerlySerializedAs("normalColor")]
	[SerializeField]
	private Color m_NormalColor; //Field offset: 0x0
	[FormerlySerializedAs("highlightedColor")]
	[SerializeField]
	private Color m_HighlightedColor; //Field offset: 0x10
	[FormerlySerializedAs("pressedColor")]
	[SerializeField]
	private Color m_PressedColor; //Field offset: 0x20
	[FormerlySerializedAs("m_HighlightedColor")]
	[SerializeField]
	private Color m_SelectedColor; //Field offset: 0x30
	[FormerlySerializedAs("disabledColor")]
	[SerializeField]
	private Color m_DisabledColor; //Field offset: 0x40
	[Range(1, 5)]
	[SerializeField]
	private float m_ColorMultiplier; //Field offset: 0x50
	[FormerlySerializedAs("fadeDuration")]
	[SerializeField]
	private float m_FadeDuration; //Field offset: 0x54

	public float colorMultiplier
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public Color disabledColor
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 8
	}

	public float fadeDuration
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public Color highlightedColor
	{
		[CallerCount(Count = 17)]
		[DeduplicatedMethod]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 8
	}

	public Color normalColor
	{
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		 get { } //Length: 10
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 set { } //Length: 7
	}

	public Color pressedColor
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 8
	}

	public Color selectedColor
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 get { } //Length: 11
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		 set { } //Length: 8
	}

	[CallerCount(Count = 0)]
	private static ColorBlock() { }

	[CalledBy(Type = typeof(ColorBlock), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ColorBlock), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorBlock), typeof(ColorBlock)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ColorBlock), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorBlock), typeof(ColorBlock)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(ColorBlock other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ColorBlock), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorBlock)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_colorMultiplier() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Color get_disabledColor() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public float get_fadeDuration() { }

	[CallerCount(Count = 17)]
	[DeduplicatedMethod]
	public Color get_highlightedColor() { }

	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	public Color get_normalColor() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Color get_pressedColor() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Color get_selectedColor() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValueType), Member = "GetHashCode", ReturnType = typeof(int))]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ColorBlock), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorBlock)}, ReturnType = typeof(bool))]
	public static bool op_Equality(ColorBlock point1, ColorBlock point2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ColorBlock), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ColorBlock)}, ReturnType = typeof(bool))]
	public static bool op_Inequality(ColorBlock point1, ColorBlock point2) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_colorMultiplier(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_disabledColor(Color value) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void set_fadeDuration(float value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_highlightedColor(Color value) { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public void set_normalColor(Color value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_pressedColor(Color value) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void set_selectedColor(Color value) { }

}

