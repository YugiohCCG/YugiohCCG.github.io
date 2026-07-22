namespace UnityEngine.TextCore;

[UsedByNativeCode]
public class Glyph
{
	[NativeName("index")]
	[SerializeField]
	private uint m_Index; //Field offset: 0x10
	[NativeName("metrics")]
	[SerializeField]
	private GlyphMetrics m_Metrics; //Field offset: 0x14
	[NativeName("glyphRect")]
	[SerializeField]
	private GlyphRect m_GlyphRect; //Field offset: 0x28
	[NativeName("scale")]
	[SerializeField]
	private float m_Scale; //Field offset: 0x38
	[NativeName("atlasIndex")]
	[SerializeField]
	private int m_AtlasIndex; //Field offset: 0x3C
	[NativeName("type")]
	[SerializeField]
	private GlyphClassDefinitionType m_ClassDefinitionType; //Field offset: 0x40

	public int atlasIndex
	{
		[CalledBy(Type = "TMPro.TextMeshPro", Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TextProcessingElement[]"}, ReturnType = typeof(int))]
		[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TextProcessingElement[]"}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextProcessingElement[]", "UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.TextCore.Text.TextInfo"}, ReturnType = typeof(int))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "PopulateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.TextCore.Text.TextProcessingElement[]"}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextLib", Member = "ProcessMeshInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.NativeTextInfo", "UnityEngine.TextCore.NativeTextGenerationSettings"}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		 get { } //Length: 6
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public GlyphRect glyphRect
	{
		[CallerCount(Count = 21)]
		[DeduplicatedMethod]
		 get { } //Length: 11
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 set { } //Length: 8
	}

	public uint index
	{
		[CallerCount(Count = 59)]
		[DeduplicatedMethod]
		 get { } //Length: 6
		[CallerCount(Count = 7)]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public GlyphMetrics metrics
	{
		[CallerCount(Count = 40)]
		[DeduplicatedMethod]
		 get { } //Length: 17
		[CalledBy(Type = "TMPro.TMP_SpriteAsset", Member = "UpgradeSpriteAsset", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_SpriteGlyph", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(GlyphMetrics), typeof(GlyphRect), typeof(float), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_SpriteGlyph", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(GlyphMetrics), typeof(GlyphRect), typeof(float), typeof(int), typeof(Sprite)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		 set { } //Length: 14
	}

	public float scale
	{
		[CallerCount(Count = 41)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	[CalledBy(Type = "TMPro.TMP_SpriteAsset", Member = "UpgradeSpriteAsset", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_SpriteGlyph", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_SpriteGlyph", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(GlyphMetrics), typeof(GlyphRect), typeof(float), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_SpriteGlyph", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(GlyphMetrics), typeof(GlyphRect), typeof(float), typeof(int), typeof(Sprite)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.SpriteGlyph", Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Glyph() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal Glyph(GlyphMarshallingStruct glyphStruct) { }

	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "AddSynthesizedCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "AddSynthesizedCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Glyph(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex) { }

	[CalledBy(Type = "TMPro.TextMeshPro", Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TextProcessingElement[]"}, ReturnType = typeof(int))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TextProcessingElement[]"}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "SetArraySizes", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextProcessingElement[]", "UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.TextCore.Text.TextInfo"}, ReturnType = typeof(int))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "PopulateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.TextCore.Text.TextProcessingElement[]"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextLib", Member = "ProcessMeshInfos", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.NativeTextInfo", "UnityEngine.TextCore.NativeTextGenerationSettings"}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	public int get_atlasIndex() { }

	[CallerCount(Count = 21)]
	[DeduplicatedMethod]
	public GlyphRect get_glyphRect() { }

	[CallerCount(Count = 59)]
	[DeduplicatedMethod]
	public uint get_index() { }

	[CallerCount(Count = 40)]
	[DeduplicatedMethod]
	public GlyphMetrics get_metrics() { }

	[CallerCount(Count = 41)]
	[DeduplicatedMethod]
	public float get_scale() { }

	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	public void set_atlasIndex(int value) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public void set_glyphRect(GlyphRect value) { }

	[CallerCount(Count = 7)]
	[DeduplicatedMethod]
	public void set_index(uint value) { }

	[CalledBy(Type = "TMPro.TMP_SpriteAsset", Member = "UpgradeSpriteAsset", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_SpriteGlyph", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(GlyphMetrics), typeof(GlyphRect), typeof(float), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_SpriteGlyph", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(GlyphMetrics), typeof(GlyphRect), typeof(float), typeof(int), typeof(Sprite)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	public void set_metrics(GlyphMetrics value) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public void set_scale(float value) { }

}

