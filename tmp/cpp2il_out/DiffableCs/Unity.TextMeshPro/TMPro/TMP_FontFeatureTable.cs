namespace TMPro;

public class TMP_FontFeatureTable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<GlyphPairAdjustmentRecord, UInt32> <>9__25_0; //Field offset: 0x8
		public static Func<GlyphPairAdjustmentRecord, UInt32> <>9__25_1; //Field offset: 0x10
		public static Func<MarkToBaseAdjustmentRecord, UInt32> <>9__26_0; //Field offset: 0x18
		public static Func<MarkToBaseAdjustmentRecord, UInt32> <>9__26_1; //Field offset: 0x20
		public static Func<MarkToMarkAdjustmentRecord, UInt32> <>9__27_0; //Field offset: 0x28
		public static Func<MarkToMarkAdjustmentRecord, UInt32> <>9__27_1; //Field offset: 0x30

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GlyphPairAdjustmentRecord), Member = "get_firstAdjustmentRecord", ReturnType = typeof(GlyphAdjustmentRecord))]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		internal uint <SortGlyphPairAdjustmentRecords>b__25_0(GlyphPairAdjustmentRecord s) { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[DeduplicatedMethod]
		internal uint <SortGlyphPairAdjustmentRecords>b__25_1(GlyphPairAdjustmentRecord s) { }

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		internal uint <SortMarkToBaseAdjustmentRecords>b__26_0(MarkToBaseAdjustmentRecord s) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal uint <SortMarkToBaseAdjustmentRecords>b__26_1(MarkToBaseAdjustmentRecord s) { }

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		internal uint <SortMarkToMarkAdjustmentRecords>b__27_0(MarkToMarkAdjustmentRecord s) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal uint <SortMarkToMarkAdjustmentRecords>b__27_1(MarkToMarkAdjustmentRecord s) { }

	}

	[SerializeField]
	internal List<MultipleSubstitutionRecord> m_MultipleSubstitutionRecords; //Field offset: 0x10
	[SerializeField]
	internal List<LigatureSubstitutionRecord> m_LigatureSubstitutionRecords; //Field offset: 0x18
	[SerializeField]
	internal List<GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords; //Field offset: 0x20
	[SerializeField]
	internal List<MarkToBaseAdjustmentRecord> m_MarkToBaseAdjustmentRecords; //Field offset: 0x28
	[SerializeField]
	internal List<MarkToMarkAdjustmentRecord> m_MarkToMarkAdjustmentRecords; //Field offset: 0x30
	internal Dictionary<UInt32, List`1<LigatureSubstitutionRecord>> m_LigatureSubstitutionRecordLookup; //Field offset: 0x38
	internal Dictionary<UInt32, GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookup; //Field offset: 0x40
	internal Dictionary<UInt32, MarkToBaseAdjustmentRecord> m_MarkToBaseAdjustmentRecordLookup; //Field offset: 0x48
	internal Dictionary<UInt32, MarkToMarkAdjustmentRecord> m_MarkToMarkAdjustmentRecordLookup; //Field offset: 0x50

	public List<GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords
	{
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public List<LigatureSubstitutionRecord> ligatureRecords
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 9)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public List<MarkToBaseAdjustmentRecord> MarkToBaseAdjustmentRecords
	{
		[CallerCount(Count = 15)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public List<MarkToMarkAdjustmentRecord> MarkToMarkAdjustmentRecords
	{
		[CallerCount(Count = 62)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	public List<MultipleSubstitutionRecord> multipleSubstitutionRecords
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		 set { } //Length: 13
	}

	[CalledBy(Type = typeof(TMP_FontAsset), Member = "UpdateGlyphAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "UpgradeGlyphAdjustmentTableToFontFeatureTable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 8)]
	public TMP_FontFeatureTable() { }

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public List<GlyphPairAdjustmentRecord> get_glyphPairAdjustmentRecords() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public List<LigatureSubstitutionRecord> get_ligatureRecords() { }

	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	public List<MarkToBaseAdjustmentRecord> get_MarkToBaseAdjustmentRecords() { }

	[CallerCount(Count = 62)]
	[DeduplicatedMethod]
	public List<MarkToMarkAdjustmentRecord> get_MarkToMarkAdjustmentRecords() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public List<MultipleSubstitutionRecord> get_multipleSubstitutionRecords() { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_glyphPairAdjustmentRecords(List<GlyphPairAdjustmentRecord> value) { }

	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_ligatureRecords(List<LigatureSubstitutionRecord> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_MarkToBaseAdjustmentRecords(List<MarkToBaseAdjustmentRecord> value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_MarkToMarkAdjustmentRecords(List<MarkToMarkAdjustmentRecord> value) { }

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public void set_multipleSubstitutionRecords(List<MultipleSubstitutionRecord> value) { }

	[CalledBy(Type = typeof(TMP_FontAsset), Member = "SortFontFeatureTable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "SortAllTables", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Func`2<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord, System.UInt32>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ThenBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.IOrderedEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphPairAdjustmentRecord)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord>)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord>))]
	[CallsUnknownMethods(Count = 4)]
	public void SortGlyphPairAdjustmentRecords() { }

	[CalledBy(Type = typeof(TMP_FontAsset), Member = "SortFontFeatureTable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "SortAllTables", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ThenBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.IOrderedEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarkToBaseAdjustmentRecord)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<TMPro.MarkToBaseAdjustmentRecord>)}, ReturnType = typeof(System.Collections.Generic.List`1<TMPro.MarkToBaseAdjustmentRecord>))]
	[CallsUnknownMethods(Count = 4)]
	public void SortMarkToBaseAdjustmentRecords() { }

	[CalledBy(Type = typeof(TMP_FontAsset), Member = "SortFontFeatureTable", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_FontAsset), Member = "SortAllTables", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "OrderBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ThenBy", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource", "TKey"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.IOrderedEnumerable`1<TSource>", "System.Func`2<TSource, TKey>"}, ReturnType = "System.Linq.IOrderedEnumerable`1<TSource>")]
	[Calls(Type = typeof(Enumerable), Member = "ToList", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MarkToMarkAdjustmentRecord)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<TMPro.MarkToMarkAdjustmentRecord>)}, ReturnType = typeof(System.Collections.Generic.List`1<TMPro.MarkToMarkAdjustmentRecord>))]
	[CallsUnknownMethods(Count = 4)]
	public void SortMarkToMarkAdjustmentRecords() { }

}

