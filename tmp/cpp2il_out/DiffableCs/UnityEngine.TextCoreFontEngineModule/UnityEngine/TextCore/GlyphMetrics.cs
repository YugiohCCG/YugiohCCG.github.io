namespace UnityEngine.TextCore;

[UsedByNativeCode]
public struct GlyphMetrics : IEquatable<GlyphMetrics>
{
	[NativeName("width")]
	[SerializeField]
	private float m_Width; //Field offset: 0x0
	[NativeName("height")]
	[SerializeField]
	private float m_Height; //Field offset: 0x4
	[NativeName("horizontalBearingX")]
	[SerializeField]
	private float m_HorizontalBearingX; //Field offset: 0x8
	[NativeName("horizontalBearingY")]
	[SerializeField]
	private float m_HorizontalBearingY; //Field offset: 0xC
	[NativeName("horizontalAdvance")]
	[SerializeField]
	private float m_HorizontalAdvance; //Field offset: 0x10

	public float height
	{
		[CallerCount(Count = 83)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
		[Calls(Type = "UnityEngine.UnityString", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 15)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 742
	}

	public float horizontalAdvance
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public float horizontalBearingX
	{
		[CallerCount(Count = 47)]
		[DeduplicatedMethod]
		 get { } //Length: 85
	}

	public float horizontalBearingY
	{
		[CallerCount(Count = 32)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public float width
	{
		[CallerCount(Count = 84)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "AddSynthesizedCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_SpriteAsset", Member = "UpgradeSpriteAsset", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "AddSynthesizedCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	public GlyphMetrics(float width, float height, float bearingX, float bearingY, float advance) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override bool Equals(GlyphMetrics other) { }

	[CallerCount(Count = 83)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = "UnityEngine.UnityString", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public float get_height() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public float get_horizontalAdvance() { }

	[CallerCount(Count = 47)]
	[DeduplicatedMethod]
	public float get_horizontalBearingX() { }

	[CallerCount(Count = 32)]
	[DeduplicatedMethod]
	public float get_horizontalBearingY() { }

	[CallerCount(Count = 84)]
	[DeduplicatedMethod]
	public float get_width() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValueType), Member = "GetHashCode", ReturnType = typeof(int))]
	public virtual int GetHashCode() { }

}

