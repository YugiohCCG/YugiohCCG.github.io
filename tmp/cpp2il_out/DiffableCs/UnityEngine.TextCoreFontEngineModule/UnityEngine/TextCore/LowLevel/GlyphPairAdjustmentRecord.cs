namespace UnityEngine.TextCore.LowLevel;

[DebuggerDisplay("First glyphIndex = {m_FirstAdjustmentRecord.m_GlyphIndex},  Second glyphIndex = {m_SecondAdjustmentRecord.m_GlyphIndex}")]
[UsedByNativeCode]
public struct GlyphPairAdjustmentRecord : IEquatable<GlyphPairAdjustmentRecord>
{
	[NativeName("firstAdjustmentRecord")]
	[SerializeField]
	private GlyphAdjustmentRecord m_FirstAdjustmentRecord; //Field offset: 0x0
	[NativeName("secondAdjustmentRecord")]
	[SerializeField]
	private GlyphAdjustmentRecord m_SecondAdjustmentRecord; //Field offset: 0x14
	[SerializeField]
	private FontFeatureLookupFlags m_FeatureLookupFlags; //Field offset: 0x28

	public FontFeatureLookupFlags featureLookupFlags
	{
		[CallerCount(Count = 33)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public GlyphAdjustmentRecord firstAdjustmentRecord
	{
		[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "InitializeGlyphPaidAdjustmentRecordsLookupDictionary", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "AddPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[]"}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "UpdateGlyphAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32[]"}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_FontFeatureTable+<>c", Member = "<SortGlyphPairAdjustmentRecords>b__25_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphPairAdjustmentRecord)}, ReturnType = typeof(uint))]
		[CalledBy(Type = "TMPro.TMP_GlyphPairAdjustmentRecord", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphPairAdjustmentRecord)}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_Text", Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), "TMPro.TextWrappingModes"}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "TMPro.TextMeshPro", Member = "GenerateTextMesh", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "GenerateTextMesh", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.FontFeatureTable+<>c", Member = "<SortGlyphPairAdjustmentRecords>b__24_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphPairAdjustmentRecord)}, ReturnType = typeof(uint))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "InitializeGlyphPairAdjustmentRecordsLookupDictionary", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "AddPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[]"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextInfo", "UnityEngine.TextCore.Text.TextGenerationSettings", typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), "UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.TextCore.Text.TextInfo"}, ReturnType = typeof(Vector2))]
		[CallerCount(Count = 14)]
		 get { } //Length: 16
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public GlyphAdjustmentRecord secondAdjustmentRecord
	{
		[CallerCount(Count = 40)]
		[DeduplicatedMethod]
		 get { } //Length: 17
	}

	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "UpgradeGlyphAdjustmentTableToFontFeatureTable", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public GlyphPairAdjustmentRecord(GlyphAdjustmentRecord firstAdjustmentRecord, GlyphAdjustmentRecord secondAdjustmentRecord) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ExcludeFromDocs]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ExcludeFromDocs]
	public override bool Equals(GlyphPairAdjustmentRecord other) { }

	[CallerCount(Count = 33)]
	[DeduplicatedMethod]
	public FontFeatureLookupFlags get_featureLookupFlags() { }

	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "InitializeGlyphPaidAdjustmentRecordsLookupDictionary", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "AddPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "UpdateGlyphAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_FontFeatureTable+<>c", Member = "<SortGlyphPairAdjustmentRecords>b__25_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphPairAdjustmentRecord)}, ReturnType = typeof(uint))]
	[CalledBy(Type = "TMPro.TMP_GlyphPairAdjustmentRecord", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphPairAdjustmentRecord)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_Text", Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), "TMPro.TextWrappingModes"}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "TMPro.TextMeshPro", Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TextMeshProUGUI", Member = "GenerateTextMesh", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontFeatureTable+<>c", Member = "<SortGlyphPairAdjustmentRecords>b__24_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphPairAdjustmentRecord)}, ReturnType = typeof(uint))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "InitializeGlyphPairAdjustmentRecordsLookupDictionary", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "AddPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord[]"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "ParsingPhase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextInfo", "UnityEngine.TextCore.Text.TextGenerationSettings", typeof(UInt32&), typeof(Single&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextGenerator", Member = "CalculatePreferredValues", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Single&), typeof(Vector2), typeof(bool), "UnityEngine.TextCore.Text.TextGenerationSettings", "UnityEngine.TextCore.Text.TextInfo"}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 14)]
	public GlyphAdjustmentRecord get_firstAdjustmentRecord() { }

	[CallerCount(Count = 40)]
	[DeduplicatedMethod]
	public GlyphAdjustmentRecord get_secondAdjustmentRecord() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ValueType), Member = "GetHashCode", ReturnType = typeof(int))]
	[ExcludeFromDocs]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public void set_firstAdjustmentRecord(GlyphAdjustmentRecord value) { }

}

