namespace UnityEngine.TextCore.LowLevel;

[NativeHeader("Modules/TextCoreFontEngine/Native/FontEngine.h")]
public sealed class FontEngine
{
	private static Glyph[] s_Glyphs; //Field offset: 0x0
	private static UInt32[] s_GlyphIndexes_MarshallingArray_A; //Field offset: 0x8
	private static GlyphMarshallingStruct[] s_GlyphMarshallingStruct_IN; //Field offset: 0x10
	private static GlyphMarshallingStruct[] s_GlyphMarshallingStruct_OUT; //Field offset: 0x18
	private static GlyphRect[] s_FreeGlyphRects; //Field offset: 0x20
	private static GlyphRect[] s_UsedGlyphRects; //Field offset: 0x28
	private static LigatureSubstitutionRecord[] s_LigatureSubstitutionRecords_MarshallingArray; //Field offset: 0x30
	private static GlyphPairAdjustmentRecord[] s_PairAdjustmentRecords_MarshallingArray; //Field offset: 0x38
	private static MarkToBaseAdjustmentRecord[] s_MarkToBaseAdjustmentRecords_MarshallingArray; //Field offset: 0x40
	private static MarkToMarkAdjustmentRecord[] s_MarkToMarkAdjustmentRecords_MarshallingArray; //Field offset: 0x48
	private static Dictionary<UInt32, Glyph> s_GlyphLookupDictionary; //Field offset: 0x50

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private static FontEngine() { }

	[CalledBy(Type = typeof(FontEngine), Member = "GetLigatureSubstitutionRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>)}, ReturnType = typeof(LigatureSubstitutionRecord[]))]
	[CalledBy(Type = typeof(FontEngine), Member = "GetPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>)}, ReturnType = typeof(GlyphPairAdjustmentRecord[]))]
	[CalledBy(Type = typeof(FontEngine), Member = "GetMarkToBaseAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>)}, ReturnType = typeof(MarkToBaseAdjustmentRecord[]))]
	[CalledBy(Type = typeof(FontEngine), Member = "GetMarkToMarkAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>)}, ReturnType = typeof(MarkToMarkAdjustmentRecord[]))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 5)]
	[DeduplicatedMethod]
	private static void GenericListToMarshallingArray(ref List<T>& srcList, ref T[] dstArray) { }

	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "InitializeDictionaryLookupTables", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "ImportFontFeatures", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "InitializeDictionaryLookupTables", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "ImportFontFeatures", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "TextCore::FontEngine::GetAllLigatureSubstitutionRecords", IsThreadSafe = True, IsFreeFunction = True)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
	internal static LigatureSubstitutionRecord[] GetAllLigatureSubstitutionRecords() { }

	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "InitializeDictionaryLookupTables", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "ImportFontFeatures", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "InitializeDictionaryLookupTables", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "ImportFontFeatures", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	[NativeMethod(Name = "TextCore::FontEngine::GetAllMarkToBaseAdjustmentRecords", IsThreadSafe = True, IsFreeFunction = True)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
	internal static MarkToBaseAdjustmentRecord[] GetAllMarkToBaseAdjustmentRecords() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetAllMarkToBaseAdjustmentRecords_Injected(out BlittableArrayWrapper ret) { }

	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "InitializeDictionaryLookupTables", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "ImportFontFeatures", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "InitializeDictionaryLookupTables", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "ImportFontFeatures", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	[NativeMethod(Name = "TextCore::FontEngine::GetAllMarkToMarkAdjustmentRecords", IsThreadSafe = True, IsFreeFunction = True)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
	internal static MarkToMarkAdjustmentRecord[] GetAllMarkToMarkAdjustmentRecords() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetAllMarkToMarkAdjustmentRecords_Injected(out BlittableArrayWrapper ret) { }

	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "InitializeDictionaryLookupTables", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "ImportFontFeatures", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "InitializeDictionaryLookupTables", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "ImportFontFeatures", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	[NativeMethod(Name = "TextCore::FontEngine::GetAllPairAdjustmentRecords", IsThreadSafe = True, IsFreeFunction = True)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
	internal static GlyphPairAdjustmentRecord[] GetAllPairAdjustmentRecords() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetAllPairAdjustmentRecords_Injected(out BlittableArrayWrapper ret) { }

	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "CreateFontAssetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), "TMPro.AtlasPopulationMode", typeof(bool)}, ReturnType = "TMPro.TMP_FontAsset")]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "CreateFontAssetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), "UnityEngine.TextCore.Text.AtlasPopulationMode", typeof(bool)}, ReturnType = "UnityEngine.TextCore.Text.FontAsset")]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "ReadFontAssetDefinition", ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public static FaceInfo GetFaceInfo() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "TextCore::FontEngine::GetFaceInfo", IsThreadSafe = True, IsFreeFunction = True)]
	private static int GetFaceInfo_Internal(ref FaceInfo faceInfo) { }

	[CalledBy(Type = "TMPro.TMP_DynamicFontAssetUtilities", Member = "InitializeSystemFontReferenceCache", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static String[] GetFontFaces() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "TextCore::FontEngine::GetFontFaces", IsThreadSafe = True, IsFreeFunction = True)]
	private static String[] GetFontFaces_Internal() { }

	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "AddSynthesizedCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "GetGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32[]", "System.UInt32[]&", typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "TryAddCharacterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), "TMPro.TMP_Character&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "TryGetCharacter_and_QueueRenderToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), "TMPro.TMP_Character&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "AddSynthesizedCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "GetGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(uint))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "GetGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Boolean&)}, ReturnType = typeof(uint))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32[]", "System.UInt32[]&", typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "TryAddCharacterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), "UnityEngine.TextCore.Text.FontStyles", "UnityEngine.TextCore.Text.TextFontWeight", "UnityEngine.TextCore.Text.Character&", typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 19)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "TextCore::FontEngine::GetGlyphIndex", IsThreadSafe = True, IsFreeFunction = True)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
	internal static uint GetGlyphIndex(uint unicode) { }

	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "UpdateGlyphAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FontEngine), Member = "SetMarshallingArraySize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetPairAdjustmentRecordsFromMarshallingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord>)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
	internal static GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentTable(UInt32[] glyphIndexes) { }

	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "UpdateFontFeaturesForNewlyAddedGlyphs", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "UpdateLigatureSubstitutionRecords", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32[]", "System.UInt32[]&", typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "UpdateFontFeaturesForNewlyAddedGlyphs", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "UpdateLigatureSubstitutionRecords", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(FontEngine), Member = "GenericListToMarshallingArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>&", "T[]&"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetLigatureSubstitutionRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[])}, ReturnType = typeof(LigatureSubstitutionRecord[]))]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
	internal static LigatureSubstitutionRecord[] GetLigatureSubstitutionRecords(List<UInt32> glyphIndexes) { }

	[CalledBy(Type = typeof(FontEngine), Member = "GetLigatureSubstitutionRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>)}, ReturnType = typeof(LigatureSubstitutionRecord[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FontEngine), Member = "SetMarshallingArraySize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private static LigatureSubstitutionRecord[] GetLigatureSubstitutionRecords(UInt32[] glyphIndexes) { }

	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "UpdateGSUBFontFeaturesForNewGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "TryAddGlyphToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Glyph&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "UpdateGSUBFontFeaturesForNewGlyphIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsInvalidInstructions]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
	internal static LigatureSubstitutionRecord[] GetLigatureSubstitutionRecords(uint glyphIndex) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "TextCore::FontEngine::GetLigatureSubstitutionRecordsFromMarshallingArray", IsFreeFunction = True)]
	private static int GetLigatureSubstitutionRecordsFromMarshallingArray(out LigatureSubstitutionRecord[] ligatureSubstitutionRecords) { }

	[CalledBy(Type = typeof(FontEngine), Member = "GetMarkToBaseAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>)}, ReturnType = typeof(MarkToBaseAdjustmentRecord[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FontEngine), Member = "SetMarshallingArraySize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	private static MarkToBaseAdjustmentRecord[] GetMarkToBaseAdjustmentRecords(UInt32[] glyphIndexes) { }

	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "UpdateDiacriticalMarkAdjustmentRecords", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "UpdateDiacriticalMarkAdjustmentRecords", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FontEngine), Member = "GenericListToMarshallingArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>&", "T[]&"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetMarkToBaseAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[])}, ReturnType = typeof(MarkToBaseAdjustmentRecord[]))]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
	internal static MarkToBaseAdjustmentRecord[] GetMarkToBaseAdjustmentRecords(List<UInt32> glyphIndexes) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "TextCore::FontEngine::GetMarkToBaseAdjustmentRecordsFromMarshallingArray", IsFreeFunction = True)]
	private static int GetMarkToBaseAdjustmentRecordsFromMarshallingArray(Span<MarkToBaseAdjustmentRecord> adjustmentRecords) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int GetMarkToBaseAdjustmentRecordsFromMarshallingArray_Injected(ref ManagedSpanWrapper adjustmentRecords) { }

	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "UpdateDiacriticalMarkAdjustmentRecords", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "UpdateDiacriticalMarkAdjustmentRecords", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(FontEngine), Member = "GenericListToMarshallingArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>&", "T[]&"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetMarkToMarkAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[])}, ReturnType = typeof(MarkToMarkAdjustmentRecord[]))]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
	internal static MarkToMarkAdjustmentRecord[] GetMarkToMarkAdjustmentRecords(List<UInt32> glyphIndexes) { }

	[CalledBy(Type = typeof(FontEngine), Member = "GetMarkToMarkAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>)}, ReturnType = typeof(MarkToMarkAdjustmentRecord[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FontEngine), Member = "SetMarshallingArraySize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	private static MarkToMarkAdjustmentRecord[] GetMarkToMarkAdjustmentRecords(UInt32[] glyphIndexes) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "TextCore::FontEngine::GetMarkToMarkAdjustmentRecordsFromMarshallingArray", IsFreeFunction = True)]
	private static int GetMarkToMarkAdjustmentRecordsFromMarshallingArray(Span<MarkToMarkAdjustmentRecord> adjustmentRecords) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int GetMarkToMarkAdjustmentRecordsFromMarshallingArray_Injected(ref ManagedSpanWrapper adjustmentRecords) { }

	[CalledBy(Type = typeof(FontEngine), Member = "GetPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>)}, ReturnType = typeof(GlyphPairAdjustmentRecord[]))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FontEngine), Member = "SetMarshallingArraySize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetPairAdjustmentRecordsFromMarshallingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Span`1<UnityEngine.TextCore.LowLevel.GlyphPairAdjustmentRecord>)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private static GlyphPairAdjustmentRecord[] GetPairAdjustmentRecords(UInt32[] glyphIndexes) { }

	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "UpdateFontFeaturesForFontAssetsInQueue", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "UpdateFontFeaturesForNewlyAddedGlyphs", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "UpdateGPOSFontFeaturesForNewlyAddedGlyphs", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "UpdateGlyphAdjustmentRecords", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "UpdateGlyphAdjustmentRecords", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(FontEngine), Member = "GenericListToMarshallingArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>&", "T[]&"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(FontEngine), Member = "GetPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[])}, ReturnType = typeof(GlyphPairAdjustmentRecord[]))]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
	internal static GlyphPairAdjustmentRecord[] GetPairAdjustmentRecords(List<UInt32> glyphIndexes) { }

	[CalledBy(Type = typeof(FontEngine), Member = "GetGlyphPairAdjustmentTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[])}, ReturnType = typeof(GlyphPairAdjustmentRecord[]))]
	[CalledBy(Type = typeof(FontEngine), Member = "GetPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[])}, ReturnType = typeof(GlyphPairAdjustmentRecord[]))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "TextCore::FontEngine::GetGlyphPairAdjustmentRecordsFromMarshallingArray", IsFreeFunction = True)]
	private static int GetPairAdjustmentRecordsFromMarshallingArray(Span<GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int GetPairAdjustmentRecordsFromMarshallingArray_Injected(ref ManagedSpanWrapper glyphPairAdjustmentRecords) { }

	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "GetGlyphVariantIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "GetGlyphVariantIndex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(uint))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "TextCore::FontEngine::GetVariantGlyphIndex", IsThreadSafe = True, IsFreeFunction = True)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
	internal static uint GetVariantGlyphIndex(uint unicode, uint variantSelectorUnicode) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	private static void GlyphIndexToMarshallingArray(uint glyphIndex, ref UInt32[] dstArray) { }

	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "CreateFontAssetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), "UnityEngine.TextCore.Text.AtlasPopulationMode", typeof(bool)}, ReturnType = "UnityEngine.TextCore.Text.FontAsset")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
	internal static bool IsColorFontFace() { }

	[CalledBy(Type = "TMPro.TMP_DynamicFontAssetUtilities", Member = "InitializeSystemFontReferenceCache", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FontEngine), Member = "LoadFontFace_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	public static FontEngineError LoadFontFace(string filePath) { }

	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "LoadFontFace", ReturnType = typeof(FontEngineError))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "LoadFontFace", ReturnType = typeof(FontEngineError))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Math), Member = "Round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int), typeof(MidpointRounding)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(FontEngine), Member = "LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	public static FontEngineError LoadFontFace(string familyName, string styleName, float pointSize) { }

	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), "TMPro.AtlasPopulationMode", typeof(bool)}, ReturnType = "TMPro.TMP_FontAsset")]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "LoadFontFace", ReturnType = typeof(FontEngineError))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), "UnityEngine.TextCore.Text.AtlasPopulationMode", typeof(bool)}, ReturnType = "UnityEngine.TextCore.Text.FontAsset")]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "LoadFontFace", ReturnType = typeof(FontEngineError))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Math), Member = "Round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int), typeof(MidpointRounding)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(FontEngine), Member = "LoadFontFace_With_Size_And_FaceIndex_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	public static FontEngineError LoadFontFace(string filePath, float pointSize, int faceIndex) { }

	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font)}, ReturnType = "TMPro.TMP_FontAsset")]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(int), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), "TMPro.AtlasPopulationMode", typeof(bool)}, ReturnType = "TMPro.TMP_FontAsset")]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(int), typeof(int), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), "TMPro.AtlasPopulationMode", typeof(bool)}, ReturnType = "TMPro.TMP_FontAsset")]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "LoadFontFace", ReturnType = typeof(FontEngineError))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(int), typeof(int), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), "UnityEngine.TextCore.Text.AtlasPopulationMode", typeof(bool)}, ReturnType = "UnityEngine.TextCore.Text.FontAsset")]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "LoadFontFace", ReturnType = typeof(FontEngineError))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Math), Member = "Round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(int), typeof(MidpointRounding)}, ReturnType = typeof(double))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public static FontEngineError LoadFontFace(Font font, float pointSize, int faceIndex) { }

	[CalledBy(Type = typeof(FontEngine), Member = "LoadFontFace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(FontEngineError))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod(Name = "TextCore::FontEngine::LoadFontFace", IsFreeFunction = True)]
	private static int LoadFontFace_Internal(string filePath) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int LoadFontFace_Internal_Injected(ref ManagedSpanWrapper filePath) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod(Name = "TextCore::FontEngine::LoadFontFace", IsFreeFunction = True)]
	private static int LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal(Font font, int pointSize, int faceIndex) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal_Injected(IntPtr font, int pointSize, int faceIndex) { }

	[CalledBy(Type = typeof(FontEngine), Member = "LoadFontFace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(int)}, ReturnType = typeof(FontEngineError))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod(Name = "TextCore::FontEngine::LoadFontFace", IsFreeFunction = True)]
	private static int LoadFontFace_With_Size_And_FaceIndex_Internal(string filePath, int pointSize, int faceIndex) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int LoadFontFace_With_Size_And_FaceIndex_Internal_Injected(ref ManagedSpanWrapper filePath, int pointSize, int faceIndex) { }

	[CalledBy(Type = typeof(FontEngine), Member = "LoadFontFace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(float)}, ReturnType = typeof(FontEngineError))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod(Name = "TextCore::FontEngine::LoadFontFace", IsFreeFunction = True)]
	private static int LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal(string familyName, string styleName, int pointSize) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal_Injected(ref ManagedSpanWrapper familyName, ref ManagedSpanWrapper styleName, int pointSize) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "TextCore::FontEngine::PopulateLigatureSubstitutionRecordMarshallingArray", IsFreeFunction = True)]
	private static int PopulateLigatureSubstitutionRecordMarshallingArray(UInt32[] glyphIndexes, out int recordCount) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int PopulateLigatureSubstitutionRecordMarshallingArray_Injected(ref ManagedSpanWrapper glyphIndexes, out int recordCount) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "TextCore::FontEngine::PopulateMarkToBaseAdjustmentRecordMarshallingArray", IsFreeFunction = True)]
	private static int PopulateMarkToBaseAdjustmentRecordMarshallingArray(UInt32[] glyphIndexes, out int recordCount) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int PopulateMarkToBaseAdjustmentRecordMarshallingArray_Injected(ref ManagedSpanWrapper glyphIndexes, out int recordCount) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "TextCore::FontEngine::PopulateMarkToMarkAdjustmentRecordMarshallingArray", IsFreeFunction = True)]
	private static int PopulateMarkToMarkAdjustmentRecordMarshallingArray(UInt32[] glyphIndexes, out int recordCount) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int PopulateMarkToMarkAdjustmentRecordMarshallingArray_Injected(ref ManagedSpanWrapper glyphIndexes, out int recordCount) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "TextCore::FontEngine::PopulatePairAdjustmentRecordMarshallingArray", IsFreeFunction = True)]
	private static int PopulatePairAdjustmentRecordMarshallingArray(UInt32[] glyphIndexes, out int recordCount) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "TextCore::FontEngine::PopulatePairAdjustmentRecordMarshallingArrayFromKernTable", IsFreeFunction = True)]
	private static int PopulatePairAdjustmentRecordMarshallingArray_from_KernTable(UInt32[] glyphIndexes, out int recordCount) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int PopulatePairAdjustmentRecordMarshallingArray_from_KernTable_Injected(ref ManagedSpanWrapper glyphIndexes, out int recordCount) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static int PopulatePairAdjustmentRecordMarshallingArray_Injected(ref ManagedSpanWrapper glyphIndexes, out int recordCount) { }

	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32[]", "System.UInt32[]&", typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "TryAddGlyphInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Glyph&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "TryAddCharacterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), "TMPro.TMP_Character&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "SetupNewAtlasTexture", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "UpdateAtlasTexture", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "ClearAtlasTextures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "ClearAtlasTextures", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32[]", "System.UInt32[]&", typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "TryAddGlyphToAtlas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Glyph&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "SetupNewAtlasTexture", ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod(Name = "TextCore::FontEngine::ResetAtlasTexture", IsFreeFunction = True)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
	internal static void ResetAtlasTexture(Texture2D texture) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void ResetAtlasTexture_Injected(IntPtr texture) { }

	[CalledBy(Type = typeof(FontEngine), Member = "GetLigatureSubstitutionRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[])}, ReturnType = typeof(LigatureSubstitutionRecord[]))]
	[CalledBy(Type = typeof(FontEngine), Member = "GetGlyphPairAdjustmentTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[])}, ReturnType = typeof(GlyphPairAdjustmentRecord[]))]
	[CalledBy(Type = typeof(FontEngine), Member = "GetPairAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[])}, ReturnType = typeof(GlyphPairAdjustmentRecord[]))]
	[CalledBy(Type = typeof(FontEngine), Member = "GetMarkToBaseAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[])}, ReturnType = typeof(MarkToBaseAdjustmentRecord[]))]
	[CalledBy(Type = typeof(FontEngine), Member = "GetMarkToMarkAdjustmentRecords", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[])}, ReturnType = typeof(MarkToMarkAdjustmentRecord[]))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Array), Member = "Resize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]&", typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	private static void SetMarshallingArraySize(ref T[] marshallingArray, int recordCount) { }

	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "TryAddGlyphToAtlas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Glyph&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "TryAddGlyphToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Glyph&), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "TextCore::FontEngine::SetTextureUploadMode", IsThreadSafe = True, IsFreeFunction = True)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
	internal static void SetTextureUploadMode(bool shouldUploadImmediately) { }

	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32[]", "System.UInt32[]&", typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(String&), typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "TryAddGlyphsToNewAtlasTexture", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "TryAddCharacters", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.UInt32[]", "System.UInt32[]&", typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "TryAddGlyphsToNewAtlasTexture", ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(FontEngine), Member = "TryAddGlyphsToTexture_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[]), typeof(int), typeof(GlyphPackingMode), typeof(GlyphRect[]), typeof(Int32&), typeof(GlyphRect[]), typeof(Int32&), typeof(GlyphRenderMode), typeof(Texture2D), typeof(GlyphMarshallingStruct[]), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	[ContainsUnimplementedInstructions]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
	internal static bool TryAddGlyphsToTexture(List<UInt32> glyphIndexes, int padding, GlyphPackingMode packingMode, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, out Glyph[] glyphs) { }

	[CalledBy(Type = typeof(FontEngine), Member = "TryAddGlyphsToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.UInt32>), typeof(int), typeof(GlyphPackingMode), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.GlyphRect>), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.GlyphRect>), typeof(GlyphRenderMode), typeof(Texture2D), typeof(Glyph[]&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	[NativeMethod(Name = "TextCore::FontEngine::TryAddGlyphsToTexture", IsThreadSafe = True, IsFreeFunction = True)]
	private static bool TryAddGlyphsToTexture_Internal(UInt32[] glyphIndex, int padding, GlyphPackingMode packingMode, out GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, out GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, out GlyphMarshallingStruct[] glyphs, ref int glyphCount) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool TryAddGlyphsToTexture_Internal_Injected(ref ManagedSpanWrapper glyphIndex, int padding, GlyphPackingMode packingMode, out BlittableArrayWrapper freeGlyphRects, ref int freeGlyphRectCount, out BlittableArrayWrapper usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, IntPtr texture, out BlittableArrayWrapper glyphs, ref int glyphCount) { }

	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "TryAddGlyphInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Glyph&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "TryAddCharacterInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), "TMPro.TMP_Character&"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "TryAddGlyphToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(Glyph&), typeof(bool)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(FontEngine), Member = "TryAddGlyphToTexture_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(int), typeof(GlyphPackingMode), typeof(GlyphRect[]), typeof(Int32&), typeof(GlyphRect[]), typeof(Int32&), typeof(GlyphRenderMode), typeof(Texture2D), typeof(GlyphMarshallingStruct&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
	internal static bool TryAddGlyphToTexture(uint glyphIndex, int padding, GlyphPackingMode packingMode, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, out Glyph glyph) { }

	[CalledBy(Type = typeof(FontEngine), Member = "TryAddGlyphToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(int), typeof(GlyphPackingMode), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.GlyphRect>), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.GlyphRect>), typeof(GlyphRenderMode), typeof(Texture2D), typeof(Glyph&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 9)]
	[NativeMethod(Name = "TextCore::FontEngine::TryAddGlyphToTexture", IsThreadSafe = True, IsFreeFunction = True)]
	private static bool TryAddGlyphToTexture_Internal(uint glyphIndex, int padding, GlyphPackingMode packingMode, out GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, out GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, out GlyphMarshallingStruct glyph) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool TryAddGlyphToTexture_Internal_Injected(uint glyphIndex, int padding, GlyphPackingMode packingMode, out BlittableArrayWrapper freeGlyphRects, ref int freeGlyphRectCount, out BlittableArrayWrapper usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, IntPtr texture, out GlyphMarshallingStruct glyph) { }

	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "TryGetCharacter_and_QueueRenderToTexture", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), "TMPro.TMP_Character&"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public static bool TryGetGlyphWithIndexValue(uint glyphIndex, GlyphLoadFlags flags, out Glyph glyph) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "TextCore::FontEngine::TryGetGlyphWithIndexValue", IsThreadSafe = True, IsFreeFunction = True)]
	private static bool TryGetGlyphWithIndexValue_Internal(uint glyphIndex, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct) { }

	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "AddSynthesizedCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "AddSynthesizedCharacter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public static bool TryGetGlyphWithUnicodeValue(uint unicode, GlyphLoadFlags flags, out Glyph glyph) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "TextCore::FontEngine::TryGetGlyphWithUnicodeValue", IsThreadSafe = True, IsFreeFunction = True)]
	private static bool TryGetGlyphWithUnicodeValue_Internal(uint unicode, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct) { }

	[CalledBy(Type = "TMPro.TMP_FontAsset", Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int)}, ReturnType = "TMPro.TMP_FontAsset")]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int)}, ReturnType = "UnityEngine.TextCore.Text.FontAsset")]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "CreateFontAssetInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int)}, ReturnType = "UnityEngine.TextCore.Text.FontAsset")]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "CreateFontAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(int), typeof(int), typeof(GlyphRenderMode)}, ReturnType = "UnityEngine.TextCore.Text.FontAsset")]
	[CalledBy(Type = "UnityEngine.TextCore.Text.FontAsset", Member = "CreateFontAssetFromFamilyName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = "UnityEngine.TextCore.Text.FontAsset")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(FontEngine), Member = "TryGetSystemFontReference_Internal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(FontReference&)}, ReturnType = typeof(bool))]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
	internal static bool TryGetSystemFontReference(string familyName, string styleName, out FontReference fontRef) { }

	[CalledBy(Type = typeof(FontEngine), Member = "TryGetSystemFontReference", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(FontReference&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 3)]
	[NativeMethod(Name = "TextCore::FontEngine::TryGetSystemFontReference", IsThreadSafe = True, IsFreeFunction = True)]
	private static bool TryGetSystemFontReference_Internal(string familyName, string styleName, out FontReference fontRef) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static bool TryGetSystemFontReference_Internal_Injected(ref ManagedSpanWrapper familyName, ref ManagedSpanWrapper styleName, out FontReference fontRef) { }

	[CalledBy(Type = "TMPro.TMP_DynamicFontAssetUtilities", Member = "InitializeSystemFontReferenceCache", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static FontEngineError UnloadFontFace() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[NativeMethod(Name = "TextCore::FontEngine::UnloadFontFace", IsFreeFunction = True)]
	private static int UnloadFontFace_Internal() { }

}

