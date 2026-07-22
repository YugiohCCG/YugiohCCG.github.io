namespace UnityEngine.TextCore;

[UsedByNativeCode]
public struct GlyphRect : IEquatable<GlyphRect>
{
	private static readonly GlyphRect s_ZeroGlyphRect; //Field offset: 0x0
	[NativeName("x")]
	[SerializeField]
	private int m_X; //Field offset: 0x0
	[NativeName("y")]
	[SerializeField]
	private int m_Y; //Field offset: 0x4
	[NativeName("width")]
	[SerializeField]
	private int m_Width; //Field offset: 0x8
	[NativeName("height")]
	[SerializeField]
	private int m_Height; //Field offset: 0xC

	public int height
	{
		[CallerCount(Count = 118)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public int width
	{
		[CallerCount(Count = 45)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public int x
	{
		[CallerCount(Count = 262)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public int y
	{
		[CallerCount(Count = 57)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public static GlyphRect zero
	{
		[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "AddSynthesizedCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "AddSynthesizedCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		 get { } //Length: 96
	}

	[CallerCount(Count = 0)]
	private static GlyphRect() { }

	[CallerCount(Count = 19)]
	[DeduplicatedMethod]
	public GlyphRect(int x, int y, int width, int height) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override bool Equals(GlyphRect other) { }

	[CallerCount(Count = 118)]
	[DeduplicatedMethod]
	public int get_height() { }

	[CallerCount(Count = 45)]
	[DeduplicatedMethod]
	public int get_width() { }

	[CallerCount(Count = 262)]
	[DeduplicatedMethod]
	public int get_x() { }

	[CallerCount(Count = 57)]
	[DeduplicatedMethod]
	public int get_y() { }

	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "AddSynthesizedCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "AddSynthesizedCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	public static GlyphRect get_zero() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValueType), Member = "GetHashCode", ReturnType = typeof(int))]
	public virtual int GetHashCode() { }

}

