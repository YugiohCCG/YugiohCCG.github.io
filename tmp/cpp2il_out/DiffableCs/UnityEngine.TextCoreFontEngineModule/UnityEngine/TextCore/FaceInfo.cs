namespace UnityEngine.TextCore;

[UsedByNativeCode]
public struct FaceInfo
{
	[NativeName("faceIndex")]
	[SerializeField]
	private int m_FaceIndex; //Field offset: 0x0
	[NativeName("familyName")]
	[SerializeField]
	private string m_FamilyName; //Field offset: 0x8
	[NativeName("styleName")]
	[SerializeField]
	private string m_StyleName; //Field offset: 0x10
	[NativeName("pointSize")]
	[SerializeField]
	private float m_PointSize; //Field offset: 0x18
	[NativeName("scale")]
	[SerializeField]
	private float m_Scale; //Field offset: 0x1C
	[NativeName("unitsPerEM")]
	[SerializeField]
	private int m_UnitsPerEM; //Field offset: 0x20
	[NativeName("lineHeight")]
	[SerializeField]
	private float m_LineHeight; //Field offset: 0x24
	[NativeName("ascentLine")]
	[SerializeField]
	private float m_AscentLine; //Field offset: 0x28
	[NativeName("capLine")]
	[SerializeField]
	private float m_CapLine; //Field offset: 0x2C
	[NativeName("meanLine")]
	[SerializeField]
	private float m_MeanLine; //Field offset: 0x30
	[NativeName("baseline")]
	[SerializeField]
	private float m_Baseline; //Field offset: 0x34
	[NativeName("descentLine")]
	[SerializeField]
	private float m_DescentLine; //Field offset: 0x38
	[NativeName("superscriptOffset")]
	[SerializeField]
	private float m_SuperscriptOffset; //Field offset: 0x3C
	[NativeName("superscriptSize")]
	[SerializeField]
	private float m_SuperscriptSize; //Field offset: 0x40
	[NativeName("subscriptOffset")]
	[SerializeField]
	private float m_SubscriptOffset; //Field offset: 0x44
	[NativeName("subscriptSize")]
	[SerializeField]
	private float m_SubscriptSize; //Field offset: 0x48
	[NativeName("underlineOffset")]
	[SerializeField]
	private float m_UnderlineOffset; //Field offset: 0x4C
	[NativeName("underlineThickness")]
	[SerializeField]
	private float m_UnderlineThickness; //Field offset: 0x50
	[NativeName("strikethroughOffset")]
	[SerializeField]
	private float m_StrikethroughOffset; //Field offset: 0x54
	[NativeName("strikethroughThickness")]
	[SerializeField]
	private float m_StrikethroughThickness; //Field offset: 0x58
	[NativeName("tabWidth")]
	[SerializeField]
	private float m_TabWidth; //Field offset: 0x5C

	public float ascentLine
	{
		[CalledBy(Type = "TMPro.TMP_Text", Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), "TMPro.TextWrappingModes"}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "TMPro.TextMeshPro", Member = "GenerateTextMesh", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "GenerateTextMesh", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextInfo", "UnityEngine.TextCore.Text.TextGenerationSettings", typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), "UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.TextCore.Text.TextInfo"}, ReturnType = typeof(Vector2))]
		[CallerCount(Count = 25)]
		 get { } //Length: 8
	}

	public float baseline
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public float capLine
	{
		[CallerCount(Count = 18)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float descentLine
	{
		[CallerCount(Count = 41)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
	internal int faceIndex
	{
		[CallerCount(Count = 262)]
		[DeduplicatedMethod]
		internal get { } //Length: 5
	}

	public string familyName
	{
		[CallerCount(Count = 27)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public float lineHeight
	{
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public float meanLine
	{
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float pointSize
	{
		[CallerCount(Count = 63)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public float scale
	{
		[CallerCount(Count = 57)]
		[DeduplicatedMethod]
		 get { } //Length: 8
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public float strikethroughOffset
	{
		[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "LayoutPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextInfo", "UnityEngine.TextCore.Text.TextGenerationSettings", typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		 get { } //Length: 8
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	public string styleName
	{
		[CallerCount(Count = 206)]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	public float subscriptOffset
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public float subscriptSize
	{
		[CallerCount(Count = 8)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public float superscriptOffset
	{
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public float superscriptSize
	{
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public float tabWidth
	{
		[CalledBy(Type = "TMPro.TMP_Text", Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), "TMPro.TextWrappingModes"}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), "UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.TextCore.Text.TextInfo"}, ReturnType = typeof(Vector2))]
		[CallerCount(Count = 2)]
		 get { } //Length: 8
	}

	public float underlineOffset
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public float underlineThickness
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
	internal int unitsPerEM
	{
		[CallerCount(Count = 30)]
		[DeduplicatedMethod]
		internal get { } //Length: 6
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		internal set { } //Length: 4
	}

	[CalledBy(Type = "TMPro.TMP_Text", Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), "TMPro.TextWrappingModes"}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextInfo", "UnityEngine.TextCore.Text.TextGenerationSettings", typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), "UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.TextCore.Text.TextInfo"}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 25)]
	public float get_ascentLine() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public float get_baseline() { }

	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	public float get_capLine() { }

	[CallerCount(Count = 41)]
	[DeduplicatedMethod]
	public float get_descentLine() { }

	[CallerCount(Count = 262)]
	[DeduplicatedMethod]
	internal int get_faceIndex() { }

	[CallerCount(Count = 27)]
	[DeduplicatedMethod]
	public string get_familyName() { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public float get_lineHeight() { }

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public float get_meanLine() { }

	[CallerCount(Count = 63)]
	[DeduplicatedMethod]
	public float get_pointSize() { }

	[CallerCount(Count = 57)]
	[DeduplicatedMethod]
	public float get_scale() { }

	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "LayoutPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextInfo", "UnityEngine.TextCore.Text.TextGenerationSettings", typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	public float get_strikethroughOffset() { }

	[CallerCount(Count = 206)]
	[DeduplicatedMethod]
	public string get_styleName() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public float get_subscriptOffset() { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public float get_subscriptSize() { }

	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public float get_superscriptOffset() { }

	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	public float get_superscriptSize() { }

	[CalledBy(Type = "TMPro.TMP_Text", Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), "TMPro.TextWrappingModes"}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), "UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.TextCore.Text.TextInfo"}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 2)]
	public float get_tabWidth() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public float get_underlineOffset() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public float get_underlineThickness() { }

	[CallerCount(Count = 30)]
	[DeduplicatedMethod]
	internal int get_unitsPerEM() { }

	[CallerCount(Count = 8)]
	[DeduplicatedMethod]
	public void set_capLine(float value) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void set_meanLine(float value) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void set_scale(float value) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void set_strikethroughOffset(float value) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	internal void set_unitsPerEM(int value) { }

}

